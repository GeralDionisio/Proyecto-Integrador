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
        private string cadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
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
            SqlConnection sqlconexion = ConexionDB.ObtenerConexion();
            SqlDataAdapter sqladaptador = new SqlDataAdapter("select IdSalida, Fecha, TotalVenta from Eliminados", sqlconexion);
            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);
            dvgProductosCerrados.DataSource = tabladatos;

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

        private void dvgProductosCerrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            {
                int idSalida = Convert.ToInt32(dvgProductosCerrados.Rows[e.RowIndex].Cells["IdSalida"].Value);

                MessageBox.Show("Venta Seleccionada: " + idSalida);

                CargarDetalleVenta(idSalida);
            }
        }
        private void CargarDetalleVenta(int idVenta)
        {
            SqlConnection SqlConexion = new SqlConnection(cadenaConexion);

            SqlDataAdapter sqlAdaptador = new SqlDataAdapter("VerDetalles_de_los_Productos_Eliminados", SqlConexion);
            sqlAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlAdaptador.SelectCommand.Parameters.AddWithValue("@IdSalida", idVenta);

            DataTable tablaDato = new DataTable();
            sqlAdaptador.Fill(tablaDato);

            dvgDetallesProductosCerrados.DataSource = tablaDato;
        }
    }
}
