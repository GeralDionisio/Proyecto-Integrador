using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proyecto_Integrador
{
    public partial class Venta : Form
    {
        private Usuario usuarioSesion;
        private Form formularioCreador;
        private string cadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
        List<Producto> ListaDeSeleccionados = new List<Producto>();
        private System.Windows.Forms.Timer timerBucleCincoSegundos = new System.Windows.Forms.Timer();
        private int contadorSegundosBucle = 0;

        private bool INTENDO_1 = false;
        public Venta(Usuario usuario, Form parent)
        {
            this.usuarioSesion = usuario;
            this.formularioCreador = parent;
            InitializeComponent();
            lblUsuario.Text = usuario?.NombreCompleto ?? String.Empty;
            lblRol.Text = usuario?.Rol ?? String.Empty;
            System.Windows.Forms.Timer miReloj = new System.Windows.Forms.Timer();
            miReloj.Interval = 1000; // 1 segundo
            miReloj.Tick += MiReloj_Tick; // Apunta al método de abajo, NO al Label
            miReloj.Start();
            timerBucleCincoSegundos.Stop();
            ContadoradorTabla();
           


        }
        private void MiReloj_Tick(object sender, EventArgs e)
        {
            lblFecha1.Text = "" + DateTime.Now.ToString("dd/M/yyyy HH:mm:ss");
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
            if (contadorSegundosBucle >= 50)
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

            SqlDataAdapter sqladaptador = new SqlDataAdapter("CARGAR_Productos_Disponibles", sqlconexion);
            sqladaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgProductosDisponible.DataSource = tabladatos;
        }
        private void CargarProductos()
        {
            try
            {
                using SqlConnection sqlConexion = new SqlConnection(cadenaConexion);
                {
                    // Cargamos TODOS los productos al iniciar la ventana

                    using (SqlDataAdapter da = new SqlDataAdapter("CARGAR_Productos_Disponibles", sqlConexion))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dvgProductosDisponible.DataSource = dt;
                        dvgDetalleVenta.Columns["IdProducto"].Visible = false;

                        ColoresDiseño();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar productos disponibles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void Venta_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvgProductosDisponible_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        public class Producto
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public int Cantidad { get; set; }
        }
        double N1;
        public List<Producto> AgregarProductoPorNombre(string nombreProductoBuscado, int cantidadIngresada)
        {

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand("Agregar_producto_Por_Nombre", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Nombre", nombreProductoBuscado);

                    try
                    {
                        conexion.Open();
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                Producto prod = new Producto();
                                prod.Nombre = lector["Nombre"].ToString();
                                N1 = Convert.ToDouble(lector["PrecioActual"]);
                                prod.Precio = N1;
                                prod.Cantidad = cantidadIngresada;

                                ListaDeSeleccionados.Add(prod);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar el producto: " + ex.Message);
                    }
                }
            }
            return ListaDeSeleccionados;
        }
        private double CalcularSubtotalGeneral()
        {
            double sumaTotal = 0;

            // Recorremos la lista producto por producto
            foreach (Producto producto in ListaDeSeleccionados)
            {
                // Multiplicamos el precio de ese producto por su cantidad
                double subtotalProducto = producto.Precio * producto.Cantidad;

                // Lo acumulamos en nuestra variable sumadora
                sumaTotal = sumaTotal + subtotalProducto;
            }

            // Devolvemos el resultado final de la suma
            return sumaTotal;
        }
        private double CalcularSubtotalGeneral2()
        {
            double sumaTotal = 0;

            // Recorremos la lista producto por producto
            foreach (Producto producto in ListaDeSeleccionados)
            {
                // Multiplicamos el precio de ese producto por su cantidad
                double subtotalProducto = producto.Precio * producto.Cantidad;
                double iva = subtotalProducto * 0.15;
                double totalConIva = subtotalProducto + iva;
                // Lo acumulamos en nuestra variable sumadora
                sumaTotal = sumaTotal + totalConIva;
            }

            // Devolvemos el resultado final de la suma
            return sumaTotal;
        }
        private double CalcularSubtotalGeneral3(double subtotal, double paga)
        {
            double Total = 0;

            // Recorremos la lista producto por producto

            Total = paga - subtotal;

            // Devolvemos el resultado final de la suma
            return Total;
        }

        private void dvgProductosDisponible_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgarrarCantidad_Click(object sender, EventArgs e)
        {
            if (dvgProductosDisponible.CurrentRow != null && dvgProductosDisponible.CurrentRow.Index >= 0)
            {
                // 2. VALIDACIÓN SEGURA DEL TEXTBOX DE CANTIDAD
                int cantidad;
                bool esNumeroValido = int.TryParse(txtCantidad.Text, out cantidad);

                if (!esNumeroValido || cantidad <= 0)
                {
                    MessageBox.Show("Por favor, ingresa una cantidad numérica válida mayor a 0 antes de añadir al carrito.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int stockDisponible = Convert.ToInt32(dvgProductosDisponible.CurrentRow.Cells["stock"].Value);

                if (cantidad > stockDisponible)
                {
                    MessageBox.Show($"La cantidad ingresada ({cantidad}) excede el stock disponible ({stockDisponible}).", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Extraemos el nombre del producto de la fila actualmente seleccionada
                string nombreSeleccionado = dvgProductosDisponible.CurrentRow.Cells["Producto"].Value.ToString();

                // 4. Invocamos tu método pasándole el nombre y la cantidad
                // (Asegúrate de que este método devuelva una List<Productos> con la propiedad Cantidad ya asignada al objeto)
                List<Venta.Producto> listaActualizada = AgregarProductoPorNombre(nombreSeleccionado, cantidad);

                // 5. Refrescamos tu DataGridView de destino (el detalle o carrito de ventas)
                dvgDetalleVenta.DataSource = null;
                dvgDetalleVenta.DataSource = listaActualizada;

                // Vamos a calcular el subtotal cada vez que se añada un producto al carrito
                double resultadoSuma = CalcularSubtotalGeneral();
                lblSubtotal.Text = resultadoSuma.ToString("N2");

                // Vamos a calcular el IVA / Total cada vez que se añada un producto al carrito
                double resultadoSuma2 = CalcularSubtotalGeneral2();
                lblTotalaPagar.Text = resultadoSuma2.ToString("N2");

                // Opcional: Limpia el campo de texto para el siguiente producto
                txtCantidad.Clear();
                txtCantidad.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona primero un producto de la tabla de disponibles.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            double total = CalcularSubtotalGeneral3(double.Parse(lblTotalaPagar.Text), double.Parse(txtRecibido.Text));
            int filasValidas = dvgDetalleVenta.Rows.Count;
            lblCambio.Text = $"C$ {total:N2}";

            if (dvgDetalleVenta.AllowUserToAddRows && filasValidas > 0)
            {
                filasValidas--;
            }

            if (filasValidas <= 0)
            {
                MessageBox.Show("Por favor añada al menos un producto");
                return;
            }

            // 1. Validaciones previas básicas antes de tocar la Base de Datos
            if (dvgDetalleVenta.Rows.Count == 0 || (dvgDetalleVenta.Rows.Count == 1 && dvgDetalleVenta.Rows[0].IsNewRow))
            {
                MessageBox.Show("Debe agregar al menos un producto a la venta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtRecibido.Text))
            {
                MessageBox.Show("Por favor, ingrese la cantidad con la que paga el cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.Parse(txtRecibido.Text) < double.Parse(lblTotalaPagar.Text))
            {
                MessageBox.Show("El dinero recibido no es suficiente para procesar la venta.", "Venta Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(txtRecibido.Text))
            {
                MessageBox.Show("Por favor introduzca el dinero que se recibio de parte del cliente");
                return;

            }


            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                try
                {
                    con.Open();
                    using (SqlTransaction transaccion = con.BeginTransaction())
                    {
                        int idSalidaGenerado = 0;
                        

                        try
                        {
                            // --- PASO 1: REGISTRAR EN LA TABLA MAESTRA (SALIDA) ---
                            using (SqlCommand cmdSalida = new SqlCommand("INSERTAR_Producto_Salida", con, transaccion))
                            {
                                cmdSalida.CommandType = CommandType.StoredProcedure;
                                cmdSalida.Parameters.AddWithValue("@Fecha", DateTime.Now);

                                // Reemplaza por el nombre de tu Label o Variable donde calculás el total (ej. lblTotalAPagar o lblSubtotal)
                                cmdSalida.Parameters.AddWithValue("@TotalVenta", Convert.ToDecimal(lblTotalaPagar.Text));


                                // Id del usuario que inició sesión
                                cmdSalida.Parameters.AddWithValue("@IdUsuario", 1);

                                idSalidaGenerado = Convert.ToInt32(cmdSalida.ExecuteScalar());
                            }

                            // --- PASO 2: REGISTRAR EL DETALLE (DETALLESALIDA) ---
                            if (dvgDetalleVenta.DataSource != null)
                            {
                                foreach (DataGridViewRow fila in dvgDetalleVenta.Rows)
                                {
                                    if (fila.IsNewRow) continue;

                                    using (SqlCommand cmdDetalle = new SqlCommand("INSERTAR_Producto_Detalle", con, transaccion))
                                    {
                                        cmdDetalle.CommandType = CommandType.StoredProcedure;
                                        cmdDetalle.Parameters.Clear();

                                        // 1. Relación con la Salida principal

                                        cmdDetalle.Parameters.AddWithValue("@IdSalida", idSalidaGenerado);

                                        // 2. Cantidad y Precio leídos del carrito actual (derecha)
                                        int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                                        decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
                                        decimal subtotalCalculado = precio * cantidad;

                                        cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad);
                                        cmdDetalle.Parameters.AddWithValue("@Subtotal", subtotalCalculado);

                                        // 3. BUSCADOR ROBUSTO DE ID POR ÍNDICE DE INTERFAZ
                                        // Extraemos el nombre del producto de la fila que se está procesando en este giro del carrito
                                        // (Revisa si tu columna del DataGridView derecho se llama "Nombre" o "Producto")
                                        string nombreProductoCarrito = fila.Cells["Nombre"].Value?.ToString().Trim().ToLower()
                                                                     ?? fila.Cells["Producto"].Value?.ToString().Trim().ToLower() ?? "";

                                        string idReal = "0";

                                        // Recorremos la tabla izquierda buscando el ID que le pertenece a ese nombre específico
                                        foreach (DataGridViewRow filaDisp in dvgProductosDisponible.Rows)
                                        {
                                            if (filaDisp.Cells["Producto"].Value != null)
                                            {
                                                string nombreDisponible = filaDisp.Cells["Producto"].Value.ToString().Trim().ToLower();

                                                if (nombreDisponible == nombreProductoCarrito)
                                                {
                                                    idReal = filaDisp.Cells["IdProductos"].Value.ToString();
                                                    break; // Encontrado, salimos del buscador de esta fila
                                                }
                                            }
                                        }

                                        // Control de daños: Si los nombres no se emparejaron, usamos el ID de la primera celda
                                        if (idReal == "0" && fila.Cells[0].Value != null)
                                        {
                                            idReal = fila.Cells[0].Value.ToString();
                                        }

                                        cmdDetalle.Parameters.AddWithValue("@IdProducto", idReal);

                                        cmdDetalle.ExecuteNonQuery();
                                    }
                                }
                            }

                            // Si todo se guardó bien en ambas tablas, consolidamos la operación
                            transaccion.Commit();
                            MessageBox.Show("¡Venta finalizada y guardada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 3. Avisar al menú principal que la operación fue exitosa para que se refresque
                            this.DialogResult = DialogResult.OK;
                            
                        }
                        catch (Exception ex)
                        {
                            // Si ocurre un error aquí, se cancela todo en SQL y no se guarda nada a medias
                            transaccion.Rollback();
                            MessageBox.Show("Error al procesar los productos: " + ex.Message, "Error de Transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión con el servidor: " + ex.Message, "Error de Red", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            try
            {
                // Usamos 'using' para asegurar que la conexión se cierre y destruya correctamente
                using (SqlConnection sqlConexion = new SqlConnection(cadenaConexion))
                {
                    sqlConexion.Open(); // ¡IMPORTANTE! Abrir la conexión

                    // Recorremos CADA producto que está en el carrito de compras
                    foreach (Producto prod in ListaDeSeleccionados)
                    {
                        using (SqlCommand cmd = new SqlCommand("ACTUALIZAR_Stock_Actual_Venta_Finalizada", sqlConexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            // Pasamos los parámetros específicos de este producto
                            cmd.Parameters.AddWithValue("@Cantidad", prod.Cantidad);
                            cmd.Parameters.AddWithValue("@Nombre", prod.Nombre);

                            // Ejecutamos la consulta en la base de datos
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Venta finalizada con éxito y stock actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. LIMPIEZA POST-VENTA (Opcional pero recomendado)
                ListaDeSeleccionados.Clear();
                dvgDetalleVenta.DataSource = null;
                lblSubtotal.Text = "0.00";
                lblTotalaPagar.Text = "0.00";
                txtRecibido.Clear();
                lblCambio.Text = "0.00";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico al actualizar el inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("Colores_Diseño", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);
                Venta venta = this; // Referencia a la instancia actual de Venta

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        //Paneles atras
                        btnFinalizarVenta.BackColor = SystemColors.MenuHighlight;
                        btnEliminarProducto.BackColor = SystemColors.MenuHighlight;
                        btnRecargar.BackColor = SystemColors.MenuHighlight;
                        BtnAgarrarCantidad.BackColor = SystemColors.MenuHighlight;
                        BtnBuscar.BackColor = SystemColors.MenuHighlight;
                        btnInicio.BackColor = SystemColors.MenuHighlight;
                        btnInventario.BackColor = SystemColors.MenuHighlight;
                        btnHerramientas.BackColor = SystemColors.MenuHighlight;
                        //botones atras
                        panel3.BackColor = SystemColors.MenuHighlight;
                        panel2.BackColor = SystemColors.MenuHighlight;
                        panel6.BackColor = SystemColors.MenuHighlight;
                        lblCambio.ForeColor = SystemColors.HotTrack;
                        label1.ForeColor = SystemColors.HotTrack;
                        label12.ForeColor = SystemColors.HotTrack;
                        label5.ForeColor = SystemColors.HotTrack;
                        label8.ForeColor = SystemColors.HotTrack;
                        label14.ForeColor = SystemColors.HotTrack;
                        label2.ForeColor = SystemColors.HotTrack;
                        label3.ForeColor = SystemColors.HotTrack;
                        label7.ForeColor = SystemColors.HotTrack;
                        label10.ForeColor = SystemColors.HotTrack;
                        label11.ForeColor = SystemColors.HotTrack;
                        lblTotalaPagar.ForeColor = SystemColors.HotTrack;
                        lblSubtotal.ForeColor = SystemColors.HotTrack;
                        //letras atras
                        dvgDetalleVenta.BackgroundColor = Color.LightSkyBlue;
                        dvgProductosDisponible.BackgroundColor = Color.LightSkyBlue;
                        //tablas atras
                    }
                    else if (valorLugar == 2)
                    {

                        //Paneles atras
                        btnFinalizarVenta.BackColor = Color.MediumPurple;
                        btnEliminarProducto.BackColor = Color.MediumPurple;
                        btnRecargar.BackColor = Color.MediumPurple;
                        BtnAgarrarCantidad.BackColor = Color.MediumPurple;
                        BtnBuscar.BackColor = Color.MediumPurple;
                        btnInicio.BackColor = Color.MediumPurple;
                        btnInventario.BackColor = Color.MediumPurple;
                        btnHerramientas.BackColor = Color.MediumPurple;
                        btnCerrarSesion.BackColor = Color.MediumPurple;
                        //botones atras
                        lblCambio.ForeColor = Color.BlueViolet;
                        panel3.BackColor = Color.BlueViolet;
                        panel2.BackColor = Color.BlueViolet;
                        panel6.BackColor = Color.BlueViolet;

                        label5.ForeColor = Color.BlueViolet;
                        label1.ForeColor = Color.BlueViolet;
                        label12.ForeColor = Color.BlueViolet;
                        label8.ForeColor = Color.BlueViolet;
                        label14.ForeColor = Color.BlueViolet;
                        label2.ForeColor = Color.BlueViolet;
                        label3.ForeColor = Color.BlueViolet;
                        label7.ForeColor = Color.BlueViolet;
                        label10.ForeColor = Color.BlueViolet;
                        label11.ForeColor = Color.BlueViolet;
                        lblSubtotal.ForeColor = Color.BlueViolet;
                        lblTotalaPagar.ForeColor = Color.BlueViolet;
                        //letras atras
                        dvgDetalleVenta.BackgroundColor = Color.DarkOrchid;
                        dvgProductosDisponible.BackgroundColor = Color.DarkOrchid;
                        //tablas atras
                    }
                    else if (valorLugar == 3)
                    {

                        //Paneles atras
                        btnFinalizarVenta.BackColor = Color.CadetBlue;
                        btnEliminarProducto.BackColor = Color.CadetBlue;
                        btnRecargar.BackColor = Color.CadetBlue;
                        BtnAgarrarCantidad.BackColor = Color.CadetBlue;
                        BtnBuscar.BackColor = Color.CadetBlue;
                        btnInicio.BackColor = Color.CadetBlue;
                        btnInventario.BackColor = Color.CadetBlue;
                        btnHerramientas.BackColor = Color.CadetBlue;
                        btnCerrarSesion.BackColor = Color.CadetBlue;
                        //botones atras
                        panel3.BackColor = Color.Teal;
                        panel2.BackColor = Color.Teal;
                        panel6.BackColor = Color.Teal;
                        lblCambio.ForeColor = Color.Teal;
                        label5.ForeColor = Color.Teal;
                        label8.ForeColor = Color.Teal;
                        label1.ForeColor = Color.Teal;
                        label12.ForeColor = Color.Teal;
                        label14.ForeColor = Color.Teal;
                        label2.ForeColor = Color.Teal;
                        label3.ForeColor = Color.Teal;
                        label7.ForeColor = Color.Teal;
                        label10.ForeColor = Color.Teal;
                        label11.ForeColor = Color.Teal;
                        lblSubtotal.ForeColor = Color.Teal;
                        lblTotalaPagar.ForeColor = Color.Teal;
                        //letras atras
                        dvgDetalleVenta.BackgroundColor = Color.PowderBlue;
                        dvgProductosDisponible.BackgroundColor = Color.PowderBlue;
                        //tablas atras
                    }
                    else if (valorLugar == 4)
                    {

                        //Paneles atras
                        btnFinalizarVenta.BackColor = Color.DimGray;
                        btnEliminarProducto.BackColor = Color.DimGray;
                        btnRecargar.BackColor = Color.DimGray;
                        BtnAgarrarCantidad.BackColor = Color.DimGray;
                        BtnBuscar.BackColor = Color.DimGray;
                        btnInicio.BackColor = Color.DimGray;
                        btnInventario.BackColor = Color.DimGray;
                        btnHerramientas.BackColor = Color.DimGray;
                        btnCerrarSesion.BackColor = Color.DimGray;
                        //botones atras
                        panel3.BackColor = Color.Black;
                        panel2.BackColor = Color.Black;
                        panel6.BackColor = Color.Black;
                        lblCambio.ForeColor = Color.Black;
                        label1.ForeColor = Color.Black;
                        label12.ForeColor = Color.Black;
                        label5.ForeColor = Color.Black;
                        label8.ForeColor = Color.Black;
                        label14.ForeColor = Color.Black;
                        label2.ForeColor = Color.Black;
                        label3.ForeColor = Color.Black;
                        label7.ForeColor = Color.Black;
                        label10.ForeColor = Color.Black;
                        label11.ForeColor = Color.Black;
                        lblSubtotal.ForeColor = Color.Black;
                        lblTotalaPagar.ForeColor = Color.Black;
                        //letras atras
                        dvgDetalleVenta.BackgroundColor = Color.DarkGray;
                        dvgProductosDisponible.BackgroundColor = Color.DarkGray;
                        //tablas atras
                    }
                }

            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Pasamos a minúsculas y quitamos espacios al inicio/final
            string filtro = txtBuscar.Text.Trim().ToLower();

            if (dvgProductosDisponible.Rows.Count == 0) return;

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dvgProductosDisponible.DataSource];
            currencyManager.SuspendBinding();

            try
            {

                INTENDO_1 = !INTENDO_1;
                if (INTENDO_1)
                {
                    SqlConnection sqlConexion = ConexionDB.ObtenerConexion();
                    SqlDataAdapter AdaptadorSql = new SqlDataAdapter($"SELECT Nombre AS Producto, PrecioActual AS Precio, StockActual AS Stock, IdProductos FROM Productos {txtBuscar.Text}", sqlConexion);

                    DataTable TablaDato = new DataTable();
                    AdaptadorSql.Fill(TablaDato);

                    dvgProductosDisponible.DataSource = TablaDato;
                    timerBucleCincoSegundos.Stop(); // Detener el bucle mientras se realiza la búsqueda
                    txtBuscar.Clear();
                }
                else if (txtBuscar.Text == "")
                {
                    CargarProductos();
                    SqlConnection sqlconexion = ConexionDB.ObtenerConexion();

                    SqlDataAdapter sqladaptador = new SqlDataAdapter("CARGAR_Productos_Disponibles", sqlconexion);

                    DataTable tabladatos = new DataTable();
                    sqladaptador.Fill(tabladatos);
                    timerBucleCincoSegundos.Start(); // Reiniciar el bucle después de actualizar
                }

                foreach (DataGridViewRow fila in dvgProductosDisponible.Rows)
                {
                    if (fila.IsNewRow) continue;

                    string id = fila.Cells["IdProductos"].Value?.ToString().ToLower() ?? "";
                    string producto = fila.Cells["Producto"].Value?.ToString().ToLower() ?? "";

                    if (string.IsNullOrEmpty(filtro))
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        // Usamos .Contains() para que busque la palabra incompleta en cualquier posición
                        if (id.Contains(filtro) || producto.Contains(filtro))
                        {
                            fila.Visible = true;
                        }
                        else
                        {
                            fila.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                currencyManager.ResumeBinding();
            }

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dvgDetalleVenta.CurrentRow != null && dvgDetalleVenta.CurrentRow.Index >= 0)
            {

                var itemSeleccionado = (Producto)dvgDetalleVenta.CurrentRow.DataBoundItem;


                ListaDeSeleccionados.Remove(itemSeleccionado);


                dvgDetalleVenta.DataSource = null;
                dvgDetalleVenta.DataSource = ListaDeSeleccionados;


            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            MenuPrincipalVenta menu = new MenuPrincipalVenta(usuarioSesion, formularioCreador);
            SeguidorPila.AbrirSiguiente(this, menu);


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario(usuarioSesion, formularioCreador);
            inventario.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal(usuarioSesion, formularioCreador);
            menu.Show();
            this.Hide();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            Herramientas herramientas = new Herramientas(usuarioSesion, formularioCreador);
            SeguidorPila.AbrirSiguiente(this, herramientas);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion inicio = new InicioSesion();
            inicio.Show();
            this.Hide();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
