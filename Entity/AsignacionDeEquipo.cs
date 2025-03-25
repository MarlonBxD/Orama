using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AsignacionDeEquipo
    {
        public Fotografo Fotografo { get; set; }
        public EquipoFotografico Equipo { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Estado { get; set; }
    }
}
