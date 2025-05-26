using Entity;
using Entity.Dto;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservaRepository
    {
        private readonly Conexion _conexion;

        public ReservaRepository()
        {
            _conexion = new Conexion();
        }

        public string Agregar(Reserva reserva)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO reserva (id, fecha_evento, fecha_reserva, estado, observaciones, cliente_id, evento_id, paqueteservicio_id)
                                    VALUES (@id, @fecha_evento, @fecha_reserva, @estado, @observaciones, @cliente_id, @evento_id, @paqueteservicio_id)";
                cmd.Parameters.AddWithValue("@id", reserva.Id);
                cmd.Parameters.AddWithValue("@fecha_evento", reserva.FechaEvento);
                cmd.Parameters.AddWithValue("@fecha_reserva", reserva.FechaReserva);
                cmd.Parameters.AddWithValue("@estado", reserva.EstadoReserva);
                cmd.Parameters.AddWithValue("@observaciones", reserva.Observaciones);
                cmd.Parameters.AddWithValue("@cliente_id", reserva.Cliente.Id);
                cmd.Parameters.AddWithValue("@evento_id", reserva.Evento.Id);
                cmd.Parameters.AddWithValue("@paqueteservicio_id", reserva.PaqueteDeServicio.Id);
                cmd.ExecuteNonQuery();

                return "Reserva agregada correctamente";
            }
            catch (Npgsql.NpgsqlException ex)
            {
                throw new NpgsqlException("Error al agregar reserva", ex);
            }
        }

        public List<ReservaDTO> GetAll()
        {
            try
            {
                var reservas = new List<ReservaDTO>();

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = @"SELECT
                                r.id, r.fecha_evento, r.fecha_reserva, r.estado, r.observaciones,
                                c.id, c.nombre,
                                e.id, e.tipo,
                                p.id, p.nombre
                                FROM reserva r
                                LEFT JOIN cliente c ON r.cliente_id = c.id
                                LEFT JOIN evento e ON r.evento_id = e.id
                                LEFT JOIN paquetedeservicio p ON r.paqueteservicio_id = p.id";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reservas.Add(new ReservaDTO
                    {
                        Id = reader.GetInt32(0),
                        FechaEvento = reader.GetDateTime(1),
                        FechaReserva = reader.GetDateTime(2),
                        EstadoReserva = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Observaciones = reader.IsDBNull(4) ? null : reader.GetString(4),
                        IdCliente = reader.GetInt32(5),
                        NombreCliente = reader.IsDBNull(6) ? null : reader.GetString(6),
                        IdEvento = reader.GetInt32(7),
                        TipoEvento = reader.IsDBNull(8) ? null : reader.GetString(8),
                        IdPaqueteDeServicio = reader.GetInt32(9),
                        NombrePaqueteDeServicio = reader.IsDBNull(10) ? null : reader.GetString(10)
                    });
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener reservas", ex);
            }
        }

        public Reserva GetById(int id)
        {
            try
            {
                Reserva reserva = null;

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT
                                    r.id, r.fecha_reserva, r.fecha_evento, r.estado, r.observaciones
                                    c.id, c.nombre
                                    e.id, e.tipo,
                                    p.id, p.nombre
                                    FROM reserva r
                                    LEFT JOIN cliente c ON r.cliente_id = c.id
                                    LEFT JOIN evento e ON r.evento_id = e.id
                                    LEFT JOIN paquetedeservicio p ON r.paqueteservicio_id = p.id
                                    WHERE r.id = @id";

                cmd.Parameters.AddWithValue("@id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reserva = new Reserva
                    {
                        Id = reader.GetInt32(0),
                        FechaReserva = reader.GetDateTime(1),
                        FechaEvento = reader.GetDateTime(2),
                        EstadoReserva = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Observaciones = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Cliente = new ClienteDTO
                        {
                            Id = reader.GetInt32(5),
                            Nombre = reader.IsDBNull(6) ? null : reader.GetString(6)
                        },
                        Evento = new EventoDTO
                        {
                            Id = reader.GetInt32(7),
                            Tipo = reader.IsDBNull(8) ? null : reader.GetString(8)
                        },
                        PaqueteDeServicio = new PaqueteDeServicioDTO
                        {
                            Id = reader.GetInt32(9),
                            Nombre = reader.IsDBNull(10) ? null : reader.GetString(10)
                        }
                    };
                }
                return reserva;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener reserva", ex);
            }
        }

        public string Update(Reserva reserva)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE reserva SET 
                                    fecha_evento = @fecha_evento,
                                    fecha_reserva = @fecha_reserva, 
                                    estado = @estado, 
                                    observaciones = @observaciones,
                                    cliente_id = @cliente_id, 
                                    evento_id = @evento_id, 
                                    paqueteservicio_id = @paqueteservicio_id
                                    WHERE id = @id";
                
                cmd.Parameters.AddWithValue("@fecha_evento", reserva.FechaEvento);
                cmd.Parameters.AddWithValue("@fecha_reserva", reserva.FechaReserva);
                cmd.Parameters.AddWithValue("@estado", reserva.EstadoReserva);
                cmd.Parameters.AddWithValue("@observaciones", reserva.Observaciones);
                cmd.Parameters.AddWithValue("@cliente_id", reserva.Cliente.Id);
                cmd.Parameters.AddWithValue("@evento_id", reserva.Evento.Id);
                cmd.Parameters.AddWithValue("@paqueteservicio_id", reserva.PaqueteDeServicio.Id);
                cmd.Parameters.AddWithValue("@id", reserva.Id);
                cmd.ExecuteNonQuery();

                return "Reserva actualizada correctamente";
            }
            catch (Exception ex)
            {
                throw new AppException("Error al actualizar reserva", ex);
            }
        }

        public string Delete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM reserva WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                return "Reserva eliminada correctamente";
            }
            catch (Exception ex)
            {
                throw new AppException("Error al eliminar reserva", ex);
            }
        }

        public List<EventoDTO> ObtenerEventos(int id)
        {
            try
            {
                List<EventoDTO> eventos = new List<EventoDTO>();

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT id, tipo, fecha, ubicacion FROM evento WHERE reserva_id = @reserva_id";
                cmd.Parameters.AddWithValue("@reserva_id", id);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var evento = new EventoDTO
                    {
                        Id = reader.GetInt32(0),
                        Tipo = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Fecha = reader.GetDateTime(2),
                        Ubicacion = reader.IsDBNull(3) ? null : reader.GetString(3)
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
        public List<Reserva> GetByClienteId(int clienteId)
        {
            try
            {
                var reservas = new List<Reserva>();
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT
                                r.id, r.fecha_evento, r.fecha_reserva, r.estado, r.observaciones,
                                c.id, c.nombre,
                                e.id, e.tipo,
                                p.id, p.nombre
                                FROM reserva r
                                LEFT JOIN cliente c ON r.cliente_id = c.id
                                LEFT JOIN evento e ON r.evento_id = e.id
                                LEFT JOIN paquetedeservicio p ON r.paqueteservicio_id = p.id
                                WHERE c.id = @clienteId";
                cmd.Parameters.AddWithValue("@clienteId", clienteId);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reservas.Add(new Reserva
                    {
                        Id = reader.GetInt32(0),
                        FechaEvento = reader.GetDateTime(1),
                        FechaReserva = reader.GetDateTime(2),
                        EstadoReserva = reader.GetString(4),
                        Cliente = new ClienteDTO
                        {
                            Id = reader.GetInt32(5),
                            Nombre = reader.GetString(6)
                        },
                        Evento = new EventoDTO
                        {
                            Id = reader.GetInt32(7),
                            Tipo = reader.GetString(8)
                        },
                        PaqueteDeServicio = new PaqueteDeServicioDTO
                        {
                            Id = reader.GetInt32(9),
                            Nombre = reader.GetString(10)
                        }
                    });
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener reservas por cliente", ex);
            }
        }
    }
}
