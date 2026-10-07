using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace Proyecto_Integrador
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();

        }


        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Implementación de evento: mantener vacío intencionalmente
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            // Implementación de evento: mantener vacío intencionalmente
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            // Implementación de evento: mantener vacío intencionalmente
        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            // Implementación de evento: mantener vacío intencionalmente
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Implementación de evento: mantener vacío intencionalmente
        }

        private void label10_Click(object sender, EventArgs e)
        {
            // Implementación de evento: mantener vacío intencionalmente
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColoresDiseño();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {


        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresar1_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                Usuario user = usuarioBLL.ValidarLogin(txtUsuario1.Text, txtClave2.Text);

                
                if (user != null)
                {
                    if(user.Activo == true)
                    {
                        MessageBox.Show($"Bienvenido {user.NombreCompleto} ({user.Rol})", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Aqui se abre el nuevo formulario
                        MenuPrincipal menuprincipal = new MenuPrincipal(user, this);
                        txtUsuario.Clear();
                        txtClave.Clear();
                        this.Hide();
                        menuprincipal.Show();
                    }
                    else
                    {
                        MessageBox.Show($"EL Usuario {user.NombreCompleto} con su Rol {user.Rol} esta desactivado", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void likOlvidoContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OlvidoSuContraseña olvidoSuContraseña = new OlvidoSuContraseña();
            olvidoSuContraseña.Show();
            this.Hide();

        }
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("SELECT Numero FROM ColoresDiseño", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        panel1.BackColor = SystemColors.HotTrack;
                        //Paneles atras
                        btnIngresar1.BackColor = SystemColors.MenuHighlight;
                        btnSalir1.ForeColor = SystemColors.MenuHighlight;
                        btnSalir1.IconColor = SystemColors.MenuHighlight;
                        //botones atras
                    }
                    else if (valorLugar == 2)
                    {
                        panel1.BackColor = Color.BlueViolet;
                        //Paneles atras
                        btnIngresar1.BackColor = Color.MediumPurple;
                        btnSalir1.ForeColor = Color.MediumPurple;
                        btnSalir1.IconColor = Color.MediumPurple;
                        //botones atras
                    }
                    else if (valorLugar == 3)
                    {
                        panel1.BackColor = Color.Teal;
                        //Paneles atras
                        btnIngresar1.BackColor = Color.CadetBlue;
                        btnSalir1.ForeColor = Color.CadetBlue;
                        btnSalir1.IconColor = Color.CadetBlue;
                        //botones atras
                    }
                    else if (valorLugar == 4)
                    {
                        panel1.BackColor = Color.Black;
                        //Paneles atras
                        btnIngresar1.BackColor = Color.DimGray;
                        btnSalir1.ForeColor = Color.DimGray;
                        btnSalir1.IconColor = Color.DimGray;
                        //botones atras
                    }
                }

            }

        }
    }
}
