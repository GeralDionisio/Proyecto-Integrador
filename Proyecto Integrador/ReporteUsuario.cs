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
    public partial class ReporteUsuario : Form
    {
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";

        public ReporteUsuario()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReporteUsuario_Load(object sender, EventArgs e)
        {
            ColoresDiseño();
            ObtenerDatos();
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
                        //Paneles atras

                        btnRegresar.BackColor = SystemColors.MenuHighlight;
                        dvgReporteUsuario.BackgroundColor = Color.LightSkyBlue;

                        panel1.BackColor = SystemColors.MenuHighlight;


                    }
                    else if (valorLugar == 2)
                    {

                        //Paneles atras
                        btnRegresar.BackColor = Color.MediumPurple;
                        dvgReporteUsuario.BackgroundColor = Color.DarkOrchid;
                        panel1.BackColor = Color.DarkOrchid;

                    }
                    else if (valorLugar == 3)
                    {
                        btnRegresar.BackColor = Color.CadetBlue;
                        dvgReporteUsuario.BackgroundColor = Color.PowderBlue;

                        panel1.BackColor = Color.Teal;

                    }
                    else if (valorLugar == 4)
                    {

                        //Paneles atras
                        dvgReporteUsuario.BackgroundColor = Color.DarkGray;
                        btnRegresar.BackColor = Color.DimGray;
                        panel1.BackColor = Color.Black;

                    }
                }

            }
        }
        private void ObtenerDatos()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                String consulta = @"SELECT IdReporte, NombreUsuario AS Usuario_Email, Rol, Operacion, ZonaDelSistema, Detalle, Fecha FROM ReporteVentas;";
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable tabladatos = new DataTable();
                    adaptador.Fill(tabladatos);

                    dvgReporteUsuario.DataSource = tabladatos;
                }
            }
        }
    }
}
