using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pago : Transaccion
    {
        public Cliente Cliente { get; set; }

    }

}
