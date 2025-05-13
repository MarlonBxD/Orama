using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity

namespace FormularioGenerico
{
    public partial class Form1: Form
    {
        private readonly Conexion conexion;
        public Form1()
        {
            InitializeComponent();
            conexion = new DAL.Conexion();
        }

        private void agregarEvento()
        {
            
            var evento = new Entity.Evento
            {
                Tipo = "Concierto",
                Fecha = DateTime.Now,
                Ubicacion = "Auditorio Principal"
            };
            // Llamar al método AddEvento del repositorio
            var eventoRepository = new DAL.EventoRepository();
            eventoRepository.AddEvento(evento);
        }
    }
}
