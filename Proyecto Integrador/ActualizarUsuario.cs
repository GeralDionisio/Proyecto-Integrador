using FontAwesome.Sharp;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class ActualizarUsuario : Form
    {
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";

        private int IdSeleccionadoUsuario = 0;

        public ActualizarUsuario()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ActualizarUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            ColoresDiseño();
        }
        private void CargarUsuarios()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {

                using (SqlCommand cmd = new SqlCommand("Ver_Usuario", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    SqlDataReader TablaDato = cmd.ExecuteReader();
                    DataTable DatosTablas = new DataTable();
                    DatosTablas.Load(TablaDato);
                    dvgUsuarios.DataSource = DatosTablas;
                }
            }
        }

        private void dvgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow filaSeleccionada = dvgUsuarios.Rows[e.RowIndex];

                IdSeleccionadoUsuario = Convert.ToInt32(filaSeleccionada.Cells["IdUsuario"].Value);
                txtNombreUsuario.Text = filaSeleccionada.Cells["NombreUsuario"].Value.ToString();
                txtNombreCompleto.Text = filaSeleccionada.Cells["NombreCompleto"].Value.ToString();
                txtCorreoElectronico.Text = filaSeleccionada.Cells["Email"].Value.ToString();
                txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
                cbRol.Text = filaSeleccionada.Cells["Rol"].Value.ToString();
                txtContraseñaActual.Text = filaSeleccionada.Cells["Contrasena"].Value.ToString();

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (IdSeleccionadoUsuario == 0)
            {
                MessageBox.Show("Porfavor seleccione un usuario que gustaria actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Esta seguro que quiere actualizar este registro del usuario eligido?\n" +
                "Los viejos datos se perderan", "Esperando Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                    {
                        using (SqlCommand cmd = new SqlCommand("Actualizar_Usuario", conexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@IdUsuario", IdSeleccionadoUsuario);
                            cmd.Parameters.AddWithValue("@NombreUsuario", txtNombreUsuario.Text);
                            cmd.Parameters.AddWithValue("@NombreCompleto", txtNombreCompleto.Text);
                            cmd.Parameters.AddWithValue("@Contrasena", txtContraseñaActual.Text);
                            cmd.Parameters.AddWithValue("@Email", txtCorreoElectronico.Text);
                            cmd.Parameters.AddWithValue("@Rol", cbRol.Text);
                            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                            conexion.Open();
                            cmd.ExecuteNonQuery();
                            LimpiarCampos();
                            CargarUsuarios();
                            MessageBox.Show("Los datos del usuario han sido actualizados correctamente", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show("Error al actualizar el usuario: " + es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarCampos()
        {
            txtContraseñaActual.Clear();
            txtCorreoElectronico.Clear();
            txtNombreCompleto.Clear();
            txtNombreUsuario.Clear();
            txtTelefono.Clear();
            cbRol.SelectedIndex = -1;

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        

        private void btnDesactivarUsuario_Click(object sender, EventArgs e)
        {

            if (IdSeleccionadoUsuario == 0)
            {
                MessageBox.Show("Por favor seleccione un usuario que gustaria desactivar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult Resultado = MessageBox.Show("¿Esta seguro de desactivar este usuario?\n" +
                "Este usuario no podra volver a acceder al sistema", "Confirmar Desactivacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (Resultado == DialogResult.Yes)
                {

                    using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                    {
                        using (SqlCommand cmd = new SqlCommand("Desactivar_Usuario", conexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@IdUsuario", IdSeleccionadoUsuario);
                            conexion.Open();
                            cmd.ExecuteNonQuery();
                            LimpiarCampos();
                            CargarUsuarios();

                            MessageBox.Show("El usuario seleccionado se a desactivado correctamenten\n" +
                                "El usuario no tiene acceso al sistema", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desactivar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("Colores_Diseño", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);
                ActualizarUsuario actualizar = this;

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        //Paneles atras
                        btnRegresar.BackColor = SystemColors.MenuHighlight;
                        btnActualizar.BackColor = SystemColors.MenuHighlight;
                        label5.ForeColor = SystemColors.MenuHighlight;
                        label6.ForeColor = SystemColors.MenuHighlight;
                        label11.ForeColor = SystemColors.MenuHighlight;
                        label8.ForeColor = SystemColors.MenuHighlight;
                        label7.ForeColor = SystemColors.MenuHighlight;
                        label9.ForeColor = SystemColors.MenuHighlight;
                        dvgUsuarios.BackgroundColor = Color.LightSkyBlue;
                        panel1.BackColor = SystemColors.MenuHighlight;


                    }
                    else if (valorLugar == 2)
                    {

                        //Paneles atras
                        btnRegresar.BackColor = Color.MediumPurple;
                        btnActualizar.BackColor = Color.MediumPurple;
                        label5.ForeColor = Color.MediumPurple;
                        label6.ForeColor = Color.MediumPurple;
                        label11.ForeColor = Color.MediumPurple;
                        label8.ForeColor = Color.MediumPurple;
                        label7.ForeColor = Color.MediumPurple;
                        label9.ForeColor = Color.MediumPurple;
                        dvgUsuarios.BackgroundColor = Color.MediumPurple;
                        panel1.BackColor = Color.DarkOrchid;

                    }
                    else if (valorLugar == 3)
                    {

                        //Paneles atras
                        btnRegresar.BackColor = Color.CadetBlue;
                        btnActualizar.BackColor = Color.CadetBlue;
                        label5.ForeColor = Color.Teal;
                        label6.ForeColor = Color.Teal;
                        label11.ForeColor = Color.Teal;
                        label8.ForeColor = Color.Teal;
                        label7.ForeColor = Color.Teal;
                        label9.ForeColor = Color.CadetBlue;
                        dvgUsuarios.BackgroundColor = Color.PowderBlue;
                        panel1.BackColor = Color.Teal;

                    }
                    else if (valorLugar == 4)
                    {

                        //Paneles atras
                        btnRegresar.BackColor = Color.DimGray;
                        btnActualizar.BackColor = Color.DimGray;
                        label5.ForeColor = Color.Black;
                        label6.ForeColor = Color.Black;
                        label11.ForeColor = Color.Black;
                        label8.ForeColor = Color.Black;
                        label7.ForeColor = Color.Black;
                        label9.ForeColor = Color.Black;
                        dvgUsuarios.BackgroundColor = Color.DarkGray;
                        panel1.BackColor = Color.Black;

                    }
                }

            }
        }

        private void btnVolverActivarUsuario_Click(object sender, EventArgs e)
        {


            if (IdSeleccionadoUsuario == 0)
            {
                MessageBox.Show("Eliga al usuario que tenga desactivado", "Esperando Usuario", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            DialogResult resultado = MessageBox.Show("El usuario seleccionado volvera a usar las funciones prestablecida que se le habia asignado anteriormente.\n" +
                "¿Esta seguro de volver a activar el usuario?", "Esperando Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("VOLVER_Activar_Usuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdUsuario", IdSeleccionadoUsuario);
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        CargarUsuarios();

                        MessageBox.Show($"El usuario seleccionado a sido activado", "Operacion Exitosa", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                }
            }

        }
    }

}
