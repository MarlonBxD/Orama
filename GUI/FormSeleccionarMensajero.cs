using BLL;
using Entity;
using Entity.Dto;
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
    public partial class FormSeleccionarMensajero : Form
    {
        private readonly MensajeroService _mensajeroService = new MensajeroService();
        private List<Mensajero> listaMensajeros = new List<Mensajero>();

        public FormSeleccionarMensajero()
        {
            InitializeComponent();
        }

        private void FormSeleccionarMensajero_Load(object sender, EventArgs e)
        {
            listaMensajeros = _mensajeroService.GetAll();

            dgv.DataSource = null;
            dgv.DataSource = listaMensajeros;

            if (dgv.Columns.Contains("Id"))
                dgv.Columns["Id"].Visible = false;

            if (dgv.Columns.Contains("NombreCompleto"))
                dgv.Columns["NombreCompleto"].Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            string textoBuscar = txtBuscar.Text.Trim();

            ActualizarResultados(textoBuscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        private void ActualizarResultados(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgv.DataSource = listaMensajeros;
            }
            else
            {
                var listaFiltrada = listaMensajeros.Where(m => m.Nombre.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)
                                                        || m.Apellido.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)).ToList();

                dgv.DataSource = listaFiltrada;
            }
        }

        public Mensajero MensajeroSeleccionado { get; private set; }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                MensajeroSeleccionado = (Mensajero)dgv.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
