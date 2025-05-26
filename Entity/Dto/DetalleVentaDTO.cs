using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class DetalleVentaDTO
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int PaqueteServicioId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Descuento { get; set; }
        public decimal Subtotal { get; set; }
        public string NombreProducto { get; set; }
        public string NombrePaqueteServicio { get; set; }
    }
}
