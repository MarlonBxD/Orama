using Entity;
using Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly Conexion _conexion;
        public ProductoRepository()
        {
            _conexion = new Conexion();
        }
        public string Agregar(Producto producto)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Productos (Nombre, Precio, Descripcion, stock)
                        VALUES (@Nombre, @Precio, @Descripcion, @stock)";
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@stock", producto.stock);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Producto agregado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public string Delete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Producto WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Producto eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Producto> GetAll()
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Producto";
                using var reader = cmd.ExecuteReader();
                var productos = new List<Producto>();
                while (reader.Read())
                {
                    var producto = new Producto
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Precio = reader.GetDouble(2),
                        Descripcion = reader.GetString(3),
                        stock = reader.GetInt32(5)
                    };
                    productos.Add(producto);
                }
                conn.Close();
                return productos;
            }
            catch (AppException ex)
            {
                return null;
            }

        }
        public string Update(int id, string nombre)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = @"UPDATE producto SET nombre = @Nombre WHERE id = @Id";
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();

                return "Producto actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw new AppException("Error al actualizar el producto", ex);
            }
        }
        public Producto ObtenerPorId(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection(); // 🔁 nueva conexión
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT id, nombre, precio, descripcion, stock FROM productos WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Producto
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                        Precio = reader.GetDouble(reader.GetOrdinal("precio")),
                        Descripcion = reader.GetString(reader.GetOrdinal("descripcion")),
                        stock = reader.GetInt32(reader.GetOrdinal("stock"))
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"❌ Error al obtener el producto por ID (repo): {ex.Message}", ex);
            }
        }



        public string ActualizarStock(int id, int nuevoStock)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Producto SET stock = @nuevoStock WHERE id = @id";
                cmd.Parameters.AddWithValue("@nuevoStock", nuevoStock);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return "Stock actualizado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
