using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAL
{
    public class Conexion : IDisposable
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=admin;Password=1234;Database=orama_db";
        private readonly NpgsqlConnection connection;
        private bool disposed = false;

        public Conexion()
        {
            try
            {
                connection = new NpgsqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                // Solo propagar la excepción, no mostrarla
                throw new DALException("Error al crear la conexión", ex);
            }
        }

        public NpgsqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                // Solo propagar la excepción, no mostrarla
                throw new DALException("Error al abrir la conexión", ex);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Solo propagar la excepción, no mostrarla
                throw new DALException("Error al cerrar la conexión", ex);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    try
                    {
                        CloseConnection();
                        connection.Dispose();
                    }
                    catch
                    {
                        // Simplemente ignoramos las excepciones al liberar recursos
                    }
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
