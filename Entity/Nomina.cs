using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Nomina()
    {
        public int Id { get; private set; }
        public DateTime FechaPago { get; private set; }
        public double Total_Pagos { get; private set; }
        public Fotografo Fotografo { get; private set; }
    }
}
