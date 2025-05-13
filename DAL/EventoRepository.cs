using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Entity;
using Entity.DTO;

namespace DAL
{
    public class EventoRepository
    {
        private readonly Conexion conexion;

        public EventoRepository()
        {
            conexion = new Conexion();
        }

                    

        public void AddEvento(Evento evento)
        {
            try
            {
                conexion.OpenConnection();
                string query = "INSERT INTO evento (tipo, fecha, ubicacion, nombre) VALUES (@tipo, @fecha, @nombre, @ubicacion)";
                using (var command = new NpgsqlCommand(query, conexion.GetConnection()))
                {
                    command.Parameters.AddWithValue("@tipo", evento.Tipo);
                    command.Parameters.AddWithValue("@fecha", evento.Fecha);
                    command.Parameters.AddWithValue("@ubicacion", evento.Ubicacion);
                    command.Parameters.AddWithValue("@nombre", evento.Nombre);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al agregar el evento", ex);
            }
            finally
            {
                conexion.CloseConnection();
            }
        }
        public void UpdateEvento(Evento evento)
        {
            try
            {
                conexion.OpenConnection();
                string query = "UPDATE evento SET tipo = @tipo, fecha = @fecha, ubicacion = @ubicacion WHERE id = @id";
                using (var command = new NpgsqlCommand(query, conexion.GetConnection()))
                {
                    command.Parameters.AddWithValue("@tipo", evento.Tipo);
                    command.Parameters.AddWithValue("@fecha", evento.Fecha);
                    command.Parameters.AddWithValue("@ubicacion", evento.Ubicacion);
                    command.Parameters.AddWithValue("@id", evento.Id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al actualizar el evento", ex);
            }
            finally
            {
                conexion.CloseConnection();
            }
        }
        public void DeleteEvento(Evento evento)
        {
            try
            {
                conexion.OpenConnection();
                string query = "DELETE FROM evento WHERE id = @id";
                using (var command = new NpgsqlCommand(query, conexion.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id", evento.Id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al eliminar el evento", ex);
            }
            finally
            {
                conexion.CloseConnection();
            }
        }

        public Evento GetEventoById(int id)
        {
            Evento evento = null;
            try
            {
                conexion.OpenConnection();
                string query = "SELECT * FROM evento WHERE id = @id";
                using (var command = new NpgsqlCommand(query, conexion.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            evento = new Evento
                            {
                                Tipo = reader.GetString(0),
                                Fecha = reader.GetDateTime(1),
                                Ubicacion = reader.GetString(2),
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener el evento por ID", ex);
            }
            finally
            {
                conexion.CloseConnection();
            }
            return evento;
        }
        public List<Evento> GetEventos()
        {
            List<Evento> eventos = new List<Evento>();
            try
            {
                conexion.OpenConnection();
                string query = "SELECT * FROM evento";
                using (var command = new NpgsqlCommand(query, conexion.GetConnection()))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Evento evento = new Evento
                            {
                                Id = reader.GetInt32(0),
                                Tipo = reader.GetString(1),
                                Fecha = reader.GetDateTime(2),
                                Ubicacion = reader.GetString(3),
                                Nombre = reader.GetString(4),
                            };
                            eventos.Add(evento);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener los eventos", ex);
            }
            finally
            {
                conexion.CloseConnection();
            }
            return eventos;
        }
    }
}
