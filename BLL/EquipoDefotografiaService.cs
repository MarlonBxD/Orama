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
    public class EquipoDefotografiaService
    {
        private readonly EquipoFotograficoRepository _equipoFotograficoRepository;
        public EquipoDefotografiaService()
        {
            _equipoFotograficoRepository = new EquipoFotograficoRepository();
        }
        public string Agregar(EquipoFotografico equipoFotografico)
        {
            if (equipoFotografico == null)
                throw new ArgumentNullException(nameof(equipoFotografico), "El equipo fotográfico no puede ser nulo.");
            if (string.IsNullOrWhiteSpace(equipoFotografico.Modelo))
                throw new ArgumentException("El modelo del equipo fotográfico es obligatorio.");
            if (string.IsNullOrWhiteSpace(equipoFotografico.Marca))
                throw new ArgumentException("La marca del equipo fotográfico es obligatoria.");
            return _equipoFotograficoRepository.Agregar(equipoFotografico);
        }
        public List<EquipoFotografico> ObtenerEquiposFotograficos()
        {
            return _equipoFotograficoRepository.GetAll();
        }
        public string EliminarEquipoFotografico(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del equipo fotográfico debe ser mayor que cero.");
            try
            {
                _equipoFotograficoRepository.Delete(id);
                return "Equipo fotográfico eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public EquipoFotografico GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del equipo fotográfico debe ser mayor que cero.");
             return _equipoFotograficoRepository.GetById(id);
            
           
        }
    }
}
