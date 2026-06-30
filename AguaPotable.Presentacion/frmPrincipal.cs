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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Show();
        }

        private void btnMedidores_Click(object sender, EventArgs e)
        {
            frmMedidores frm = new frmMedidores();
            frm.Show();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            frmFacturacion frm = new frmFacturacion();
            frm.Show();
        }

        private void btnCortes_Click(object sender, EventArgs e)
        {
            frmCortes frm = new frmCortes();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
