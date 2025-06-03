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
    public class PaqueteDeServicioRepository
    {
        private readonly Conexion _conexion;
        private readonly ProductoRepository productoRepository;

        public PaqueteDeServicioRepository()
        {
            _conexion = new Conexion();
            productoRepository = new ProductoRepository();
        }

        public string Agregar(PaqueteDeServicio paquete)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var tran = conn.BeginTransaction();

                int paqueteId;
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Transaction = tran;
                    cmd.CommandText = @"INSERT INTO paquetedeservicio (nombre, precio, descripcion, duracion)
                                VALUES (@nombre, @precio, @descripcion, @duracion)
                                RETURNING id";
                    cmd.Parameters.AddWithValue("@nombre", paquete.Nombre);
                    cmd.Parameters.AddWithValue("@precio", paquete.Precio);
                    cmd.Parameters.AddWithValue("@descripcion", paquete.Descripcion);
                    cmd.Parameters.AddWithValue("@duracion", paquete.DuracionPaquete);
                    paqueteId = Convert.ToInt32(cmd.ExecuteScalar());
                }
                foreach (var item in paquete.productos)
                {
                    using var cmd = conn.CreateCommand();
                    cmd.Transaction = tran;
                    cmd.CommandText = @"INSERT INTO paquete_producto (id_paquete, id_producto, cantidad_producto)
                                VALUES (@paqueteId, @productoId, @cantidad)";
                    cmd.Parameters.AddWithValue("@paqueteId", paqueteId);
                    cmd.Parameters.AddWithValue("@productoId", item.Id);
                    cmd.Parameters.AddWithValue("@cantidad", item.stock);
                    cmd.ExecuteNonQuery();
                }

                tran.Commit();
                return $"✅ Paquete de servicio agregado correctamente con ID {paqueteId}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return $"Error al agregar paquete de servicio  {ex.Message}";
            }
        }
        public List<PaqueteDeServicio> GetAll()
        {
            try
            {
                var paquetes = new List<PaqueteDeServicio>();
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT id, nombre, precio, descripcion, duracion
                                FROM paquetedeservicio";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    paquetes.Add(new PaqueteDeServicio
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Precio = reader.GetDouble(2),
                        Descripcion = reader.GetString(3),
                        DuracionPaquete = reader.GetInt32(4)
                    });
                }
                return paquetes;
            }
            catch (Exception ex)
            {
                throw new AppException($"Error al obtener paquetes {ex.Message}");
            }
        }
        public List<PaqueteDeServicioDTO> GetAllDTO()
        {
            try
            {
                var paquetes = new List<PaqueteDeServicioDTO>();
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"
            SELECT id, nombre, precio, descripcion, duracion
            FROM paquetedeservicio";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    paquetes.Add(new PaqueteDeServicioDTO
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Precio = reader.GetDouble(2),
                        Descripcion = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        DuracionPaquete = reader.GetString(4)
                    });
                }
                return paquetes;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener paquetes {ex.Message}");
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
        public void DeleteProductosPaquete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM paquete_producto WHERE id_paquete = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new AppException("Error al eliminar productos del paquete", ex);
            }
        }
        public int stock_paquetes(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE stock FROM paquetedeservicio WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery(); 
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return Convert.ToInt32(reader["stock"]);
                }
                else
                {
                    throw new Exception($"Paquete con ID {id} no encontrado.");
                }
            }
            catch (Exception ex)
            {
                throw new AppException("Error al eliminar paquete de servicio", ex);
            }
        }
        public PaqueteDeServicioDTO GetById(int paqueteId)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT 
                                        p.id AS paquete_id,
                                        p.nombre AS paquete_nombre,
                                        p.precio AS paquete_precio,
                                        p.descripcion,
                                        p.duracion,

                                        pr.id AS producto_id,
                                        pr.nombre AS producto_nombre,
                                        pr.precio AS producto_precio,

                                        pp.cantidad_producto
                                    FROM paquetedeservicio p
                                    JOIN paquete_producto pp ON p.id = pp.id_paquete
                                    JOIN producto pr ON pp.id_producto = pr.id
                                    WHERE p.id = @paqueteId;";

                cmd.Parameters.AddWithValue("@paqueteId", paqueteId);

                using var reader = cmd.ExecuteReader();
                var paquete = new PaqueteDeServicioDTO();

                while (reader.Read())
                {
                    if (paquete == null)
                    {
                        paquete = new PaqueteDeServicioDTO
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Precio = reader.GetDouble(2),
                            Descripcion = reader.GetString(3),
                            DuracionPaquete = reader.GetString(4),
                            productos = new List<Producto>()
                        };
                    }

                    var producto = new Producto
                    {
                        Id = reader.GetInt32(5),
                        Nombre = reader.GetString(6),
                        Precio = reader.GetDouble(7)
                    };

                    paquete.productos.Add(producto);
                }

                return paquete;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener paquete con productos", ex);
            }
        }
        public void Descontar_productos(PaqueteDeServicio paquete)
        {
            foreach (var item in paquete.productos)
            {
                var stockActual = productoRepository.ObtenerStock(item.Id);
                var nuevoStock = stockActual - item.stock;
                productoRepository.ActualizarStock(item.Id, nuevoStock);
            }
        }
        public void ActualizarStock(int id, int nuevoStock)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE PaqueteDeServicio
                                    SET stock = @nuevoStock
                                    WHERE id = @id";

                cmd.Parameters.AddWithValue("@nuevoStock", nuevoStock);
                cmd.Parameters.AddWithValue("@id", id);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    throw new Exception($"❌ No se encontró el paquete con ID {id} para actualizar stock.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"❌ Error al actualizar el stock del paquete (ID {id}): {ex.Message}", ex);
            }
        }
        public void Descontar_stock(PaqueteDeServicio? paqueteservi)
        {
            try
            {
                var paquetes = GetById(paqueteservi.Id);
                if (paquetes == null)
                {
                    throw new Exception("Paquete no encontrado");
                }
                var stockActual = stock_paquetes(paqueteservi.Id);
                var nuevoStock = stockActual - paqueteservi.stock;
                ActualizarStock(paqueteservi.Id, nuevoStock);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al descontar stock de productos del paquete", ex);
            }
        }

        public List<(int ProductoId, int Cantidad)> ObtenerProductosPorPaquete(int paqueteId)
        {
            var lista = new List<(int, int)>();

            using var conn = _conexion.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
            SELECT id_producto, cantidad_producto 
            FROM paquete_producto 
            WHERE id_paquete = @id";
            cmd.Parameters.AddWithValue("@id", paqueteId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int productoId = reader.GetInt32(0);
                int cantidad = reader.GetInt32(1);
                lista.Add((productoId, cantidad));
            }

            return lista;
        }


    }
}
