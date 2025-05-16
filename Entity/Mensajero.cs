using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Mensajero: Persona
    {
        public string Direccion { get; set; }
        public string tipo_mensajero { get; set; }

        public Mensajero()
        {
        }
        public string NombreCompleto => $"{Nombre} {Apellido}";
    }

}
