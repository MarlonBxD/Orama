using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;
        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        public string AgregarUsuario(Usuario usuario)
        {
            try
            {
                if (usuario == null)
                {
                    throw new ArgumentNullException(nameof(usuario), "El usuario no puede ser nulo.");
                }
                return _usuarioRepository.Agregar(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar el usuario: {ex.Message}");
            }
        }
        public void ActualizarUsuario(Entity.Usuario usuario)
        {
            try
            {
                if (usuario == null)
                {
                    throw new ArgumentNullException(nameof(usuario), "El usuario no puede ser nulo.");
                }
                _usuarioRepository.Actualizar(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el usuario: {ex.Message}");
            }
        }
        public Usuario ObtenerUsuarioPorId(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("El ID del usuario debe ser mayor que cero.", nameof(id));
                }
                return _usuarioRepository.ObtenerPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el usuario por ID: {ex.Message}");
            }
        }
        public void EliminarUsuario(int id)
        {
            try
            {
                _usuarioRepository.Eliminar(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el usuario: {ex.Message}");
            }
        }
        public List<Usuario> GetUsuarios()
        {
            try
            {
                return _usuarioRepository.usuarios();
            }
            catch (Exception ex)
            { 
                throw new Exception($"Error al cargar los Usuarios { ex.Message }");
            }
        }
    }
}
