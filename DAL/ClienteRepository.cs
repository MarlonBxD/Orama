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
        public void Agregar(Cliente cliente)
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
            conn.Close();
        }
        public List<Cliente> GetClientes()
        {
            using var conn = _conexion.GetConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Cliente";
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
            conn.Close();
            return clientes;
        }
        public void DelecteClienteById(int id)
        {
            using var conn = _conexion.GetConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Cliente WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateCliente(Cliente cliente)
        {
            using var conn = _conexion.GetConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE Cliente SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Email = @Email, Direccion = @Direccion WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public ClienteDTO ObtenerClientePorNombre(string nombre)
        {
            try
            {
                using var conn = _conexion.GetConnection();
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Id, Nombre, Telefono, Direccion FROM Cliente WHERE Nombre = @Nombre";
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new ClienteDTO
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Telefono = reader.GetString(2),
                        Direccion = reader.GetString(3)
                    };
                }
                conn.Close();
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cliente por nombre", ex);
            }

        }

    }
}
