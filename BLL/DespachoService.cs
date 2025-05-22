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

        public DespachoService()
        {
            _repository = new DespachoRepository();
        }

        public string Agregar(Despacho despacho)
        {
            try
            {
                if (despacho == null)
                    throw new ArgumentException("El despacho no puede ser nulo.");

                if (despacho.FechaDespacho == default)
                    throw new ArgumentException("La fecha de despacho es obligatoria.");

                if (string.IsNullOrWhiteSpace(despacho.Estado))
                    throw new ArgumentException("El estado es obligatorio.");

                if (despacho.NumeroPaquetes <= 0)
                    throw new ArgumentException("El número de paquetes debe ser mayor a cero.");

                if (despacho.PaqueteDeServicio == null || despacho.PaqueteDeServicio.Id <= 0)
                    throw new ArgumentException("Debe especificar un paquete de servicio válido.");

                if (despacho.Cliente == null || despacho.Cliente.Id <= 0)
                    throw new ArgumentException("Debe especificar un cliente válido.");

                if (despacho.Mensajero == null || despacho.Mensajero.Id <= 0)
                    throw new ArgumentException("Debe especificar un mensajero válido.");

                return _repository.Agregar(despacho);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al agregar el despacho", ex);
            }
        }

        public List<DespachoDTO> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener la lista de despachos", ex);
            }
        }

        public Despacho GetById(int id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("El ID debe ser mayor que cero.");

                var despacho = _repository.GetById(id);
                if (despacho == null)
                    throw new AppException("No se encontró el despacho con el ID especificado.");

                return despacho;
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener el despacho por ID", ex);
            }
        }

        public string Update(Despacho despacho)
        {
            try
            {
                if (despacho == null)
                    throw new ArgumentException("El despacho no puede ser nulo.");

                if (despacho.Id <= 0)
                    throw new ArgumentException("El ID del despacho no es válido.");

                if (despacho.FechaDespacho == default)
                    throw new ArgumentException("La fecha de despacho es obligatoria.");

                if (string.IsNullOrWhiteSpace(despacho.Estado))
                    throw new ArgumentException("El estado es obligatorio.");

                if (despacho.NumeroPaquetes <= 0)
                    throw new ArgumentException("El número de paquetes debe ser mayor a cero.");

                if (despacho.PaqueteDeServicio == null || despacho.PaqueteDeServicio.Id <= 0)
                    throw new ArgumentException("Debe especificar un paquete de servicio válido.");

                if (despacho.Cliente == null || despacho.Cliente.Id <= 0)
                    throw new ArgumentException("Debe especificar un cliente válido.");

                if (despacho.Mensajero == null || despacho.Mensajero.Id <= 0)
                    throw new ArgumentException("Debe especificar un mensajero válido.");

                return _repository.Update(despacho);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al actualizar el despacho", ex);
            }
        }

        public string Delete(int id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("El ID debe ser mayor que cero.");

                return _repository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al eliminar el despacho", ex);
            }
        }
    }

}
