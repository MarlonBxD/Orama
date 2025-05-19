using Entity;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAL
{
    public class IngresoRepository
    {
        private readonly Conexion _conexion;

        public IngresoRepository()
        {
            _conexion = new Conexion();
        }

        //Agregar, GetAll, GetById Delete, Update
        public string Agregar(Ingreso ingreso)
        {
            try
            {
                if (ingreso == null)
                    throw new ArgumentException("Datos del ingreso no válidos");

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO ingreso (descripcion, monto, fecha, concepto, metodo_pago, cliente_id) VALUES (@descripcion, @monto, @fecha, @concepto, @metodo_pago, @cliente_id)";
                cmd.Parameters.AddWithValue("@descripcion", ingreso.Descripcion);
                cmd.Parameters.AddWithValue("@monto", ingreso.Monto);
                cmd.Parameters.AddWithValue("@fecha", ingreso.Fecha);
                cmd.Parameters.AddWithValue("@concepto", ingreso.Concepto);
                cmd.Parameters.AddWithValue("@metodo_pago", ingreso.MetodoPago);
                cmd.Parameters.AddWithValue("@cliente_Id", ingreso.Cliente.Id);
                cmd.ExecuteNonQuery();
                return "Ingreso agregado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<IngresoDTO> GetAll()
        {
            try
            {
                var ingresos = new List<IngresoDTO>();

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = @"SELECT
                                i.id, i.descripcion, i.monto, i.fecha, i.concepto, i.metodo_pago, i.cliente_id FROM ingresos
                                c.id, c.nombre
                                FROM ingreso i INNER JOIN Cliente c ON i.cliente_id = c.id";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ingresos.Add(new IngresoDTO
                    {
                        Id = reader.GetInt32(0),
                        Descripcion = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Monto = reader.GetDecimal(2),
                        Fecha = reader.GetDateTime(3),
                        Concepto = reader.IsDBNull(4) ? null : reader.GetString(4),
                        MetodoPago = reader.IsDBNull(5) ? null : reader.GetString(5),
                        IdCliente = reader.GetInt32(6),
                        NombreCliente = reader.IsDBNull(7) ? null : reader.GetString(7)
                    });
                }
                return ingresos;
            }
            catch
            {
                throw new Exception("Error al obtener ingresos");
                //throw new DALException("Error al obtener ingresos", ex);
            }
        }

        public Ingreso GetById(int id)
        {
            try
            {
                Ingreso ingreso = null;

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = @"SELECT 
                                i.id, i.descripcion, i.monto, i.fecha, i.concepto, i.metodo_pago, i.cliente_id FROM ingresos
                                c.id, c.nombre, c.apellido, c.telefono, c.email, c.direccion
                                FROM ingreso i
                                INNER JOIN cliente c ON i.cliente_id = c.id
                                WHERE i.Id = @id";

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ingreso = new Ingreso
                    {
                        Id = reader.GetInt32(0),
                        Descripcion = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Monto = reader.GetDecimal(2),
                        Fecha = reader.GetDateTime(3),
                        Concepto = reader.IsDBNull(4) ? null : reader.GetString(4),
                        MetodoPago = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Cliente = new ClienteDTO
                        {
                            Id = reader.GetInt32(6),
                            Nombre = reader.IsDBNull(7) ? null : reader.GetString(7),
                            Apellido = reader.IsDBNull(8) ? null : reader.GetString(8),
                            Telefono = reader.IsDBNull(9) ? null : reader.GetString(9),
                            Email = reader.IsDBNull(10) ? null : reader.GetString(10),
                            Direccion = reader.IsDBNull(11) ? null : reader.GetString(11)
                        }
                    };
                }
                return ingreso;
            }
            catch
            {
                throw new Exception("Error al obtener ingreso");
            }
        }

        public string Update(Ingreso ingreso)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = @"UPDATE ingreso SET 
                            descripcion = @descripcion,
                            monto = @monto,
                            fecha = @fecha,
                            concepto = @concepto,
                            cliente_id = @cliente_id
                            WHERE id = @id";

                cmd.Parameters.AddWithValue("@descripcion", ingreso.Descripcion);
                cmd.Parameters.AddWithValue("@monto", ingreso.Monto);
                cmd.Parameters.AddWithValue("@fecha", ingreso.Fecha);
                cmd.Parameters.AddWithValue("@concepto", ingreso.Concepto);
                cmd.Parameters.AddWithValue("@cliente_id", ingreso.Cliente.Id);
                cmd.Parameters.AddWithValue("@id", ingreso.Id);
                cmd.ExecuteNonQuery();

                return "Ingreso actualizado correctamente";
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

                cmd.CommandText = @"DELETE FROM ingresos WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                return "Ingreso eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
