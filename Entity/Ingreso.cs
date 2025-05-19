using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ingreso : Transaccion
    {
        public string Concepto { get; set; }
        public ClienteDTO Cliente { get; set; }
    }
}

