using Microsoft.Data.SqlClient;
using Proyecto_Integrador;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Proyecto_Integrador
{
    public class UsuarioDAL
    {
        public Usuario ValidarLogin(string nombreUsuario, string contrasena)
        {
            Usuario usuarioAutenticado = null;
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"SELECT IdUsuario, NombreUsuario, NombreCompleto, Contrasena, Email, Rol, Telefono FROM Usuario WHERE NombreUsuario = @NombreUsuario AND Contrasena = @Contrasena AND Activo = 1";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                try
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioAutenticado = new Usuario
                            {
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                NombreUsuario = reader["NombreUsuario"].ToString(),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                Contrasena = reader["Contrasena"].ToString(),
                                Email = reader["Email"].ToString(),
                                Rol = reader["Rol"].ToString(),
                                Telefono = reader["Telefono"].ToString()
                            };

                        }
                    }

                }
                catch(Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }

            }
            return usuarioAutenticado;
        }
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"SELECT IdUsuario, NombreUsuario, NombreCompleto, Contrasena, Email, Rol, Telefono FROM Usuario";

                SqlCommand cmd = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario
                            {
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                NombreUsuario = reader["NombreUsuario"].ToString(),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                Contrasena = reader["Contrasena"].ToString(),
                                Email = reader["Email"].ToString(),
                                Rol = reader["Rol"].ToString(),
                                Telefono = reader["Telefono"].ToString()
                            });
                               
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los usuarios: " + ex.Message);
                }
            }
            return lista;

        }
        public bool Insertar(Usuario obj)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"INSERT INTO Usuario (NombreUsuario, NombreCompleto, Contrasena, Email, Rol, Telefono) VALUES (@NombreUsuario, @NombreCompleto, @Contrasena, @Email, @Rol, @Telefono)";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@NombreUsuario", obj.NombreUsuario);
                cmd.Parameters.AddWithValue("@NombreCompleto", obj.NombreCompleto);
                cmd.Parameters.AddWithValue("@Contrasena", obj.Contrasena);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                cmd.Parameters.AddWithValue("@Rol", obj.Rol);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);

                try
                {
                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar el usuario: " + ex.Message);
                }

            }
              
        }

        public bool Actualizar(Usuario obj)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"UPDATE Usuario SET NombreUsuario = @NombreUsuario, NombreCompleto = @NombreCompleto, Contrasena = @Contrasena, Email = @Email, Rol = @Rol, Telefono = @Telefono WHERE IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);
                cmd.Parameters.AddWithValue("@NombreUsuario", obj.NombreUsuario);
                cmd.Parameters.AddWithValue("@NombreCompleto", obj.NombreCompleto);
                cmd.Parameters.AddWithValue("@Contrasena", obj.Contrasena);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                cmd.Parameters.AddWithValue("@Rol", obj.Rol);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);

                try
                {
                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el usuario: " + ex.Message);
                }

            }

        }

        public bool Eliminar(int idUsuario)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = "UPDATE Usuario SET Activo = 0 WHERE IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                try
                {
                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch(Exception ex)
                {
                    throw new Exception("Error al eliminar el usuario: " + ex.Message);
                }
            }
                
        }
            
    }

}
    