using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.Interfaces;

namespace DAL
{
    public class VentaRepository : IVentaRepository
    {
        private readonly Conexion _conexion;
        public VentaRepository()
        {
            _conexion = new Conexion();
        }
        public string RegistrarVenta(Venta venta)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var transaction = conn.BeginTransaction();
                try
                {
                    using (var cmdVenta = conn.CreateCommand())
                    {
                        cmdVenta.Transaction = transaction;
                        cmdVenta.CommandText = @"INSERT INTO ventas (fecha, total, cliente_id)
                                                VALUES (@fecha, @total, @cliente_id)
                                                RETURNING id;";
                        cmdVenta.Parameters.AddWithValue("@fecha", venta.Fecha);
                        cmdVenta.Parameters.AddWithValue("@total", venta.Total);
                        cmdVenta.Parameters.AddWithValue("@cliente_id", venta.ClienteId);

                        venta.Id = Convert.ToInt32(cmdVenta.ExecuteScalar());
                    }
                    foreach (var detalle in venta.Detalles)
                    {
                        if (detalle == null)
                            throw new Exception("Uno de los detalles de venta está vacío.");
                        if (detalle.ProductoId <= 0 && detalle.producto == null)
                            throw new Exception("El detalle de venta no tiene producto asignado.");

                        int? productoId = detalle.ProductoId;
                        int? paqueteId = detalle.PaqueteServicio?.Id; 
                        double precioUnitario = detalle.producto?.Precio ?? detalle.PrecioUnitario;

                        using var cmdDetalle = conn.CreateCommand();
                        cmdDetalle.Transaction = transaction;

                        cmdDetalle.CommandText = @"INSERT INTO detalle_venta 
                                                    (venta_id, producto_id, paquete_id, cantidad, descuento, precio_unitario, subtotal)
                                                    VALUES (@venta_id, @producto_id, @paquete_id, @cantidad, @descuento, @precio_unitario, @subtotal);";

                        cmdDetalle.Parameters.AddWithValue("@venta_id", venta.Id);
                        cmdDetalle.Parameters.AddWithValue("@producto_id", productoId);
                        cmdDetalle.Parameters.AddWithValue("@paquete_id", paqueteId.HasValue ? paqueteId.Value : DBNull.Value);
                        cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@descuento", detalle.Descuento);
                        cmdDetalle.Parameters.AddWithValue("@precio_unitario", precioUnitario);
                        cmdDetalle.Parameters.AddWithValue("@subtotal", detalle.Subtotal);

                        cmdDetalle.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return "Venta registrada correctamente";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al registrar la venta en la base de datos: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }
        public List<Venta> ObtenerVentasPorCliente(int clienteId)
        {
            var lista = new List<Venta>();
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT id, cliente_id, fecha, total
                                FROM ventas
                                WHERE cliente_id = @clienteId
                                ORDER BY fecha DESC";
                cmd.Parameters.AddWithValue("@clienteId", clienteId);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Venta
                    {
                        Id = reader.GetInt32(0),
                        Cliente = new Cliente { Id = reader.GetInt32(1) },
                        Fecha = reader.GetDateTime(2),
                        Total = reader.GetDouble(3)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las ventas del cliente", ex);
            }
            return lista;
        }
        public List<Venta> ObtenerVentasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            var lista = new List<Venta>();
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT id, cliente_id, fecha, total
                                FROM ventas
                                WHERE fecha BETWEEN @fechaInicio AND @fechaFin
                                ORDER BY fecha DESC";
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Venta
                    {
                        Id = reader.GetInt32(0),
                        Cliente = new Cliente { Id = reader.GetInt32(1) },
                        Fecha = reader.GetDateTime(2),
                        Total = reader.GetDouble(3)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las ventas por fecha", ex);
            }
            return lista;
        }
        public string EliminarVenta(int ventaId)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var tran = conn.BeginTransaction();
                using var cmd = conn.CreateCommand();
                cmd.Transaction = tran;
                cmd.CommandText = @"DELETE FROM venta_producto WHERE venta_id = @ventaId";
                cmd.Parameters.AddWithValue("@ventaId", ventaId);
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"DELETE FROM venta WHERE id = @ventaId";
                cmd.ExecuteNonQuery();
                tran.Commit();
                return "Venta eliminada correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return $"Error al eliminar la venta: {ex.Message}";
            }
        }

    }
}
