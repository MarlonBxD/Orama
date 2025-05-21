using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.Dto;

namespace DAL
{
    public class DespachoRepository
    {
        private readonly Conexion _conexion;

        public DespachoRepository()
        {
            _conexion = new Conexion();
        }

        public string Agregar(Despacho despacho)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = @"INSERT INTO despacho (fechadespacho, estado, numero_paquetes, 
                                                      paquetedeservicio_id, cliente_id, mensajero_id)
                                VALUES (@fechadespacho, @estado, @numeropaquetes, 
                                        @paquetedeservicio_id, @cliente_id, @mensajero_id)";

                cmd.Parameters.AddWithValue("@fechadespacho", despacho.FechaDespacho);
                cmd.Parameters.AddWithValue("@estado", despacho.Estado);
                cmd.Parameters.AddWithValue("@numeropaquetes", despacho.NumeroPaquetes);
                cmd.Parameters.AddWithValue("@paquetedeservicio_id", despacho.PaqueteDeServicio.Id);
                cmd.Parameters.AddWithValue("@cliente_id", despacho.Cliente.Id);
                cmd.Parameters.AddWithValue("@mensajero_id", despacho.Mensajero.Id);

                cmd.ExecuteNonQuery();

                return "Despacho agregado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<DespachoDTO> GetAll()
        {
            var despachos = new List<DespachoDTO>();

            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = @"SELECT 
                            d.id, d.fechadespacho, d.estado, d.numero_paquetes,
                            p.nombre AS nombre_paquete,
                            c.nombre AS nombre_cliente,
                            m.nombre AS nombre_mensajero
                            FROM despacho d
                            LEFT JOIN paquetedeservicio p ON d.paquetedeservicio_id = p.id
                            LEFT JOIN cliente c ON d.cliente_id = c.id
                            LEFT JOIN mensajero m ON d.mensajero_id = m.id";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    despachos.Add(new DespachoDTO
                    {
                        Id = reader.GetInt32(0),
                        FechaDespacho = reader.GetDateTime(1),
                        Estado = reader.GetString(2),
                        NumeroPaquetes = reader.GetInt32(3),
                        NombrePaquete = reader.IsDBNull(4) ? null : reader.GetString(4),
                        NombreCliente = reader.IsDBNull(5) ? null : reader.GetString(5),
                        NombreMensajero = reader.IsDBNull(6) ? null : reader.GetString(6)
                    });
                }

                return despachos;
            }
            catch
            {
                return null;
            }
        }


        public Despacho GetById(int id)
        {
            try
            {
                Despacho despacho = null;

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = @"SELECT 
                                d.id, d.fechadespacho, d.estado, d.numero_paquetes,
                                p.id, p.nombre,
                                c.id, c.nombre,
                                m.id, m.nombre
                                FROM despacho d
                                LEFT JOIN paquetedeservicio p ON d.paquetedeservicio_id = p.id
                                LEFT JOIN cliente c ON d.cliente_id = c.id
                                LEFT JOIN mensajero m ON d.mensajero_id = m.id
                                WHERE d.id = @id";

                cmd.Parameters.AddWithValue("@id", id);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    despacho = new Despacho
                    {
                        Id = reader.GetInt32(0),
                        FechaDespacho = reader.GetDateTime(1),
                        Estado = reader.GetString(2),
                        NumeroPaquetes = reader.GetInt32(3),
                        PaqueteDeServicio = new PaqueteDeServicioDTO
                        {
                            Id = reader.GetInt32(4),
                            Nombre = reader.GetString(5)
                        },
                        Cliente = new ClienteDTO
                        {
                            Id = reader.GetInt32(6),
                            Nombre = reader.GetString(7)
                        },
                        Mensajero = new MensajeroDTO
                        {
                            Id = reader.GetInt32(8),
                            Nombre = reader.GetString(9)
                        }
                    };
                }

                return despacho;
            }
            catch
            {
                return null;
            }
        }

        public string Update(Despacho despacho)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();

                cmd.CommandText = @"UPDATE despacho SET 
                                fechadespacho = @fechadespacho,
                                estado = @estado,
                                numero_paquetes = @numeropaquetes,
                                paquetedeservicio_id = @paquetedeservicio_id,
                                cliente_id = @cliente_id,
                                mensajero_id = @mensajero_id
                                WHERE id = @id";

                cmd.Parameters.AddWithValue("@fechadespacho", despacho.FechaDespacho);
                cmd.Parameters.AddWithValue("@estado", despacho.Estado);
                cmd.Parameters.AddWithValue("@numeropaquetes", despacho.NumeroPaquetes);
                cmd.Parameters.AddWithValue("@paquetedeservicio_id", despacho.PaqueteDeServicio.Id);
                cmd.Parameters.AddWithValue("@cliente_id", despacho.Cliente.Id);
                cmd.Parameters.AddWithValue("@mensajero_id", despacho.Mensajero.Id);
                cmd.Parameters.AddWithValue("@id", despacho.Id);

                cmd.ExecuteNonQuery();

                return "Despacho actualizado correctamente";
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

                cmd.CommandText = @"DELETE FROM despacho WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                return "Despacho eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
