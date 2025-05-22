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
        public string Agregar(Mensajero mensajero)
        {
            try
            {
                _mensajeroRepository.Agregar(mensajero);
                return "Mensajero agregado correctamente";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        public List<Mensajero> GetAll()
        {
            try
            {
                return _mensajeroRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener los mensajeros: {ex.Message}");
            }
        }
        public string Delete(int id)
        {
            try
            {
                _mensajeroRepository.Delete(id);
                return "Mensajero eliminado correctamente";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        public Mensajero GetById(int id)
        {
            try
            {
                return _mensajeroRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el mensajero: {ex.Message}");
            }
        }
        public string Update(Mensajero mensajero)
        {
            try
            {
                _mensajeroRepository.Update(mensajero);
                return "Mensajero actualizado correctamente";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        
    }
}
