using Entity;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AsignacionRepository
    {
        private readonly Conexion _conexion;
        public AsignacionRepository()
        {
            _conexion = new Conexion();
        }

        public string Agregar(Asignacion asignacion)
        {
            try
            {
                if (asignacion == null || asignacion.Fotografo == null)
                    throw new ArgumentException("Datos de la asignación no válidos");
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Asignacion (Fotografo_id, Evento_id, Fecha)
                            VALUES (@Fotografo_id, @Evento_id, @Fecha)";
                cmd.Parameters.AddWithValue("@Fotografo_id", asignacion.Fotografo.Id);
                cmd.Parameters.AddWithValue("@Evento_id", asignacion.Evento.Id);
                cmd.Parameters.AddWithValue("@Fecha", asignacion.FechaAsignacion);
                cmd.ExecuteNonQuery();
                return "Asignación agregada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Asignacion> GetAll()
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Asignacion";
                using var reader = cmd.ExecuteReader();
                var asignaciones = new List<Asignacion>();
                while (reader.Read())
                {
                    var asignacion = new Asignacion
                    {
                        Id = reader.GetInt32(0),
                        FechaAsignacion = reader.GetDateTime(3),
                        Fotografo = new Fotografo { Id = reader.GetInt32(1) },
                        Evento = new Evento { Id = reader.GetInt32(2) }
                    };
                    asignaciones.Add(asignacion);
                }
                return asignaciones;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string Delete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Asignacion WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                return "Asignación eliminada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public Asignacion GetById(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Asignacion WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var asignacion = new Asignacion
                    {
                        Id = reader.GetInt32(0),
                        FechaAsignacion = reader.GetDateTime(3),
                        Fotografo = new Fotografo { Id = reader.GetInt32(1) },
                        Evento = new Evento { Id = reader.GetInt32(2) }
                    };
                    return asignacion;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string Update(Asignacion asignacion)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE Asignacion SET Fotografo_id = @Fotografo_id, Evento_id = @Evento_id, Fecha = @Fecha WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Fotografo_id", asignacion.Fotografo.Id);
                cmd.Parameters.AddWithValue("@Evento_id", asignacion.Evento.Id);
                cmd.Parameters.AddWithValue("@Fecha", asignacion.FechaAsignacion);
                cmd.Parameters.AddWithValue("@Id", asignacion.Id);
                cmd.ExecuteNonQuery();
                return "Asignación actualizada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
