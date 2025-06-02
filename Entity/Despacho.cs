using Entity.Dto;
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
        public DateTime FechaDespacho { get; set; }
        public string Estado { get; set; }
        public int NumeroPaquetes { get; set; }

        public PaqueteDeServicio PaqueteDeServicio { get; set; }
        public Cliente Cliente { get; set; }
        public Mensajero Mensajero { get; set; } 

    }

}
