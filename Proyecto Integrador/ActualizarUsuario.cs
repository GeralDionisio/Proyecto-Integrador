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
    public partial class ActualizarUsuario : Form
    {
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
        public ActualizarUsuario()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ActualizarUsuario_Load(object sender, EventArgs e)
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
    }
}
