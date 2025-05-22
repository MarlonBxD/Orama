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

        public PaqueteDeServicioDTO PaqueteDeServicio { get; set; }
        public ClienteDTO Cliente { get; set; }
        public MensajeroDTO Mensajero { get; set; } 

    }

}
