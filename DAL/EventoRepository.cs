using Entity;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EventoRepository
    {
        private readonly Conexion _conexion;

        public EventoRepository()
        {
            _conexion = new Conexion();
        }

        public string Agregar(Evento evento)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO evento (tipo, fecha, ubicacion, reserva_id) VALUES (@tipo, @fecha, @ubicacion, @reserva_id)";
                cmd.Parameters.AddWithValue("@tipo", evento.Tipo);
                cmd.Parameters.AddWithValue("@fecha", evento.Fecha);
                cmd.Parameters.AddWithValue("@ubicacion", evento.Ubicacion);
                cmd.Parameters.AddWithValue("@reserva_id", evento.Reserva.Id);

                cmd.ExecuteNonQuery();

                return "Evento agregado correctamente";
            }
            catch (Exception ex)
            {
                throw new AppException("Error al agregar evento", ex);
            }
        }

        public List<EventoDTO> GetAll()
        {
            try
            {
                var eventos = new List<EventoDTO>();

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT id, tipo, fecha, ubicacion, reserva_id, bebe_id FROM evento";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var evento = new EventoDTO
                    {
                        Id = reader.GetInt32(0),
                        Tipo = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Fecha = reader.GetDateTime(2),
                        Ubicacion = reader.IsDBNull(3) ? null : reader.GetString(3),
                        IdReserva = reader.GetInt32(4),
                        IdBebe = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5)
                    };
                    eventos.Add(evento);
                }
                return eventos;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener eventos", ex);
            }
        }

        public Evento GetById(int id)
        {
            try
            {
                Evento evento = null;

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT id, tipo, fecha, ubicacion, reserva_id, bebe_id FROM evento WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    evento = new Evento
                    {
                        Id = reader.GetInt32(0),
                        Tipo = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Fecha = reader.GetDateTime(2),
                        Ubicacion = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Reserva = new Reserva { Id = reader.GetInt32(4) },
                        Bebe = reader.IsDBNull(5) ? null : new Bebe { Id = reader.GetInt32(5) }
                    };
                }
                return evento;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener evento", ex);
            }
        }

        public string Update(Evento evento)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE evento
                                    SET
                                    tipo = @tipo
                                    fecha = @fecha
                                    ubicacion = @ubicacion
                                    reserva_id = @reserva_id
                                    bebe_id = @bebe_id
                                    WHERE id = @id";

                cmd.Parameters.AddWithValue("@tipo", evento.Tipo);
                cmd.Parameters.AddWithValue("@fecha", evento.Fecha);
                cmd.Parameters.AddWithValue("@ubicacion", evento.Ubicacion);
                cmd.Parameters.AddWithValue("@reserva_id", evento.Reserva.Id);
                cmd.Parameters.AddWithValue("@bebe_id", (object?)evento.Bebe?.Id ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id", evento.Id);

                cmd.ExecuteNonQuery();

                return "Evento actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw new AppException("Error al actualizar evento", ex);
            }
        }

        public string Delete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM evento WHERE id = @id";

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                return "Evento eliminado correctamene";
            }
            catch (Exception ex)
            {
                throw new AppException("Error al eliminar evento", ex);
            }
        }

        public List<PaqueteDeServicioDTO> ObtenerPaquetes(int id)
        {
            try
            {
                var paquetes = new List<PaqueteDeServicioDTO>();

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT id, nombre FROM paquetedeservicio WHERE evento_id = @evento_id";

                cmd.Parameters.AddWithValue("@evento_id", id);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var paquete = new PaqueteDeServicioDTO
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.IsDBNull(1) ? null : reader.GetString(1)
                    };
                    paquetes.Add(paquete);
                }
                return paquetes;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener paquetes", ex);
            }
        }

        //Pendiente reconstruir entidad Fotografo
        //public List<Fotografo> ObtenerFotografos(int id)
        //{
        //    try
        //    {
        //        var fotografos = new List<Fotografo>();

        //        using var conn = _conexion.GetConnection();
        //        conn.Open();
        //        using var cmd = conn.CreateCommand();
        //        cmd.CommandText = "SELECT id, nombre FROM paquetedeservicio WHERE evento_id = @evento_id";
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
    }
}
