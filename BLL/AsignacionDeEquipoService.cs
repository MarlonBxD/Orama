using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.Dto;
using DAL;

namespace BLL
{
    public class AsignacionDeEquipoService
    {
        private readonly AsignacionDeEquipoRepository _AsignacionEqRepository;
        public AsignacionDeEquipoService()
        {
            _AsignacionEqRepository = new AsignacionDeEquipoRepository();
        }

        public List<AsignacionDeEquipoDTO> GetAll()
        {
            try
            {
                return _AsignacionEqRepository.GetAll();
            }
            catch (AppException ex)
            {
                throw new AppException("Error al acceder al Repositorio de AsignacionDeEquipo.", ex);
            }
        }
        public string Agregar(AsignacionDeEquipo asignacion)
        {
            try
            {
                if (string.IsNullOrEmpty(asignacion.fotografo.Nombre) || asignacion == null || asignacion.equipo == null)
                    return "Error al agregar equipo al Fotografo";
                return _AsignacionEqRepository.Agregar(asignacion);
            }
            catch (AppException ex) 
            { 
                return ex.Message;
            }
        }
        public AsignacionDeEquipoDTO GetById(int id)
        {
            try
            {
                return _AsignacionEqRepository.GetById(id);
            }
            catch (AppException ex)
            {
                return null;
            }
        
        }
        public string DeleteById(int id) 
        {
            try
            {
                _AsignacionEqRepository.Delete(id);
                return $"Eliminado con Exito: {id}";
            }
            catch (AppException ex)
            {
                return ex.Message;
            }
        }

    }
}
