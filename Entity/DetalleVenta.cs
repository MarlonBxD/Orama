using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public int? PaqueteServicioId { get; set; }
        public double PrecioUnitario { get; set; }
        public int Descuento { get; set; }
        public double Subtotal => (Cantidad * PrecioUnitario) - Descuento;

        public PaqueteDeServicio PaqueteServicio { get; set; }
        public Producto producto { get; set; }
    }
}
