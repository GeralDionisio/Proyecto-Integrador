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
            // Implementación de evento: mantener vacío intencionalmente
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                Usuario user = usuarioBLL.IniciarSesion(txtUsuario.Text, txtClave.Text);

                if(user != null)
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
                    MessageBox.Show("Usuario o Contraseña incorrecta.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
