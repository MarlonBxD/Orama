using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class EventoDto
    {
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Ubicacion { get; set; }
        public string Nombre { get; set; }
    }
}
