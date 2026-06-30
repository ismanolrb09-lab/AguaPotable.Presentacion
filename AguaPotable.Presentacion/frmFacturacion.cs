using AguaPotable.Datos;
using AguaPotable.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AguaPotable.Presentacion
{
    public partial class frmFacturacion : Form
    {
        FacturaDAL facturaDAL = new FacturaDAL();
        ClienteDAL clienteDAL = new ClienteDAL();
        LecturaDAL lecturaDAL = new LecturaDAL();
        Calculos calculos = new Calculos();
        int idFacturaSeleccionada = 0;

        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Clear(); // limpia por si acaso
            cmbTipo.Items.Add("R - Residencial");
            cmbTipo.Items.Add("C - Comercial");
            cmbTipo.SelectedIndex = 0; // selecciona el primero por defecto
            CargarClientes();
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvFacturas.DataSource = facturaDAL.ObtenerTodas();
        }

        private void CargarClientes()
        {
            DataTable dt = clienteDAL.ObtenerTodos();
            cmbCliente.DataSource = dt;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "ClienteID";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConsumo.Text))
            {
                MessageBox.Show("Ingrese el consumo en m3.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal consumo;
            if (!decimal.TryParse(txtConsumo.Text, out consumo) || consumo <= 0)
            {
                MessageBox.Show("Ingrese un numero valido mayor que cero. Ejemplo: 25 o 25.5",
                    "Dato invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConsumo.Clear();
                txtConsumo.Focus();
                return;
            }

            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tipo de cliente.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string tipo = cmbTipo.SelectedItem.ToString();
                Calculos.OperacionTarifa operacion;

                if (tipo == "R - Residencial")
                    operacion = calculos.TarifaResidencial;
                else
                    operacion = calculos.TarifaComercial;

                decimal total = operacion(consumo);
                txtTotal.Text = total.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && txtConsumo.Text.Contains("."))
                e.Handled = true;
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConsumo.Text) ||
                string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("Calcule el total primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int clienteID = Convert.ToInt32(cmbCliente.SelectedValue);
                decimal consumo = Convert.ToDecimal(txtConsumo.Text);
                decimal total = Convert.ToDecimal(txtTotal.Text);

                int medidorID = lecturaDAL.ObtenerMedidorPorCliente(clienteID);
                if (medidorID == 0)
                {
                    MessageBox.Show("Este cliente no tiene un medidor activo asignado.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal lecturaAnterior = lecturaDAL.ObtenerUltimaLectura(medidorID);
                decimal lecturaActual = lecturaAnterior + consumo;
                int lecturaID = lecturaDAL.Insertar(medidorID, lecturaActual);

                facturaDAL.Insertar(clienteID, lecturaID, consumo, total);

                MessageBox.Show("Factura emitida correctamente.",
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtConsumo.Clear();
                txtTotal.Clear();
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (idFacturaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una factura de la tabla primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                facturaDAL.MarcarPagada(idFacturaSeleccionada);
                MessageBox.Show("Factura marcada como pagada.",
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idFacturaSeleccionada = 0;
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVencidas_Click(object sender, EventArgs e)
        {
            try
            {
                dgvFacturas.DataSource = facturaDAL.ObtenerVencidas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvFacturas.Rows[e.RowIndex].Cells["FacturaID"].Value != null)
            {
                DataGridViewRow fila = dgvFacturas.Rows[e.RowIndex];
                idFacturaSeleccionada = Convert.ToInt32(fila.Cells["FacturaID"].Value);
            }
        }
    }
}





