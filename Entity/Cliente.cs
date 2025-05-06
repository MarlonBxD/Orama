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

        
        public Cliente()
        {

        }

        public Cliente(int Id, string Nombre, string Apellido, string Telefono, string Email, string Direccion)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Email = Email;
            this.Direccion = Direccion;
        }

    }
}
