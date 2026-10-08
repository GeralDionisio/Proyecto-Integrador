using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text;

namespace Proyecto_Integrador
{
    public partial class Herramientas : Form
    {
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
        private string CadenaMaster = "Server=Gerald;Database=master;Trusted_Connection=True;TrustServerCertificate=True;";

        private Usuario usuarioSesion;
        private Form parentForms;
        public Herramientas(Usuario usuario, Form parentForm)
        {
            usuarioSesion = usuario;
            parentForms = parentForm;

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            SeguidorPila.Regresar(this);
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrearRespaldo_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo de respaldo (*.bak) |*.bak";
                saveFileDialog.Title = "Guardar respaldo de la base de datos";
                saveFileDialog.FileName = $"Respaldo Gestion De Inventario_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.bak";


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filepath = saveFileDialog.FileName;

                    try
                    {
                        using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                        {
                            using (SqlCommand cmd = new SqlCommand("CREA_Respaldo_Base_De_Datos", conexion))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@filepath", filepath);
                                conexion.Open();
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("El respaldo de la base de datos se realizo exitosamente", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al crear el respaldo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }
        }

        private void btnRestaurarRespaldo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivo de respaldo (*.bak) | *.bak";
                openFileDialog.Title = "Selecciona un archivo de respaldo para el sistema de inventario";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filepath = openFileDialog.FileName;

                    DialogResult resultado = MessageBox.Show("¿Estas seguro que quieres restaurar la base de datos?\n " +
                        "se sobrescribiran datos con el archivo seleccionado."
                        , "Confirmacion Restauracion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {

                        string validacion = @" DECLARE @sql NVARCHAR(MAX) = N'';
                                 SELECT @sql += N'KILL ' + CAST(session_id AS NVARCHAR(50)) + N'; '
                                  FROM sys.dm_exec_sessions
                                  WHERE database_id = DB_ID('GestionInventario11') AND session_id <> @@SPID;
                                 IF LEN(@sql) > 0 EXEC sp_executesql @sql;";
                        try
                        {

                            using (SqlConnection conexion = new SqlConnection(CadenaMaster))
                            {
                                conexion.Open();


                                using (SqlCommand cmdProcesos = new SqlCommand(validacion, conexion))
                                {
                                    cmdProcesos.ExecuteNonQuery();
                                }

                                using (SqlCommand cmd1 = new SqlCommand("ALTER DATABASE [GestionInventario11] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; ", conexion))
                                {
                                    cmd1.ExecuteNonQuery();
                                }

                                using (SqlCommand cmd2 = new SqlCommand($"RESTORE DATABASE [GestionInventario11] FROM DISK = @filepath WITH REPLACE;", conexion))
                                {
                                    cmd2.Parameters.AddWithValue("@filepath", filepath);
                                    cmd2.CommandTimeout = 120;
                                    cmd2.ExecuteNonQuery();
                                }

                                using (SqlCommand cmd = new SqlCommand("ALTER DATABASE [GestionInventario11] SET MULTI_USER WITH ROLLBACK IMMEDIATE;", conexion))
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                MessageBox.Show("La restauracion de la base de datos se realizo exitosamente", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al restaurar el respaldo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
            }
        }

        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que quiere cerrar las ventas del dia de hoy?\n" +
                "Se exportaran los datos de ventas a excel", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                DataTable Tablareporte = ObtenerVentasyDetallesdelDia();

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
                    GuardadoExcel.FileName = $"Ventas_Cerradas_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.csv";

                }

                if (GuardadoExcel.ShowDialog() == DialogResult.OK)
                {
                    ExportarAExcel(Tablareporte, GuardadoExcel.FileName);

                    CerrarVentasComoCerrado();

                    CargarVentanaDeVentas();

                    MessageBox.Show("El cierre del dia se proceso y se guardo con exito", "Cierre Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrieron errores en los procedimiento." + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private DataTable ObtenerVentasyDetallesdelDia()
        {
            DataTable tablaDatos = new DataTable();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand("Obtener_Ventas_Del_Dia", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    adaptador.Fill(tablaDatos);
                }
            }
            return tablaDatos;
        }
        private void CerrarVentasComoCerrado()
        {
            using (SqlConnection Conexion = new SqlConnection(CadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand("Eliminar_Venta_Del_Dia", Conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    Conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
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
                escritoExcel.WriteLine("sep=;");

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

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.Show();


        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            ActualizarUsuario actualizarUsuario = new ActualizarUsuario();
            actualizarUsuario.Show();
        }

        private void Herramientas_Load(object sender, EventArgs e)
        {
            ColoresdeFondo();
        }

        private void btnColorAzul_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconexion = ConexionDB.ObtenerConexion())
            {

                using (SqlCommand cmd = new SqlCommand("Color_Azul", sqlconexion))
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
                            ColoresdeFondo();
                            MenuPrincipal menuprincipal = new MenuPrincipal(usuarioSesion, this);
                            menuprincipal.Show();
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
        private void ColoresdeFondo()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("Colores_Diseño", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);
                Herramientas herramientas = this;

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        herramientas.BackColor = SystemColors.HotTrack;
                        //Paneles atras
                        btnRegresar.BackColor = SystemColors.MenuHighlight;
                        btnCrearRespaldo.BackColor = SystemColors.MenuHighlight;
                        btnRestaurarRespaldo.BackColor = SystemColors.MenuHighlight;
                        btnCerrarVenta.BackColor = SystemColors.MenuHighlight;
                        iconButton1.BackColor = SystemColors.MenuHighlight;
                        btnCrearUsuario.BackColor = SystemColors.MenuHighlight;
                        btnEditarUsuario.BackColor = SystemColors.MenuHighlight;
                        btnReporteUsuario.BackColor = SystemColors.MenuHighlight;
                        //botones atras
                    }
                    else if (valorLugar == 2)
                    {
                        herramientas.BackColor = Color.BlueViolet;
                        //Paneles atras
                        btnRegresar.BackColor = Color.MediumPurple;
                        btnCrearRespaldo.BackColor = Color.MediumPurple;
                        btnRestaurarRespaldo.BackColor = Color.MediumPurple;
                        btnCerrarVenta.BackColor = Color.MediumPurple;
                        iconButton1.BackColor = Color.MediumPurple;
                        btnCrearUsuario.BackColor = Color.MediumPurple;
                        btnEditarUsuario.BackColor = Color.MediumPurple;
                        btnReporteUsuario.BackColor = Color.MediumPurple;
                        //botones atras
                    }
                    else if (valorLugar == 3)
                    {
                        herramientas.BackColor = Color.Teal;
                        //Paneles atras
                        btnRegresar.BackColor = Color.CadetBlue;
                        btnCrearRespaldo.BackColor = Color.CadetBlue;
                        btnRestaurarRespaldo.BackColor = Color.CadetBlue;
                        btnCerrarVenta.BackColor = Color.CadetBlue;
                        iconButton1.BackColor = Color.CadetBlue;
                        btnCrearUsuario.BackColor = Color.CadetBlue;
                        btnEditarUsuario.BackColor = Color.CadetBlue;
                        btnReporteUsuario.BackColor = Color.CadetBlue;
                        //botones atras
                    }
                    else if (valorLugar == 4)
                    {
                        herramientas.BackColor = Color.Black;
                        //Paneles atras
                        btnRegresar.BackColor = Color.DimGray;
                        btnCrearRespaldo.BackColor = Color.DimGray;
                        btnRestaurarRespaldo.BackColor = Color.DimGray;
                        btnCerrarVenta.BackColor = Color.DimGray;
                        iconButton1.BackColor = Color.DimGray;
                        btnCrearUsuario.BackColor = Color.DimGray;
                        btnEditarUsuario.BackColor = Color.DimGray;
                        btnReporteUsuario.BackColor = Color.DimGray;
                        //botones atras
                    }
                }

            }

        }

        private void btnColorMorado_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconexion = ConexionDB.ObtenerConexion())
            {

                using (SqlCommand cmd = new SqlCommand("Color_Morado", sqlconexion))
                {
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
                            MenuPrincipal menuprincipal = new MenuPrincipal(usuarioSesion, this);
                            menuprincipal.Show();
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

        private void btnColorNaranja_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconexion = ConexionDB.ObtenerConexion())
            {

                using (SqlCommand cmd = new SqlCommand("Color_Verde", sqlconexion))
                {
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
                            MenuPrincipal menuprincipal = new MenuPrincipal(usuarioSesion, this);
                            menuprincipal.Show();
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

                using (SqlCommand cmd = new SqlCommand("Color_Oscuro", sqlconexion))
                {
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
                            MenuPrincipal menuprincipal = new MenuPrincipal(usuarioSesion, this);
                            menuprincipal.Show();
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

        private void btnReporteUsuario_Click(object sender, EventArgs e)
        {
            ReporteUsuario reporteUsuario = new ReporteUsuario();
            reporteUsuario.Show();
        }
    }
}
