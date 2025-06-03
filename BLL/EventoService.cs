using DAL;
using Entity.Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EventoService
    {
        private readonly EventoRepository _eventoRepository;

        public EventoService()
        {
            _eventoRepository = new EventoRepository();
        }

        public string Agregar(Evento evento)
        {
            try
            {
                //if (evento == null)
                //    throw new AppException("El evento no puede ser nulo.");

                //if (string.IsNullOrWhiteSpace(evento.Tipo))
                //    throw new AppException("El tipo del evento es obligatorio.");

                //if (evento.Fecha == default)
                //    throw new AppException("La fecha del evento es obligatoria.");

                //if (string.IsNullOrWhiteSpace(evento.Ubicacion))
                //    throw new AppException("La ubicación del evento es obligatoria.");

                //if (evento.Reserva == null || evento.Reserva.Id <= 0)
                //    throw new AppException("La reserva asociada es obligatoria y debe tener un ID válido.");

                return _eventoRepository.Agregar(evento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la lógica de negocio al agregar evento {ex.Message}");
            }
        }

        public string Actualizar(Evento evento)
        {
            try
            {
                if (evento == null)
                    throw new AppException("El evento no puede ser nulo.");

                if (evento.Id <= 0)
                    throw new AppException("El ID del evento es inválido.");

                if (string.IsNullOrWhiteSpace(evento.Tipo))
                    throw new AppException("El tipo del evento es obligatorio.");

                if (evento.Fecha == default)
                    throw new AppException("La fecha del evento es obligatoria.");

                if (string.IsNullOrWhiteSpace(evento.Ubicacion))
                    throw new AppException("La ubicación del evento es obligatoria.");

                if (evento.Reserva == null || evento.Reserva.Id <= 0)
                    throw new AppException("La reserva asociada es obligatoria y debe tener un ID válido.");

                return _eventoRepository.Update(evento);
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de negocio al actualizar evento", ex);
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                    throw new AppException("El ID del evento es inválido.");

                return _eventoRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de negocio al eliminar evento", ex);
            }
        }

        public List<EventoDTO> ObtenerTodos()
        {
            try
            {
                return _eventoRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de negocio al obtener eventos", ex);
            }
        }

        public Evento ObtenerPorId(int id)
        {
            try
            {
                if (id <= 0)
                    throw new AppException("El ID del evento es inválido.");

                return _eventoRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de negocio al obtener evento por ID", ex);
            }
        }

        public List<PaqueteDeServicioDTO> ObtenerPaquetesPorEvento(int idEvento)
        {
            try
            {
                if (idEvento <= 0)
                    throw new AppException("El ID del evento es inválido.");

                return _eventoRepository.ObtenerPaquetes(idEvento);
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de negocio al obtener paquetes por evento", ex);
            }
        }
    }

}
