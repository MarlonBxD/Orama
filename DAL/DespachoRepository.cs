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
        public void AgregarDespacho(Despacho despacho)
        {
            if (despacho == null || despacho.NumeroPaquetes <= 0)
                throw new ArgumentException("Datos del despacho no válidos");

            using var conn = _conexion.GetConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                INSERT INTO Despacho (Fecha_Despacho, Estado, Cliente_Id, Mensajero_Id, Numero_Paquetes)
                VALUES (@FechaDespacho, @Estado, @ClienteId, @MensajeroId, @NumeroPaquetes)";

            cmd.Parameters.AddWithValue("@FechaDespacho", despacho.FechaDespacho);
            cmd.Parameters.AddWithValue("@Estado", despacho.Estado);
            cmd.Parameters.AddWithValue("@ClienteId", despacho.ClienteId);

            if (despacho.Mensajeroid.HasValue)
                cmd.Parameters.AddWithValue("@MensajeroId", despacho.Mensajeroid.Value);
            else
                cmd.Parameters.AddWithValue("@MensajeroId", DBNull.Value);

            cmd.Parameters.AddWithValue("@NumeroPaquetes", despacho.NumeroPaquetes);


            cmd.ExecuteNonQuery();
        }

        public void ActualizarDespacho(DespachoResponseDTO dto)
        {
            using var conn = _conexion.GetConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"UPDATE Despacho SET fecha_despacho = @fecha, estado = @estado,
                            cliente_id = @cliente, mensajero_id = @mensajero, numero_paquetes = @paquetes
                            WHERE id = @id";

            cmd.Parameters.AddWithValue("@fecha", dto.FechaDespacho);
            cmd.Parameters.AddWithValue("@estado", dto.Estado.ToString());
            cmd.Parameters.AddWithValue("@cliente", dto.ClienteId);
            cmd.Parameters.AddWithValue("@paquetes", dto.NumeroPaquetes);
            cmd.Parameters.AddWithValue("@id", dto.Id);

            cmd.ExecuteNonQuery();
        }


        public void Eliminar(int id)
        {
            try
            {
                _conexion.OpenConnection();
                using (var command = _conexion.GetConnection().CreateCommand())
                {
                    command.CommandText = "DELETE FROM despachos WHERE id_despacho = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al eliminar el despacho", ex);
            }
            finally
            {
                _conexion.CloseConnection();
            }
        }

        public List<DespachoResponseDTO> ObtenerDespachos()
        {
            var lista = new List<DespachoResponseDTO>();
            using var conn = _conexion.GetConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                                SELECT 
                                    d.id, 
                                    d.fecha_despacho, 
                                    d.estado, 
                                    c.nombre, 
                                    c.direccion, 
                                    c.telefono,
                                    m.nombre, 
                                    d.numero_paquetes 
                                FROM Despacho d
                                JOIN Cliente c ON d.cliente_id = c.id
                                LEFT JOIN Mensajero m ON d.mensajero_id = m.id";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new DespachoResponseDTO
                {
                    Id = reader.GetInt32(0),
                    FechaDespacho = reader.GetDateTime(1),
                    Estado = reader.GetString(2),
                    ClienteNombre = reader.GetString(3),
                    ClienteDireccion = reader.GetString(4),
                    ClienteTelefono = reader.GetString(5),
                    MensajeroNombre = reader.IsDBNull(6) ? "N/A" : reader.GetString(6),
                    NumeroPaquetes = reader.GetInt32(7)
                });
            }
            return lista;
        }


        public DespachoResponseDTO ObtenerDespachoPorId(int id)
        {
            DespachoResponseDTO? dto = null; // Use nullable type
            try
            {
                _conexion.OpenConnection();
                using (var command = _conexion.GetConnection().CreateCommand())
                {
                    command.CommandText = @"
                    SELECT d.id, d.fecha_despacho, d.estado, 
                    c.nombre, c.direccion, c.telefono,
                    m.nombre, d.numero_paquetes
                    FROM Despacho d
                    JOIN Cliente c ON d.cliente_id = c.id
                    LEFT JOIN Mensajero m ON d.mensajero_id = m.id
                    WHERE d.id = @id";
                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dto = new DespachoResponseDTO
                            {
                                Id = reader.GetInt32(0),
                                FechaDespacho = reader.GetDateTime(1),
                                Estado = reader.GetString(2),
                                ClienteNombre = reader.GetString(3),
                                ClienteTelefono = reader.GetString(4),
                                ClienteDireccion = reader.GetString(5),
                                MensajeroNombre = reader.IsDBNull(6) ? "N/A" : reader.GetString(6),
                                NumeroPaquetes = reader.GetInt32(7)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener el despacho", ex);
            }
            finally
            {
                _conexion.CloseConnection();
            }
            return dto ?? throw new InvalidOperationException("No se encontró el despacho con el ID especificado.");
        }

    }
}
