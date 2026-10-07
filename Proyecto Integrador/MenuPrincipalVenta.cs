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


        public MenuPrincipalVenta(Usuario usuario, Form parent)
        {
            ContadoradorTabla();

            usuarioSesion = usuario;
            parentForm = parent;
            InitializeComponent();
            lblUsuario.Text = usuario?.NombreCompleto ?? String.Empty;
            lblRol.Text = usuario?.Rol ?? String.Empty;

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
            SqlConnection sqlconexion =  ConexionDB.ObtenerConexion();

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
            Venta venta = new Venta(usuarioSesion, this);
            venta.Show();

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
            SqlConnection sqlConexion = new SqlConnection(CadenaConexion);
            SqlDataAdapter AdaptadorSql = new SqlDataAdapter("BOTON_Buscar_Venta", sqlConexion);
            AdaptadorSql.SelectCommand.CommandType = CommandType.StoredProcedure;
            AdaptadorSql.SelectCommand.Parameters.AddWithValue("@IdSalida", txtBuscarId.Text.Trim());

            DataTable TablaDato = new DataTable();
            AdaptadorSql.Fill(TablaDato);

            dvgVentasRegistradas.DataSource = TablaDato;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
        }

        private void MiReloj_Tick(object sender, EventArgs e)
        {
            lblFecha1.Text = "" + DateTime.Now.ToString("dd/M/yyyy HH:mm:ss");
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

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        panel1.BackColor = SystemColors.HotTrack;
                        panel2.BackColor = SystemColors.HotTrack;
                        panel6.BackColor = SystemColors.HotTrack;
                        //Paneles atras
                        btnInventario.BackColor = SystemColors.MenuHighlight;
                        btnHerramientas.BackColor = SystemColors.MenuHighlight;
                        btnInicio.BackColor = SystemColors.MenuHighlight;
                        btnCerrarSesion.BackColor = SystemColors.MenuHighlight;
                        btnBuscar.BackColor = SystemColors.MenuHighlight;
                        btnRegistrarNuevaVenta.BackColor = SystemColors.MenuHighlight;
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
                        panel1.BackColor = Color.BlueViolet;
                        panel2.BackColor = Color.BlueViolet;
                        panel6.BackColor = Color.BlueViolet;
                        //Paneles atras
                        btnInventario.BackColor = Color.MediumPurple;
                        btnHerramientas.BackColor = Color.MediumPurple;
                        btnInicio.BackColor = Color.MediumPurple;
                        btnCerrarSesion.BackColor = Color.MediumPurple;
                        btnBuscar.BackColor = Color.MediumPurple;
                        btnRegistrarNuevaVenta.BackColor = Color.MediumPurple;
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
                        panel1.BackColor = Color.Teal;
                        panel2.BackColor = Color.Teal;
                        panel6.BackColor = Color.Teal;
                        //Paneles atras
                        btnInventario.BackColor = Color.CadetBlue;
                        btnHerramientas.BackColor = Color.CadetBlue;
                        btnInicio.BackColor = Color.CadetBlue;
                        btnCerrarSesion.BackColor = Color.CadetBlue;
                        btnBuscar.BackColor = Color.CadetBlue;
                        btnRegistrarNuevaVenta.BackColor = Color.CadetBlue;
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
                        panel1.BackColor = Color.Black;
                        panel2.BackColor = Color.Black;
                        panel6.BackColor = Color.Black;
                        //Paneles atras
                        btnInventario.BackColor = Color.DimGray;
                        btnHerramientas.BackColor = Color.DimGray;
                        btnInicio.BackColor = Color.DimGray;
                        btnCerrarSesion.BackColor = Color.DimGray;
                        btnBuscar.BackColor = Color.DimGray;
                        btnRegistrarNuevaVenta.BackColor = Color.DimGray;
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
    }
}
