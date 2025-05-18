using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class DespachoResponseDTO
    {
        public int Id { get; set; }
        public DateTime FechaDespacho { get; set; }
        public string Estado { get; set; }
        public string ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteTelefono { get; set; }
        public string ClienteDireccion { get; set; }
        public string MensajeroId { get; set; }
        public string MensajeroNombre { get; set; }
        public int NumeroPaquetes { get; set; }
    }
}
