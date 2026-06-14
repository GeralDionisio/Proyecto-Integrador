using Microsoft.Data.SqlClient;
using Proyecto_Integrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto_Integrador
{
    public partial class MenuPrincipal : Form
    {
        private Usuario usuarioSesion;
        private Form parentForm;
        int Timer1;

        public static string UsuarioActual;
        List<AgregarProductos> Ayuda = new List<AgregarProductos>();

        public MenuPrincipal(Usuario usuario, Form parent)
        {
            InitializeComponent();
            usuarioSesion = usuario;
            parentForm = parent;
            lblBienvenido.Text = $"Bienvenido, {usuarioSesion.NombreCompleto}";
            lblUsuario.Text = usuario?.NombreCompleto ?? string.Empty;
            lblRol.Text = usuario?.Rol ?? string.Empty;

            System.Windows.Forms.Timer miReloj = new System.Windows.Forms.Timer();
            miReloj.Interval = 1000; // 1 segundo
            miReloj.Tick += MiReloj_Tick; // Apunta al método de abajo, NO al Label
            miReloj.Start();




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


            SqlConnection sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter sqladaptador = new SqlDataAdapter("SELECT Nombre AS Producto,StockActual,StockMinimo FROM Productos WHERE StockActual <= StockMinimo", sqlconexion);

            DataTable tabladatos1 = new DataTable();
            sqladaptador.Fill(tabladatos1);
            Ayuda.Add(new AgregarProductos(usuarioSesion, this));

            dvgProductosBajo.DataSource = tabladatos1;


            lblBajoStock.Text = "" + tabladatos1.Rows.Count;

            SqlConnection Sqlconexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter adaptadorSql = new SqlDataAdapter("SELECT IdSalida, Fecha, TotalVenta FROM Salida", Sqlconexion);

            DataTable tablaDato = new DataTable();
            adaptadorSql.Fill(tablaDato);

            lblVentasDia.Text = "" + tablaDato.Rows.Count;



            SqlConnection sqlconexion2 = new SqlConnection("Server=DESKTOP-3BT9K72;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");

            SqlDataAdapter sqladaptador2 = new SqlDataAdapter("SELECT TOP 5 p.Nombre AS Producto,SUM(dv.Cantidad) AS TotalVendido, SUM(dv.Cantidad * dv.Subtotal) AS TotalRecaudado FROM DetalleSalida dv INNER JOIN Productos p ON dv.IdProducto = p.IdProductos GROUP BY  p.Nombre ORDER BY TotalVendido DESC", sqlconexion);

            DataTable tabladatos2 = new DataTable();
            sqladaptador2.Fill(tabladatos2);
            Ayuda.Add(new AgregarProductos(usuarioSesion, this));

            dvgProductosMasVendidos.DataSource = tabladatos2;






        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
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
            MenuPrincipalVenta menuprincipalventa = new MenuPrincipalVenta(usuarioSesion, this);
            menuprincipalventa.Show();
            this.Close();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MiReloj_Tick(object sender, EventArgs e)
        {

            lblFecha.Text = "" + DateTime.Now.ToString("dd/M/yyyy HH:mm:ss");

        }
    }
}
