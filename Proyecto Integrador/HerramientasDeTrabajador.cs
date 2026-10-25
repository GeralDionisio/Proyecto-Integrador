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
    public partial class HerramientasDeTrabajador : Form
    {
        private Usuario usuarioSesion;
        private Form formParent;
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
        public HerramientasDeTrabajador(Usuario usuario, Form formparent)
        {
            usuarioSesion = usuario;
            formParent = formparent;
            InitializeComponent();
        }

        private void btnColorNaranja_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconexion = ConexionDB.ObtenerConexion())
            {

                using (SqlCommand cmd = new SqlCommand("Color_Verde_Trabajo", sqlconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        if (sqlconexion.State != System.Data.ConnectionState.Open)
                        {
                            sqlconexion.Open();
                        }

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Debido a los cambios realizados debe regresar a la pantalla de Menu Principal.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ColoresDiseño();
                            MenuPrincipalTrabajador menuPrincipalTrabajador = new MenuPrincipalTrabajador(this, usuarioSesion);
                            menuPrincipalTrabajador.Show();
                            this.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            SeguidorPila.Regresar(this);
        }
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("Colores_Diseño_Trabajador", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);
                HerramientasDeTrabajador herramientas = this;

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        herramientas.BackColor = SystemColors.HotTrack;
                        //Paneles atras
                        btnRegresar.BackColor = SystemColors.MenuHighlight;
                        btnCerrarVenta.BackColor = SystemColors.MenuHighlight;
                        //botones atras
                    }
                    else if (valorLugar == 2)
                    {
                        herramientas.BackColor = Color.BlueViolet;
                        //Paneles atras
                        btnRegresar.BackColor = Color.MediumPurple;
                        btnCerrarVenta.BackColor = Color.MediumPurple;

                        //botones atras
                    }
                    else if (valorLugar == 3)
                    {
                        herramientas.BackColor = Color.Teal;
                        //Paneles atras
                        btnRegresar.BackColor = Color.CadetBlue;
                        btnCerrarVenta.BackColor = Color.CadetBlue;
                        //botones atras
                    }
                    else if (valorLugar == 4)
                    {
                        herramientas.BackColor = Color.Black;
                        //Paneles atras
                        btnRegresar.BackColor = Color.DimGray;
                        btnCerrarVenta.BackColor = Color.DimGray;
                        //botones atras
                    }
                }

            }
        }

        private void btnColorAzul_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconexion = ConexionDB.ObtenerConexion())
            {

                using (SqlCommand cmd = new SqlCommand("Color_Azul_Trabajador", sqlconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        if (sqlconexion.State != System.Data.ConnectionState.Open)
                        {
                            sqlconexion.Open();
                        }

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Debido a los cambios realizados debe regresar a la pantalla de Menu Principal.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ColoresDiseño();
                            MenuPrincipalTrabajador menuPrincipalTrabajador = new MenuPrincipalTrabajador(this, usuarioSesion);
                            menuPrincipalTrabajador.Show();
                            this.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void HerramientasDeTrabajador_Load(object sender, EventArgs e)
        {
            ColoresDiseño();
        }

        private void btnColorMorado_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconexion = ConexionDB.ObtenerConexion())
            {

                using (SqlCommand cmd = new SqlCommand("Color_Morado_Trabajo", sqlconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        if (sqlconexion.State != System.Data.ConnectionState.Open)
                        {
                            sqlconexion.Open();
                        }

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Debido a los cambios realizados debe regresar a la pantalla de Menu Principal.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ColoresDiseño();
                            MenuPrincipalTrabajador menuPrincipalTrabajador = new MenuPrincipalTrabajador(this, usuarioSesion);
                            menuPrincipalTrabajador.Show();
                            this.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnColorOscuro_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconexion = ConexionDB.ObtenerConexion())
            {

                using (SqlCommand cmd = new SqlCommand("Color_Oscuro_Trabajador", sqlconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        if (sqlconexion.State != System.Data.ConnectionState.Open)
                        {
                            sqlconexion.Open();
                        }

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Debido a los cambios realizados debe regresar a la pantalla de Menu Principal.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ColoresDiseño();
                            MenuPrincipalTrabajador menuPrincipalTrabajador = new MenuPrincipalTrabajador(this, usuarioSesion);
                            menuPrincipalTrabajador.Show();
                            this.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private DataTable ObtenerVentasyDetallesdelDia(int IdUsuario)
        {
            DataTable tablaDatos = new DataTable();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand("Obtener_Ventas_Del_Dia", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    adaptador.Fill(tablaDatos);
                }
            }
            return tablaDatos;
        }
        private void CargarVentanaDeVentas()
        {
            MenuPrincipalVenta menuprincipalventa = Application.OpenForms.OfType<MenuPrincipalVenta>().FirstOrDefault();

            if (menuprincipalventa != null)
            {
                menuprincipalventa.CargarVentasEnPantalla();
            }
        }
        private void ExportarAExcel(DataTable data, string RutaArchivo)
        {
            using (StreamWriter escritoExcel = new StreamWriter(RutaArchivo, false, new System.Text.UTF8Encoding(true)))
            {
                escritoExcel.WriteLine("sep=;");

                for (int i = 0; i < data.Columns.Count; i++)
                {
                    escritoExcel.Write(data.Columns[i].ColumnName);
                    if (i < data.Columns.Count - 1) escritoExcel.Write(";");
                }
                escritoExcel.WriteLine("");

                foreach (DataRow Row in data.Rows)
                {
                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        string valortotal = Row[i].ToString().Replace("\"", "\"\"");
                        escritoExcel.Write($"\"{valortotal}\"");
                        if (i < data.Columns.Count - 1) escritoExcel.Write(";");
                    }
                    escritoExcel.WriteLine();
                }
            }
        }
        private void InsertarDatosTablaEliminado()
        {
            try
            {
                using (SqlConnection sqlConexion = new SqlConnection(CadenaConexion))
                {
                    sqlConexion.Open();

                    // 1. Ejecutamos INTENTO_5 para respaldar las cabeceras de ventas
                    using (SqlCommand cmdIntento5 = new SqlCommand("Carga_Masiva_Tabla_Salida", sqlConexion))
                    {
                        cmdIntento5.CommandType = CommandType.StoredProcedure;
                        cmdIntento5.ExecuteNonQuery();
                    }

                    // 2. Ejecutamos INTENTO2DELOSDETALLES1_2 para respaldar los detalles
                    using (SqlCommand cmdDetalles = new SqlCommand("Detalle_Salida", sqlConexion))
                    {
                        cmdDetalles.CommandType = CommandType.StoredProcedure;
                        cmdDetalles.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar los respaldos en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            InsertarDatosTablaEliminado();

            DialogResult result = MessageBox.Show("¿Esta seguro que quiere cerrar las ventas del dia de hoy?\n" +
                "Se exportaran los datos de ventas a excel", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                int idTrabajadorActual = usuarioSesion.IdUsuario;

                DataTable Tablareporte = ObtenerVentasyDetallesdelDia(idTrabajadorActual);

                if (Tablareporte == null || Tablareporte.Rows.Count == 0)
                {
                    MessageBox.Show("No hay ventas registradas en el dia de hoy", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog GuardadoExcel = new SaveFileDialog();
                {
                    GuardadoExcel.Filter = "Archivo csv (*.csv)|*.csv";
                    GuardadoExcel.DefaultExt = "csv";
                    GuardadoExcel.AddExtension = true;
                    GuardadoExcel.Title = "Guarde los reportes del dia de hoy";
                    GuardadoExcel.FileName = $"Ventas_Cerradas_Trabajador_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.csv";


                }

                if (GuardadoExcel.ShowDialog() == DialogResult.OK)
                {
                    ExportarAExcel(Tablareporte, GuardadoExcel.FileName);

                    CerrarVentasTrabajador();

                    CargarVentanaDeVentas();


                    MessageBox.Show("El cierre del dia se proceso y se guardo con exito", "Cierre Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrieron errores en los procedimiento." + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void CerrarVentasTrabajador()
        {
            using (SqlConnection Conexion = new SqlConnection(CadenaConexion))
            {

                int idTrabajadorSeleccionado = usuarioSesion.IdUsuario;
                using (SqlCommand cmd = new SqlCommand("Eliminar_Venta_Del_Dia", Conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", idTrabajadorSeleccionado);
                    Conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
