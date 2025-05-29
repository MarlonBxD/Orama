using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente : Persona
    {
        public string Direccion { get; set; } = string.Empty; 
        public string NombreCompleto { get; private set; }
        public List<Pago> Pagos { get; set; }
        public List<Reserva> Reservas { get; set; }
        public List<Despacho> Despachos { get; set; }

        public Cliente()
        {
            NombreCompleto = $"{Nombre} {Apellido}"; 
        }
    }
}
