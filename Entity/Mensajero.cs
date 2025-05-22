using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Mensajero: Persona
    {
        public string Direccion { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Teléfono: {Telefono}, Email: {Email}, Dirección: {Direccion}";
        }


    }

}
