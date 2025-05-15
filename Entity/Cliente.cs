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
        public List<Despacho> Despachos { get; set; } = new List<Despacho>(); 
        public string NombreCompleto { get; private set; } 

        public Cliente()
        {
            NombreCompleto = $"{Nombre} {Apellido}"; 
        }
    }
}
