using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace Proyecto_Integrador
{
    public partial class OlvidoSuContraseña : Form
    {
        private string CadenaConexion = "Server=Gerald;Database=GestionInventario11;Trusted_Connection=True;TrustServerCertificate=True;";
        public OlvidoSuContraseña()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
            this.Hide();
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            string CorreoIngresado = txtCorreoElectronico.Text.Trim();

            if (string.IsNullOrEmpty(CorreoIngresado))
            {
                MessageBox.Show("Por favor, ingrese su correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string CorreoDestino = "";

            String Query = "SELECT Email FROM Usuario WHERE NombreUsuario = @filtroCorreo OR Email = @filtroCorreo";

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(Query, conexion))
                {

                    cmd.Parameters.AddWithValue("@filtroCorreo", CorreoIngresado);
                    try
                    {
                        conexion.Open();
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            CorreoDestino = resultado.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrEmpty(CorreoDestino))
                    {
                        MessageBox.Show("No se a encontrado ningun usuario con esos datos", "Datos no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Random random = new Random();
                    string codigoRecuperacion = random.Next(100000, 999999).ToString();

                    string queryGuardar = "UPDATE Usuario SET CodigoRecuperacion = @Codigo WHERE NombreUsuario = @filtroCorreo OR Email = @filtroCorreo";
                    using (SqlCommand cmdGuardar = new SqlCommand(queryGuardar, conexion))
                    {
                        cmdGuardar.Parameters.AddWithValue("@Codigo", codigoRecuperacion);
                        cmdGuardar.Parameters.AddWithValue("@filtroCorreo", CorreoIngresado);
                        cmdGuardar.ExecuteNonQuery();
                    }

                    try
                    {
                        string remitente = "asistentesoportetecnico900@gmail.com";
                        string Contraseña = "urma xptq vubo jxwp";

                        MailMessage mensaje = new MailMessage();
                        mensaje.From = new MailAddress(remitente);
                        mensaje.To.Add(CorreoDestino);
                        mensaje.Subject = "Código de recuperación de contraseña";
                        mensaje.Body = $"Su código de recuperación de contraseña es: {codigoRecuperacion}";

                        using (SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587))
                        {
                            cliente.Credentials = new NetworkCredential(remitente, Contraseña);
                            cliente.EnableSsl = true;
                            cliente.Send(mensaje);
                        }
                        MessageBox.Show("Se ha enviado un correo con el código de recuperación.", "Correo enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ConfirmacionContraseña confirmacionContraseña = new ConfirmacionContraseña(CorreoIngresado);
                        confirmacionContraseña.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo enviar el correo . detalle:" + ex.Message, "Error de envio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
            }

        }

        private void OlvidoSuContraseña_Load(object sender, EventArgs e)
        {
            ColoresDiseño();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                        btnEnviarCorreo.BackColor = SystemColors.MenuHighlight;
                        btnRegresar.BackColor = SystemColors.MenuHighlight;
                        //botones atras
                    }
                    else if (valorLugar == 2)
                    {
                        panel1.BackColor = Color.BlueViolet;
                        //Paneles atras
                        btnEnviarCorreo.BackColor = Color.MediumPurple;
                        btnRegresar.BackColor = Color.MediumPurple;
                        //botones atras
                    }
                    else if (valorLugar == 3)
                    {
                        panel1.BackColor = Color.Teal;
                        //Paneles atras
                        btnEnviarCorreo.BackColor = Color.CadetBlue;
                        btnRegresar.BackColor = Color.CadetBlue;
                        //botones atras
                    }
                    else if (valorLugar == 4)
                    {
                        panel1.BackColor = Color.Black;
                        //Paneles atras
                        btnEnviarCorreo.BackColor = Color.DimGray;
                        btnRegresar.BackColor = Color.DimGray;
                        //botones atras
                    }
                }

            }

        }
    }
}
