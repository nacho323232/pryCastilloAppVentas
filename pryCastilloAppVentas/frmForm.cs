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
        DateTime vFecha;
        string vProducto;
        int vCantidad;
        int vPrecio;
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

        }

        private void btnCancelar_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmForm_Load(object sender, EventArgs e)
        {
            vFecha = DateTime.Now;
            vProducto = "";
            vCantidad = 0;
            vPrecio = 0;



            lstProducto.Items.Add("Gabinete");
            lstProducto.Items.Add("CPU");
            lstProducto.Items.Add("RAM");
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vFecha = dtpFecha.Value;
            vProducto = lstProducto.Text;
            vCantidad = Convert.ToInt32(txtCantidad.Text);
            vPrecio = Convert.ToInt32(txtPrecio.Text);

            lblResultadoRegistro.Text =
                vFecha + " - " + vProducto
                + "  " + vCantidad + "  " + vPrecio;
        }

    }
}
