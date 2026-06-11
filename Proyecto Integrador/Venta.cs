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
                    string query = "SELECT Nombre AS Producto, PrecioActual AS Precio, StockActual AS Stock FROM Productos";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, sqlConexion))
                    {

                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dvgProductosDisponible.DataSource = dt;
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

                // 4. Invocamos el método para ir por los datos y agregarlo a la lista
                List<Producto> listaActualizada = AgregarProductoPorNombre(nombreSeleccionado, cantidad);

                // 5. Refrescamos tu DataGridView de destino (el detalle o carrito de ventas)
                dvgDetalleVenta.DataSource = null;
                dvgDetalleVenta.DataSource = listaActualizada;
                //Vamos a calcular el subtotal cada vez que se añada un producto al carrito
                double resultadoSuma = CalcularSubtotalGeneral();

                // Lo guardas en el TextBox o Label que tengas destinado para ver el total
                // (Asegúrate de cambiar 'txtSubtotalGeneral' por el nombre real de tu control)
                lblSubtotal.Text = resultadoSuma.ToString("N2");
                //Vamos a calcular el el IVA cada vez que se añada un producto al carrito
                double resultadoSuma2 = CalcularSubtotalGeneral2();

                // Lo guardas en el TextBox o Label que tengas destinado para ver el total
                // (Asegúrate de cambiar 'txtSubtotalGeneral' por el nombre real de tu control)
                lblTotalaPagar.Text = resultadoSuma2.ToString("N2");
                // Opcional: Limpia el campo de texto para dejarlo listo para el siguiente producto

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


        }
    }
}
