using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormEquipoConsulta : Form
    {
        private readonly EquipoDefotografiaService _equipoService = new EquipoDefotografiaService();
        private readonly Action<Form> cambiarFormulario;

        public FormEquipoConsulta(Action<Form> cambiarFormulario)
        {
            InitializeComponent();
            this.cambiarFormulario = cambiarFormulario;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            cambiarFormulario(new FormEquipoConsulta(cambiarFormulario));
        }

        private void FormEquipoConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                var listaEquipos = _equipoService.ObtenerEquiposFotograficos();

                var listaFormateada = listaEquipos.Select(e => new
                {
                    e.Marca,
                    e.Modelo,
                    e.Tipo,
                    e.Estado,
                    e.Cantidad
                }).ToList();

                dgvConsulta.DataSource = null;
                dgvConsulta.Columns.Clear();
                dgvConsulta.DataSource = listaFormateada;

                dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar equipos fotográficos: " + ex.Message);
            }
        }
    }
}
