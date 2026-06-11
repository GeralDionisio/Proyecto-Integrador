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
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Drawing.Text;

namespace Proyecto_Integrador
{
    public partial class EditarProducto : Form
    {
        int IdProductos = 0;
        private int idProductoSeleccionado = 0;

        public EditarProducto()
        {


            InitializeComponent();

        }
        public void CargarProducto()
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgProductosExistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Implementación vacía añadida para evitar errores del diseñador
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Implementación vacía añadida para evitar errores del diseñador
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtMarca.Clear();
            txtPrecioActual.Clear();
            txtStockActual.Clear();
            txtStockMinimo.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            SqlConnection sqlConexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            string Consulta = @"UPDATE Productos SET Nombre = @Nombre, Marca = @Marca, PrecioActual = @PrecioActual, StockActual = @StockActual, StockMinimo = @StockMinimo, FechaVencimiento = @FechaVencimiento, Categoria = @Categoria WHERE IdProductos = @IdProductos";

            SqlCommand cmd = new SqlCommand(Consulta, sqlConexion);
            {
                cmd.Parameters.AddWithValue("@IdProductos", idProductoSeleccionado);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Marca", txtMarca.Text);
                cmd.Parameters.AddWithValue("@Categoria", cbCategoria.Text);
                cmd.Parameters.AddWithValue("@PrecioActual", txtPrecioActual.Text);
                cmd.Parameters.AddWithValue("@StockActual", txtStockActual.Text);
                cmd.Parameters.AddWithValue("@StockMinimo", txtStockMinimo.Text);
                cmd.Parameters.AddWithValue("@FechaVencimiento", dtpFechaVencimiento.Value);

                sqlConexion.Open();
                int filas = cmd.ExecuteNonQuery();

                MessageBox.Show("Filas Afectadas:" + filas);
                sqlConexion.Close();

                MessageBox.Show("Los datos fueron actualizados correctamente en la base de datos");

                CargarProducto();

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {

            SqlConnection sqlConexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter tablaAdaptador = new SqlDataAdapter("SELECT * FROM Productos", sqlConexion);

            DataTable tablaDatos = new DataTable();
            tablaAdaptador.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;

            lblTotalProductos.Text = "Total de Productos: " + tablaDatos.Rows.Count;

            CargarProducto();
        }
        public void CargarProductos()
        {
            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter sqladaptador = new SqlDataAdapter("SELECT * FROM Productos", sqlconexion);

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgProductosExistencia.DataSource = tabladatos;

        }

        private void dvgProductosExistencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow fila = dvgProductosExistencia.Rows[e.RowIndex];

            idProductoSeleccionado = Convert.ToInt32(fila.Cells["IdProductos"].Value);

            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtMarca.Text = fila.Cells["Marca"].Value.ToString();
            txtPrecioActual.Text = fila.Cells["PrecioActual"].Value.ToString();
            txtStockActual.Text = fila.Cells["StockActual"].Value.ToString();
            txtStockMinimo.Text = fila.Cells["StockMinimo"].Value.ToString();
            cbCategoria.Text = fila.Cells["Categoria"].Value.ToString();
            dtpFechaVencimiento.Value = Convert.ToDateTime(fila.Cells["FechaVencimiento"].Value);

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                SqlConnection conexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

                string consulta = "DELETE FROM Productos WHERE IdProductos = @IdProductos";

                SqlCommand cmd = new SqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@IdProductos", idProductoSeleccionado);

                conexion.Open();

                int filas = cmd.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Filas eliminadas: " + filas);

                CargarProductos();

                txtNombre.Clear();
                txtMarca.Clear();
                txtPrecioActual.Clear();
                txtStockActual.Clear();
                txtStockMinimo.Clear();
                cbCategoria.SelectedIndex = -1;

                idProductoSeleccionado = 0;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");
            SqlDataAdapter AdaptadorSql = new SqlDataAdapter($"SELECT * FROM Productos WHERE Nombre LIKE '{txtBuscarProducto.Text}%'", sqlConexion);

            DataTable TablaDato = new DataTable();
            AdaptadorSql.Fill(TablaDato);

            dvgProductosExistencia.DataSource = TablaDato;
        }

        private void btnMostrarProducto_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter sqladaptador = new SqlDataAdapter("SELECT * FROM Productos", sqlconexion);

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgProductosExistencia.DataSource = tabladatos;
        }
    }
}
