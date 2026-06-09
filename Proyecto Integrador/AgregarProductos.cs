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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            string Consulta = @"INSERT INTO Productos (Nombre, Marca, PrecioActual, StockActual, StockMinimo, FechaVencimiento, Categoria) VALUES (@Nombre, @Marca, @PrecioActual, @StockActual, @StockMinimo, @FechaVencimiento, @Categoria)";

            SqlCommand cmd = new SqlCommand(Consulta, sqlconexion);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Marca", txtMarca.Text);
            cmd.Parameters.AddWithValue("@Categoria", cmbCategoria.Text);
            cmd.Parameters.AddWithValue("@StockMinimo", txtStockMinimo.Text);
            cmd.Parameters.AddWithValue("@PrecioActual", txtPrecioActual.Text);
            cmd.Parameters.AddWithValue("@StockActual", txtStockActual.Text);
            cmd.Parameters.AddWithValue("@FechaVencimiento", dtpFechaVencimiento.Value);

            sqlconexion.Open();
            cmd.ExecuteNonQuery();
            sqlconexion.Close();

            MessageBox.Show("El productos se guardo Correctamente");
        }
    }
}
