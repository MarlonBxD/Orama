﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class ReservaDTO
    {
        public int Id { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaEvento { get; set; }
        public string EstadoReserva { get; set; }
        public string Observaciones { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public int IdEvento { get; set; }
        public string TipoEvento { get; set; }
        public int IdPaqueteDeServicio { get; set; }
        public string NombrePaqueteDeServicio { get; set; }
    }
}
