using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Fotografo: Persona
    {
        public string Especialidad { get; set; }

        public List<AsignacionDeEquipo> AsignacionesDeEquipos { get; set; } = new();
        public List<Asignacion> AsignacionesDeEventos { get; set; } = new();
        public List<Reserva> Pagos { get; set; }
        public List<Evento> Eventos { get; set; } = new();
    }
}
