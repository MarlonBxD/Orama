using Entity;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AsignacionDeEquipoRepository
    {
        private readonly Conexion _conexion;
        private readonly FotografoRepository fotografoRepository;
        private readonly EquipoFotograficoRepository equipoRepository;

        public AsignacionDeEquipoRepository()
        {
            _conexion = new Conexion();
            fotografoRepository = new FotografoRepository();
            equipoRepository = new EquipoFotograficoRepository();
        }

        public void Agregar(AsignacionDeEquipo asignacion)
        {
            try
            {
                if (asignacion == null || asignacion.FechaAsignacion > asignacion.FechaDevolucion)
                    throw new ArgumentException("Datos de asignación no válidos");

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO AsignacionDeEquipo (Fecha_asignacion, Fecha_entrega, Fotografo_Id, Equipo_Id, Estado)
                            VALUES (@FechaAsignacion, @FechaDevolucion, @FotografoId, @EquipoId, @Estado)";
                cmd.Parameters.AddWithValue("@FechaAsignacion", asignacion.FechaAsignacion);
                cmd.Parameters.AddWithValue("@FechaDevolucion", asignacion.FechaDevolucion);
                cmd.Parameters.AddWithValue("@FotografoId", asignacion.fotografo.Id);
                cmd.Parameters.AddWithValue("@EquipoId", asignacion.equipo.Id);
                cmd.Parameters.AddWithValue("@Estado", asignacion.Estado);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DALException("Error al agregar asignación de equipo", ex);
            }
        }

        public void Actualizar(AsignacionDeEquipo asignacion)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE AsignacionDeEquipo SET Fecha_asignacion = @FechaAsignacion, 
                            Fecha_entrega = @FechaDevolucion, Fotografo_Id = @FotografoId, 
                            Equipo_Id = @EquipoId, Estado = @Estado
                            WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", asignacion.Id);
                cmd.Parameters.AddWithValue("@FechaAsignacion", asignacion.FechaAsignacion);
                cmd.Parameters.AddWithValue("@FechaDevolucion", asignacion.FechaDevolucion);
                cmd.Parameters.AddWithValue("@FotografoId", asignacion.fotografo.Id);
                cmd.Parameters.AddWithValue("@EquipoId", asignacion.equipo.Id);
                cmd.Parameters.AddWithValue("@Estado", asignacion.Estado);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DALException("Error al actualizar asignación de equipo", ex);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM AsignacionDeEquipo WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DALException("Error al eliminar asignación de equipo", ex);
            }
        }

        public List<AsignacionDeEquipoDTO> ObtenerTodos()
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT a.Id, a.Fecha_asignacion, a.Fecha_entrega, a.Estado, 
                            f.Id, f.Nombre, e.Id, e.Nombre
                            FROM AsignacionDeEquipo a
                            JOIN Fotografo f ON a.Fotografo_Id = f.Id
                            JOIN EquipoFotografico e ON a.Equipo_Id = e.Id";
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
                        FotografoId = reader.GetInt32(4),
                        FotografoNombre = reader.GetString(5),
                        EquipoId = reader.GetInt32(6),
                        EquipoNombre = reader.GetString(7)
                    };
                    asignaciones.Add(asignacion);
                }
                return asignaciones;
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener asignaciones de equipo", ex);
            }
        }

        public AsignacionDeEquipo ObtenerPorId(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT a.Id, a.Fecha_asignacion, a.Fecha_entrega, a.Estado, 
                            a.Fotografo_Id, a.Equipo_Id
                            FROM AsignacionDeEquipo a
                            WHERE a.Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var asignacion = new AsignacionDeEquipo
                    {
                        Id = reader.GetInt32(0),
                        FechaAsignacion = reader.GetDateTime(1),
                        FechaDevolucion = reader.GetDateTime(2),
                        Estado = reader.GetString(3)
                    };
                    reader.Close();

                    int fotografoId = reader.GetInt32(4);
                    int equipoId = reader.GetInt32(5);

                    asignacion.fotografo = fotografoRepository.ObtenerPorId(fotografoId);
                    asignacion.equipo = equipoRepository.ObtenerPorId(equipoId);

                    return asignacion;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener asignación de equipo", ex);
            }
        }
    }
}
