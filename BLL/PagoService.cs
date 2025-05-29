using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using Entity.Dto;

namespace BLL
{
    public class PagoService
    {
        private readonly PagoRepository _pagoRepository;
        public PagoService()
        {
            _pagoRepository = new PagoRepository();
        }
        public void AgregarPago(Pago pago)
        {
            if (pago == null)
                throw new ArgumentNullException(nameof(pago), "El objeto pago no puede ser nulo.");

            if (string.IsNullOrWhiteSpace(pago.MetodoPago))
                throw new ArgumentException("El método de pago es obligatorio.", nameof(pago.MetodoPago));

            if (pago.Monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero.", nameof(pago.Monto));

            if (pago.cliente == null || pago.cliente.Id <= 0)
                throw new ArgumentException("El cliente es obligatorio y debe tener un ID válido.");

            try
            {
                 _pagoRepository.Agregar(pago);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al intentar agregar el pago. {ex.Message}");
            }
        }

        public List<PagoDto> ObtenerPagos()
        {
            return _pagoRepository.GetAll();
        }
        public void EliminarPago(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID de pago no válido.");

            _pagoRepository.Delete(id);
        }
        public PagoDto ObtenerPagoPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID de pago no válido.");
            return _pagoRepository.GetById(id);
        }
        public List<PagoDto> ObtenerPagosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
                throw new ArgumentException("La fecha de inicio no puede ser mayor que la fecha de fin.");
            return _pagoRepository.GetByFecha(fechaInicio, fechaFin);
        }
        public List<PagoDto> GetByName(string nombreCliente)
        {
            if (string.IsNullOrWhiteSpace(nombreCliente))
                throw new ArgumentException("Nombre del cliente requerido.");
            return _pagoRepository.GetByNombreCliente(nombreCliente);
        }

    }
}
