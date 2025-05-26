using BLL;
using DAL;
using Entity;
using Entity.Dto;
using Entity.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        // Repositorios (deben estar implementados con PostgreSQL)
        IVentaRepository ventaRepo = new VentaRepository();
        IProductoRepository productoRepo = new ProductoRepository();
        IMovimientoInventarioRepository movimientoRepo = new MovimientoInventarioRepository();

        // Servicio
        var ventaService = new VentaService(ventaRepo, productoRepo, movimientoRepo);

        // Simulación: productos seleccionados por el cliente
        var producto = productoRepo.ObtenerPorId(1);
        Console.WriteLine($"Producto seleccionado: {producto.Nombre} - Precio: {producto.Precio}");
        var detalles = new List<DetalleVenta>
        {
            new DetalleVenta
            {
                ProductoId = producto.Id,
                producto = producto, // ✅ esto es necesario si luego usas producto.Id en el repo
                Cantidad = 2,
                PrecioUnitario = producto.Precio,
                Descuento = 0
            }

        };

        // Construir la venta
        var venta = new Venta
        {
            ClienteId = 2,
            Detalles = detalles,
            Fecha = DateTime.Now
        };

        try
        {
            ventaService.RegistrarVenta(venta);
            Console.WriteLine($"✅ Venta registrada con éxito. ID de venta: {venta.Id}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"✖️😂Error al registrar la venta (program): {ex.Message}");
        }
    }


}