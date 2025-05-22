using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class IngresoDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public string MetodoPago { get; set; }

        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
    }

}
