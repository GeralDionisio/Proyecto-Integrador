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
    public partial class ConfirmacionContraseña : Form
    {
        private string Usuarioemaill;
        public ConfirmacionContraseña(string identificador)
        {
            InitializeComponent();
            Usuarioemaill = identificador;
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            string CodigoIngresado = txtCodigoverificacion.Text.Trim();
            string ContraseñaNueva = txtNuevaContraseña.Text.Trim();
            string ConfirmarContraseña = txtConfirmacionContraseña.Text.Trim();

            if(string.IsNullOrEmpty(txtCodigoverificacion.Text) || string.IsNullOrEmpty(txtNuevaContraseña.Text) || string.IsNullOrEmpty(txtConfirmacionContraseña.Text))
            {
                MessageBox.Show("Porfavor complete los campos solicitados",
                    "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ContraseñaNueva != ConfirmarContraseña)
            {
                MessageBox.Show("La contraseña no coincide porfavor escriba bien la contraseña", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    String queryverificacion = "SELECT COUNT(*) FROM Usuario WHERE (NombreUsuario = @IdUsuario OR Email = @IdUsuario) AND CodigoRecuperacion = @codigo";

                    using (SqlCommand cmd = new SqlCommand(queryverificacion, conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdUsuario", Usuarioemaill);
                        cmd.Parameters.AddWithValue("@codigo", CodigoIngresado);

                        int resultado = (int)cmd.ExecuteScalar();

                        if(resultado == 0)
                        {
                            MessageBox.Show("El codigo que se ingreso es incorrecto, porfavor ingrese el codigo Correcto.", "Codigo Invalido"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string queryActualizar = "UPDATE Usuario SET Contrasena = @NuevaContraseña, CodigoRecuperacion = NULL WHERE NombreUsuario = @IdUsuario OR Email = @IdUsuario";

                        using (SqlCommand cmdActualizar = new SqlCommand(queryActualizar, conexion))
                        {
                            cmdActualizar.Parameters.AddWithValue("@NuevaContraseña", ContraseñaNueva);
                            cmdActualizar.Parameters.AddWithValue("@IdUsuario", Usuarioemaill);

                            cmdActualizar.ExecuteNonQuery();
                        }
                        MessageBox.Show("La contraseña se a cambiado correctamente", "Contraseña Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        InicioSesion iniciosesion = new InicioSesion();
                        iniciosesion.Show();
                        this.Hide();

                       
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
