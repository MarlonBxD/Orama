using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Fotografia
    {
        public int Id { get; set; }
        public string URLFotografia { get; set; }
        public DateTime FechaCaptura { get; set; }
        public string Descripcion { get; set; }
        public string Formato { get; set; }
        public string Resolucion { get; set; }

        public Evento evento { get; set; }
        public Despacho despacho { get; set; }

    }
}
