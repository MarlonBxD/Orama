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
        public int IdEvento { get; set; }
        public string TipoEvento { get; set; }

        public PaqueteDeServicioDTO()
        {
            
        }

        public PaqueteDeServicioDTO(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
