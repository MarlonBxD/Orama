using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.Dto;

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
                cmd.CommandText = @"INSERT INTO Cliente (Nombre, Apellido, Telefono, Email, Direccion)
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
                return ex.Message;
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
            catch
            {
                return null;
            }
        }

        public Cliente GetById(int id)
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

        public string Delete(int id)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM cliente WHERE id = @id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

                return "Cliente eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
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
                return ex.Message;
            }
        }

        //public ClienteDTO ObtenerClientePorNombre(string nombre)
        //{
        //    using var conn = _conexion.GetConnection();
        //    conn.Open();

        //    using var cmd = conn.CreateCommand();
        //    cmd.CommandText = "SELECT id, Nombre, Telefono, Direccion FROM Cliente WHERE Nombre = @nombre LIMIT 1";
        //    cmd.Parameters.AddWithValue("@nombre", nombre);

        //    using var reader = cmd.ExecuteReader();
        //    if (reader.Read())
        //    {
        //        return new ClienteDTO
        //        {
        //            Id = reader.GetInt32(0),
        //            Nombre = reader.GetString(1),
        //            Telefono = reader.GetString(2),
        //            Direccion = reader.GetString(3)
        //        };
        //    }

        //    throw new Exception("Cliente no encontrado.");
        //}


    }
}
