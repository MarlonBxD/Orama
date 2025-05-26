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
        private readonly IVentaRepository _ventaRepo;
        private readonly IProductoRepository _productoRepo;
        private readonly IMovimientoInventarioRepository _movimientoRepo;

        public VentaService(IVentaRepository ventaRepo, IProductoRepository productoRepo, IMovimientoInventarioRepository movimientoRepo)
        {
            _ventaRepo = ventaRepo;
            _productoRepo = productoRepo;
            _movimientoRepo = movimientoRepo;
        }

        public void RegistrarVenta(Venta venta)
        {
            foreach (var detalle in venta.Detalles)
            {
                var producto = _productoRepo.ObtenerPorId(detalle.ProductoId);
                if (producto.stock < detalle.Cantidad)
                {
                    throw new Exception($"No hay suficiente stock para el producto {producto.Nombre}");
                }

                _productoRepo.ActualizarStock(producto.Id, producto.stock - detalle.Cantidad);

                _movimientoRepo.RegistrarMovimiento(new MovimientoInventario
                {
                    ProductoId = producto.Id,
                    Cantidad = detalle.Cantidad,
                    TipoMovimiento = "SALIDA",
                    Motivo = "Venta"
                });
            }

            venta.Total = venta.Detalles.Sum(d => d.Subtotal);
            _ventaRepo.RegistrarVenta(venta);
        }
    }
}
