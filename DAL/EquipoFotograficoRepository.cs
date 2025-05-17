using Entity;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EquipoFotograficoRepository
    {
        private readonly Conexion _conexion;

        public EquipoFotograficoRepository()
        {
            _conexion = new Conexion();
        }

        public void Agregar(EquipoFotografico equipo)
        {
            try
            {
                if (equipo == null || string.IsNullOrEmpty(equipo.Nombre) || string.IsNullOrEmpty(equipo.Modelo))
                    throw new ArgumentException("Datos del equipo fotográfico no válidos");

                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO EquipoFotografico (Nombre, Marca, Modelo, Estado, Tipo)
                            VALUES (@Nombre, @Marca, @Modelo, @Estado, @Tipo)";
                cmd.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                cmd.Parameters.AddWithValue("@Marca", equipo.Marca);
                cmd.Parameters.AddWithValue("@Modelo", equipo.Modelo);
                cmd.Parameters.AddWithValue("@Estado", equipo.Estado);
                cmd.Parameters.AddWithValue("@Tipo", equipo.Tipo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DALException("Error al agregar equipo fotográfico", ex);
            }
        }

        public void Actualizar(EquipoFotografico equipo)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE EquipoFotografico SET Nombre = @Nombre, Marca = @Marca, 
                            Modelo = @Modelo, Estado = @Estado, Tipo = @Tipo WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", equipo.Id);
                cmd.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                cmd.Parameters.AddWithValue("@Marca", equipo.Marca);
                cmd.Parameters.AddWithValue("@Modelo", equipo.Modelo);
                cmd.Parameters.AddWithValue("@Estado", equipo.Estado);
                cmd.Parameters.AddWithValue("@Tipo", equipo.Tipo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DALException("Error al actualizar equipo fotográfico", ex);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM EquipoFotografico WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DALException("Error al eliminar equipo fotográfico", ex);
            }
        }

        public List<EquipoFotografico> ObtenerTodos()
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nombre, Marca, Modelo, Estado, Tipo FROM EquipoFotografico";
                using var reader = cmd.ExecuteReader();
                var equipos = new List<EquipoFotografico>();
                while (reader.Read())
                {
                    var equipo = new EquipoFotografico
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Marca = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Modelo = reader.GetString(3),
                        Estado = reader.GetString(4),
                        Tipo = reader.GetString(5)
                    };
                    equipos.Add(equipo);
                }
                return equipos;
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener equipos fotográficos", ex);
            }
        }

        public EquipoFotografico ObtenerPorId(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nombre, Marca, Modelo, Estado, Tipo FROM EquipoFotografico WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new EquipoFotografico
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Marca = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Modelo = reader.GetString(3),
                        Estado = reader.GetString(4),
                        Tipo = reader.GetString(5)
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener equipo fotográfico", ex);
            }
        }
    }
}
