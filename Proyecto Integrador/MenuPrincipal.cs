using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proyecto_Integrador;

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
