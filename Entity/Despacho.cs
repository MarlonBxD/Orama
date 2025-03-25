using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{

    public class Despacho
    {
        public int IdEntrega { get; set; }
        public Cliente cliente { get; set; }
        public string Estado { get; set; }

    }
}
