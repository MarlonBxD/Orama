using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PagoFotografo
    {
        public Fotografo Fotografo { get; set; }
        public double Monto { get; set; }

        public PagoFotografo(Fotografo fotografo, double monto)
        {
            Fotografo = fotografo;
            Monto = monto;
        }
    }
}
