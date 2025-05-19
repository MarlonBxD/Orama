using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class AsignacionDTO
    {
        public int Id { get; set; }
        public string TipoEvento { get; set; } = string.Empty;
        public string NombreFotografo { get; set; } = string.Empty;
    }
}
