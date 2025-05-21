using Entity;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                conn.Close();
                return "Asignación agregada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<AsignacionDTO> GetAll()
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT a.id, " +
                                       "e.tipo AS TipoEvento, " +
                                       "f.nombre AS NombreFotografo " +
                                       "FROM Asignacion a " +
                                       "JOIN Evento e ON a.evento_id = e.id " +
                                       "JOIN Fotografo f ON a.fotografo_id = f.id ";
                using var reader = cmd.ExecuteReader();
                var asignaciones = new List<AsignacionDTO>();
                while (reader.Read())
                {
                    var asignacion = new AsignacionDTO
                    {
                        Id = reader.GetInt32(0),
                        TipoEvento = reader.GetString(1),
                        NombreFotografo = reader.GetString(2)
                    };
                    asignaciones.Add(asignacion);
                }
                conn.Close();
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
                conn.Close();
                return "Asignación eliminada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public AsignacionDTO GetById(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT a.id, " +
                                       "e.tipo AS TipoEvento, " +
                                       "f.nombre AS NombreFotografo " +
                                       "FROM Asignacion a " +
                                       "JOIN Evento e ON a.evento_id = e.id " +
                                       "JOIN Fotografo f ON a.fotografo_id = f.id " +
                                   "WHERE a.id = @id;";
                cmd.Parameters.AddWithValue("@id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var asignacion = new AsignacionDTO
                    {
                        Id = reader.GetInt32(0),
                        TipoEvento = reader.GetString(1),
                        NombreFotografo = reader.GetString(2)
                    };
                    return asignacion;
                }
                conn.Close();
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
                conn.Close();
                return "Asignación actualizada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<AsignacionDTO> GetByNameFotografo(string nombreFotografo)
        {
            var asignaciones = new List<AsignacionDTO>();

            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText =
                    "SELECT a.id, " +
                    "e.tipo AS TipoEvento, " +
                    "f.nombre AS NombreFotografo " +
                    "FROM Asignacion a " +
                    "JOIN Evento e ON a.evento_id = e.id " +
                    "JOIN Fotografo f ON a.fotografo_id = f.id " +
                    "WHERE f.nombre LIKE @nombreFotografo";

                cmd.Parameters.AddWithValue("@nombreFotografo", $"%{nombreFotografo}%");

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    asignaciones.Add(new AsignacionDTO
                    {
                        Id = reader.GetInt32(0),
                        TipoEvento = reader.GetString(1),
                        NombreFotografo = reader.GetString(2)
                    });
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                return null;
            }

            return asignaciones;
        }
        public List<Asignacion> GetByEventoId(int eventoId)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Asignacion WHERE Evento_id = @Evento_id";
                cmd.Parameters.AddWithValue("@Evento_id", eventoId);
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
                conn.Close();
                return asignaciones;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<AsignacionDTO> GetByFecha(DateTime fecha)
        {
            var asignaciones = new List<AsignacionDTO>();
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText =
                    "SELECT a.id, " +
                    "e.tipo AS TipoEvento, " +
                    "f.nombre AS NombreFotografo " +
                    "FROM Asignacion a " +
                    "JOIN Evento e ON a.evento_id = e.id " +
                    "JOIN Fotografo f ON a.fotografo_id = f.id " +
                    "WHERE CAST(a.fecha AS DATE) = @fecha";
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    asignaciones.Add(new AsignacionDTO
                    {
                        Id = reader.GetInt32(0),
                        TipoEvento = reader.GetString(1),
                        NombreFotografo = reader.GetString(2)
                    });
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            return asignaciones;
        }
    }
}