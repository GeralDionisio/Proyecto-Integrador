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
    }
}
