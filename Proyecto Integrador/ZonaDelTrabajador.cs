using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Proyecto_Integrador.Venta;

namespace Proyecto_Integrador
{
    public partial class ZonaDelTrabajador : Form
    {
        private Usuario usuarioSesion;
        private Form FormParente;
        private string cadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";

        List<Producto> ListaDeSeleccionados = new List<Producto>();
        private bool INTENDO_1 = false;

        public ZonaDelTrabajador(Usuario usuario, Form parente)
        {
            InitializeComponent();
            usuarioSesion = usuario;
            FormParente = parente;
            lblNombreUsuario.Text = usuario?.NombreUsuario ?? string.Empty;
            lblRolUsuario.Text = usuario?.Rol ?? string.Empty;

            System.Windows.Forms.Timer miReloj = new System.Windows.Forms.Timer();
            miReloj.Interval = 1000; // 1 segundo
            miReloj.Tick += MiRelojTick; // Mi Reloj_Tick es el metodo donde ira metido el lbl
            miReloj.Start();
        }

        private void MiRelojTick(object sender, EventArgs e)
        {
            lblHora.Text = "" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void ZonaDelTrabajador_Load(object sender, EventArgs e)
        {
            CargarProducto();
            ColoresDiseño();
        }
        private void CargarProducto()
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
                        dvgProductos.DataSource = dt;
                        dvgDetalleProducto.Columns["IdProducto"].Visible = false;


                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar productos disponibles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public class Producto
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public int Cantidad { get; set; }
            public string UnidadDeMedida { get; set; }
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
                                prod.UnidadDeMedida = lector["UnidadDeMedida"].ToString();
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
        private double CalcularSubtotalGeneral3(double subtotal, double paga)
        {
            double Total = 0;

            // Recorremos la lista producto por producto

            Total = paga - subtotal;

            // Devolvemos el resultado final de la suma
            return Total;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            HerramientasDeTrabajador herramientastraba = new HerramientasDeTrabajador(usuarioSesion, this);
            SeguidorPila.AbrirSiguiente(this, herramientastraba);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MenuPrincipalTrabajador MenuPrincipaltraba = new MenuPrincipalTrabajador(this, usuarioSesion);
            MenuPrincipaltraba.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            // Pasamos a minúsculas y quitamos espacios al inicio/final
            string filtro = txtProductosbuscar.Text.Trim().ToLower();

            if (dvgProductos.Rows.Count == 0) return;

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dvgProductos.DataSource];
            currencyManager.SuspendBinding();

            try
            {

                INTENDO_1 = !INTENDO_1;
                if (INTENDO_1)
                {
                    SqlConnection sqlConexion = ConexionDB.ObtenerConexion();
                    SqlDataAdapter AdaptadorSql = new SqlDataAdapter($"SELECT Nombre AS Producto, PrecioActual AS Precio, StockActual AS Stock, IdProductos FROM Productos {txtProductosbuscar.Text}", sqlConexion);

                    DataTable TablaDato = new DataTable();
                    AdaptadorSql.Fill(TablaDato);

                    dvgProductos.DataSource = TablaDato;
                }
                else if (txtProductosbuscar.Text == "")
                {
                    CargarProducto();
                    SqlConnection sqlconexion = ConexionDB.ObtenerConexion();

                    SqlDataAdapter sqladaptador = new SqlDataAdapter("CARGAR_Productos_Disponibles", sqlconexion);

                    DataTable tabladatos = new DataTable();
                    sqladaptador.Fill(tabladatos);
                }

                foreach (DataGridViewRow fila in dvgProductos.Rows)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgarrarProducto_Click(object sender, EventArgs e)
        {
            if (dvgProductos.CurrentRow != null && dvgProductos.CurrentRow.Index >= 0)
            {
                // 2. VALIDACIÓN SEGURA DEL TEXTBOX DE CANTIDAD
                int cantidad;
                bool esNumeroValido = int.TryParse(txtCantidad.Text, out cantidad);

                if (!esNumeroValido || cantidad <= 0)
                {
                    MessageBox.Show("Por favor, ingresa una cantidad numérica válida mayor a 0 antes de añadir al carrito.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int stockDisponible = Convert.ToInt32(dvgProductos.CurrentRow.Cells["stock"].Value);

                if (cantidad > stockDisponible)
                {
                    MessageBox.Show($"La cantidad ingresada ({cantidad}) excede el stock disponible ({stockDisponible}).", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Extraemos el nombre del producto de la fila actualmente seleccionada
                string nombreSeleccionado = dvgProductos.CurrentRow.Cells["Producto"].Value.ToString();
                string TipoProducto = dvgProductos.CurrentRow.Cells["TipoProducto"].Value.ToString();

                // 4. Invocamos tu método pasándole el nombre y la cantidad
                // (Asegúrate de que este método devuelva una List<Productos> con la propiedad Cantidad ya asignada al objeto)
                List<ZonaDelTrabajador.Producto> listaActualizada = AgregarProductoPorNombre(nombreSeleccionado, cantidad);

                // 5. Refrescamos tu DataGridView de destino (el detalle o carrito de ventas)
                dvgDetalleProducto.DataSource = null;
                dvgDetalleProducto.DataSource = listaActualizada;

                // Vamos a calcular el subtotal cada vez que se añada un producto al carrito
                double resultadoSuma = CalcularSubtotalGeneral();
                lblTotalPagar.Text = resultadoSuma.ToString("N2");

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
            // 1. Validaciones previas básicas antes de tocar la Base de Datos
            if (dvgDetalleProducto.Rows.Count == 0 || (dvgDetalleProducto.Rows.Count == 1 && dvgDetalleProducto.Rows[0].IsNewRow))
            {
                MessageBox.Show("Debe agregar al menos un producto a la venta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtRecibidoCliente.Text))
            {
                MessageBox.Show("Por favor, ingrese la cantidad con la que paga el cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.Parse(txtRecibidoCliente.Text) < double.Parse(lblTotalPagar.Text))
            {
                MessageBox.Show("El dinero recibido no es suficiente para procesar la venta.", "Venta Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(txtRecibidoCliente.Text))
            {
                MessageBox.Show("Por favor introduzca el dinero que se recibio de parte del cliente");
                return;

            }
            double total = CalcularSubtotalGeneral3(double.Parse(lblTotalPagar.Text), double.Parse(txtRecibidoCliente.Text));
            lblCambio.Text = $"C$ {total:N2}";


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
                                cmdSalida.Parameters.AddWithValue("@TotalVenta", Convert.ToDecimal(lblTotalPagar.Text));


                                // Id del usuario que inició sesión
                                cmdSalida.Parameters.AddWithValue("@IdUsuario", usuarioSesion.IdUsuario);
                                cmdSalida.Parameters.AddWithValue("@NombreTrabajador", usuarioSesion.NombreUsuario);

                                idSalidaGenerado = Convert.ToInt32(cmdSalida.ExecuteScalar());
                            }

                            // --- PASO 2: REGISTRAR EL DETALLE (DETALLESALIDA) ---
                            if (dvgDetalleProducto.DataSource != null)
                            {
                                foreach (DataGridViewRow fila in dvgDetalleProducto.Rows)
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
                                        foreach (DataGridViewRow filaDisp in dvgProductos.Rows)
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

                MessageBox.Show("El stock se actualizo correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProducto();
                // 5. LIMPIEZA POST-VENTA (Opcional pero recomendado)
                ListaDeSeleccionados.Clear();
                dvgDetalleProducto.DataSource = null;
                lblTotalPagar.Text = "0.00";
                txtRecibidoCliente.Clear();
                lblCambio.Text = "0.00";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico al actualizar el inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dvgDetalleProducto.Rows.Count == 0 || (dvgDetalleProducto.Rows.Count != 1 && dvgDetalleProducto.Rows[0].IsNewRow))
            {
                MessageBox.Show("Debe agregar al menos un producto a la venta.\n" +
                    "Para que pueda eliminar un producto de la fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dvgDetalleProducto.CurrentRow != null && dvgDetalleProducto.CurrentRow.Index >= 0)
            {

                var itemSeleccionado = (Producto)dvgDetalleProducto.CurrentRow.DataBoundItem;


                ListaDeSeleccionados.Remove(itemSeleccionado);


                dvgDetalleProducto.DataSource = null;
                dvgDetalleProducto.DataSource = ListaDeSeleccionados;


            }
        }

        private void btnReporteDeVentas_Click(object sender, EventArgs e)
        {
            ReporteVentasTrabajador reporteVentasTrabajador = new ReporteVentasTrabajador(usuarioSesion, this);
            SeguidorPila.AbrirSiguiente(this, reporteVentasTrabajador);

        }
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("Colores_Diseño_Trabajador", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        //Paneles atras
                        btnInicio.BackColor = SystemColors.MenuHighlight;
                        btnReporteDeVentas.BackColor = SystemColors.MenuHighlight;
                        btnFinalizarVenta.BackColor = SystemColors.MenuHighlight;
                        btnAgarrarProducto.BackColor = SystemColors.MenuHighlight;
                        btnEliminarProducto.BackColor = SystemColors.MenuHighlight;
                        btnBuscar.BackColor = SystemColors.MenuHighlight;
                        btnCerrarSesion.BackColor = SystemColors.MenuHighlight;
                        btnReporteVentasCerradas.BackColor = SystemColors.MenuHighlight;
                        label1.ForeColor = SystemColors.MenuHighlight;
                        label7.ForeColor = SystemColors.MenuHighlight;
                        label10.ForeColor = SystemColors.MenuHighlight;
                        label11.ForeColor = SystemColors.MenuHighlight;
                        lblCambio.ForeColor = SystemColors.MenuHighlight;
                        lblTotalPagar.ForeColor = SystemColors.MenuHighlight;
                        label2.ForeColor = SystemColors.MenuHighlight;
                        label12.ForeColor = SystemColors.MenuHighlight;

                        dvgProductos.BackgroundColor = Color.LightSkyBlue;
                        dvgDetalleProducto.BackgroundColor = Color.LightSkyBlue;
                        btnHerramientas.BackColor = SystemColors.MenuHighlight;
                        panel1.BackColor = SystemColors.HotTrack;
                        panel2.BackColor = SystemColors.HotTrack;

                        //botones atras
                    }
                    else if (valorLugar == 2)
                    {
                        label2.ForeColor = Color.BlueViolet;
                        label12.ForeColor = Color.BlueViolet;
                        //Paneles atras
                        label1.ForeColor = Color.BlueViolet;
                        label7.ForeColor = Color.BlueViolet;
                        label10.ForeColor = Color.BlueViolet;
                        label11.ForeColor = Color.BlueViolet;
                        lblCambio.ForeColor = Color.BlueViolet;
                        lblTotalPagar.ForeColor = Color.BlueViolet;
                        btnInicio.BackColor = Color.MediumPurple;
                        btnReporteDeVentas.BackColor = Color.MediumPurple;
                        btnFinalizarVenta.BackColor = Color.MediumPurple;
                        btnEliminarProducto.BackColor = Color.MediumPurple;
                        btnAgarrarProducto.BackColor = Color.MediumPurple;
                        btnBuscar.BackColor = Color.MediumPurple;
                        btnCerrarSesion.BackColor = Color.MediumPurple;
                        dvgDetalleProducto.BackgroundColor = Color.DarkOrchid;
                        dvgProductos.BackgroundColor = Color.DarkOrchid;
                        btnHerramientas.BackColor = Color.MediumPurple;
                        btnReporteVentasCerradas.BackColor = Color.MediumPurple;
                        panel1.BackColor = Color.BlueViolet;
                        panel2.BackColor = Color.BlueViolet;

                        //botones atras
                    }
                    else if (valorLugar == 3)
                    {
                        label2.ForeColor = Color.Teal;
                        label12.ForeColor = Color.Teal;
                        label1.ForeColor = Color.Teal;
                        label7.ForeColor = Color.Teal;
                        label10.ForeColor = Color.Teal;
                        label11.ForeColor = Color.Teal;
                        lblCambio.ForeColor = Color.Teal;
                        lblTotalPagar.ForeColor = Color.Teal;
                        btnInicio.BackColor = Color.CadetBlue;
                        btnReporteDeVentas.BackColor = Color.CadetBlue;
                        btnAgarrarProducto.BackColor = Color.CadetBlue;
                        btnBuscar.BackColor = Color.CadetBlue;
                        btnEliminarProducto.BackColor = Color.CadetBlue;
                        btnFinalizarVenta.BackColor = Color.CadetBlue;
                        btnCerrarSesion.BackColor = Color.CadetBlue;
                        btnReporteVentasCerradas.BackColor = Color.CadetBlue;
                        dvgDetalleProducto.BackgroundColor = Color.PowderBlue;
                        dvgProductos.BackgroundColor = Color.PowderBlue;
                        //Paneles atras
                        btnHerramientas.BackColor = Color.CadetBlue;

                        panel1.BackColor = Color.Teal;
                        panel2.BackColor = Color.Teal;
                        //botones atras
                    }
                    else if (valorLugar == 4)
                    {
                        label2.ForeColor = Color.Black;
                        label12.ForeColor = Color.Black;
                        label1.ForeColor = Color.Black;
                        label7.ForeColor = Color.Black;
                        label10.ForeColor = Color.Black;
                        label11.ForeColor = Color.Black;
                        lblCambio.ForeColor = Color.Black;
                        lblTotalPagar.ForeColor = Color.Black;
                        btnAgarrarProducto.BackColor = Color.DimGray;
                        btnBuscar.BackColor = Color.DimGray;
                        btnCerrarSesion.BackColor = Color.DimGray;
                        btnFinalizarVenta.BackColor = Color.DimGray;
                        btnAgarrarProducto.BackColor = Color.DimGray;
                        btnEliminarProducto.BackColor = Color.DimGray;
                        btnInicio.BackColor = Color.DimGray;
                        dvgDetalleProducto.BackgroundColor = Color.DarkGray;
                        dvgProductos.BackgroundColor = Color.DarkGray;
                        btnReporteDeVentas.BackColor = Color.DimGray;
                        btnReporteVentasCerradas.BackColor = Color.DimGray;
                        //Paneles atras
                        btnHerramientas.BackColor = Color.DimGray;
                        panel1.BackColor = Color.Black;
                        panel2.BackColor = Color.Black;

                        //botones atras
                    }
                }

            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MenuPrincipalTrabajador menuPrincipalTrabajador = new MenuPrincipalTrabajador(this, usuarioSesion);
            menuPrincipalTrabajador.Show();
            this.Hide();

        }

        private void btnReporteVentasCerradas_Click(object sender, EventArgs e)
        {
            ReporteVentasCerradasTrabajador reporteVentasCerradasTrabajador = new ReporteVentasCerradasTrabajador(usuarioSesion, this);
            SeguidorPila.AbrirSiguiente(this, reporteVentasCerradasTrabajador);
        }
    }

}
