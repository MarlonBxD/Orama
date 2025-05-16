using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ClienteSerive
    {
        private readonly CLienteRepository _clienteRepository;
        public ClienteSerive()
        {
            _clienteRepository = new CLienteRepository();
        }
        public string AgregarCliente(Cliente cliente)
        {
            try
            {
                _clienteRepository.AgregarCliente(cliente);
                return "Cliente agregado correctamente";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        public List<Cliente> GetClientes()
        {
            try
            {
                return _clienteRepository.GetClientes();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener los clientes: {ex.Message}");
            }
        }
        public string DeleteCliente(int id)
        {
            try
            {
                _clienteRepository.DelecteClienteById(id);
                return "Error al eliminar el cliente";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        
    }
}
