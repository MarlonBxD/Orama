using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente: Persona
    {
        public string Direccion { get; set; }


        public Cliente( string nombre, string telefono, string direccion)
        {
            
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }

    }
}
