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
        public List<PagoFotografo> PagosFotografos { get; set; } = new List<PagoFotografo>();

        

        private void CalcularTotal()
        {
                        
        }

        public void AgregarPagoFotografo(PagoFotografo pago)
        {
            PagosFotografos.Add(pago);
            CalcularTotal();
        }

        public void AgregarEgreso(Egreso egreso)
        {
            Egresos.Add(egreso);
            CalcularTotal();
        }
    }
}
