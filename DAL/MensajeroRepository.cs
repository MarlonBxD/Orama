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
        public string AgregarMensajero(Mensajero mensajero)
        {
            try
            {
                if (mensajero == null || string.IsNullOrEmpty(mensajero.Nombre) || string.IsNullOrEmpty(mensajero.Telefono))
                    throw new ArgumentException("Datos del mensajero no válidos");
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Mensajero (Nombre, Apellido, Telefono, Email, Direccion, TipoMensajero)
                            VALUES (@Nombre, @Apellido, @Telefono, @Email, @Direccion, @TipoMensajero)";
                cmd.Parameters.AddWithValue("@Nombre", mensajero.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", mensajero.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", mensajero.Telefono);
                cmd.Parameters.AddWithValue("@Email", mensajero.Email);
                cmd.Parameters.AddWithValue("@Direccion", mensajero.Direccion);
                cmd.Parameters.AddWithValue("@TipoMensajero", mensajero.tipo_mensajero);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Mensajero Agregado";
            }
            catch (AppException ex) 
            { 
                return ex.Message;
            }
        }
        public Mensajero GetMensajero(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Mensajero WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                using var reader = cmd.ExecuteReader();
                var mensajero = new Mensajero
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Telefono = reader.GetString(2),
                    Email = reader.GetString(3),
                    Direccion = reader.GetString(4),
                    tipo_mensajero = reader.GetString(5)
                };
                conn.Close();
                return mensajero;

            }
            catch (AppException ex) 
            {
                return null;
            }
        }
        public string DeleteMensajero(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Mensajero WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Eliminado con Exito";
            }
            catch (AppException ex) 
            {
                return ex.Message;
            
            }
        }
        public string UpdateMensajero(Mensajero mensajero)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE Mensajero SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono,
                            Email = @Email, Direccion = @Direccion, TipoMensajero = @TipoMensajero WHERE id = @id";
                cmd.Parameters.AddWithValue("@Nombre", mensajero.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", mensajero.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", mensajero.Telefono);
                cmd.Parameters.AddWithValue("@Email", mensajero.Email);
                cmd.Parameters.AddWithValue("@Direccion", mensajero.Direccion);
                cmd.Parameters.AddWithValue("@TipoMensajero", mensajero.tipo_mensajero);
                cmd.Parameters.AddWithValue("@id", mensajero.Id);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Actualizado Con exito";
            }
            catch (AppException ex) 
            {
                return ex.Message;
            }
        }
        public Mensajero GetMensajeroById(int id)
        {
            using var conn = _conexion.GetConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Mensajero WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Mensajero
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Apellido = reader.GetString(2),
                    Telefono = reader.GetString(3),
                    Email = reader.GetString(4),
                    Direccion = reader.GetString(5),
                    tipo_mensajero = reader.GetString(6)
                };
            }
            conn.Close();
            return null;
        }
        public MensajeroDTO ObtenerMensajeroPorNombre(string nombre)
        {
            using var conn = _conexion.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Nombre telfono FROM Mensajero WHERE Nombre = @nombre LIMIT 1";
            cmd.Parameters.AddWithValue("@nombre", nombre);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new MensajeroDTO
                {
                    Nombre = reader.GetString(0),
                    Telefono = reader.GetString(1)
                };
            }

            throw new Exception("Mensajero no encontrado.");
        }

    }
}