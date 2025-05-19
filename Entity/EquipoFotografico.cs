using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EquipoFotografico
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public int Cantidad { get; set; }

        public List<AsignacionDeEquipo> Asignaciones { get; set; } = new();

        public override string ToString()
        {
            return $"{Marca} {Modelo}";
        }
    }

}
