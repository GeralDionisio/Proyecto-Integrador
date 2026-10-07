using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;
using ExcelDataReader;

namespace Proyecto_Integrador
{
    public partial class Inventario : Form
    {
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";

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
            MenuPrincipal menuPrincipal = new MenuPrincipal(usuarioSesion, this);
            menuPrincipal.Show();
            this.Hide();

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

            SqlDataAdapter sqladaptador = new SqlDataAdapter("Ver_Producto", sqlconexion);
            sqladaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgProductosExistencia.DataSource = tabladatos;

            ColoresDiseño();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductosLimpieza_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("Boton_Limpieza", sqlconexion);
            AdaptadorSQL.SelectCommand.CommandType = CommandType.StoredProcedure;

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

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("Boton_Panaderia", sqlconexion);
            AdaptadorSQL.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("Boton_Bebidas", sqlconexion);
            AdaptadorSQL.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;

        }

        private void btnMeneitos_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("Boton_Meneitos", sqlconexion);
            AdaptadorSQL.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;
        }

        private void btnComidasCongelada_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("Boton_Comidas_Congeladas", sqlconexion);
            AdaptadorSQL.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;

        }

        private void btnHigienePersonal_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter("Boton_Higiene_Personal", sqlconexion);
            AdaptadorSQL.SelectCommand.CommandType = CommandType.StoredProcedure;


            DataTable tablaDatos = new DataTable();
            AdaptadorSQL.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter sqladaptador = new SqlDataAdapter("Ver_Producto", sqlconexion);
            sqladaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgProductosExistencia.DataSource = tabladatos;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConexion = new SqlConnection(CadenaConexion);
            SqlDataAdapter AdaptadorSql = new SqlDataAdapter("Boton_Buscar", sqlConexion);
            AdaptadorSql.SelectCommand.CommandType = CommandType.StoredProcedure;
            AdaptadorSql.SelectCommand.Parameters.AddWithValue("@Nombre", txtBuscarProducto.Text.Trim());

            DataTable TablaDato = new DataTable();
            AdaptadorSql.Fill(TablaDato);

            dvgProductosExistencia.DataSource = TablaDato;
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAñadirNuevo_Click(object sender, EventArgs e)
        {
            AgregarProductos agregarproductos = new AgregarProductos(usuarioSesion, parentForm);
            SeguidorPila.AbrirSiguiente(this, agregarproductos);
            
        }

        private void btnEditarValor_Click(object sender, EventArgs e)
        {

        }

        private void MiReloj_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = "" + DateTime.Now.ToString("dd/M/yyyy HH:mm:ss");
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            Herramientas herramientas = new Herramientas(usuarioSesion, parentForm);
            SeguidorPila.AbrirSiguiente(this, herramientas);
        }

        private void btnIngresarProductoExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog DatosDialogo = new OpenFileDialog();
            {
                DatosDialogo.Filter = "Archivos Excel (*.xlsx;*.xls)| *.xlsx;*.xls";
                DatosDialogo.Title = "Por favor seleccione un archivo Excel";
            }

            if (DatosDialogo.ShowDialog() == DialogResult.OK)
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error al importar el archivo Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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
                        panel1.BackColor = SystemColors.HotTrack;
                        panel2.BackColor = SystemColors.HotTrack;
                        panel3.BackColor = SystemColors.HotTrack;
                        //Paneles atras
                        btnInicio.BackColor = SystemColors.MenuHighlight;
                        btnHerramientas.BackColor = SystemColors.MenuHighlight;
                        btnVentas.BackColor = SystemColors.MenuHighlight;
                        btnCerrarSesion.BackColor = SystemColors.MenuHighlight;
                        BtnBuscar.BackColor = SystemColors.MenuHighlight;
                        btnPanaderia.BackColor = SystemColors.MenuHighlight;
                        btnBebidas.BackColor = SystemColors.MenuHighlight;
                        btnMeneitos.BackColor = SystemColors.MenuHighlight;
                        btnComidasCongelada.BackColor = SystemColors.MenuHighlight;
                        btnProductosLimpieza.BackColor = SystemColors.MenuHighlight;
                        btnHigienePersonal.BackColor = SystemColors.MenuHighlight;
                        btnTodoLosProductos.BackColor = SystemColors.MenuHighlight;
                        btnAñadirNuevo.BackColor = SystemColors.MenuHighlight;
                        btnEditarProductos.BackColor = SystemColors.MenuHighlight;
                        btnIngresarProductoExcel.BackColor = SystemColors.MenuHighlight;
                        //botones atras
                        label11.ForeColor = SystemColors.HotTrack;
                        label3.ForeColor = SystemColors.HotTrack;
                        //letras atras
                        dvgProductosExistencia.BackgroundColor = Color.LightSkyBlue;
                        //tablas atras
                    }
                    else if (valorLugar == 2)
                    {
                        panel1.BackColor = Color.BlueViolet;
                        panel2.BackColor = Color.BlueViolet;
                        panel3.BackColor = Color.BlueViolet;
                        //Paneles atras
                        btnInicio.BackColor = Color.MediumPurple;
                        btnHerramientas.BackColor = Color.MediumPurple;
                        btnVentas.BackColor = Color.MediumPurple;
                        btnCerrarSesion.BackColor = Color.MediumPurple;
                        BtnBuscar.BackColor = Color.MediumPurple;
                        btnPanaderia.BackColor = Color.MediumPurple;
                        btnBebidas.BackColor = Color.MediumPurple;
                        btnMeneitos.BackColor = Color.MediumPurple;
                        btnComidasCongelada.BackColor = Color.MediumPurple;
                        btnProductosLimpieza.BackColor = Color.MediumPurple;
                        btnHigienePersonal.BackColor = Color.MediumPurple;
                        btnTodoLosProductos.BackColor = Color.MediumPurple;
                        btnAñadirNuevo.BackColor = Color.MediumPurple;
                        btnEditarProductos.BackColor = Color.MediumPurple;
                        btnIngresarProductoExcel.BackColor = Color.MediumPurple;
                        //botones atras
                        label11.ForeColor = Color.BlueViolet;
                        label3.ForeColor = Color.BlueViolet;
                        //letras atras
                        dvgProductosExistencia.BackgroundColor = Color.DarkOrchid;
                        //tablas atras
                    }
                    else if (valorLugar == 3)
                    {
                        panel1.BackColor = Color.Teal;
                        panel2.BackColor = Color.Teal;
                        panel3.BackColor = Color.Teal;
                        //Paneles atras
                        btnInicio.BackColor = Color.CadetBlue;
                        btnHerramientas.BackColor = Color.CadetBlue;
                        btnVentas.BackColor = Color.CadetBlue;
                        btnCerrarSesion.BackColor = Color.CadetBlue;
                        BtnBuscar.BackColor = Color.CadetBlue;
                        btnPanaderia.BackColor = Color.CadetBlue;
                        btnBebidas.BackColor = Color.CadetBlue;
                        btnMeneitos.BackColor = Color.CadetBlue;
                        btnComidasCongelada.BackColor = Color.CadetBlue;
                        btnProductosLimpieza.BackColor = Color.CadetBlue;
                        btnHigienePersonal.BackColor = Color.CadetBlue;
                        btnTodoLosProductos.BackColor = Color.CadetBlue;
                        btnAñadirNuevo.BackColor = Color.CadetBlue;
                        btnEditarProductos.BackColor = Color.CadetBlue;
                        btnIngresarProductoExcel.BackColor = Color.CadetBlue;
                        //botones atras
                        label11.ForeColor = Color.Teal;
                        label3.ForeColor = Color.Teal;
                        //letras atras
                        dvgProductosExistencia.BackgroundColor = Color.PowderBlue;
                        //tablas atras
                    }
                    else if (valorLugar == 4)
                    {
                        panel1.BackColor = Color.Black;
                        panel2.BackColor = Color.Black;
                        panel3.BackColor = Color.Black;
                        //Paneles atras
                        btnInicio.BackColor = Color.DimGray;
                        btnHerramientas.BackColor = Color.DimGray;
                        btnVentas.BackColor = Color.DimGray;
                        btnCerrarSesion.BackColor = Color.DimGray;
                        BtnBuscar.BackColor = Color.DimGray;
                        btnPanaderia.BackColor = Color.DimGray;
                        btnBebidas.BackColor = Color.DimGray;
                        btnMeneitos.BackColor = Color.DimGray;
                        btnComidasCongelada.BackColor = Color.DimGray;
                        btnProductosLimpieza.BackColor = Color.DimGray;
                        btnHigienePersonal.BackColor = Color.DimGray;
                        btnTodoLosProductos.BackColor = Color.DimGray;
                        btnAñadirNuevo.BackColor = Color.DimGray;
                        btnEditarProductos.BackColor = Color.DimGray;
                        btnIngresarProductoExcel.BackColor = Color.DimGray;
                        //botones atras
                        label11.ForeColor = Color.Black;
                        label3.ForeColor = Color.Black;
                        //letras atras
                        dvgProductosExistencia.BackgroundColor = Color.DarkGray;
                        //tablas atras
                    }
                }

            }

        }

        private void btnEditarProductos_Click(object sender, EventArgs e)
        {
            EditarProducto editarProducto = new EditarProducto(parentForm, usuarioSesion);
            SeguidorPila.AbrirSiguiente(this, editarProducto);

        }
    }
}
