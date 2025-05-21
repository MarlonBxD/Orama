using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class EventoDTO
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Ubicacion { get; set; }
        public int IdReserva { get; set; }
        public int? IdBebe { get; set; }
        public string? NombreBebe { get; set; }

        public EventoDTO()
        {
            
        }

        public EventoDTO(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }

        public EventoDTO(int id, string tipo, DateTime fecha, string ubicacion)
        {
            Id = id;
            Tipo = tipo;
            Fecha = fecha;
            Ubicacion = ubicacion;
        }
    }
}
