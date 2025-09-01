using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCastilloAppVentas
{
    public partial class frmForm : Form
    {
        public frmForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstProducto_TextChanged(object sender, EventArgs e)
        {
            if (lstProducto.Text == "")
            {
                txtCantidad.Enabled = false;
            }
            else
            {
                txtCantidad.Enabled = true;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtPrecio.Enabled = false;
            }
            else
            {
                txtPrecio.Enabled = true;
            }
        }

        private void btnRegistrar_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void btnCancelar_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                btnCancelar.Enabled = false;
            }
            else
            {
                btnCancelar.Enabled= true;
            }
        }
    }
}
