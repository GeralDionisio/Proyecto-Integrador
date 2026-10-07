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
            ColoresDiseño();
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
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("Colores_Diseño", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);
                CrearUsuario crearusuario = this;

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        //Paneles atras
                        btnGuardar.BackColor = SystemColors.MenuHighlight;
                        btnRegresar.BackColor = SystemColors.MenuHighlight;
                        label5.ForeColor = SystemColors.MenuHighlight;
                        label6.ForeColor = SystemColors.MenuHighlight;
                        label11.ForeColor = SystemColors.MenuHighlight;
                        label8.ForeColor = SystemColors.MenuHighlight;
                        label7.ForeColor = SystemColors.MenuHighlight;
                        label9.ForeColor = SystemColors.MenuHighlight;
                        label10.ForeColor = SystemColors.MenuHighlight;
                        label12.ForeColor = SystemColors.MenuHighlight;
                        panel1.BackColor = SystemColors.MenuHighlight;


                    }
                    else if (valorLugar == 2)
                    {

                        //Paneles atras
                        btnGuardar.BackColor = Color.MediumPurple;
                        btnRegresar.BackColor = Color.MediumPurple;
                        label5.ForeColor = Color.MediumPurple;
                        label6.ForeColor = Color.MediumPurple;
                        label11.ForeColor = Color.MediumPurple;
                        label8.ForeColor = Color.MediumPurple;
                        label7.ForeColor = Color.MediumPurple;
                        label9.ForeColor = Color.MediumPurple;
                        label10.ForeColor = Color.MediumPurple;
                        label12.ForeColor = Color.MediumPurple;
                        panel1.BackColor = Color.DarkOrchid;

                    }
                    else if (valorLugar == 3)
                    {

                        //Paneles atras
                        btnGuardar.BackColor = Color.CadetBlue;
                        btnRegresar.BackColor = Color.CadetBlue;
                        label5.ForeColor = Color.Teal;
                        label6.ForeColor = Color.Teal;
                        label11.ForeColor = Color.Teal;
                        label8.ForeColor = Color.Teal;
                        label7.ForeColor = Color.Teal;
                        label9.ForeColor = Color.CadetBlue;
                        label10.ForeColor = Color.Teal;
                        label12.ForeColor = Color.Teal;
                        panel1.BackColor = Color.Teal;

                    }
                    else if (valorLugar == 4)
                    {

                        //Paneles atras
                        btnGuardar.BackColor = Color.DimGray;
                        btnRegresar.BackColor = Color.DimGray;
                        label5.ForeColor = Color.Black;
                        label6.ForeColor = Color.Black;
                        label11.ForeColor = Color.Black;
                        label8.ForeColor = Color.Black;
                        label7.ForeColor = Color.Black;
                        label9.ForeColor = Color.Black;
                        label10.ForeColor = Color.Black;
                        label12.ForeColor = Color.Black;
                        panel1.BackColor = Color.Black;

                    }
                }

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
