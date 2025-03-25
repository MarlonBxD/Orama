using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public DateTime Fecha { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public string EstadoEvento { get; set; }
        //public Cliente Cliente { get; set; }


    }
}
