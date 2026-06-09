using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador
{

    public partial class AgregarProductos : Form
    {
        public AgregarProductos(Usuario usuario, Form parent)
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMarca.Clear();
            txtNombre.Clear();
            txtPrecioActual.Clear();
            txtStockActual.Clear();
            txtStockMinimo.Clear();
        }
    }
}
