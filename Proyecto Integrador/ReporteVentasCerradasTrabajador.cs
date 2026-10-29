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

        private int idSeleccionado = 0;
        private string FechaVenta = "";
        private string TotalVenta = "";
        private string NombreTrabajador = "";
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
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
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
                        dvgVentasCerradas.BackgroundColor = Color.LightSkyBlue;
                        dvgDetalleVentasCerradas.BackgroundColor = Color.LightSkyBlue;
                        //Paneles atras
                        btnRegresar.BackColor = SystemColors.MenuHighlight;
                        btnImprimirVentas.BackColor = SystemColors.MenuHighlight;
                        //botones atras
                    }
                    else if (valorLugar == 2)
                    {
                        herramientas.BackColor = Color.BlueViolet;
                        dvgDetalleVentasCerradas.BackgroundColor = Color.BlueViolet;
                        dvgVentasCerradas.BackgroundColor = Color.BlueViolet;
                        //Paneles atras
                        btnRegresar.BackColor = Color.MediumPurple;
                        btnImprimirVentas.BackColor = Color.MediumPurple;
                    

                        //botones atras
                    }
                    else if (valorLugar == 3)
                    {
                        herramientas.BackColor = Color.Teal;
                        dvgDetalleVentasCerradas.BackgroundColor = Color.PowderBlue;
                        dvgVentasCerradas.BackgroundColor = Color.PowderBlue;

                        btnRegresar.BackColor = Color.CadetBlue;
                        btnImprimirVentas.BackColor = Color.CadetBlue;

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
                        btnImprimirVentas.BackColor = Color.DimGray;
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
                DataGridViewRow fila = dvgVentasCerradas.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["IdSalida"].Value);
                FechaVenta = fila.Cells["Fecha"].Value.ToString();
                TotalVenta = fila.Cells["TotalVenta"].Value.ToString();
                NombreTrabajador = fila.Cells["NombreTrabajador"].Value.ToString();

                int idSalida = Convert.ToInt32(dvgVentasCerradas.Rows[e.RowIndex].Cells["IdSalida"].Value);

                MessageBox.Show("Venta Seleccionada: " + idSalida);

                CargarDetalleVenta(idSalida);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 20;
            int y = 100;
            int anchoColumna = 150;
            int Altofila = 60;
            Font FuenteCabecera = new Font("Arial", 10, FontStyle.Bold);
            Font FuenteContenido = new Font("Arial", 9, FontStyle.Regular);
            Pen lapiz = new Pen(Color.Black, 1);

            Image logo = Properties.Resources.ImpagenPortadaFactura;
            e.Graphics.DrawImage(logo, x, y, 120, 100);

            y += 50;
            e.Graphics.DrawString("Factura De Venta Que Se Realizo Dentro De La Pulperia", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, x, 85);
            y += 22;

            e.Graphics.DrawString("Fecha:" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, x, 260);
            y += 18;
            e.Graphics.DrawString("Nombre del Trabajador: " + NombreTrabajador, new Font("arial", 10, FontStyle.Regular), Brushes.Black, x, 220);
            e.Graphics.DrawString("Numero de Factura:" + idSeleccionado, new Font("arial", 10, FontStyle.Regular), Brushes.Black, x, 240);
            y += 18;
            e.Graphics.DrawString("Fecha que se realizo la venta:" + FechaVenta, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, x, 200);

            y += 80;
            for (int i = 0; i < dvgDetalleVentasCerradas.Columns.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, x + (i * anchoColumna), y, anchoColumna, Altofila);
                e.Graphics.DrawRectangle(lapiz, x + (i * anchoColumna), y, anchoColumna, Altofila);
                e.Graphics.DrawString(dvgDetalleVentasCerradas.Columns[i].HeaderText, FuenteCabecera, Brushes.Black, x + (i * anchoColumna) + 5, y + 5);
            }
            y += Altofila;

            foreach (DataGridViewRow row in dvgDetalleVentasCerradas.Rows)
            {
                if (row.IsNewRow) continue;

                for (int i = 0; i < dvgDetalleVentasCerradas.Columns.Count; i++)
                {
                    object valor = row.Cells[i].Value;
                    string texto = valor != null ? valor.ToString() : string.Empty;

                    e.Graphics.DrawRectangle(lapiz, x + (i * anchoColumna), y, anchoColumna, Altofila);
                    e.Graphics.DrawString(texto, FuenteContenido, Brushes.Black, x + (i * anchoColumna) + 5, y + 5);
                }
                y += Altofila;
            }
            Font fuenteTotal = new Font("Arial", 11, FontStyle.Bold);
            e.Graphics.DrawString("Total De Venta Fue De: " + TotalVenta, fuenteTotal, Brushes.Black, x + 1, y);
        }
        

        private void btnImprimirVentas_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Por favor Seleccione una venta dentro de la tabla para poder imprimir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
