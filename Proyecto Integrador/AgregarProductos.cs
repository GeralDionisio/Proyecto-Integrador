using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Proyecto_Integrador
{

    public partial class AgregarProductos : Form
    {
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
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
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(cmbCategoria.Text) || string.IsNullOrWhiteSpace(txtStockMinimo.Text) || string.IsNullOrWhiteSpace(txtPrecioActual.Text) || string.IsNullOrWhiteSpace(txtStockActual.Text) || string.IsNullOrWhiteSpace(cbUnidadDeMedida.Text))
            {
                MessageBox.Show($"Por favor complete la cajita de texto que se encuentran vacía", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlCommand cmd = new SqlCommand("Insertar_Producto", sqlconexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Marca", txtMarca.Text);
            cmd.Parameters.AddWithValue("@Categoria", cmbCategoria.Text);
            cmd.Parameters.AddWithValue("@StockMinimo", txtStockMinimo.Text);
            cmd.Parameters.AddWithValue("@PrecioActual", txtPrecioActual.Text);
            cmd.Parameters.AddWithValue("@StockActual", txtStockActual.Text);
            cmd.Parameters.AddWithValue("@FechaVencimiento", dtpFechaVencimiento.Value);
            cmd.Parameters.AddWithValue("@UnidadDeMedida", cbUnidadDeMedida.Text);

            sqlconexion.Open();
            cmd.ExecuteNonQuery();
            LimpiarCampos();
            sqlconexion.Close();

            MessageBox.Show("Se registro Correctamente el producto", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtMarca.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtStockMinimo.Clear();
            txtPrecioActual.Clear();
            txtStockActual.Clear();
            dtpFechaVencimiento.Value = DateTime.Now;
            cbUnidadDeMedida.SelectedIndex = -1;
        }
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
