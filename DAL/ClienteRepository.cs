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
    public class CLienteRepository
    {
        private readonly Conexion _conexion;
        public CLienteRepository()
        {
            _conexion = new Conexion();
        }
        public string Agregar(Cliente cliente)
        {
            try
            {
                if (cliente == null || string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrEmpty(cliente.Telefono))
                    throw new ArgumentException("Datos del cliente no válidos");
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO cliente (nombre, apellido, telefono, email, direccion)
                            VALUES (@Nombre, @Apellido, @Telefono, @Email, @Direccion)";
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.ExecuteNonQuery();

                return "Cliente agregado correctamente";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar cliente", ex);
            }
        }
        public List<Cliente> GetAll()
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT id, nombre, apellido, telefono, email, direccion FROM cliente";
                using var reader = cmd.ExecuteReader();
                var clientes = new List<Cliente>();
                while (reader.Read())
                {
                    var cliente = new Cliente
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Telefono = reader.GetString(3),
                        Email = reader.GetString(4),
                        Direccion = reader.GetString(5)
                    };
                    clientes.Add(cliente);
                    
                }

                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clintes", ex);
            }
        }
        public Cliente GetById(int id)
        {
            try
            {
                Cliente cliente = null;

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT id, nombre, apellido, telefono, email, direccion FROM cliente WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cliente = new Cliente
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Telefono = reader.GetString(3),
                        Email = reader.GetString(4),
                        Direccion = reader.GetString(5)
                    };
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cliente", ex);
            }
        }
        public string Delete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = "DELETE FROM cliente WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id); 

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                    return "No se encontró ningún cliente con ese ID.";

                return "Cliente eliminado correctamente.";
            }
            catch (PostgresException pgEx) when (pgEx.SqlState == "23503")
            {
                // Clave foránea impide eliminar
                return "No se puede eliminar el cliente porque tiene reservas asociadas.";
            }
            catch (Exception ex)
            {
                throw new AppException($"Error al eliminar cliente: {ex.Message}");
            }
        }
        public string Update(Cliente cliente)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE cliente SET nombre = @nombre, apellido = @apellido, telefono = @telefono, email = @email, direccion = @direccion WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", cliente.Id);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.ExecuteNonQuery();

                return "Cliente actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar cliente {ex.Message}" );
            }
        }
        public List<PagoDto> ObtenerPagos(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = @"SELECT 
                                        p.id, 
                                        p.fecha, 
                                        p.monto, 
                                        p.descripcion, 
                                        p.metodo_pago,
                                        c.nombre
                                    FROM pagos p
                                    JOIN cliente c ON c.id = p.cliente_id
                                    WHERE p.cliente_id = @cliente_id";

                cmd.Parameters.AddWithValue("@cliente_id", id);

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
                        nombreCliente = reader.GetString(5)
                    };
                    pagos.Add(pago);
                }

                return pagos;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener pagos", ex);
            }
        }
        public List<Reserva> ObtenerReservas(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT
                                        r.id AS reserva_id,
                                        r.fecha_evento,
                                        r.fecha_reserva,
                                        r.estado,
                                        r.observaciones,
    
                                        p.id AS paquete_id,
                                        p.nombre AS paquete_nombre,
    
                                        c.id AS cliente_id,
                                        c.nombre AS cliente_nombre
                                    FROM reserva r
                                    LEFT JOIN paquetedeservicio p ON r.paqueteservicio_id = p.id
                                    LEFT JOIN cliente c ON r.cliente_id = c.id
                                    WHERE r.cliente_id = @cliente_id;";
                cmd.Parameters.AddWithValue("@cliente_id", id);
                using var reader = cmd.ExecuteReader();
                var reservas = new List<Reserva>();
                while (reader.Read())
                {
                    var reserva = new Reserva
                    {
                        Id = reader.GetInt32(0),
                        FechaEvento = reader.GetDateTime(1),
                        FechaReserva = reader.GetDateTime(2),
                        EstadoReserva = reader.GetString(3),
                        Observaciones = reader.GetString(4),
                        PaqueteDeServicio = new PaqueteDeServicioDTO
                        {
                            Id = reader.GetInt32(5),
                            Nombre = reader.GetString(6)
                        },
                        Cliente = new Cliente
                        {
                            Id = reader.GetInt32(7),
                            Nombre = reader.GetString(8)
                        }
                    };
                    reservas.Add(reserva);
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener reservas", ex);
            }
        }
        public List<Despacho> ObtenerDespachos(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT
                                    d.id, d.fechadespacho, d.estado, d.numero_paquetes,
                                    p.id, p.nombre,
                                    m.id, m.nombre,
                                    c.id, c.nombre
                                    FROM despacho d
                                    LEFT JOIN paquetedeservicio p ON d.paquete_servicio_id = p.id
                                    LEFT JOIN mensajero m ON d.mensajero_id = m.id
                                    LEFT JOIN cliente c ON d.cliente_id = c.id
                                    WHERE d.cliente_id = @cliente_id";

                cmd.Parameters.AddWithValue("@cliente_id", id);
                using var reader = cmd.ExecuteReader();
                var despachos = new List<Despacho>();
                while (reader.Read())
                {
                    var despacho = new Despacho
                    {
                        Id = reader.GetInt32(0),
                        FechaDespacho = reader.GetDateTime(1),
                        Estado = reader.IsDBNull(2) ? null : reader.GetString(2),
                        NumeroPaquetes = reader.GetInt32(3),
                        PaqueteDeServicio = new PaqueteDeServicio
                        {
                            Id = reader.GetInt32(4),
                            Nombre = reader.IsDBNull(5) ? null : reader.GetString(5)
                        },
                        Mensajero = new Mensajero
                        {
                            Id = reader.GetInt32(6),
                            Nombre = reader.IsDBNull(7) ? null : reader.GetString(7)
                        },
                        Cliente = new Cliente
                        {
                            Id = reader.GetInt32(8),
                            Nombre = reader.IsDBNull(9) ? null : reader.GetString(9)
                        }
                    };
                }
                return despachos;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener despachos", ex);
            }
        }
        public ClienteDTO GetByTelefono(string telefono)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT id, nombre, apellido, telefono, email, direccion
                                    FROM cliente
                                    WHERE telefono = @telefono";
                cmd.Parameters.AddWithValue("@telefono", telefono);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var cliente = new ClienteDTO
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Telefono = reader.GetString(3),
                        Email = reader.GetString(4),
                        Direccion = reader.GetString(5)
                    };
                    return cliente;
                }

                return null; 
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener cliente por teléfono", ex);
            }
        }





    }
}
