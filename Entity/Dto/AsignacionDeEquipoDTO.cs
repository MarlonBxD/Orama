using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class AsignacionDeEquipoDTO
    {
        public int Id { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Estado { get; set; }
        public string nombreFotografo { get; set; } 
        public string nombreEquipo { get; set; }


    }
}
