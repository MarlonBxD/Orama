using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.Dto;

namespace DAL
{
    public class FotografoRepository
    {
        private readonly Conexion _conexion;
        public FotografoRepository()
        {
            _conexion = new Conexion();
        }
        public string Agregar(Fotografo fotografo)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Fotografo (nombre, apellido, telefono, email, especialidad)
                            VALUES (@Nombre, @Apellido, @Telefono, @Email, @Especialidad)";
                cmd.Parameters.AddWithValue("@Nombre", fotografo.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", fotografo.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", fotografo.Telefono);
                cmd.Parameters.AddWithValue("@Email", fotografo.Email);
                cmd.Parameters.AddWithValue("@Especialidad", fotografo.Especialidad); 

                cmd.ExecuteNonQuery();
                conn.Close();

                return "Fotógrafo agregado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public List<Fotografo> GetAll()
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT id, nombre, apellido, telefono, especialidad FROM fotografo";

                using var reader = cmd.ExecuteReader();
                var fotografos = new List<Fotografo>();

                while (reader.Read())
                {
                    var fotografo = new Fotografo
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Telefono = reader.GetString(3),
                        Especialidad = reader.GetString(4)
                    };
                    fotografos.Add(fotografo);
                }

                return fotografos;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener la lista de fotógrafos", ex);
            }
        }
        public string Delete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Fotografo WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Fotografo eliminado correctamente";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Update(Fotografo fotografo)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Fotografo SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Email = @Email, Especialidad = @Especialidad WHERE id = @id";
                cmd.Parameters.AddWithValue("@Nombre", fotografo.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", fotografo.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", fotografo.Telefono);
                cmd.Parameters.AddWithValue("@Email", fotografo.Email);
                cmd.Parameters.AddWithValue("@Especialidad", fotografo.Especialidad);
                cmd.Parameters.AddWithValue("@id", fotografo.Id);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Fotografo actualizado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public Fotografo GetById(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT id, nombre, apellido, telefono, especialidad 
                                    FROM fotografo 
                                    WHERE id = @id";

                cmd.Parameters.AddWithValue("@id", id);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Fotografo
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Telefono = reader.GetString(3),
                        Especialidad = reader.GetString(4)
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener el fotógrafo por ID", ex);
            }
        }

        public Fotografo GetByName(string name)
        {
            using var conn = _conexion.GetConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Fotografo WHERE Nombre = @Nombre";
            cmd.Parameters.AddWithValue("@Nombre", name);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var fotografo = new Fotografo
                {
                    Nombre = reader.GetString(1),
                    Apellido = reader.GetString(6),
                    Telefono = reader.GetString(7),
                    Especialidad = reader.GetString(2)
                };
                conn.Close();
                return fotografo;
            }
            return null;
        }

    }
}
