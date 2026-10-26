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
    public partial class ReporteVentasTrabajador : Form
    {
        private string cadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";

        private Usuario usuarioSesion;
        private Form FormParent;
        public ReporteVentasTrabajador(Usuario usuario, Form formparent)
        {
            InitializeComponent();
            usuarioSesion = usuario;
            FormParent = formparent;
        }

        private void ReporteVentasTrabajador_Load(object sender, EventArgs e)
        {
            CargarProducto();
            ColoresDiseño();
            CargarVentasdelDia();
        }

        private void CargarVentasdelDia()
        {
            try
            {
                int idTrabajadorActual = usuarioSesion.IdUsuario;
                using (SqlConnection conexion = new SqlConnection(cadenaConexion)) 
                {
                    using (SqlCommand cmd = new SqlCommand("ObtenerVentasDelDiaTrabajador", ConexionDB.ObtenerConexion()))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdUsuario", idTrabajadorActual);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable data = new DataTable();
                        dataAdapter.Fill(data);

                        dvgVentasrealizadas.DataSource = data;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas del trabajador:" + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarProducto()
        {
            SqlConnection Sqlconexion = new SqlConnection(cadenaConexion);

            SqlDataAdapter adaptadorSql = new SqlDataAdapter("ver_Ventas_Realizadas", Sqlconexion);

            DataTable tablaDato = new DataTable();
            adaptadorSql.Fill(tablaDato);

            dvgVentasrealizadas.DataSource = tablaDato;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            SeguidorPila.Regresar(this);
        }

        private void dvgDetalleVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void CargarDetalleVenta(int idVenta)
        {
            SqlConnection SqlConexion = new SqlConnection(cadenaConexion);

            SqlDataAdapter sqlAdaptador = new SqlDataAdapter("Ver_Detalle_Producto", SqlConexion);
            sqlAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlAdaptador.SelectCommand.Parameters.AddWithValue("@idSalida", idVenta);

            DataTable tablaDato = new DataTable();
            sqlAdaptador.Fill(tablaDato);

            dvgDetalleVentas.DataSource = tablaDato;
        }
        public void CargarVentasEnPantalla()
        {
            try
            {
                DataTable Tabladatos = new DataTable();

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("Cargar_Ventas_Pantalla", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter AdaptadorSQL = new SqlDataAdapter(cmd);
                        AdaptadorSQL.Fill(Tabladatos);
                    }
                }
                dvgVentasrealizadas.DataSource = Tabladatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recargar las ventas" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgVentasrealizadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            {
                int idSalida = Convert.ToInt32(dvgVentasrealizadas.Rows[e.RowIndex].Cells["IdSalida"].Value);

                MessageBox.Show("Venta Seleccionada: " + idSalida);

                CargarDetalleVenta(idSalida);
            }
        }
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("Colores_Diseño_Trabajador", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);
                ReporteVentasTrabajador herramientas = this;

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        herramientas.BackColor = SystemColors.HotTrack;
                        dvgDetalleVentas.BackgroundColor = Color.LightSkyBlue;
                        dvgVentasrealizadas.BackgroundColor = Color.LightSkyBlue;
                        //Paneles atras
                        btnRegresar.BackColor = SystemColors.MenuHighlight;
                        //botones atras
                    }
                    else if (valorLugar == 2)
                    {
                        herramientas.BackColor = Color.BlueViolet;
                        dvgVentasrealizadas.BackgroundColor = Color.BlueViolet;
                        dvgDetalleVentas.BackgroundColor = Color.BlueViolet;
                        //Paneles atras
                        btnRegresar.BackColor = Color.MediumPurple;

                        //botones atras
                    }
                    else if (valorLugar == 3)
                    {
                        herramientas.BackColor = Color.Teal;
                        dvgDetalleVentas.BackgroundColor = Color.PowderBlue;
                        dvgVentasrealizadas.BackgroundColor = Color.PowderBlue;
                        //Paneles atras
                        btnRegresar.BackColor = Color.CadetBlue;
                        //botones atras
                    }
                    else if (valorLugar == 4)
                    {
                        herramientas.BackColor = Color.Black;
                        dvgDetalleVentas.BackgroundColor = Color.DarkGray;
                        dvgVentasrealizadas.BackgroundColor = Color.DarkGray;
                        //Paneles atras
                        btnRegresar.BackColor = Color.DimGray;
                        //botones atras
                    }
                }

            }
        }
    }
}
