using Microsoft.Data.SqlClient;
using Proyecto_Integrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class MenuPrincipal : Form
    {
        private Usuario usuarioSesion;
        private Form parentForm;

        public static string UsuarioActual;

        public MenuPrincipal(Usuario usuario, Form parent)
        {
            InitializeComponent();
            usuarioSesion = usuario;
            parentForm = parent;
            lblBienvenido.Text = $"Bienvenido, {usuarioSesion.NombreCompleto}";
            lblUsuario.Text = usuario?.NombreCompleto ?? string.Empty;
            lblRol.Text = usuario?.Rol ?? string.Empty;
            lblFecha.Text = DateTime.Now.ToString();
            
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter tablaAdaptador = new SqlDataAdapter("SELECT * FROM Productos", sqlConexion);

            DataTable tablaDatos = new DataTable();
            tablaAdaptador.Fill(tablaDatos);

            lblProductosRegistrados.Text = "" + tablaDatos.Rows.Count;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
            this.Close();
            MessageBox.Show("Cerrando Sesion...");

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario(usuarioSesion, this);
            inventario.Show();
            this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            MenuPrincipalVenta menuprincipalventa = new MenuPrincipalVenta(usuarioSesion, this);
            menuprincipalventa.Show();
            this.Close();
        }
    }
}
