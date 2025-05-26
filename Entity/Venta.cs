using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public double Total { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

    }
}
