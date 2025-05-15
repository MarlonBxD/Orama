using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PaqueteDeServicioRepository
    {
        private readonly Conexion _conexion;

        public PaqueteDeServicioRepository()
        {
            _conexion = new Conexion();
        }

        public void Agregar(PaqueteDeServicio paquete)
        {
            try
            {
                _conexion.OpenConnection();
                using(var command = _conexion.GetConnection().CreateCommand())
                {
                    command.CommandText = "INSERT INTO PaqueteDeServicio (Nombre, Precio, Descripcion, Duracion) VALUES (@Nombre, @Precio, @Descripcion, @Duracion)";
                    command.Parameters.AddWithValue("@Nombre", paquete.Nombre);
                    command.Parameters.AddWithValue("@Precio", paquete.PrecioPaquete);
                    command.Parameters.AddWithValue("@Descripcion", paquete.Descripcion ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Duracion", paquete.DuracionPaquete);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al agregar el paquete de servicio", ex);
            }
            finally
            {
                _conexion.CloseConnection();
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                _conexion.OpenConnection();
                using (var command = _conexion.GetConnection().CreateCommand())
                {
                    command.CommandText = "DELETE FROM PaqueteDeServicio WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al eliminar el paquete de servicio", ex);
            }
            finally
            {
                _conexion.CloseConnection();
            }
        }

        public void Actualizar(PaqueteDeServicio paquete)
        {
            try
            {
                _conexion.OpenConnection();
                using (var command = _conexion.GetConnection().CreateCommand())
                {
                    command.CommandText = "UPDATE PaqueteDeServicio SET Nombre = @Nombre, Precio = @Precio, Descripcion = @Descripcion, Duracion = @Duracion WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", paquete.Id);
                    command.Parameters.AddWithValue("@Nombre", paquete.Nombre);
                    command.Parameters.AddWithValue("@Precio", paquete.PrecioPaquete);
                    command.Parameters.AddWithValue("@Descripcion", paquete.Descripcion ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("Duracion", paquete.DuracionPaquete);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al actualizar el paquete de servicio", ex);
            }
            finally
            {
                _conexion.CloseConnection();
            }
        }

        public List<PaqueteDeServicio> ObtenerTodos()
        {
            List<PaqueteDeServicio> paquetes = new List<PaqueteDeServicio>();
            try
            {
                _conexion.OpenConnection();
                using(var command = _conexion.GetConnection().CreateCommand())
                {
                    command.CommandText = "SELECT Id, Nombre, Precio, Descripcion, Duracion FROM PaqueteDeServicio";
                    using(var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var paquete = new PaqueteDeServicio
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                PrecioPaquete = Convert.ToDouble(reader.GetDecimal(2)),
                                Descripcion = reader.IsDBNull(3) ? null : reader.GetString(3),
                                DuracionPaquete = reader.GetInt32(4)
                            };
                            paquetes.Add(paquete);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener los paquetes de servicio", ex);
            }
            finally
            {
                _conexion.CloseConnection();
            }
            return paquetes;
        }

        public PaqueteDeServicio ObtenerPorId(int id)
        {
            PaqueteDeServicio paquete = null;
            try
            {
                _conexion.OpenConnection();
                using (var command = _conexion.GetConnection().CreateCommand())
                {
                    command.CommandText = "SELECT Id, Nombre, Precio, Descripcion, Duracion FROM PaqueteDeServicio WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    using(var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            paquete = new PaqueteDeServicio
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                PrecioPaquete = Convert.ToDouble(reader.GetDecimal(2)),
                                Descripcion = reader.IsDBNull(3) ? null : reader.GetString(3),
                                DuracionPaquete = reader.GetInt32(4)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener el paquete de servicio por ID", ex);
            }
            finally
            {
                _conexion.CloseConnection();
            }
            return paquete;
        }
    }
}
