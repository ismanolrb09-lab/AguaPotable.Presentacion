using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AguaPotable.Datos;

namespace AguaPotable.Presentacion
{
    public partial class frmCortes : Form
    {
        ClienteDAL clienteDAL = new ClienteDAL();
        OrdenCorteDAL ordenDAL = new OrdenCorteDAL();
        LecturaDAL lecturaDAL = new LecturaDAL();
        int idSeleccionado = 0;

        public frmCortes()
        {
            InitializeComponent();
        }

        private void frmCortes_Load(object sender, EventArgs e)
        {
            cmbTipoOrden.Items.Add("Corte");
            cmbTipoOrden.Items.Add("Reconexion");
            cmbTipoOrden.SelectedIndex = 0;
            CargarClientes();
            CargarTabla();
        }

        private void CargarClientes()
        {
            DataTable dt = clienteDAL.ObtenerTodos();
            cmbCliente.DataSource = dt;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "ClienteID";
        }

        private void CargarTabla()
        {
            try
            {
                dgvCortes.DataSource = ordenDAL.ObtenerTodas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTipoOrden.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tipo de orden.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Ingrese el motivo de la orden.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int clienteID = Convert.ToInt32(cmbCliente.SelectedValue);
                string tipo = cmbTipoOrden.SelectedItem.ToString();
                string motivo = txtMotivo.Text.Trim();

                int medidorID = lecturaDAL.ObtenerMedidorPorCliente(clienteID);
                if (medidorID == 0)
                {
                    MessageBox.Show("Este cliente no tiene un medidor activo asignado.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ordenDAL.Insertar(clienteID, medidorID, tipo, motivo);

                MessageBox.Show("Orden registrada correctamente.",
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMotivo.Clear();
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una orden de la tabla primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ordenDAL.Ejecutar(idSeleccionado);
                MessageBox.Show("Orden ejecutada correctamente.",
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idSeleccionado = 0;
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCortes.DataSource = ordenDAL.ObtenerPendientesCorte();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCortes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCortes.Rows[e.RowIndex].Cells["OrdenID"].Value != null)
            {
                DataGridViewRow fila = dgvCortes.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["OrdenID"].Value);
            }
        }
    }
}



