using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;


namespace Proyecto_Integrador
{
    public partial class ConfirmacionContraseña : Form
    {
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
        private string Usuarioemaill;

        public int IdUsuario;

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

            if (string.IsNullOrEmpty(txtCodigoverificacion.Text) || string.IsNullOrEmpty(txtNuevaContraseña.Text) || string.IsNullOrEmpty(txtConfirmacionContraseña.Text))
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

                        if (resultado == 0)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfirmacionContraseña_Load(object sender, EventArgs e)
        {
            ColoresDiseño();
        }
        
        private void btnVolverEnviarCorreo_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("Codigo_Existente", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", Usuarioemaill);

                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("El codigo ya se encuentra registrado en la base de datos\n" +
                            "No es necesario volverlo a enviar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Random random = new Random();
                    string codigoRecuperacion = random.Next(100000, 999999).ToString();

                    string queryGuardar = "UPDATE Usuario SET CodigoRecuperacion = @Codigo WHERE NombreUsuario = @filtroCorreo OR Email = @filtroCorreo";
                    using (SqlCommand cmdGuardar = new SqlCommand(queryGuardar, conexion))
                    {
                        cmdGuardar.Parameters.AddWithValue("@Codigo", codigoRecuperacion);
                        cmdGuardar.Parameters.AddWithValue("@filtroCorreo", Usuarioemaill);
                        cmdGuardar.ExecuteNonQuery();
                    }
                    try
                    {
                        string remitente = "asistentesoportetecnico900@gmail.com";
                        string Contraseña = "urma xptq vubo jxwp";

                        MailMessage mensaje = new MailMessage();
                        mensaje.From = new MailAddress(remitente);
                        mensaje.To.Add(Usuarioemaill);
                        mensaje.Subject = "Código de recuperación de contraseña";
                        mensaje.Body = $"Su código de recuperación de contraseña es: {codigoRecuperacion}";

                        using (SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587))
                        {
                            cliente.Credentials = new NetworkCredential(remitente, Contraseña);
                            cliente.EnableSsl = true;
                            cliente.Send(mensaje);
                        }
                        MessageBox.Show("Se ha enviado un correo con el código de recuperación.", "Correo enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    

                }

            }


        }
        private void ColoresDiseño()
        {
            using (SqlConnection sqlConexionColores = ConexionDB.ObtenerConexion())
            {
                SqlDataAdapter sqlAdaptadorColores = new SqlDataAdapter("SELECT Numero FROM ColoresDiseño", sqlConexionColores);
                DataTable dtColores = new DataTable();
                sqlAdaptadorColores.Fill(dtColores);
                ConfirmacionContraseña confirmacionContraseña = this;

                if (dtColores.Rows.Count > 0)
                {
                    int valorLugar = Convert.ToInt32(dtColores.Rows[0]["Numero"]);
                    if (valorLugar == 1)
                    {
                        confirmacionContraseña.BackColor = SystemColors.HotTrack;
                        //Paneles atras
                        btnCambiarContraseña.BackColor = SystemColors.MenuHighlight;
                        btnVolverEnviarCorreo.BackColor = SystemColors.MenuHighlight;
                        //botones atras
                    }
                    else if (valorLugar == 2)
                    {
                        confirmacionContraseña.BackColor = Color.BlueViolet;
                        //Paneles atras
                        btnCambiarContraseña.BackColor = Color.MediumPurple;
                        btnVolverEnviarCorreo.BackColor = Color.MediumPurple;
                        //botones atras
                    }
                    else if (valorLugar == 3)
                    {
                        confirmacionContraseña.BackColor = Color.Teal;
                        //Paneles atras
                        btnCambiarContraseña.BackColor = Color.CadetBlue;
                        btnVolverEnviarCorreo.BackColor = Color.CadetBlue;
                        //botones atras
                    }
                    else if (valorLugar == 4)
                    {
                        confirmacionContraseña.BackColor = Color.Black;
                        //Paneles atras
                        btnCambiarContraseña.BackColor = Color.DimGray;
                        btnVolverEnviarCorreo.BackColor = Color.DimGray;
                        //botones atras
                    }

                }
            }

        }

    }
}

