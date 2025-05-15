using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{

    public class Despacho
    {
        public int Id { get; set; }
        public DateTime FechaDespacho { get; set; }
        public string Estado { get; set; } = string.Empty;
        public int ClienteId { get; set; }
        public int? Mensajeroid { get; set; }
        public int NumeroPaquetes { get; set; }

        public Cliente Cliente { get; set; } = null!;
        public Mensajero Mensajero { get; set; } = null!;

    }

}
