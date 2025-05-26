using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.Dto;

namespace DAL
{
    public class DetalleVentaRepository
    {
        private readonly Conexion _conexion;
        public DetalleVentaRepository()
        {
            _conexion = new Conexion();
        }
        public string Agregar(DetalleVenta detalleVenta)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var tran = conn.BeginTransaction();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Transaction = tran;
                    cmd.CommandText = @"INSERT INTO detalle_venta (venta_id, producto_id, paquete_id , cantidad, precio_unitario, descuento, subtotal)
                                        VALUES (@ventaId, @productoId, @paqueteId , @cantidad, @precio_unitario, @descuento, @subtotal)";
                    cmd.Parameters.AddWithValue("@ventaId", detalleVenta.VentaId);
                    cmd.Parameters.AddWithValue("@productoId", detalleVenta.ProductoId);
                    cmd.Parameters.AddWithValue("@paqueteId", detalleVenta.PaqueteServicio.Id);
                    cmd.Parameters.AddWithValue("@cantidad", detalleVenta.Cantidad);
                    cmd.Parameters.AddWithValue("@precio_unitario", detalleVenta.producto.Precio);
                    cmd.Parameters.AddWithValue("@descuento", detalleVenta.Descuento);
                    cmd.Parameters.AddWithValue("@subtotal", detalleVenta.Subtotal);
                    cmd.ExecuteNonQuery();
                }
                tran.Commit();
                return "Detalle de venta registrado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return $"Error al registrar el detalle de venta: {ex.Message}";
            }
        }
        public List<DetalleVentaDTO> ObtenerDetallesPorVentaId(int ventaId)
        {
            var detalles = new List<DetalleVentaDTO>();
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT 
                                            dv.Id,
                                            dv.VentaId,
                                            dv.ProductoId,
                                            dv.PaqueteServicioId,
                                            dv.Cantidad,
                                            dv.PrecioUnitario,
                                            dv.Descuento,
                                            p.Nombre AS NombreProducto,
                                            ps.Nombre AS NombrePaqueteServicio,
                                            (dv.Cantidad * dv.PrecioUnitario - dv.Descuento) AS Subtotal
                                        FROM DetalleVenta dv
                                        INNER JOIN Producto p ON dv.ProductoId = p.Id
                                        INNER JOIN PaqueteDeServicio ps ON dv.PaqueteServicioId = ps.Id
                                        WHERE dv.VentaId = @ventaId;";
                    cmd.Parameters.AddWithValue("@ventaId", ventaId);
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var detalle = new DetalleVentaDTO
                        {
                            Id = reader.GetInt32(0),
                            VentaId = reader.GetInt32(1),
                            ProductoId = reader.GetInt32(2),
                            PaqueteServicioId = reader.GetInt32(3),
                            Cantidad = reader.GetInt32(4),
                            PrecioUnitario = reader.GetDecimal(5),
                            Descuento = reader.GetInt32(6),
                            NombreProducto = reader.GetString(7),
                            NombrePaqueteServicio = reader.GetString(8),
                            Subtotal = reader.GetDecimal(9)
                        };
                        detalles.Add(detalle);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return detalles;
        }
        public DetalleVentaDTO GetById(int id)
        {
            DetalleVentaDTO detalle = null;
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT 
                                            dv.Id,
                                            dv.VentaId,
                                            dv.ProductoId,
                                            dv.PaqueteServicioId,
                                            dv.Cantidad,
                                            dv.PrecioUnitario,
                                            dv.Descuento,
                                            p.Nombre AS NombreProducto,
                                            ps.Nombre AS NombrePaqueteServicio,
                                            (dv.Cantidad * dv.PrecioUnitario - dv.Descuento) AS Subtotal
                                        FROM DetalleVenta dv
                                        INNER JOIN Producto p ON dv.ProductoId = p.Id
                                        INNER JOIN PaqueteDeServicio ps ON dv.PaqueteServicioId = ps.Id
                                        WHERE dv.Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        detalle = new DetalleVentaDTO
                        {
                            Id = reader.GetInt32(0),
                            VentaId = reader.GetInt32(1),
                            ProductoId = reader.GetInt32(2),
                            PaqueteServicioId = reader.GetInt32(3),
                            Cantidad = reader.GetInt32(4),
                            PrecioUnitario = reader.GetDecimal(5),
                            Descuento = reader.GetInt32(6),
                            NombreProducto = reader.GetString(7),
                            NombrePaqueteServicio = reader.GetString(8),
                            Subtotal = reader.GetDecimal(9)
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❗ Error al obtener el detalle de venta ID {id}: {ex.Message}");
            }
            return detalle;
        }

    }
}
