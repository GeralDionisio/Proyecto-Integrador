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
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
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
            miReloj.Tick += MiReloj_Tick; // Mi Reloj_Tick es el metodo donde ira metido el lbl
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
            SqlConnection sqlConexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter tablaAdaptador = new SqlDataAdapter("Ver_Producto", sqlConexion);

            DataTable tablaDatos = new DataTable();
            tablaAdaptador.Fill(tablaDatos);

            lblProductosRegistrados.Text = "" + tablaDatos.Rows.Count;


            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter sqladaptador = new SqlDataAdapter("Ver_Producto_Bajo_Stock", sqlconexion);

            DataTable tabladatos1 = new DataTable();
            sqladaptador.Fill(tabladatos1);
            Ayuda.Add(new AgregarProductos(usuarioSesion, this));

            dvgProductosBajo.DataSource = tabladatos1;


            lblBajoStock.Text = "" + tabladatos1.Rows.Count;

            SqlConnection Sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter adaptadorSql = new SqlDataAdapter("Ver_Ventas_Del_Dia", Sqlconexion);

            DataTable tablaDato = new DataTable();
            adaptadorSql.Fill(tablaDato);

            lblVentasDia.Text = "" + tablaDato.Rows.Count;



            SqlConnection sqlconexion2 = new SqlConnection(CadenaConexion);

            SqlDataAdapter sqladaptador2 = new SqlDataAdapter("Ver_Productos_Mas_Vendidos", sqlconexion);

            DataTable tabladatos2 = new DataTable();
            sqladaptador2.Fill(tabladatos2);
            Ayuda.Add(new AgregarProductos(usuarioSesion, this));

            dvgProductosMasVendidos.DataSource = tabladatos2;

            ColoresDiseño();

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

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            Herramientas herramientas = new Herramientas(usuarioSesion, parentForm);
            SeguidorPila.AbrirSiguiente(this, herramientas);



        }
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("Colores_Diseño", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        panel1.BackColor = SystemColors.HotTrack;
                        panel2.BackColor = SystemColors.HotTrack;
                        panel6.BackColor = SystemColors.HotTrack;
                        //Paneles atras
                        btnInventario.BackColor = SystemColors.MenuHighlight;
                        btnHerramientas.BackColor = SystemColors.MenuHighlight;
                        btnVentas.BackColor = SystemColors.MenuHighlight;
                        btnCerrarSesion.BackColor = SystemColors.MenuHighlight;
                        //botones atras
                        lblBienvenido.ForeColor = SystemColors.HotTrack;
                        label11.ForeColor = SystemColors.HotTrack;
                        label21.ForeColor = SystemColors.HotTrack;
                        label4.ForeColor = SystemColors.HotTrack;
                        //letras atras
                        dvgProductosBajo.BackgroundColor = Color.LightSkyBlue;
                        dvgProductosMasVendidos.BackgroundColor = Color.LightSkyBlue;
                        //tablas atras
                    }
                    else if (valorLugar == 2)
                    {
                        panel1.BackColor = Color.BlueViolet;
                        panel2.BackColor = Color.BlueViolet;
                        panel6.BackColor = Color.BlueViolet;
                        //Paneles atras
                        btnInventario.BackColor = Color.MediumPurple;
                        btnHerramientas.BackColor = Color.MediumPurple;
                        btnVentas.BackColor = Color.MediumPurple;
                        btnCerrarSesion.BackColor = Color.MediumPurple;
                        //botones atras
                        lblBienvenido.ForeColor = Color.BlueViolet;
                        label11.ForeColor = Color.BlueViolet;
                        label21.ForeColor = Color.BlueViolet;
                        label4.ForeColor = Color.BlueViolet;
                        //letras atras
                        dvgProductosBajo.BackgroundColor = Color.DarkOrchid;
                        dvgProductosMasVendidos.BackgroundColor = Color.DarkOrchid;
                        //tablas atras
                    }
                    else if (valorLugar == 3)
                    {
                        panel1.BackColor = Color.Teal;
                        panel2.BackColor = Color.Teal;
                        panel6.BackColor = Color.Teal;
                        //Paneles atras
                        btnInventario.BackColor = Color.CadetBlue;
                        btnHerramientas.BackColor = Color.CadetBlue;
                        btnVentas.BackColor = Color.CadetBlue;
                        btnCerrarSesion.BackColor = Color.CadetBlue;
                        //botones atras
                        lblBienvenido.ForeColor = Color.Teal;
                        label11.ForeColor = Color.Teal;
                        label21.ForeColor = Color.Teal;
                        label4.ForeColor = Color.Teal;
                        //letras atras
                        dvgProductosBajo.BackgroundColor = Color.PowderBlue;
                        dvgProductosMasVendidos.BackgroundColor = Color.PowderBlue;
                        //tablas atras
                    }
                    else if (valorLugar == 4)
                    {
                        panel1.BackColor = Color.Black;
                        panel2.BackColor = Color.Black;
                        panel6.BackColor = Color.Black;
                        //Paneles atras
                        btnInventario.BackColor = Color.DimGray;
                        btnHerramientas.BackColor = Color.DimGray;
                        btnVentas.BackColor = Color.DimGray;
                        btnCerrarSesion.BackColor = Color.DimGray;
                        //botones atras
                        lblBienvenido.ForeColor = Color.Black;
                        label11.ForeColor = Color.Black;
                        label21.ForeColor = Color.Black;
                        label4.ForeColor = Color.Black;
                        //letras atras
                        dvgProductosBajo.BackgroundColor = Color.DarkGray;
                        dvgProductosMasVendidos.BackgroundColor = Color.DarkGray;
                        //tablas atras
                    }
                }

            }

        }
    }
}
