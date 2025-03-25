using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pago
    {
        public int ID_Pago { get; set; }
        public double Monto { get; set; }
        public double AbonoInicial { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public string Metodo_Pago { get; set; }
        public Reserva Reserva { get; set; }


        public bool EsPagoCompleto()
        {
            return Monto >= Reserva.PaqueteDeServicios.PrecioPaquete;
        }

    }

}
