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
        public void AgregarMensajero(Mensajero mensajero)
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
        }
        public List<Mensajero> GetMensajeros()
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
                    Direccion = reader.GetString(4),
                    tipo_mensajero = reader.GetString(5)
                };
                mensajeros.Add(mensajero);
            }
            return mensajeros;
        }
        public void DeleteMensajero(int id)
        {
            using var conn = _conexion.GetConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Mensajero WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        public void UpdateMensajero(Mensajero mensajero)
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
            return null;
        }
        //public MensajeroDTO ObtenerMensajeroPorNombre(string nombre)
        //{
        //    using var conn = _conexion.GetConnection();
        //    conn.Open();

        //    using var cmd = conn.CreateCommand();
        //    cmd.CommandText = "SELECT Nombre FROM Mensajero WHERE Nombre = @nombre LIMIT 1";
        //    cmd.Parameters.AddWithValue("@nombre", nombre);

        //    using var reader = cmd.ExecuteReader();
        //    if (reader.Read())
        //    {
        //        return new MensajeroDTO
        //        {
        //            Nombre = reader.GetString(0)
        //        };
        //    }

        //    throw new Exception("Mensajero no encontrado.");
        //}

    }
}