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
    public class FotografoService
    {
        private readonly FotografoRepository _fotografoRepository;

        public FotografoService()
        {
            _fotografoRepository = new FotografoRepository();
        }
        public void AgregarFotografo(Fotografo fotografo)
        {
            if (fotografo == null)
                throw new ArgumentNullException(nameof(fotografo), "El fotógrafo no puede ser nulo.");

            if (string.IsNullOrWhiteSpace(fotografo.Nombre))
                throw new ArgumentException("El nombre del fotógrafo es obligatorio.");

            if (string.IsNullOrWhiteSpace(fotografo.Telefono))
                throw new ArgumentException("El teléfono del fotógrafo es obligatorio.");

            _fotografoRepository.Agregar(fotografo);
        }
        public List<Fotografo> ObtenerFotografos()
        {
            return _fotografoRepository.GetAll();
        }
        public string EliminarFotografo(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del fotógrafo debe ser mayor que cero.");

            try
            {
                _fotografoRepository.Delete(id);
                return "Fotógrafo eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public Fotografo ObtenerFotografoPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del fotógrafo debe ser mayor que cero.");
            var fotografos = _fotografoRepository.GetById(id);
            if (fotografos == null)
                throw new KeyNotFoundException($"No se encontró un fotógrafo con ID {id}.");
            return fotografos;
        }
        public string ActualizarFotografo(Fotografo fotografo)
        {
            if (fotografo == null)
                throw new ArgumentNullException(nameof(fotografo), "El fotógrafo no puede ser nulo.");
            if (fotografo.Id <= 0)
                throw new ArgumentException("El ID del fotógrafo debe ser mayor que cero.");
            if (string.IsNullOrWhiteSpace(fotografo.Nombre))
                throw new ArgumentException("El nombre del fotógrafo es obligatorio.");
            if (string.IsNullOrWhiteSpace(fotografo.Telefono))
                throw new ArgumentException("El teléfono del fotógrafo es obligatorio.");
            return _fotografoRepository.Update(fotografo);
        }
        public Fotografo ObtenerFotografoPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del fotógrafo es obligatorio.");
            var fotografos = _fotografoRepository.GetByName(nombre);
            if (fotografos == null)
                throw new KeyNotFoundException($"No se encontró un fotógrafo con nombre {nombre}.");
            return fotografos;
        }


    }
}
