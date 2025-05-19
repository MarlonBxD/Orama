using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Asignacion
    {
        public int Id { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public Fotografo Fotografo { get; set; }
        public Evento Evento { get; set; }
    }
}
