using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class CrearUsuario : Form
    {
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";

        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ContraseñaNueva = txtContraseña.Text.Trim();
            string ConfirmacionContraseña = txtConfirmarContraseña.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || string.IsNullOrWhiteSpace(txtNombreCompleto.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtConfirmarContraseña.Text) || string.IsNullOrWhiteSpace(txtCorreoEletrónico.Text) || string.IsNullOrWhiteSpace(txtNumeroTelefono.Text) || string.IsNullOrWhiteSpace(cbRol.Text))
            {
                MessageBox.Show("Para poder añadir un nuevo usuario porfavor llene las cajitas de texto vacias", "Falta de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ContraseñaNueva != ConfirmacionContraseña)
            {
                MessageBox.Show("La contraseña Escrita no coincide con la prestablecida", "Porfavor vuelva a escribir la contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {

                using (SqlCommand cmd = new SqlCommand("AÑADIR_Usuario", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreUsuario", txtNombreUsuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@NombreCompleto", txtNombreCompleto.Text.Trim());
                    cmd.Parameters.AddWithValue("@Contrasena", txtContraseña.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtCorreoEletrónico.Text.Trim());
                    cmd.Parameters.AddWithValue("@Rol", cbRol.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono", txtNumeroTelefono.Text.Trim());

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("El usuario se creo Correctamente", "Usuario Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtNombreCompleto.Clear();
            txtContraseña.Clear();
            txtConfirmarContraseña.Clear();
            txtCorreoEletrónico.Clear();
            txtNumeroTelefono.Clear();
            cbRol.SelectedIndex = -1;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
