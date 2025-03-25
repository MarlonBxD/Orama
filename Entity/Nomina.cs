using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Nomina(int ID_Nomina, DateTime Fecha_Pago, double Total_Pagos)
    {
        public double Total_Pagos { get; private set; } = Total_Pagos;

        public List<Egreso> Egresos = new List<Egreso>();
        public List<PagoFotografo> PagosFotografos { get; set; } = new List<PagoFotografo>();

        public Nomina(int idNomina, DateTime fechaPago) : this(idNomina, fechaPago, default)
        {
        }

        private void CalcularTotal()
        {
            Total_Pagos = 0;
            foreach (var pago in PagosFotografos)
            {
                Total_Pagos += pago.Monto;
            }
            foreach (var egreso in Egresos)
            {
                Total_Pagos += egreso.Monto;
            }
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
