using Entity.Dto;
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

        public string Agregar(PaqueteDeServicio paquete)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO paquetedeservicio (nombre, precio, descripcion, duracion, evento_id)
                                VALUES (@nombre, @precio, @descripcion, @duracion, @evento_id)";
                cmd.Parameters.AddWithValue("@nombre", paquete.Nombre);
                cmd.Parameters.AddWithValue("@precio", paquete.Precio);
                cmd.Parameters.AddWithValue("@descripcion", paquete.Descripcion);
                cmd.Parameters.AddWithValue("@duracion", paquete.DuracionPaquete);
                cmd.Parameters.AddWithValue("@evento_id", paquete.evento.Id);
                cmd.ExecuteNonQuery();

                return "Paquete de servicio agregado correctamente";
            }
            catch (Exception ex)
            {
                throw new AppException("Error al agregar paquete de servicio", ex);
            }
        }

        public List<PaqueteDeServicioDTO> GetAll()
        {
            try
            {
                var paquetes = new List<PaqueteDeServicioDTO>();
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT p.id, p.nombre, p.precio, p.descripcion, p.duracion, e.id, e.tipo
                                FROM paquetedeservicio p
                                LEFT JOIN evento e ON p.evento_id = e.id";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    paquetes.Add(new PaqueteDeServicioDTO
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Precio = reader.GetDouble(2),
                        Descripcion = reader.IsDBNull(3) ? null : reader.GetString(3),
                        DuracionPaquete = reader.GetInt32(4),
                        IdEvento = reader.GetInt32(5),
                        TipoEvento = reader.IsDBNull(6) ? null : reader.GetString(6)
                    });
                }
                return paquetes;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener paquetes", ex);
            }
        }

        public PaqueteDeServicio GetById(int id)
        {
            try
            {
                PaqueteDeServicio paquete = null;
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT p.id, p.nombre, p.precio, p.descripcion, p.duracion, e.id, e.tipo
                                FROM paquetedeservicio p
                                LEFT JOIN evento e ON p.evento_id = e.id
                                WHERE p.id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    paquete = new PaqueteDeServicio
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Precio = reader.GetDouble(2),
                        Descripcion = reader.IsDBNull(3) ? null : reader.GetString(3),
                        DuracionPaquete = reader.GetInt32(4),
                        evento = new EventoDTO
                        {
                            Id = reader.GetInt32(5),
                            Tipo = reader.IsDBNull(6) ? null : reader.GetString(6)
                        }
                    };
                }
                return paquete;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener paquete", ex);
            }
        }

        public string Update(PaqueteDeServicio paquete)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE paquetedeservicio SET
                                nombre = @nombre,
                                precio = @precio,
                                descripcion = @descripcion,
                                duracion = @duracion,
                                evento_id = @evento_id
                                WHERE id = @id";
                cmd.Parameters.AddWithValue("@nombre", paquete.Nombre);
                cmd.Parameters.AddWithValue("@precio", paquete.Precio);
                cmd.Parameters.AddWithValue("@descripcion", paquete.Descripcion);
                cmd.Parameters.AddWithValue("@duracion", paquete.DuracionPaquete);
                cmd.Parameters.AddWithValue("@evento_id", paquete.evento.Id);
                cmd.Parameters.AddWithValue("@id", paquete.Id);
                cmd.ExecuteNonQuery();

                return "Paquete de servicio actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw new AppException("Error al actualizar paquete de servicio", ex);
            }
        }

        public string Delete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM paquetedeservicio WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                return "Paquete de servicio eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw new AppException("Error al eliminar paquete de servicio", ex);
            }
        }

        public List<Producto> ObtenerProductos(int idPaquete)
        {
            try
            {
                List<Producto> productos = new List<Producto>();
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT id, nombre, descripcion, precio, stock FROM producto WHERE paquetedeservicio_id = @id";
                cmd.Parameters.AddWithValue("@id", idPaquete);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2),
                        Precio = reader.GetDecimal(3),
                        stock = reader.GetInt32(4)
                    });
                }
                return productos;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener productos", ex);
            }
        }
    }
}
