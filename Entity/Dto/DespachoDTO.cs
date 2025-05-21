using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class DespachoDTO
    {
        public int Id { get; set; }
        public DateTime FechaDespacho { get; set; }
        public string Estado { get; set; }
        public int NumeroPaquetes { get; set; }

        public string NombrePaquete { get; set; }
        public string NombreCliente { get; set; }
        public string NombreMensajero { get; set; }
    }
}
