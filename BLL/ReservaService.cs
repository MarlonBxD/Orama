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
    public class ReservaService
    {
        private readonly ReservaRepository _reservaRepository;

        public ReservaService()
        {
            _reservaRepository = new ReservaRepository();
        }

        public string Agregar(Reserva reserva)
        {
            try
            {
                if (reserva == null)
                    throw new AppException("La reserva no puede ser nula.");

                if (reserva.Id <= 0)
                    throw new AppException("El ID de la reserva es inválido.");

                if (reserva.FechaEvento == default)
                    throw new AppException("La fecha del evento es obligatoria.");

                if (reserva.FechaReserva == default)
                    throw new AppException("La fecha de la reserva es obligatoria.");

                if (reserva.Cliente == null || reserva.Cliente.Id <= 0)
                    throw new AppException("El cliente es obligatorio y debe tener un ID válido.");

                if (reserva.Evento == null || reserva.Evento.Id <= 0)
                    throw new AppException("El evento es obligatorio y debe tener un ID válido.");

                if (reserva.PaqueteDeServicio == null || reserva.PaqueteDeServicio.Id <= 0)
                    throw new AppException("El paquete de servicio es obligatorio y debe tener un ID válido.");

                return _reservaRepository.Agregar(reserva);
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de negocio al agregar reserva", ex);
            }
        }

        public string Actualizar(Reserva reserva)
        {
            try
            {
                if (reserva == null)
                    throw new AppException("La reserva no puede ser nula.");

                if (reserva.Id <= 0)
                    throw new AppException("El ID de la reserva es inválido.");

                if (reserva.FechaEvento == default)
                    throw new AppException("La fecha del evento es obligatoria.");

                if (reserva.FechaReserva == default)
                    throw new AppException("La fecha de la reserva es obligatoria.");

                if (reserva.Cliente == null || reserva.Cliente.Id <= 0)
                    throw new AppException("El cliente es obligatorio y debe tener un ID válido.");

                if (reserva.Evento == null || reserva.Evento.Id <= 0)
                    throw new AppException("El evento es obligatorio y debe tener un ID válido.");

                if (reserva.PaqueteDeServicio == null || reserva.PaqueteDeServicio.Id <= 0)
                    throw new AppException("El paquete de servicio es obligatorio y debe tener un ID válido.");

                return _reservaRepository.Update(reserva);
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de negocio al actualizar reserva", ex);
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                    throw new AppException("El ID de la reserva es inválido.");

                return _reservaRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de negocio al eliminar reserva", ex);
            }
        }

        public List<ReservaDTO> ObtenerTodos()
        {
            try
            {
                return _reservaRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de negocio al obtener todas las reservas", ex);
            }
        }

        public Reserva ObtenerPorId(int id)
        {
            try
            {
                if (id <= 0)
                    throw new AppException("El ID de la reserva es inválido.");

                return _reservaRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de negocio al obtener reserva por ID", ex);
            }
        }

        public List<EventoDTO> ObtenerEventosPorReserva(int reservaId)
        {
            try
            {
                if (reservaId <= 0)
                    throw new AppException("El ID de la reserva es inválido.");

                return _reservaRepository.ObtenerEventos(reservaId);
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de negocio al obtener eventos por reserva", ex);
            }
        }
    }

}
