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
        private int IdSeleccionado = 0;
        private string FechaVenta = "";
        private string TotalVenta = "";

        private string NombreVendedor = "";
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
            SqlDataAdapter sqladaptador = new SqlDataAdapter("select IdSalida, Fecha, TotalVenta, NombreTrabajador from Eliminados", sqlconexion);
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
                        btnImprimirVentaRealizada.BackColor = SystemColors.MenuHighlight;
                        dvgDetallesProductosCerrados.BackgroundColor = Color.LightSkyBlue;
                        dvgProductosCerrados.BackgroundColor = Color.LightSkyBlue;


                    }
                    else if (valorLugar == 2)
                    {
                        reportes.BackColor = Color.MediumPurple;

                        //Paneles atras
                        btnImprimirVentaRealizada.BackColor = Color.MediumPurple;
                        btnRegresar.BackColor = Color.MediumPurple;
                        dvgDetallesProductosCerrados.BackgroundColor = Color.DarkOrchid;
                        dvgProductosCerrados.BackgroundColor = Color.DarkOrchid;


                    }
                    else if (valorLugar == 3)
                    {
                        reportes.BackColor = Color.Teal;
                        btnRegresar.BackColor = Color.CadetBlue;
                        btnImprimirVentaRealizada.BackColor = Color.CadetBlue;
                        dvgDetallesProductosCerrados.BackgroundColor = Color.PowderBlue;
                        dvgProductosCerrados.BackgroundColor = Color.PowderBlue;


                    }
                    else if (valorLugar == 4)
                    {
                        reportes.BackColor = Color.Black;

                        //Paneles atras
                        dvgDetallesProductosCerrados.BackgroundColor = Color.DarkGray;
                        dvgProductosCerrados.BackgroundColor = Color.DimGray;
                        btnImprimirVentaRealizada.BackColor = Color.DimGray;
                        btnRegresar.BackColor = Color.DimGray;


                    }
                }

            }
        }

        private void dvgProductosCerrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            {
                DataGridViewRow fila = dvgProductosCerrados.Rows[e.RowIndex];
                IdSeleccionado = Convert.ToInt32(fila.Cells["IdSalida"].Value);
                FechaVenta = fila.Cells["Fecha"].Value.ToString();
                TotalVenta = fila.Cells["TotalVenta"].Value.ToString();
                NombreVendedor = fila.Cells["NombreTrabajador"].Value.ToString();
               
                int idSalida = Convert.ToInt32(dvgProductosCerrados.Rows[e.RowIndex].Cells["IdSalida"].Value);

                MessageBox.Show("Venta Seleccionada: " + idSalida);

                CargarDetalleVenta(IdSeleccionado);
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

        private void btnImprimirVentaRealizada_Click(object sender, EventArgs e)
        {
            if (IdSeleccionado == 0)
            {
                MessageBox.Show("Por favor Seleccione una venta dentro de la tabla para poder imprimir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
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
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, x, 260);
            y += 18;
            e.Graphics.DrawString("Nombre del Vendedor: " + NombreVendedor, new Font("arial", 10, FontStyle.Regular), Brushes.Black, x, 220);
            e.Graphics.DrawString("Numero de la Factura: " + IdSeleccionado, new Font("arial", 10, FontStyle.Regular), Brushes.Black, x, 240);
            y += 18;
            e.Graphics.DrawString("Fecha que se realizo la venta: " + FechaVenta, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, x, 200);

            y += 80;

            for (int i = 0; i < dvgDetallesProductosCerrados.Columns.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, x + (i * anchoColumna), y, anchoColumna, Altofila);
                e.Graphics.DrawRectangle(lapiz, x + (i * anchoColumna), y, anchoColumna, Altofila);
                e.Graphics.DrawString(dvgDetallesProductosCerrados.Columns[i].HeaderText, FuenteCabecera, Brushes.Black, x + (i * anchoColumna) + 5, y + 5);
            }
            y += Altofila;

            foreach (DataGridViewRow row in dvgDetallesProductosCerrados.Rows)
            {
                if (row.IsNewRow) continue;

                for (int i = 0; i < dvgDetallesProductosCerrados.Columns.Count; i++)
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
    }
}
