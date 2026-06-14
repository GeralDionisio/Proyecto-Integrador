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
        public Venta(Usuario usuario, Form parent)
        {
            this.usuarioSesion = usuario;
            this.formularioCreador = parent;
            InitializeComponent();

        }

        private void Venta_Load(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection sqlConexion = new SqlConnection("Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;");
                {
                    // Cargamos TODOS los productos al iniciar la ventana
                    string query = "SELECT Nombre AS Producto, PrecioActual AS Precio, StockActual AS Stock, IdProductos FROM Productos";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, sqlConexion))
                    {

                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dvgProductosDisponible.DataSource = dt;
                        dvgDetalleVenta.Columns["IdProducto"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar productos disponibles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
            string query = "SELECT Nombre, PrecioActual FROM Productos WHERE Nombre = @Nombre";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
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
            }
            else
            {
                MessageBox.Show("Por favor, selecciona primero un producto de la tabla de disponibles.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            double total = CalcularSubtotalGeneral3(double.Parse(lblTotalaPagar.Text), double.Parse(txtRecibido.Text));
            lblCambio.Text = $"C$ {total:N2}";

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

            // 2. Proceso de guardado en la Base de Datos
            string conexionString = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";

            string querySalida = @"INSERT INTO Salida (Fecha, TotalVenta, IdUsuario) 
                           VALUES (@Fecha, @TotalVenta, @IdUsuario); 
                           SELECT SCOPE_IDENTITY();";

            string queryDetalle = @"INSERT INTO DetalleSalida (IdSalida, IdProducto, Cantidad, Subtotal) 
                            VALUES (@IdSalida, @IdProducto, @Cantidad, @Subtotal);";

            using (SqlConnection con = new SqlConnection(conexionString))
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
                            using (SqlCommand cmdSalida = new SqlCommand(querySalida, con, transaccion))
                            {
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

                                    using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, con, transaccion))
                                    {
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
                            this.Close(); // Cerramos la ventana actual automáticamente
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

            string consulta = @"UPDATE Productos SET StockActual = StockActual - @Cantidad WHERE Nombre = @Nombre";

            try
            {
                // Usamos 'using' para asegurar que la conexión se cierre y destruya correctamente
                using (SqlConnection sqlConexion = new SqlConnection(cadenaConexion))
                {
                    sqlConexion.Open(); // ¡IMPORTANTE! Abrir la conexión

                    // Recorremos CADA producto que está en el carrito de compras
                    foreach (Producto prod in ListaDeSeleccionados)
                    {
                        using (SqlCommand cmd = new SqlCommand(consulta, sqlConexion))
                        {
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

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico al actualizar el inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }
        private void CargarVentas()
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {



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
    }
}
