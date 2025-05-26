using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.Interfaces;

namespace DAL
{
    public class MovimientoInventarioRepository : IMovimientoInventarioRepository
    {
        private readonly Conexion _conexion;
        public MovimientoInventarioRepository()
        {
            _conexion = new Conexion();
        }


        public void RegistrarMovimiento(MovimientoInventario movimiento)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO movimiento_inventario (producto_id, fecha, tipo, cantidad, descripcion)
                                VALUES (@productoId, @fecha, @tipoMovimiento, @cantidad, @descripcion)";
                cmd.Parameters.AddWithValue("@productoId", movimiento.ProductoId);
                cmd.Parameters.AddWithValue("@fecha", movimiento.Fecha);
                cmd.Parameters.AddWithValue("@tipoMovimiento", movimiento.TipoMovimiento);
                cmd.Parameters.AddWithValue("@cantidad", movimiento.Cantidad);
                cmd.Parameters.AddWithValue("@descripcion", movimiento.Motivo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar movimiento al inventario {ex.Message}");
            }
        }

        public List<MovimientoInventario> ObtenerPorProducto(int productoId)
        {
            var lista = new List<MovimientoInventario>();

            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = @"SELECT id, producto_id, fecha, tipo_movimiento, cantidad, descripcion
                                FROM movimiento_inventario
                                WHERE producto_id = @productoId
                                ORDER BY fecha DESC";

                cmd.Parameters.AddWithValue("@productoId", productoId);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new MovimientoInventario
                    {
                        Id = reader.GetInt32(0),
                        ProductoId = reader.GetInt32(1),
                        Fecha = reader.GetDateTime(2),
                        TipoMovimiento = reader.GetString(3),
                        Cantidad = reader.GetInt32(4),
                        Motivo = reader.GetString(5)
                    });
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener movimientos del inventario", ex);
            }
        }
    }
}
