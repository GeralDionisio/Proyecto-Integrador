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
    public partial class ReporteVentasCerradas : Form
    {

        private Form parentForm;
        private object UsuarioSesion;
        public ReporteVentasCerradas(Form parentForm, object usuarioSesion)
        {
            InitializeComponent();
            this.UsuarioSesion = usuarioSesion;
            this.parentForm = parentForm;
        }

        private void ReporteVentasCerradas_Load(object sender, EventArgs e)
        {
            ColoresDiseño();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("Colores_Diseño", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);
                ReporteVentasCerradas reportes = (this);

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        reportes.BackColor = SystemColors.HotTrack;

                        btnRegresar.BackColor = SystemColors.MenuHighlight;
                        dvgDetallesProductosCerrados.BackgroundColor = Color.LightSkyBlue;
                        dvgProductosCerrados.BackgroundColor = Color.LightSkyBlue;


                    }
                    else if (valorLugar == 2)
                    {
                        reportes.BackColor = Color.MediumPurple;

                        //Paneles atras
                        btnRegresar.BackColor = Color.MediumPurple;
                        dvgDetallesProductosCerrados.BackgroundColor = Color.DarkOrchid;
                        dvgProductosCerrados.BackgroundColor = Color.DarkOrchid;


                    }
                    else if (valorLugar == 3)
                    {
                        reportes.BackColor = Color.Teal;
                        btnRegresar.BackColor = Color.CadetBlue;
                        dvgDetallesProductosCerrados.BackgroundColor = Color.PowderBlue;
                        dvgProductosCerrados.BackgroundColor = Color.PowderBlue;


                    }
                    else if (valorLugar == 4)
                    {
                        reportes.BackColor = Color.Black;

                        //Paneles atras
                        dvgDetallesProductosCerrados.BackgroundColor = Color.DarkGray;
                        dvgProductosCerrados.BackgroundColor = Color.DimGray;
                        btnRegresar.BackColor = Color.DimGray;


                    }
                }

            }
        }
    }
}
