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
    public class AsignacionService
    {
        private readonly AsignacionRepository _asignacionRepository;
        public AsignacionService()
        {
            _asignacionRepository = new AsignacionRepository();
        }
        public string Agregar(Asignacion asignacion)
        {
            if (asignacion == null)
                throw new ArgumentNullException(nameof(asignacion), "La asignación no puede ser nula.");
            if (asignacion.Fotografo == null)
                throw new ArgumentException("El fotógrafo de la asignación es obligatorio.");
            if (asignacion.Evento == null)
                throw new ArgumentException("El evento de la asignación es obligatorio.");
            return _asignacionRepository.Agregar(asignacion);
        }
        public List<AsignacionDTO> ObtenerAsignaciones()
        {
            return _asignacionRepository.GetAll();
        }
        public string EliminarAsignacion(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la asignación debe ser mayor que cero.");
            try
            {
                _asignacionRepository.Delete(id);
                return "Asignación eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public AsignacionDTO GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la asignación debe ser mayor que cero.");
            var asignacion = _asignacionRepository.GetById(id);
            if (asignacion == null)
                throw new KeyNotFoundException($"No se encontró una asignación con ID {id}.");
            return asignacion;
        }
        public List<Asignacion> GetByFotografoId(int fotografoId)
        {
            if (fotografoId <= 0)
                throw new ArgumentException("El ID del fotógrafo debe ser mayor que cero.");
            return _asignacionRepository.GetByFotografoId(fotografoId);
        }
        public List<Asignacion> GetByEventoId(int eventoId)
        {
            if (eventoId <= 0)
                throw new ArgumentException("El ID del evento debe ser mayor que cero.");
            return _asignacionRepository.GetByEventoId(eventoId);
        }
        public List<AsignacionDTO> GetByFecha(DateTime fecha)
        {
            return _asignacionRepository.GetByFecha(fecha);
        }
        public List<AsignacionDTO> GetByNameFotografo(string nombre)
        {
            return _asignacionRepository.GetByNameFotografo(nombre);
        }
    }
}
