using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    class DespachoRepository
    {
        private readonly Conexion _conexion;
        public DespachoRepository()
        {
            _conexion = new Conexion();
        }
        public void AgregarDespacho(Despacho despacho)
        {
            try
            {
                _conexion.OpenConnection();
                using (var command = _conexion.GetConnection().CreateCommand())
                {
                    command.CommandText = "INSERT INTO despachos (id, fecha_despacho, cliente, direccion, telefono, estado, fotofrafias, numero_paquetes) VALUES (@id, @fecha_despacho, @cliente, @direccion, @telefono, @estado, @fotofrafias, @numero_paquetes)";
                    command.Parameters.AddWithValue("@id", despacho.Id);
                    command.Parameters.AddWithValue("@fecha_despacho", despacho.FechaDespacho);
                    command.Parameters.AddWithValue("@cliente", despacho.Cliente.Nombre);
                    command.Parameters.AddWithValue("@direccion", despacho.Cliente.Direccion);
                    command.Parameters.AddWithValue("@telefono", despacho.Cliente.Telefono);
                    command.Parameters.AddWithValue("@estado", despacho.Estado);
                    command.Parameters.AddWithValue("@fotofrafias", despacho.Fotografias);
                    command.Parameters.AddWithValue("@numero_paquetes", despacho.numero_paquetes);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al agregar el despacho", ex);
            }
            finally
            {
                _conexion.CloseConnection();
            }
        }
        public void EliminarDespacho(int id)
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
        public void ActualizarDespacho(Despacho despacho)
        {
            try
            {
                _conexion.OpenConnection();
                using (var command = _conexion.GetConnection().CreateCommand())
                {
                    command.CommandText = "UPDATE despachos SET id = @id, id_equipo = @id_equipo, fecha_despacho = @fecha_despacho, fecha_devolucion = @fecha_devolucion WHERE id_despacho = @id";
                    command.Parameters.AddWithValue("@id", despacho.Id);
                    command.Parameters.AddWithValue("@fecha_despacho", despacho.FechaDespacho);
                    command.Parameters.AddWithValue("@cliente", despacho.Cliente.Nombre);
                    command.Parameters.AddWithValue("@direccion", despacho.Cliente.Direccion);
                    command.Parameters.AddWithValue("@telefono", despacho.Cliente.Telefono);
                    command.Parameters.AddWithValue("@estado", despacho.Estado);
                    command.Parameters.AddWithValue("@fotofrafias", despacho.Fotografias);
                    command.Parameters.AddWithValue("@numero_paquetes", despacho.numero_paquetes);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al actualizar el despacho", ex);
            }
            finally
            {
                _conexion.CloseConnection();
            }
        }
        public List<Despacho> ObtenerDespachos()
        {
            List<Despacho> despachos = new List<Despacho>();
            try
            {
                _conexion.OpenConnection();
                using (var command = _conexion.GetConnection().CreateCommand())
                {
                    command.CommandText = "SELECT * FROM despachos";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Despacho despacho = new Despacho
                            {
                                Id = reader.GetInt32(0),
                                FechaDespacho = reader.GetDateTime(1),
                                Cliente = new Cliente
                                {
                                    Nombre = reader.GetString(2),
                                    Direccion = reader.GetString(3),
                                    Telefono = reader.GetString(4)
                                },
                                Estado = reader.GetString(5),
                                Fotografias = new List<Fotografia>(), 
                                numero_paquetes = reader.GetInt32(6)
                            };
                            despachos.Add(despacho);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener los despachos", ex);
            }
            finally
            {
                _conexion.CloseConnection();
            }
            return despachos;
        }

        public Despacho ObtenerDespachoPorId(int id)
        {
            Despacho despacho = null;
            try
            {
                _conexion.OpenConnection();
                using (var command = _conexion.GetConnection().CreateCommand())
                {
                    command.CommandText = "SELECT * FROM despachos WHERE id_despacho = @id";
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            despacho = new Despacho
                            {
                                Id = reader.GetInt32(0),
                                FechaDespacho = reader.GetDateTime(1),
                                Cliente = new Cliente
                                {
                                    Nombre = reader.GetString(2),
                                    Direccion = reader.GetString(3),
                                    Telefono = reader.GetString(4)
                                },
                                Estado = reader.GetString(5),
                                Fotografias = new List<Fotografia>(), 
                                numero_paquetes = reader.GetInt32(6)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DALException("Error al obtener el despacho por ID", ex);
            }
            finally
            {
                _conexion.CloseConnection();
            }
            return despacho;
        }
    }
}
