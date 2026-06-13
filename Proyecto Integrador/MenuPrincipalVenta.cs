using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class MenuPrincipalVenta : Form
    {
        private Usuario usuarioSesion;
        private Form parentForm;

        public MenuPrincipalVenta(Usuario usuario, Form parent)
        {
            usuarioSesion = usuario;
            parentForm = parent;
            InitializeComponent();
            lblUsuario.Text = usuario?.NombreCompleto ?? String.Empty;
            lblRol.Text = usuario?.Rol ?? String.Empty;
            lblFecha1.Text = DateTime.Now.ToString();
        }

        private void MenuPrincipalVenta_Load(object sender, EventArgs e)
        {
            CargarVentas();


            SqlConnection Sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter adaptadorSql = new SqlDataAdapter("SELECT IdSalida, Fecha, TotalVenta FROM Salida", Sqlconexion);

            DataTable tablaDato = new DataTable();
            adaptadorSql.Fill(tablaDato);

            lblTotalVentas.Text = "Total de Ventas Registradas: " + tablaDato.Rows.Count;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuprincipal = new MenuPrincipal(usuarioSesion, this);
            menuprincipal.Show();
            this.Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario(usuarioSesion, this);
            inventario.Show();
            this.Close();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion inicosesion = new InicioSesion();
            inicosesion.Show();
            this.Close();


        }

        private void btnRegistrarNuevaVenta_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(usuarioSesion, this);
            venta.Show();

        }
        private void CargarVentas()
        {
            SqlConnection Sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter adaptadorSql = new SqlDataAdapter("SELECT IdSalida, Fecha, TotalVenta FROM Salida", Sqlconexion);

            DataTable tablaDato = new DataTable();
            adaptadorSql.Fill(tablaDato);

            dvgVentasRegistradas.DataSource = tablaDato;

        }

        private void dvgVentasRegistradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            {
                int idSalida = Convert.ToInt32(dvgVentasRegistradas.Rows[e.RowIndex].Cells["IdSalida"].Value);

                MessageBox.Show("Venta Seleccionada:" + idSalida);

                CargarDetalleVenta(idSalida);
            }



        }
        private void CargarDetalleVenta(int idVenta)
        {
            SqlConnection SqlConexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter sqlAdaptador = new SqlDataAdapter("SELECT IdProducto, Cantidad, Subtotal FROM DetalleSalida WHERE IdSalida = @id", SqlConexion);

            sqlAdaptador.SelectCommand.Parameters.AddWithValue("@id", idVenta);

            DataTable tablaDato = new DataTable();
            sqlAdaptador.Fill(tablaDato);

            dvgProductos.DataSource = tablaDato;
        }

        private void CargarProductosDeVenta(string idSalida)
        {
            // Tu cadena de conexión a SQL Server
            string conexionString = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";

            // Consulta SQL para traer la descripción, cantidad y subtotal
            string query = @"SELECT p.Descripcion, d.Cantidad, d.Subtotal 
                     FROM DetalleVenta d 
                     INNER JOIN Producto p ON d.IdProducto = p.IdProducto 
                     WHERE d.IdSalida = @IdSalida";

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdSalida", idSalida);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Asignamos el resultado al DataGridView de la derecha
                    dvgProductos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }




        private void dvgVentasRegistradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotalSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");
            SqlDataAdapter AdaptadorSql = new SqlDataAdapter($"SELECT * FROM Salida WHERE IdSalida LIKE '{txtBuscarId.Text}%'", sqlConexion);

            DataTable TablaDato = new DataTable();
            AdaptadorSql.Fill(TablaDato);

            dvgVentasRegistradas.DataSource = TablaDato;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter sqladaptador = new SqlDataAdapter("SELECT * FROM Salida", sqlconexion);

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgVentasRegistradas.DataSource = tabladatos;
        }
    }
}
