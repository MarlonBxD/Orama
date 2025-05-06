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
        public Evento Evento { get; set; }
        public string EstadoReserva { get; set; }
        public string Observaciones { get; set; }
        public Cliente Cliente { get; set; }


        public Reserva()
        {

        }

        public Reserva(int idReserva, DateTime fechaReserva, DateTime fechaEvento, Evento evento, string estadoReserva, string observaciones, Cliente cliente)
        {
            IdReserva = idReserva;
            FechaReserva = fechaReserva;
            FechaEvento = fechaEvento;
            Evento = evento;
            EstadoReserva = estadoReserva;
            Observaciones = observaciones;
            Cliente = cliente;
        }
    }
}
