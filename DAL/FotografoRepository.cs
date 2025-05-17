using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FotografoRepository
    {
        private readonly Conexion _conexion;

        public FotografoRepository()
        {
            _conexion = new Conexion();
        }

        public void Agregar(Fotografo fotografo)
        {
            try
            {
                if (fotografo == null || string.IsNullOrEmpty(fotografo.Nombre) || string.IsNullOrEmpty(fotografo.Especialidad))
                    throw new ArgumentException("Datos del fotógrafo no válidos");

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Fotografo (Nombre, Apellido, Telefono, Email, Especialidad) VALUES (@Nombre, @Apellido, @Telefono, @Email, @Especialidad)";
                cmd.Parameters.AddWithValue("@Nombre", fotografo.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", fotografo.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", fotografo.Telefono);
                cmd.Parameters.AddWithValue("@Email", fotografo.Email);
                cmd.Parameters.AddWithValue("@Especialidad", fotografo.Especialidad);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DALException("Error al agregar fotografo", ex);
            }
        }

        public void Actualizar(Fotografo fotografo)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Fotografo Set Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Email = @Email, Especialidad = @Especialidad WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Nombre", fotografo.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", fotografo.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", fotografo.Telefono);
                cmd.Parameters.AddWithValue("@Email", fotografo.Email);
                cmd.Parameters.AddWithValue("@Especialidad", fotografo.Especialidad);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DALException("Error al actualizar fotografo", ex);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Fotografo WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DALException("Error al eliminar fotografo", ex);
            }
        }

        public List<Fotografo> ObtenerTodos()
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nombre, Apellido, Telefono, Email, Especialidad FROM Fotografo";
                using var reader = cmd.ExecuteReader();
                var fotografos = new List<Fotografo>();
                while (reader.Read())
                {
                    var fotografo = new Fotografo
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Telefono = reader.GetString(3),
                        Email = reader.GetString(4),
                        Especialidad = reader.GetString(5)
                    };
                    fotografos.Add(fotografo);
                }
                return fotografos;
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener fotografos", ex);
            }
        }

        public Fotografo ObtenerPorId(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nombre, Apellido, Telefono, Email, Especialidad FROM Fotografo WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Fotografo
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Telefono = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Email = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Especialidad = reader.GetString(5)
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener fotografo por ID", ex);
            }
        }
    }
}
