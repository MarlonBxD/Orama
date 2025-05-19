using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.Dto;

namespace DAL
{
    public class PagoRepository
    {
        private readonly Conexion _conexion;
        public PagoRepository()
        {
            _conexion = new Conexion();
        }
        public string Agregar(Pago pago)
        {
            try
            {
                if (pago == null || pago.Descripcion == null || pago.Monto <= 0)
                    throw new ArgumentException("Datos del pago no válidos");
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Pagos (fecha, Monto, descripcion, metodo_pago, clinete_id)
                            VALUES (@fecha, @Monto, @descripcion, @metodo_pago, @clinete_id)";
                cmd.Parameters.AddWithValue("@fecha", pago.Fecha);
                cmd.Parameters.AddWithValue("@Monto", pago.Monto);
                cmd.Parameters.AddWithValue("@descripcion", pago.Descripcion);
                cmd.Parameters.AddWithValue("@metodo_pago", pago.MetodoPago);
                cmd.Parameters.AddWithValue("@clinete_id", pago.Cliente.Id);
                cmd.ExecuteNonQuery();
                return "Pago agregado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<PagoDto> GetAll()
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT p.id, p.fecha, " +
                                           "p.monto, p.descripcion, " +
                                           "p.metodo_pago, " +
                                           "c.nombre AS nombrecliente " +
                                   "FROM pagos p " +
                                   "JOIN cliente c ON p.cliente_id = c.id";

                using var reader = cmd.ExecuteReader();
                var pagos = new List<PagoDto>();
                while (reader.Read())
                {
                    var pago = new PagoDto
                    {
                        Id = reader.GetInt32(0),
                        Fecha = reader.GetDateTime(1),
                        Monto = reader.GetDecimal(2),
                        Descripcion = reader.GetString(3),
                        MetodoPago = reader.GetString(4),
                        nombreCliente = reader.GetInt32(5)
                    };
                    pagos.Add(pago);
                }
                return pagos;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string Delete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Pagos WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return "Pago eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string updateEstado(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Pagos SET estado = @estado WHERE id = @id";
                cmd.Parameters.AddWithValue("@estado", "Pagado");
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return "Pago actualizado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public PagoDto GetById(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT p.id, p.fecha, p.monto, p.descripcion, p.metodo_pago, " +
                                  "c.nombre AS nombrecliente " +
                                  "FROM pagos p " +
                                  "JOIN cliente c ON p.cliente_id = c.id " +
                                  "WHERE p.id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new PagoDto
                    {
                        Id = reader.GetInt32(0),
                        Fecha = reader.GetDateTime(1),
                        Monto = reader.GetDecimal(2),
                        Descripcion = reader.GetString(3),
                        MetodoPago = reader.GetString(4),
                        nombreCliente = reader.GetString(5)
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<PagoDto> GetByFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT p.id, p.fecha, p.monto, p.descripcion, p.metodo_pago, " +
                                  "c.nombre AS nombrecliente " +
                                  "FROM pagos p " +
                                  "JOIN cliente c ON p.cliente_id = c.id " +
                                  "WHERE p.fecha BETWEEN @fechaInicio AND @fechaFin";

                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                using var reader = cmd.ExecuteReader();
                var pagos = new List<PagoDto>();

                while (reader.Read())
                {
                    pagos.Add(new PagoDto
                    {
                        Id = reader.GetInt32(0),
                        Fecha = reader.GetDateTime(1),
                        Monto = reader.GetDecimal(2),
                        Descripcion = reader.GetString(3),
                        MetodoPago = reader.GetString(4),
                        nombreCliente = reader.GetString(5)
                    });
                }

                return pagos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar pagos por fecha", ex);
            }
        }
        public List<PagoDto> GetByNombreCliente(string nombreCliente)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT p.id, p.fecha, p.monto, p.descripcion, p.metodo_pago, " +
                                  "c.nombre AS nombrecliente " +
                                  "FROM pagos p " +
                                  "JOIN cliente c ON p.cliente_id = c.id " +
                                  "WHERE c.nombre LIKE @nombreCliente";

                cmd.Parameters.AddWithValue("@nombreCliente", "%" + nombreCliente + "%");

                using var reader = cmd.ExecuteReader();
                var pagos = new List<PagoDto>();

                while (reader.Read())
                {
                    pagos.Add(new PagoDto
                    {
                        Id = reader.GetInt32(0),
                        Fecha = reader.GetDateTime(1),
                        Monto = reader.GetDecimal(2),
                        Descripcion = reader.GetString(3),
                        MetodoPago = reader.GetString(4),
                        nombreCliente = reader.GetString(5)
                    });
                }

                return pagos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar pagos por nombre de cliente", ex);
            }
        }




    }
}
