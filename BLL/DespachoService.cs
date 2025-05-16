using DAL;
using Entity;
using Entity.Dto;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class DespachoService
    {
        private readonly DespachoRepository _repository;
        private readonly MensajeroRepository _mensajeroRepository;
        private readonly CLienteRepository _clienteRepository;

        public DespachoService()
        {
            _repository = new DespachoRepository();
            _mensajeroRepository = new MensajeroRepository();
            _clienteRepository = new CLienteRepository();
        }

        public string GuardarDespacho(Despacho dto)
        {
            try
            {
                _repository.AgregarDespacho(dto);
                return "Despacho guardado correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al guardar despacho: {ex.Message}";
            }
        }
        public List<DespachoResponseDTO> ObtenerDespachos()
        {
            try
            {
                return _repository.ObtenerDespachos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error consultando despachos: {ex.Message}");
            }
        }

        //public string ActualizarDespacho(DespachoDTO dto)
        //{
        //    try
        //    {
        //        _repository.ActualizarDespacho(dto);
        //        return "Despacho actualizado correctamente.";
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"Error actualizando despacho: {ex.Message}";
        //    }
        //}

        public string EliminarDespacho(int id)
        {
            try
            {
                _repository.Eliminar(id);
                return "Despacho eliminado con éxito.";
            }
            catch (DALException ex)
            {
                return $"Error eliminando despacho: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Error inesperado: {ex.Message}";
            }
        }
    }
}
