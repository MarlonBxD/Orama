using Entity;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioRepository
    {
        private readonly Conexion conn;
        public UsuarioRepository()
        {
            conn = new Conexion();
        }

        public string Agregar(Usuario usuario)
        {
            try
            {
                using var connection = conn.GetConnection();
                connection.Open();

                string query = @"INSERT INTO usuarios (Nombre, Apellido, Telefono, Email, Direccion, usuario, contraseña, tipo)
                         VALUES (@Nombre, @Apellido, @Telefono, @Email, @Direccion, @Usuario, @Contrasena, @Tipo);";

                using var cmd = new NpgsqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@Email", (object)usuario.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                cmd.Parameters.AddWithValue("@Usuario", usuario.nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@Tipo", usuario.tipoUsuario);

                cmd.ExecuteNonQuery();

                return "Usuario agregado correctamente.";
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar el usuario {ex.Message}");
            }
        }
        public void Actualizar(Usuario usuario)
        {
            try
            {
                using var connection = conn.GetConnection();
                connection.Open();
                string query = @"UPDATE usuarios SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Email = @Email, 
                                 Direccion = @Direccion, usuario = @Usuario, contraseña = @Contrasena, tipo = @Tipo 
                                 WHERE Id = @Id;";
                using var cmd = new NpgsqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", usuario.Id);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@Email", (object)usuario.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                cmd.Parameters.AddWithValue("@Usuario", usuario.nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@Tipo", usuario.tipoUsuario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el usuario {ex.Message}");
            }

        }
        public void Eliminar(int id)
        {
            try
            {
                using var connection = conn.GetConnection();
                connection.Open();
                string query = @"DELETE FROM usuarios WHERE Id = @Id;";
                using var cmd = new NpgsqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el usuario {ex.Message}");
            }
        }
        public Usuario ObtenerPorId(int id)
        {
            try
            {
                using var connection = conn.GetConnection();
                connection.Open();

                string query = @"SELECT id, nombre, apellido, telefono, email, direccion, usuario, contraseña, tipo  
                         FROM usuarios WHERE Id = @Id;";

                using var cmd = new NpgsqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Usuario
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Telefono = reader.GetString(3),
                        Email = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Direccion = reader.GetString(5),
                        nombreUsuario = reader.GetString(6),
                        Contrasena = reader.GetString(7),
                        tipoUsuario = reader.GetString(8)
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el usuario: {ex.Message}", ex);
            }
        }

        public List<Usuario> usuarios()
        {
            try
            {
                return new List<Usuario>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en base de datos {ex.Message}");
            }
        }

    }
}
