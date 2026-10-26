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
    public partial class MenuPrincipalTrabajador : Form
    {
        private Usuario usuarioSesion;
        private Form formsparente;
        public MenuPrincipalTrabajador(Form parenteform, Usuario usuario)
        {
            InitializeComponent();
            usuarioSesion = usuario;
            formsparente = parenteform;
            lblNombreUsuario.Text = usuario?.NombreUsuario ?? string.Empty;
            lblRolUsuario.Text = usuario?.Rol ?? string.Empty;
            lblBienvenido.Text = $"¡Bienvenido, {usuario.NombreUsuario}! estas dentro del modulo de ventas.";
            System.Windows.Forms.Timer miReloj = new System.Windows.Forms.Timer();
            miReloj.Interval = 1000; // 1 segundo
            miReloj.Tick += MiRelojTick; // Mi Reloj_Tick es el metodo donde ira metido el lbl
            miReloj.Start();

        }

        private void MenuPrincipalTrabajador_Load(object sender, EventArgs e)
        {
            ColoresDiseño();
        }
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("Colores_Diseño_Trabajador", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        lblBienvenido.ForeColor = SystemColors.MenuHighlight;
                        //Paneles atras
                        btnReporteVenta.BackColor = SystemColors.MenuHighlight;
                        btnCerrarSesion.BackColor = SystemColors.MenuHighlight;
                        btnNuevaVenta.BackColor = SystemColors.MenuHighlight;
                        btnHerramientas.BackColor = SystemColors.MenuHighlight;
                        btnVentasCerradas.BackColor = SystemColors.MenuHighlight;
                        panel1.BackColor = SystemColors.HotTrack;
                        panel2.BackColor = SystemColors.HotTrack;

                        //botones atras
                    }
                    else if (valorLugar == 2)
                    {
                        lblBienvenido.ForeColor = Color.BlueViolet;
                        //Paneles atras
                        btnCerrarSesion.BackColor = Color.MediumPurple;
                        btnReporteVenta.BackColor = Color.MediumPurple;
                        btnNuevaVenta.BackColor = Color.MediumPurple;
                        btnHerramientas.BackColor = Color.MediumPurple;
                        btnVentasCerradas.BackColor = Color.MediumPurple;
                        panel1.BackColor = Color.BlueViolet;
                        panel2.BackColor = Color.BlueViolet;

                        //botones atras
                    }
                    else if (valorLugar == 3)
                    {
                        lblBienvenido.ForeColor = Color.Teal;
                        //Paneles atras
                        btnCerrarSesion.BackColor = Color.CadetBlue;
                        btnHerramientas.BackColor = Color.CadetBlue;
                        btnNuevaVenta.BackColor = Color.CadetBlue;
                        btnReporteVenta.BackColor = Color.CadetBlue;
                        btnVentasCerradas.BackColor = Color.CadetBlue;
                        panel1.BackColor = Color.Teal;
                        panel2.BackColor = Color.Teal;
                        //botones atras
                    }
                    else if (valorLugar == 4)
                    {
                        lblBienvenido.ForeColor = Color.Black;
                        //Paneles atras
                        btnCerrarSesion.BackColor = Color.DimGray;
                        btnHerramientas.BackColor = Color.DimGray;
                        btnNuevaVenta.BackColor = Color.DimGray;
                        btnReporteVenta.BackColor = Color.DimGray;
                        btnVentasCerradas.BackColor = Color.DimGray;
                        panel1.BackColor = Color.Black;
                        panel2.BackColor = Color.Black;

                        //botones atras
                    }
                }

            }
        }

        private void MiRelojTick(object sender, EventArgs e)
        {
            lblHora.Text = "" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            ZonaDelTrabajador Zonadeltrabajador = new ZonaDelTrabajador(usuarioSesion, this);
            Zonadeltrabajador.Show();
            this.Hide();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            HerramientasDeTrabajador herramientastraba = new HerramientasDeTrabajador(usuarioSesion, this);
            SeguidorPila.AbrirSiguiente(this, herramientastraba);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporteVenta_Click(object sender, EventArgs e)
        {
            ReporteVentasTrabajador menuPrincipalTrabajador = new ReporteVentasTrabajador(usuarioSesion, this);
            SeguidorPila.AbrirSiguiente(this, menuPrincipalTrabajador);

        }

        private void btnVentasCerradas_Click(object sender, EventArgs e)
        {
            ReporteVentasCerradasTrabajador reporteVentasCerradasTrabajador = new ReporteVentasCerradasTrabajador(usuarioSesion, this);
            SeguidorPila.AbrirSiguiente(this, reporteVentasCerradasTrabajador);
        }
    }
}
