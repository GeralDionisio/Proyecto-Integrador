using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador;

namespace Proyecto_Integrador
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL usuarioDAL = new UsuarioDAL();

        public Usuario IniciarSesion(string nombreUsuario, string contrasena)
        {
            if(string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                throw new ArgumentException("El usuario y la contraseña son obligatorios");
            }
            return usuarioDAL.ValidarLogin(nombreUsuario, contrasena);
        }

        public List<Usuario> ListarUsuarios()
        {
            return usuarioDAL.ObtenerTodos();
        }

        public bool GuardarUsuario(Usuario obj)
        {
            if(string.IsNullOrWhiteSpace(obj.NombreUsuario) || string.IsNullOrWhiteSpace(obj.Contrasena) || string.IsNullOrWhiteSpace(obj.Rol) || string.IsNullOrWhiteSpace(obj.NombreCompleto))
            {
                throw new ArgumentException("El nombre de Usuario, el nombre completo, la contraseña y el rol son obligatorios");
            }

            if(obj.IdUsuario == 0)
            {
                return usuarioDAL.Insertar(obj);
            }
            else
            {
                return usuarioDAL.Actualizar(obj);
            }

        }
        public bool EliminarUsuario(int idUsuario)
        {
            if(idUsuario <= 0)
            {
                throw new ArgumentException("Debe seleccionar un usuario valido para eliminar");
            }
            return usuarioDAL.Eliminar(idUsuario);
        }
             


        private readonly UsuarioDAL _dal;

        public UsuarioBLL()
        {
            _dal = new UsuarioDAL();
        }

        public Usuario ValidarLogin(string nombreUsuario, string contrasena)
        {
            return _dal.ValidarLogin(nombreUsuario, contrasena);
        }

        public List<Usuario> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
    }
}
