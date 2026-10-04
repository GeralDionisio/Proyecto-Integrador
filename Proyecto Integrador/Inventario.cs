using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using ExcelDataReader;

namespace Proyecto_Integrador
{
    public partial class Inventario : Form
    {
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
        public class jsonSerializer;

        private Usuario usuarioSesion;
        private Form parentForm;

        public Inventario(Usuario usuario, Form parent)
        {
            usuarioSesion = usuario;
            parentForm = parent;
            InitializeComponent();
            lblUsuario.Text = usuario?.NombreCompleto ?? string.Empty;
            lblRol.Text = usuario?.Rol ?? string.Empty;

            System.Windows.Forms.Timer miReloj = new System.Windows.Forms.Timer();
            miReloj.Interval = 1000; // 1 segundo
            miReloj.Tick += MiReloj_Tick; // Apunta al método de abajo, NO al Label
            miReloj.Start();






        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuprincipal = new MenuPrincipal(usuarioSesion, this);
            menuprincipal.Show();
            this.Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter sqladaptador = new SqlDataAdapter("SELECT * FROM Productos", sqlconexion);

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgProductosExistencia.DataSource = tabladatos;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductosLimpieza_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("SELECT * FROM Productos WHERE Categoria = 'Productos De Limpieza'", sqlconexion);

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Close();


        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            MenuPrincipalVenta menuprincipalventa = new MenuPrincipalVenta(usuarioSesion, this);
            menuprincipalventa.Show();
            this.Close();
        }

        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {


        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnPanaderia_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("SELECT * FROM Productos WHERE Categoria = 'Panaderia'", sqlconexion);

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("SELECT * FROM Productos WHERE Categoria = 'Bebidas'", sqlconexion);

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;

        }

        private void btnMeneitos_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("SELECT * FROM Productos WHERE Categoria = 'Meneitos'", sqlconexion);

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;
        }

        private void btnComidasCongelada_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("SELECT * FROM Productos WHERE Categoria = 'Comidas Congeladas'", sqlconexion);

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;

        }

        private void btnHigienePersonal_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("SELECT * FROM Productos WHERE Categoria = 'Higiene Personal'", sqlconexion);

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter sqladaptador = new SqlDataAdapter("SELECT * FROM Productos", sqlconexion);

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgProductosExistencia.DataSource = tabladatos;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConexion = new SqlConnection(CadenaConexion);
            SqlDataAdapter AdaptadorSql = new SqlDataAdapter($"SELECT * FROM Productos WHERE Nombre LIKE '{txtBuscarProducto.Text}%'", sqlConexion);

            DataTable TablaDato = new DataTable();
            AdaptadorSql.Fill(TablaDato);

            dvgProductosExistencia.DataSource = TablaDato;
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAñadirNuevo_Click(object sender, EventArgs e)
        {
            AgregarProductos agregarproductos = new AgregarProductos(usuarioSesion, this);
            agregarproductos.Show();
        }

        private void btnEditarValor_Click(object sender, EventArgs e)
        {
            EditarProducto editarproducto = new EditarProducto();
            editarproducto.Show();
        }

        private void MiReloj_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = "" + DateTime.Now.ToString("dd/M/yyyy HH:mm:ss");
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            Herramientas herramientas = new Herramientas();
            herramientas.Show();
        }

        private void btnIngresarProductoExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog DatosDialogo = new OpenFileDialog();
            {
                DatosDialogo.Filter = "Archivos Excel (*.xlsx;*.xls)| *.xlsx;*.xls";
                DatosDialogo.Title = "Por favor seleccione un archivo Excel";
            }

            if(DatosDialogo.ShowDialog() == DialogResult.OK)
            {
                string rutaExcel = DatosDialogo.FileName;

                try
                {

                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                    using (var LeerDatos = File.Open(rutaExcel, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(LeerDatos))
                        {
                            var resultado = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            DataTable tablaDatos = resultado.Tables[0];

                            int RegistroInsertados = 0;

                            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                            {
                                conexion.Open();

                                foreach (DataRow filaDatos in tablaDatos.Rows)
                                {
                                    if (filaDatos["Nombre"] == DBNull.Value || string.IsNullOrEmpty(filaDatos["Nombre"].ToString()))
                                        continue;

                                    using (SqlCommand cmd = new SqlCommand("Insertar_Producto", conexion))
                                    {
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.AddWithValue("@Nombre", filaDatos["Nombre"].ToString());
                                        cmd.Parameters.AddWithValue("@Marca", filaDatos["Marca"].ToString());
                                        cmd.Parameters.AddWithValue("@Categoria", filaDatos["Categoria"].ToString());
                                        cmd.Parameters.AddWithValue("@StockMinimo", Convert.ToInt32(filaDatos["StockMinimo"]));
                                        cmd.Parameters.AddWithValue("@PrecioActual", Convert.ToDecimal(filaDatos["PrecioActual"]));
                                        cmd.Parameters.AddWithValue("@StockActual", Convert.ToInt32(filaDatos["StockActual"]));
                                        cmd.Parameters.AddWithValue("@FechaVencimiento", Convert.ToDateTime(filaDatos["FechaVencimiento"]));
                                        cmd.Parameters.AddWithValue("@UnidadDeMedida", filaDatos["UnidadDeMedida"].ToString());
                                        cmd.ExecuteNonQuery();
                                        RegistroInsertados++;
                                        
                                    }
                                }
                            }
                            MessageBox.Show($"Proceso completado se ingresaron {RegistroInsertados} Productos correctamente a la base de datos", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al importar el archivo Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
