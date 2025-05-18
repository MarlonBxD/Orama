using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Egreso : Transaccion
    {
        public string tipoEgreso { get; set; }
        public Cliente? Cliente { get; set; }
        public Fotografo? Fotografo { get; set; }


    }
     
}
