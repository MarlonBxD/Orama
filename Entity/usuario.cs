using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario: Persona
    {
        public string Direccion { get; set; } = string.Empty;
        public string nombreUsuario { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty; 
        public string tipoUsuario { get; set; } = string.Empty; 
    }
}
