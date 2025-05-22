using DAL;
using Entity;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class IngresoService
    {
        private readonly IngresoRepository _ingresoRepository;

        public IngresoService()
        {
            _ingresoRepository = new IngresoRepository();
        }

        public List<IngresoDTO> GetAll()
        {
            try
            {
                return _ingresoRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener la lista de ingresos.", ex);
            }
        }

        public string Agregar(Ingreso ingreso)
        {
            try
            {
                if (ingreso == null)
                {
                    return "Error: Datos del ingreso incompletos";
                }

                return _ingresoRepository.Agregar(ingreso);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al agregar el ingreso.", ex);
            }
        }

        public Ingreso GetById(int id)
        {
            try
            {
                return _ingresoRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new AppException($"Error al obtener el ingreso con ID {id}.", ex);
            }
        }

        public string Update(Ingreso ingreso)
        {
            try
            {
                if (ingreso == null || ingreso.Id <= 0)
                {
                    return "Error: Datos del ingreso no válidos para la actualización.";
                }

                return _ingresoRepository.Update(ingreso);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al actualizar el ingreso.", ex);
            }
        }

        public string Delete(int id)
        {
            try
            {
                _ingresoRepository.Delete(id);
                return $"Ingreso con ID {id} eliminado correctamente.";
            }
            catch (Exception ex)
            {
                throw new AppException($"Error al eliminar el ingreso con ID {id}.", ex);
            }
        }
    }
}
