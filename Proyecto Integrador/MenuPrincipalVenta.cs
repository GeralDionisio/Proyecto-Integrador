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
    public partial class MenuPrincipalVenta : Form
    {
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
        private Usuario usuarioSesion;
        private Form parentForm;

        private System.Windows.Forms.Timer timerBucleCincoSegundos = new System.Windows.Forms.Timer();
        private int contadorSegundosBucle = 0;

        private bool Intendo_1 = false;


        public MenuPrincipalVenta(Usuario usuario, Form parent)
        {
            timerBucleCincoSegundos.Stop();
            ContadoradorTabla();

            usuarioSesion = usuario;
            parentForm = parent;
            InitializeComponent();

            System.Windows.Forms.Timer miReloj = new System.Windows.Forms.Timer();
            miReloj.Interval = 1000; // 1 segundo
            miReloj.Tick += MiReloj_Tick; // Apunta al método de abajo, NO al Label
            miReloj.Start();

        }
        private void ContadoradorTabla()
        {
            timerBucleCincoSegundos.Interval = 1000; // Cuenta cada 1 segundo
            timerBucleCincoSegundos.Tick += TimerBucleCincoSegundos_Tick;
            timerBucleCincoSegundos.Start(); // Comienza el bucle al iniciar la ventana

        }
        private void TimerBucleCincoSegundos_Tick(object sender, EventArgs e)
        {
            contadorSegundosBucle++;

            // Al llegar a 5 segundos, ejecuta la tarea y reinicia el contador
            if (contadorSegundosBucle >= 5)
            {
                EjecutarProcesoEnBucle();

                contadorSegundosBucle = 0; // Se reinicia a 0 para volver a empezar
            }
        }
        private void EjecutarProcesoEnBucle()
        {
            // AQUÍ COLOCAS LA LÓGICA QUE QUIERES QUE REPITA CADA 5 SEGUNDOS.
            // Por ejemplo: actualizar automáticamente la lista de ventas en segundo plano, 
            // verificar estado de conexiones, etc.
            SqlConnection sqlconexion = ConexionDB.ObtenerConexion();

            SqlDataAdapter sqladaptador = new SqlDataAdapter("ver_Ventas_Realizadas", sqlconexion);

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgVentasRegistradas.DataSource = tabladatos;
        }



        private void MenuPrincipalVenta_Load(object sender, EventArgs e)
        {
            CargarVentas();


            SqlConnection Sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter adaptadorSql = new SqlDataAdapter("ver_Ventas_Realizadas", Sqlconexion);

            DataTable tablaDato = new DataTable();
            adaptadorSql.Fill(tablaDato);

            lblTotalVentas.Text = "Total de Ventas Registradas: " + tablaDato.Rows.Count;

            ColoresDiseño();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuprincipal = new MenuPrincipal(usuarioSesion, this);
            menuprincipal.Show();
            this.Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario(usuarioSesion, this);
            inventario.Show();
            this.Close();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion inicosesion = new InicioSesion();
            inicosesion.Show();
            this.Close();


        }

        private void btnRegistrarNuevaVenta_Click(object sender, EventArgs e)
        {


        }
        private void CargarVentas()
        {
            SqlConnection Sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter adaptadorSql = new SqlDataAdapter("ver_Ventas_Realizadas", Sqlconexion);

            DataTable tablaDato = new DataTable();
            adaptadorSql.Fill(tablaDato);

            dvgVentasRegistradas.DataSource = tablaDato;

        }

        private void dvgVentasRegistradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            {
                int idSalida = Convert.ToInt32(dvgVentasRegistradas.Rows[e.RowIndex].Cells["IdSalida"].Value);

                MessageBox.Show("Venta Seleccionada: " + idSalida);

                CargarDetalleVenta(idSalida);
            }



        }
        private void CargarDetalleVenta(int idVenta)
        {
            SqlConnection SqlConexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter sqlAdaptador = new SqlDataAdapter("Ver_Detalle_Producto", SqlConexion);
            sqlAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlAdaptador.SelectCommand.Parameters.AddWithValue("@idSalida", idVenta);

            DataTable tablaDato = new DataTable();
            sqlAdaptador.Fill(tablaDato);

            dvgProductos.DataSource = tablaDato;
        }



        private void dvgVentasRegistradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotalSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
        }

        private void MiReloj_Tick(object sender, EventArgs e)
        {

        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            Herramientas herramientas = new Herramientas(usuarioSesion, parentForm);
            SeguidorPila.AbrirSiguiente(this, herramientas);

        }
        public void CargarVentasEnPantalla()
        {
            try
            {
                DataTable Tabladatos = new DataTable();

                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("Cargar_Ventas_Pantalla", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter AdaptadorSQL = new SqlDataAdapter(cmd);
                        AdaptadorSQL.Fill(Tabladatos);
                    }
                }
                dvgVentasRegistradas.DataSource = Tabladatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recargar las ventas" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("Colores_Diseño", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);
                MenuPrincipalVenta menu = (this);

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        menu.BackColor = SystemColors.MenuHighlight;
                        //Paneles atras

                        BtnBuscarSalida.BackColor = SystemColors.MenuHighlight;
                        btnRegresar.BackColor = SystemColors.MenuHighlight;
                        //botones atras
                        label3.ForeColor = SystemColors.HotTrack;
                        label9.ForeColor = SystemColors.HotTrack;
                        label22.ForeColor = SystemColors.HotTrack;
                        label4.ForeColor = SystemColors.HotTrack;
                        lblTotalVentas.ForeColor = SystemColors.HotTrack;
                        //letras atras
                        dvgProductos.BackgroundColor = Color.LightSkyBlue;
                        dvgVentasRegistradas.BackgroundColor = Color.LightSkyBlue;
                        //tablas atras
                    }
                    else if (valorLugar == 2)
                    {
                        menu.BackColor = Color.MediumPurple;

                        BtnBuscarSalida.BackColor = Color.MediumPurple;
                        btnRegresar.BackColor = Color.MediumPurple;
                        //botones atras
                        label3.ForeColor = Color.BlueViolet;
                        label9.ForeColor = Color.BlueViolet;
                        label22.ForeColor = Color.BlueViolet;
                        label4.ForeColor = Color.BlueViolet;
                        lblTotalVentas.ForeColor = Color.BlueViolet;
                        //letras atras
                        dvgProductos.BackgroundColor = Color.DarkOrchid;
                        dvgVentasRegistradas.BackgroundColor = Color.DarkOrchid;
                        //tablas atras
                    }
                    else if (valorLugar == 3)
                    {
                        menu.BackColor = Color.Teal;
                        //Paneles atras

                        BtnBuscarSalida.BackColor = Color.CadetBlue;
                        btnRegresar.BackColor = Color.CadetBlue;
                        //botones atras
                        label3.ForeColor = Color.Teal;
                        label9.ForeColor = Color.Teal;
                        label22.ForeColor = Color.Teal;
                        label4.ForeColor = Color.Teal;
                        lblTotalVentas.ForeColor = Color.Teal;
                        //letras atras
                        dvgProductos.BackgroundColor = Color.PowderBlue;
                        dvgVentasRegistradas.BackgroundColor = Color.PowderBlue;
                        //tablas atras
                    }
                    else if (valorLugar == 4)
                    {
                        menu.BackColor = Color.Black;

                        BtnBuscarSalida.BackColor = Color.DimGray;
                        btnRegresar.BackColor = Color.DimGray;
                        //botones atras
                        label3.ForeColor = Color.Black;
                        label9.ForeColor = Color.Black;
                        label22.ForeColor = Color.Black;
                        label4.ForeColor = Color.Black;
                        lblTotalVentas.ForeColor = Color.Black;
                        //letras atras
                        dvgProductos.BackgroundColor = Color.DarkGray;
                        dvgVentasRegistradas.BackgroundColor = Color.DarkGray;
                        //tablas atras
                    }
                }
            }

        }

        private void BtnBuscarSalida_Click(object sender, EventArgs e)
        {
            try
            {
                Intendo_1 = !Intendo_1;
                if (Intendo_1)
                {
                    SqlConnection  conexion = ConexionDB.ObtenerConexion();
                    SqlDataAdapter adaptador = new SqlDataAdapter($"SELECT IdSalida, Fecha, TotalVenta FROM Salida WHERE IdSalida LIKE '{txtBuscarSalida.Text}%'", conexion);

                    DataTable DATOS = new DataTable();
                    adaptador.Fill(DATOS);

                    dvgVentasRegistradas.DataSource = DATOS;
                    timerBucleCincoSegundos.Stop(); // Detener el bucle mientras se realiza la búsqueda
                    txtBuscarSalida.Clear();
                }
                else if (txtBuscarSalida.Text == "")
                {
                    CargarVentas();
                    SqlConnection sqlconexion = ConexionDB.ObtenerConexion();

                    SqlDataAdapter sqladaptador = new SqlDataAdapter("select IdSalida, Fecha, TotalVenta from Salida", sqlconexion);

                    DataTable tabladatos = new DataTable();
                    sqladaptador.Fill(tabladatos);
                    timerBucleCincoSegundos.Start(); // Reiniciar el bucle después de actualizar
                }

                SqlConnection sqlConexion = new SqlConnection(CadenaConexion);
                SqlDataAdapter AdaptadorSql = new SqlDataAdapter("BOTON_Buscar_Venta", sqlConexion);
                AdaptadorSql.SelectCommand.CommandType = CommandType.StoredProcedure;
                AdaptadorSql.SelectCommand.Parameters.AddWithValue("@IdSalida", txtBuscarSalida.Text.Trim());

                DataTable TablaDato = new DataTable();
                AdaptadorSql.Fill(TablaDato);

                dvgVentasRegistradas.DataSource = TablaDato;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro al buscar la venta" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            SeguidorPila.Regresar(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
