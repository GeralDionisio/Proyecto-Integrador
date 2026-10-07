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
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Drawing.Text;

namespace Proyecto_Integrador
{
    public partial class EditarProducto : Form
    {

        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
        private int idProductoSeleccionado = 0;
        private Form Form;
        private object usuario;

        private Herramientas editar;

        public EditarProducto(Form parent , object usuario)
        {
            this.Form = parent;
            this.usuario = usuario;
            

            InitializeComponent();

        }
       
            



        
        

        private void iconButton4_Click(object sender, EventArgs e)
        {
            SeguidorPila.Regresar(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgProductosExistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Implementación vacía añadida para evitar errores del diseñador
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Implementación vacía añadida para evitar errores del diseñador
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtMarca.Clear();
            txtPrecioActual.Clear();
            txtStockActual.Clear();
            txtStockMinimo.Clear();
            cbCategoria.SelectedIndex = -1;
            dtpFechaVencimiento.Value = DateTime.Now;
            cbUnidadDeMedio.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea actualizar este producto?\n" +
                "Los datos anteriores se cambiaran a los nuesvos introducidos", "Esperando Comfirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                using SqlConnection sqlConexion = new SqlConnection(CadenaConexion);
                {
                    try
                    {
                        using SqlCommand cmd = new SqlCommand("Actualizar_Productos", sqlConexion);
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@IdProductos", idProductoSeleccionado);
                            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@Marca", txtMarca.Text);
                            cmd.Parameters.AddWithValue("@Categoria", cbCategoria.Text);
                            cmd.Parameters.AddWithValue("@PrecioActual", txtPrecioActual.Text);
                            cmd.Parameters.AddWithValue("@StockActual", txtStockActual.Text);
                            cmd.Parameters.AddWithValue("@StockMinimo", txtStockMinimo.Text);
                            cmd.Parameters.AddWithValue("@FechaVencimiento", dtpFechaVencimiento.Value);
                            cmd.Parameters.AddWithValue("@UnidadDeMedida", cbUnidadDeMedio.Text);
                            sqlConexion.Open();
                            int filas = cmd.ExecuteNonQuery();

                            MessageBox.Show("filas afectadas" + filas);
                            CargarProductos();

                            MessageBox.Show("Los datos del producto fuero actualizados correctamente", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("El precio o el stock no pueden ser menores que 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }

            

            

               

            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {

            SqlConnection sqlConexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter tablaAdaptador = new SqlDataAdapter("Ver_Producto", sqlConexion);
            tablaAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tablaDatos = new DataTable();
            tablaAdaptador.Fill(tablaDatos);

            dvgProductosExistencia.DataSource = tablaDatos;

            lblTotalProductos.Text = "Total de Productos: " + tablaDatos.Rows.Count;
            ColoresDiseño();
            CargarProductos();
          
        }
        public void CargarProductos()
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter sqladaptador = new SqlDataAdapter("Ver_Producto", sqlconexion);
            sqladaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgProductosExistencia.DataSource = tabladatos;

        }

        private void dvgProductosExistencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow fila = dvgProductosExistencia.Rows[e.RowIndex];

            idProductoSeleccionado = Convert.ToInt32(fila.Cells["IdProductos"].Value);

            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtMarca.Text = fila.Cells["Marca"].Value.ToString();
            txtPrecioActual.Text = fila.Cells["PrecioActual"].Value.ToString();
            txtStockActual.Text = fila.Cells["StockActual"].Value.ToString();
            txtStockMinimo.Text = fila.Cells["StockMinimo"].Value.ToString();
            cbCategoria.Text = fila.Cells["Categoria"].Value.ToString();
            dtpFechaVencimiento.Value = Convert.ToDateTime(fila.Cells["FechaVencimiento"].Value);
            cbUnidadDeMedio.Text = fila.Cells["UnidadDemedida"].Value.ToString();

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                { 
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Eliminar_Producto", conexion);
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@IdProductos", idProductoSeleccionado);

                            conexion.Open();

                            int filas = cmd.ExecuteNonQuery();

                            conexion.Close();

                            MessageBox.Show("Producto eliminado: " + filas);

                            CargarProductos();

                            LimpiarCampos();

                            idProductoSeleccionado = 0;
                        }
                    }
                    catch(SqlException ex) when (ex.Number == 547)
                    {
                        MessageBox.Show("No se puede borrar el producto porque se esta utilizando en otro lado\n" +
                            "se recomienda que cierre la ventas al finalizar el dia", "Por favor vuelva a intentarlo mas tarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                       
                        MessageBox.Show("No se puede eliminar un producto con stock aun disponible.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }


                

                
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConexion = new SqlConnection(CadenaConexion);
            SqlDataAdapter AdaptadorSql = new SqlDataAdapter("Boton_Buscar", sqlConexion);
            AdaptadorSql.SelectCommand.CommandType = CommandType.StoredProcedure;
            AdaptadorSql.SelectCommand.Parameters.AddWithValue("@Nombre", txtBuscarProducto.Text.Trim());

            DataTable TablaDato = new DataTable();
            AdaptadorSql.Fill(TablaDato);

            dvgProductosExistencia.DataSource = TablaDato;
        }

        private void btnMostrarProducto_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconexion = new SqlConnection(CadenaConexion);

            SqlDataAdapter sqladaptador = new SqlDataAdapter("Ver_Producto", sqlconexion);

            DataTable tabladatos = new DataTable();
            sqladaptador.Fill(tabladatos);

            dvgProductosExistencia.DataSource = tabladatos;
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
                        this.BackColor = SystemColors.MenuHighlight;
                        //Paneles atras
                        iconButton2.BackColor = SystemColors.MenuHighlight;
                        btnRegresar.BackColor = SystemColors.MenuHighlight;
                        btnMostrarProducto.BackColor = SystemColors.MenuHighlight;
                        btnGuardar.BackColor = SystemColors.MenuHighlight;
                        //botones atras
                        label5.ForeColor = SystemColors.HotTrack;
                        label11.ForeColor = SystemColors.HotTrack;
                        label9.ForeColor = SystemColors.HotTrack;
                        label4.ForeColor = SystemColors.HotTrack;
                        label6.ForeColor = SystemColors.HotTrack;
                        label10.ForeColor = SystemColors.HotTrack;
                        label7.ForeColor = SystemColors.HotTrack;
                        label8.ForeColor = SystemColors.HotTrack;
                        label12.ForeColor = SystemColors.HotTrack;
                        label13.ForeColor = SystemColors.HotTrack;
                        lblTotalProductos.ForeColor = SystemColors.HotTrack;
                        //letras atras
                        dvgProductosExistencia.BackgroundColor = Color.LightSkyBlue;
                        //tablas atras
                    }
                    else if (valorLugar == 2)
                    {
                        this.BackColor = Color.MediumPurple;
                        //Paneles atras
                        iconButton2.BackColor = Color.MediumPurple;
                        btnRegresar.BackColor = Color.MediumPurple;
                        btnMostrarProducto.BackColor = Color.MediumPurple;
                        btnGuardar.BackColor = Color.MediumPurple;
                        //botones atras
                        label5.ForeColor = Color.BlueViolet;
                        label11.ForeColor = Color.BlueViolet;
                        label9.ForeColor = Color.BlueViolet;
                        label4.ForeColor = Color.BlueViolet;
                        label6.ForeColor = Color.BlueViolet;
                        label10.ForeColor = Color.BlueViolet;
                        label7.ForeColor = Color.BlueViolet;
                        label8.ForeColor = Color.BlueViolet;
                        label12.ForeColor = Color.BlueViolet;
                        lblTotalProductos.ForeColor = Color.BlueViolet;
                        label13.ForeColor = Color.BlueViolet;
                        //letras atras
                        dvgProductosExistencia.BackgroundColor = Color.DarkOrchid;
                        //tablas atras
                    }
                    else if (valorLugar == 3)
                    {
                        this.BackColor = Color.CadetBlue;
                        //Paneles atras
                        iconButton2.BackColor = Color.CadetBlue;
                        btnRegresar.BackColor = Color.CadetBlue;
                        btnMostrarProducto.BackColor = Color.CadetBlue;
                        btnGuardar.BackColor = Color.CadetBlue;
                        //botones atras
                        label5.ForeColor = Color.Teal;
                        label11.ForeColor = Color.Teal;
                        label9.ForeColor = Color.Teal;
                        label4.ForeColor = Color.Teal;
                        label6.ForeColor = Color.Teal;
                        label10.ForeColor = Color.Teal;
                        label7.ForeColor = Color.Teal;
                        label8.ForeColor = Color.Teal;
                        label12.ForeColor = Color.Teal;
                        lblTotalProductos.ForeColor = Color.Teal;
                        label13.ForeColor = Color.Teal;
                        //letras atras
                        dvgProductosExistencia.BackgroundColor = Color.PowderBlue;
                        //tablas atras
                    }
                    else if (valorLugar == 4)
                    {
                        this.BackColor = Color.DimGray;
                        //Paneles atras
                        iconButton2.BackColor = Color.DimGray;
                        btnRegresar.BackColor = Color.DimGray;
                        btnMostrarProducto.BackColor = Color.DimGray;
                        btnGuardar.BackColor = Color.DimGray;
                        //botones atras
                        label5.ForeColor = Color.Black;
                        label11.ForeColor = Color.Black;
                        label9.ForeColor = Color.Black;
                        label4.ForeColor = Color.Black;
                        label6.ForeColor = Color.Black;
                        label10.ForeColor = Color.Black;
                        label7.ForeColor = Color.Black;
                        label8.ForeColor = Color.Black;
                        label12.ForeColor = Color.Black;
                        lblTotalProductos.ForeColor = Color.Black;
                        label13.ForeColor = Color.Black;
                        //letras atras
                        dvgProductosExistencia.BackgroundColor = Color.DarkGray;
                        //tablas atras
                    }
                }

            }


        }
    }
}
