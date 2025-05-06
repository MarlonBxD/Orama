using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Evento
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Ubicacion { get; set; }

        public List<Fotografia> Fotografias { get; set; } = new();
        public List<PaqueteDeServicio> PaqueteDeServicios { get; set; } = new();

        public Fotografo Fotografo { get; set; }
        public Reserva Reserva { get; set; } 
    }

}
