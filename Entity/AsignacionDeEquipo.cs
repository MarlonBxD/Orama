using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AsignacionDeEquipo
    {
        public int Id { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Estado { get; set; }

        public Fotografo fotografo { get; set; }
        public EquipoFotografico equipo { get; set; }
    }
}
