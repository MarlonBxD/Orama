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
        public Cliente cliente { get; set; }
        public string Estado { get; set; }
        public DateTime FechaDespacho { get; set; }
        public Cliente Cliente { get; set; }
        public Mensajero Mensajero { get; set; }
        public List<Fotografia> Fotografias { get; set; } = new();
        public int numero_paquetes { get; set; }

        public Despacho()
        {

        }

    }
}
