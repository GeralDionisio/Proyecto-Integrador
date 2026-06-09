using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class Inventario : Form
    {
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

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductosLimpieza_Click(object sender, EventArgs e)
        {

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
    }
}
