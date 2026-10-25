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
    public partial class ReporteVentasCerradasTrabajador : Form
    {
        private string cadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
        private Usuario usuarioSesion;

        private Form FormParent;
        public ReporteVentasCerradasTrabajador(Usuario usuario, Form formParent)
        {
            usuarioSesion = usuario;
            InitializeComponent();
            FormParent = formParent;
        }

        private void ReporteVentasCerradasTrabajador_Load(object sender, EventArgs e)
        {
            ColoresDiseño();
            CargarVentasTrabajador();
            
        }
        private void CargarVentasTrabajador()
        {
            int IdTrabajadorSeleccionado = usuarioSesion.IdUsuario;
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("ObservarVentasCerradas_Trabajador", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", IdTrabajadorSeleccionado);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    dataAdapter.Fill(data);

                    dvgVentasCerradas.DataSource = data;
                }
            }
        }
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlConnection sqlconexion = ConexionDB.ObtenerConexion();
                SqlDataAdapter sqladaptador = new SqlDataAdapter("select IdSalida, Fecha, TotalVenta, NombreTrabajador from Eliminados", sqlconexion);
                DataTable tabladatos = new DataTable();
                sqladaptador.Fill(tabladatos);
                dvgVentasCerradas.DataSource = tabladatos;

                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("Colores_Diseño_Trabajador", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);
                ReporteVentasCerradasTrabajador herramientas = this;

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        herramientas.BackColor = SystemColors.HotTrack;
                        dvgVentasCerradas.BackgroundColor = SystemColors.MenuHighlight;
                        dvgDetalleVentasCerradas.BackgroundColor = SystemColors.MenuHighlight;
                        //Paneles atras
                        btnRegresar.BackColor = SystemColors.MenuHighlight;
                        //botones atras
                    }
                    else if (valorLugar == 2)
                    {
                        herramientas.BackColor = Color.BlueViolet;
                        dvgDetalleVentasCerradas.BackgroundColor = Color.BlueViolet;
                        dvgVentasCerradas.BackgroundColor = Color.BlueViolet;
                        //Paneles atras
                        btnRegresar.BackColor = Color.MediumPurple;

                        //botones atras
                    }
                    else if (valorLugar == 3)
                    {
                        herramientas.BackColor = Color.Teal;
                        dvgDetalleVentasCerradas.BackgroundColor = Color.PowderBlue;
                        dvgVentasCerradas.BackgroundColor = Color.PowderBlue;

                        btnRegresar.BackColor = Color.CadetBlue;

                        //Paneles atras

                        //botones atras
                    }
                    else if (valorLugar == 4)
                    {
                        herramientas.BackColor = Color.Black;
                        dvgDetalleVentasCerradas.BackgroundColor = Color.DarkGray;
                        dvgVentasCerradas.BackgroundColor = Color.DarkGray;
                        //Paneles atras
                        btnRegresar.BackColor = Color.DimGray;
                        //botones atras
                    }
                }

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

            dvgDetalleVentasCerradas.DataSource = tablaDato;
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            SeguidorPila.Regresar(this);
        }

        private void dvgVentasCerradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            {
                int idSalida = Convert.ToInt32(dvgVentasCerradas.Rows[e.RowIndex].Cells["IdSalida"].Value);

                MessageBox.Show("Venta Seleccionada: " + idSalida);

                CargarDetalleVenta(idSalida);
            }
        }
    }
}
