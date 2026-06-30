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
    public partial class frmClientes : Form
    {
        ClienteDAL clienteDAL = new ClienteDAL();
        int idSeleccionado = 0;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("R - Residencial");
            cmbTipo.Items.Add("C - Comercial");
            cmbTipo.SelectedIndex = 0;
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvClientes.DataSource = clienteDAL.ObtenerTodos();
        }

        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtBuscar.Clear();
            cmbTipo.SelectedIndex = 0;
            idSeleccionado = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                  string.IsNullOrWhiteSpace(txtNombre.Text) ||
                  string.IsNullOrWhiteSpace(txtApellido.Text) ||
                  string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Cedula, nombre, apellido y direccion son obligatorios.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCedula.Text.Trim().Length < 11)
            {
                MessageBox.Show("La cedula debe tener al menos 11 caracteres.",
                    "Dato invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string tipo = cmbTipo.SelectedItem.ToString().Substring(0, 1);

                if (idSeleccionado == 0)
                {
                    clienteDAL.Insertar(
                        txtCedula.Text.Trim(),
                        txtNombre.Text.Trim(),
                        txtApellido.Text.Trim(),
                        txtTelefono.Text.Trim(),
                        txtDireccion.Text.Trim(),
                        tipo);

                    MessageBox.Show("Cliente registrado correctamente.",
                        "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clienteDAL.Actualizar(
                        idSeleccionado,
                        txtNombre.Text.Trim(),
                        txtApellido.Text.Trim(),
                        txtTelefono.Text.Trim(),
                        txtDireccion.Text.Trim());

                    MessageBox.Show("Cliente actualizado correctamente.",
                        "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarCampos();
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente de la tabla primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Esta seguro de eliminar este cliente?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    clienteDAL.Eliminar(idSeleccionado);
                    MessageBox.Show("Cliente eliminado.",
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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Ingrese una cedula para buscar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = clienteDAL.Buscar(txtBuscar.Text.Trim());

                if (dt.Rows.Count == 0)
                    MessageBox.Show("No se encontro ningun cliente con esa cedula.",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    dgvClientes.DataSource = dt;
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

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvClientes.Rows[e.RowIndex].Cells["ClienteID"].Value != null)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["ClienteID"].Value);
                txtCedula.Text = fila.Cells["Cedula"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
            }
        }
    }
}
