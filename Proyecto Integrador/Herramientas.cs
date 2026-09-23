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

namespace Proyecto_Integrador
{
    public partial class Herramientas : Form
    {
        public Herramientas()
        {
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
            this.Close();
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

                    string ConexionBasadedatos = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
                    string dbName = "GestionInventario11";

                    string query = $"BACKUP DATABASE {dbName} TO DISK = @filepath WITH FORMAT, MEDIANAME = 'RespaldoBackUp', NAME = 'RespaldoCompleto';";

                    try
                    {
                        using (SqlConnection conexion = new SqlConnection(ConexionBasadedatos))
                        {
                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                            {
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

                    DialogResult resultado = MessageBox.Show("¿Estas seguro que quieres restaurar la base de datos? \n se sobrescribiran datos con el archivo seleccionado."
                        , "Confirmacion Restauracion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        string ConexionBASEdedatos = "Server=Gerald;Database=master;Trusted_Connection=True;TrustServerCertificate=True;";
                        string dbName = "GestionInventario11";

                        try
                        {

                            using (SqlConnection conexion = new SqlConnection(ConexionBASEdedatos))
                            {
                                conexion.Open();

                                string queryProcesos = $@"
                                 DECLARE @sql NVARCHAR(MAX) = N'';
                                 SELECT @sql += N'KILL ' + CAST(session_id AS NVARCHAR(50)) + N'; '
                                  FROM sys.dm_exec_sessions
                                  WHERE database_id = DB_ID('{dbName}') AND session_id <> @@SPID;
                                 IF LEN(@sql) > 0 EXEC sp_executesql @sql;";

                                using (SqlCommand cmdProcesos = new SqlCommand(queryProcesos, conexion))
                                {
                                    cmdProcesos.ExecuteNonQuery();
                                }

                                using (SqlCommand cmd1 = new SqlCommand($"ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;", conexion))
                                {
                                    cmd1.ExecuteNonQuery();
                                }

                                using (SqlCommand cmd2 = new SqlCommand($"RESTORE DATABASE [{dbName}] FROM DISK = @filepath WITH REPLACE;", conexion))
                                {
                                    cmd2.Parameters.AddWithValue("@filepath", filepath);
                                    cmd2.CommandTimeout = 120;
                                    cmd2.ExecuteNonQuery();
                                }

                                using (SqlCommand cmd = new SqlCommand($"ALTER DATABASE [{dbName}] SET MULTI_USER WITH ROLLBACK IMMEDIATE;", conexion))
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
    }
}
