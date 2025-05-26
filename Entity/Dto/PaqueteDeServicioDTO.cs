using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class PaqueteDeServicioDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public int DuracionPaquete { get; set; }
        public List<Producto> productos { get; set; } = new List<Producto>();

        public PaqueteDeServicioDTO()
        {
            
        }

    }
}
