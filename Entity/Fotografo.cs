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
        public string Portafolio { get; set; }

        public List<AsignacionDeEquipo> Asignaciones { get; set; } = new();
        public List<PagoFotografo> Pagos { get; set; } = new();
        public List<Evento> Eventos { get; set; } = new();
    }
}
