using Entity;
using Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VentaService
    {
        private readonly PaqueteDeServicioService _paqueteService;
        private readonly IVentaRepository _ventaRepo;
        private readonly IProductoRepository _productoRepo;
        private readonly IMovimientoInventarioRepository _movimientoRepo;

        public VentaService(IVentaRepository ventaRepo, IProductoRepository productoRepo, IMovimientoInventarioRepository movimientoRepo)
        {
            _paqueteService = new PaqueteDeServicioService();
            _ventaRepo = ventaRepo;
            _productoRepo = productoRepo;
            _movimientoRepo = movimientoRepo;

        }


        public void RegistrarVenta(Venta venta)
        {
            foreach (var detalle in venta.Detalles)
            {
                if (detalle.PaqueteServicio == null)
                {
                    throw new Exception("El detalle de venta debe tener un Paquete de Servicio asociado.");
                }
                _paqueteService.DescontarProductosDelPaquete(detalle.PaqueteServicio.Id, detalle.Cantidad);

                _paqueteService.DescontarPaqueteDeServicio(detalle.PaqueteServicio, detalle.Cantidad);
            }

            venta.Total = venta.Detalles.Sum(d => d.Subtotal);
            _ventaRepo.RegistrarVenta(venta);
        }


    }
}
