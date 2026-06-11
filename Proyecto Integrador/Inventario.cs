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
    public partial class Inventario : Form
    {
        public class jsonSerializer;

        private Usuario usuarioSesion;
        private Form parentForm;

        public Inventario(Usuario usuario, Form parent)
        {
            usuarioSesion = usuario;
            parentForm = parent;
            InitializeComponent();
            lblUsuario.Text = usuario?.NombreCompleto ?? string.Empty;
            lblRol.Text = usuario?.Rol ?? string.Empty;
            lblFecha.Text = DateTime.Now.ToString();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuprincipal = new MenuPrincipal(usuarioSesion, this);
            menuprincipal.Show();
            this.Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter sqladaptador = new SqlDataAdapter("SELECT * FROM Productos", sqlconexion);

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgProductosExistencia.DataSource = tabladatos;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductosLimpieza_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("SELECT * FROM Productos WHERE Categoria = 'Productos De Limpieza'", sqlconexion);

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Close();
            MessageBox.Show("Cerrando Sesion...");

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            MenuPrincipalVenta menuprincipalventa = new MenuPrincipalVenta(usuarioSesion, this);
            menuprincipalventa.Show();
            this.Close();
        }

        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {
            AgregarProductos agregarproductos = new AgregarProductos(usuarioSesion, this);
            agregarproductos.Show();

        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            EditarProducto editarproducto = new EditarProducto();
            editarproducto.Show();
        }

        private void btnPanaderia_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("SELECT * FROM Productos WHERE Categoria = 'Panaderia'", sqlconexion);

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("SELECT * FROM Productos WHERE Categoria = 'Bebidas'", sqlconexion);

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;

        }

        private void btnMeneitos_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("SELECT * FROM Productos WHERE Categoria = 'Meneitos'", sqlconexion);

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;
        }

        private void btnComidasCongelada_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("SELECT * FROM Productos WHERE Categoria = 'Comidas Congeladas'", sqlconexion);

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;

        }

        private void btnHigienePersonal_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("SELECT * FROM Productos WHERE Categoria = 'Higiene Personal'", sqlconexion);

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter sqladaptador = new SqlDataAdapter("SELECT * FROM Productos", sqlconexion);

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgProductosExistencia.DataSource = tabladatos;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");
            SqlDataAdapter AdaptadorSql = new SqlDataAdapter($"SELECT * FROM Productos WHERE Nombre LIKE '{txtBuscarProducto.Text}%'", sqlConexion);

            DataTable TablaDato = new DataTable();
            AdaptadorSql.Fill(TablaDato);

            dvgProductosExistencia.DataSource = TablaDato;
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
