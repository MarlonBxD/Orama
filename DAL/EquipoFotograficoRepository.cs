using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class EquipoFotograficoRepository
    {
        private readonly Conexion _conexion;
        public EquipoFotograficoRepository()
        {
            _conexion = new Conexion();
        }
        public string Agregar(EquipoFotografico equipoFotografico)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Equipofotografico (Modelo, Marca, Tipo, Estado, cantidad)
                            VALUES (@Modelo, @Marca, @Tipo, @Estado, @cantidad)";
                cmd.Parameters.AddWithValue("@Modelo", equipoFotografico.Modelo);
                cmd.Parameters.AddWithValue("@Marca", equipoFotografico.Marca);
                cmd.Parameters.AddWithValue("@Tipo", equipoFotografico.Tipo);
                cmd.Parameters.AddWithValue("@Estado", equipoFotografico.Estado);
                cmd.Parameters.AddWithValue("@cantidad", equipoFotografico.Cantidad);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Equipo Fotográfico agregado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public List<EquipoFotografico> GetAll()
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Equipofotografico";
                using var reader = cmd.ExecuteReader();
                var equipos = new List<EquipoFotografico>();
                while (reader.Read())
                {
                    var equipo = new EquipoFotografico
                    {
                        Id = reader.GetInt32(0),
                        Modelo = reader.GetString(1),
                        Marca = reader.GetString(2),
                        Tipo = reader.GetString(3),
                        Estado = reader.GetString(4),
                        Cantidad = reader.GetInt32(5)
                    };
                    equipos.Add(equipo);
                }
                conn.Close();
                return equipos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los equipos fotográficos: " + ex.Message);
            }
        }
        public string Update(EquipoFotografico equipoFotografico)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE Equipofotografico SET Modelo = @Modelo, Marca = @Marca, Tipo = @Tipo, Estado = @Estado WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", equipoFotografico.Id);
                cmd.Parameters.AddWithValue("@Modelo", equipoFotografico.Modelo);
                cmd.Parameters.AddWithValue("@Marca", equipoFotografico.Marca);
                cmd.Parameters.AddWithValue("@Tipo", equipoFotografico.Tipo);
                cmd.Parameters.AddWithValue("@Estado", equipoFotografico.Estado);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Equipo Fotográfico actualizado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Delete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Equipofotografico WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Equipo Fotográfico eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public EquipoFotografico GetById(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Cliente WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                using var reader = cmd.ExecuteReader();
                cmd.ExecuteNonQuery();
                var EquipoFotografico = new EquipoFotografico
                {
                    Id = reader.GetInt32(0),
                    Modelo = reader.GetString(1),
                    Estado = reader.GetString(2),
                    Tipo = reader.GetString(3),
                    Marca = reader.GetString(4),
                    Cantidad = reader.GetInt32(5)
                };
                conn.Close();
                return EquipoFotografico;
                
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
