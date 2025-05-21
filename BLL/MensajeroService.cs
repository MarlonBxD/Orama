using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class MensajeroService
    {
        private readonly MensajeroRepository _mensajeroRepository;
        public MensajeroService()
        {
            _mensajeroRepository = new MensajeroRepository();
        }
        public string AgregarMensajero(Mensajero mensajero)
        {
            try
            {
                _mensajeroRepository.AgregarMensajero(mensajero);
                return "Mensajero agregado correctamente";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        public List<Mensajero> GetMensajeros()
        {
            try
            {
                return _mensajeroRepository.GetMensajeros();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener los mensajeros: {ex.Message}");
            }
        }
        public string DeleteMensajero(int id)
        {
            try
            {
                _mensajeroRepository.DeleteMensajero(id);
                return "Mensajero eliminado correctamente";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        public Mensajero GetMensajeroById(int id)
        {
            try
            {
                return _mensajeroRepository.GetMensajero(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el mensajero: {ex.Message}");
            }
        }
        public string UpdateMensajero(Mensajero mensajero)
        {
            try
            {
                _mensajeroRepository.UpdateMensajero(mensajero);
                return "Mensajero actualizado correctamente";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        
    }
}
