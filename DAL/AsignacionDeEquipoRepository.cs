using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.Dto;

namespace DAL
{
    public class AsignacionDeEquipoRepository
    {
        private readonly Conexion _conexion;
        public AsignacionDeEquipoRepository()
        {
            _conexion = new Conexion();
        }
        public string Agregar(AsignacionDeEquipo asignacionDeEquipo)
        {
            try
            {
                
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Asignaciondeequipo (fecha_asignacion, fecha_entrega, fotografoid, equipoid, estado)
                            VALUES (@fecha_asignacion,@fecha_entrega @fotografoid, @equipoid, @estado)";
                cmd.Parameters.AddWithValue("@fecha_asignacion", asignacionDeEquipo.FechaAsignacion);
                cmd.Parameters.AddWithValue("@fecha_entrega", asignacionDeEquipo.FechaDevolucion);
                cmd.Parameters.AddWithValue("@fotografoid", asignacionDeEquipo.fotografo.Id);
                cmd.Parameters.AddWithValue("@equipoid", asignacionDeEquipo.equipo.Id);
                cmd.Parameters.AddWithValue("@estado", asignacionDeEquipo.Estado);
                cmd.ExecuteNonQuery();
                return "Asignacion de Equipo agregada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<AsignacionDeEquipoDTO> GetAll()
        {
            
            using var conn = _conexion.GetConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT a.id, a.fechaasignacion, " +
                                "a.fechadevolucion, a.estado, " +
                                "f.Nombre AS nombrefotografo, " +
                                "e.modelo AS modeloequipo " +
                                "FROM Asignaciondeequipo a " +
                                "JOIN fotografo f ON a.fotografoid = f.id " +
                                "JOIN equipofotografico e ON a.equipoid = e.id";

            using var reader = cmd.ExecuteReader();
            var asignaciones = new List<AsignacionDeEquipoDTO>();
            while (reader.Read())
            {
                var asignacion = new AsignacionDeEquipoDTO
                {
                    Id = reader.GetInt32(0),
                    FechaAsignacion = reader.GetDateTime(1),
                    FechaDevolucion = reader.GetDateTime(2),
                    Estado = reader.GetString(3),
                    nombreFotografo = reader.GetString(4),
                    nombreEquipo = reader.GetString(5)
                };
                asignaciones.Add(asignacion);
            }
            return asignaciones;
            
        }

        public string Delete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Asignaciondeequipo WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return "Fotografo eliminado correctamente";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string update(AsignacionDeEquipo asignacionDeEquipo)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Asignaciondeequipo SET fechaasignacion = @fechaasignacion, " +
                                  "fechadevolucion = @fechadevolucion, estado = @estado " +
                                  "WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", asignacionDeEquipo.Id);
                cmd.Parameters.AddWithValue("@fechaasignacion", asignacionDeEquipo.FechaAsignacion);
                cmd.Parameters.AddWithValue("@fechadevolucion", asignacionDeEquipo.FechaDevolucion);
                cmd.Parameters.AddWithValue("@estado", asignacionDeEquipo.Estado);
                cmd.ExecuteNonQuery();
                return "Fotografo actualizado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpdateEstado()
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Asignaciondeequipo SET estado = @estado WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", 1);
                cmd.Parameters.AddWithValue("@estado", "Devuelto");
                cmd.ExecuteNonQuery();
                return "Estado actualizado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public AsignacionDeEquipoDTO GetById(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT a.id, a.fechaasignacion, " +
                                  "a.fechadevolucion, a.estado, " +
                                  "f.Nombre AS nombrefotografo, " +
                                  "e.modelo AS modeloequipo " +
                                  "FROM Asignaciondeequipo a " +
                                  "JOIN fotografo f ON a.fotografoid = f.id " +
                                  "JOIN equipofotografico e ON a.equipoid = e.id " +
                                  "WHERE a.id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var asignacion = new AsignacionDeEquipoDTO
                    {
                        Id = reader.GetInt32(0),
                        FechaAsignacion = reader.GetDateTime(1),
                        FechaDevolucion = reader.GetDateTime(2),
                        Estado = reader.GetString(3),
                        nombreEquipo = reader.GetString(4),
                        nombreFotografo = reader.GetString(5)
                    };
                    return asignacion;
                }
                conn.Close();
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
