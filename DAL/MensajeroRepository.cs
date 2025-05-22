using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.Dto;

namespace DAL
{
    public class MensajeroRepository
    {
        private readonly Conexion _conexion;
        public MensajeroRepository()
        {
            _conexion = new Conexion();
        }
        public string Agregar(Mensajero mensajero)
        {
            try
            {
                if (mensajero == null || string.IsNullOrEmpty(mensajero.Nombre) || string.IsNullOrEmpty(mensajero.Telefono))
                    throw new ArgumentException("Datos del mensajero no válidos");
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Mensajero (Nombre, Apellido, Telefono, Email, Direccion)
                            VALUES (@Nombre, @Apellido, @Telefono, @Email, @Direccion)";
                cmd.Parameters.AddWithValue("@Nombre", mensajero.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", mensajero.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", mensajero.Telefono);
                cmd.Parameters.AddWithValue("@Email", mensajero.Email);
                cmd.Parameters.AddWithValue("@Direccion", mensajero.Direccion);
                cmd.ExecuteNonQuery();

                return "Mensajero agregado correctamente";
            }
            catch (Exception ex)
            {
                throw new AppException("Error al agregar mensajero", ex);
            }
        }
        public List<Mensajero> GetAll()
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Mensajero";
                using var reader = cmd.ExecuteReader();
                var mensajeros = new List<Mensajero>();
                while (reader.Read())
                {
                    var mensajero = new Mensajero
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Telefono = reader.GetString(2),
                        Email = reader.GetString(3),
                        Direccion = reader.GetString(4)
                    };
                    mensajeros.Add(mensajero);
                }
                return mensajeros;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener mensajeros", ex);
            }
        }
        public string Delete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Mensajero WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                return "Mensajero eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw new AppException("Error al eliminar mensajero", ex);
            }
        }
        public string Update(Mensajero mensajero)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE Mensajero SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono,
                            Email = @Email, Direccion = @Direccion WHERE id = @id";
                cmd.Parameters.AddWithValue("@Nombre", mensajero.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", mensajero.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", mensajero.Telefono);
                cmd.Parameters.AddWithValue("@Email", mensajero.Email);
                cmd.Parameters.AddWithValue("@Direccion", mensajero.Direccion);
                cmd.Parameters.AddWithValue("@id", mensajero.Id);
                cmd.ExecuteNonQuery();

                return "Mensajero actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw new AppException("Error al actualizar mensajero", ex);
            }
        }
        public Mensajero GetById(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT id, nombre, apellido, telefono, email, direccion FROM Mensajero WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Mensajero
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Nombre = reader["nombre"] as string,
                        Apellido = reader["apellido"] as string,
                        Telefono = reader["telefono"] as string,
                        Email = reader["email"] as string,
                        Direccion = reader["direccion"] as string
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el mensajero por ID", ex);
            }
        }



    }
}