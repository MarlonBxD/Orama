using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MovimientoInventario
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string TipoMovimiento { get; set; } // "Salida" o "Entrada"
        public string Motivo { get; set; } // "Venta", "Ajuste", etc.
    }
}

