using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaEvento { get; set; }
        public string EstadoReserva { get; set; }
        public string Observaciones { get; set; }
        public ClienteDTO Cliente { get; set; }
        public EventoDTO Evento { get; set; }
        public PaqueteDeServicioDTO PaqueteDeServicio { get; set; }
        //public List<Evento> Eventos { get; set; }

    }
}
