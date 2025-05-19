using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PaqueteDeServicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public int DuracionPaquete { get; set; }
        public EventoDTO evento { get; set; }
        //public List<Producto> productos { get; set; }

    }

}
