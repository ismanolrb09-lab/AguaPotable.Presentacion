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
    public partial class frmMedidores : Form
    {
        MedidorDAL medidorDAL = new MedidorDAL();
        ClienteDAL clienteDAL = new ClienteDAL();
        int idSeleccionado = 0;

        public frmMedidores()
        {
            InitializeComponent();
        }

        private void frmMedidores_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvMedidores.DataSource = medidorDAL.ObtenerTodos();
        }

        private void CargarClientes()
        {
            DataTable dt = clienteDAL.ObtenerTodos();
            cmbCliente.DataSource = dt;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "ClienteID";
        }

        private void LimpiarCampos()
        {
            txtSerial.Clear();
            if (cmbCliente.Items.Count > 0)
                cmbCliente.SelectedIndex = 0;
            idSeleccionado = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSerial.Text))
            {
                MessageBox.Show("Ingrese el numero de serie del medidor.",
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
                medidorDAL.Insertar(txtSerial.Text.Trim(), clienteID);

                MessageBox.Show("Medidor registrado correctamente.",
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuspender_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un medidor de la tabla primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                medidorDAL.CambiarEstado(idSeleccionado, "Suspendido");
                MessageBox.Show("Medidor suspendido correctamente.",
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTabla();
                idSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un medidor de la tabla primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                medidorDAL.CambiarEstado(idSeleccionado, "Activo");
                MessageBox.Show("Medidor activado correctamente.",
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTabla();
                idSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarTabla();
        }

        private void dgvMedidores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMedidores.Rows[e.RowIndex].Cells["MedidorID"].Value != null)
            {
                DataGridViewRow fila = dgvMedidores.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["MedidorID"].Value);
                txtSerial.Text = fila.Cells["NumeroSerial"].Value.ToString();
            }
        }
    }
}


