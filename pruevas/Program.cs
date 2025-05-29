using BLL;
using DAL;
using Entity;
using Entity.Dto;
using Entity.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        VentaRepository ventaRepository = new VentaRepository();
        ProductoRepository productoRepository = new ProductoRepository();
        MovimientoInventarioRepository movimientoRepository = new MovimientoInventarioRepository();
        VentaService ventaService = new VentaService(ventaRepository, productoRepository, movimientoRepository);

        Venta venta = new Venta();
        venta.Fecha = DateTime.Now;
        venta.ClienteId = 1; // Asignar un cliente existente
        venta.Detalles = new List<DetalleVenta>
        {
            new DetalleVenta
            {
                ProductoId = 1, // Asignar un producto existente
                Cantidad = 2,
                PrecioUnitario = 100.00
            },
            new DetalleVenta
            {
                ProductoId = 2, // Asignar otro producto existente
                Cantidad = 1,
                PrecioUnitario = 150.00

            }
        };
        venta.Total = venta.Detalles.Sum(d => d.Cantidad * d.PrecioUnitario);

        try
        {
            ventaService.RegistrarVenta(venta);
            Console.WriteLine($"Venta registrada con éxito. ID: {venta.Id}, Total: {venta.Total}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al registrar la venta: {ex.Message}");
        }




    }
}

