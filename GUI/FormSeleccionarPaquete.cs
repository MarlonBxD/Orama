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
    public partial class FormSeleccionarPaquete : Form
    {
        private readonly PaqueteDeServicioService _paqueteService = new PaqueteDeServicioService();
        private List<PaqueteDeServicioDTO> listaPaquetes = new List<PaqueteDeServicioDTO>();

        public FormSeleccionarPaquete()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        public PaqueteDeServicioDTO PaqueteSeleccionado { get; private set; }
        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                PaqueteSeleccionado = (PaqueteDeServicioDTO)dgv.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormSeleccionarPaquete_Load(object sender, EventArgs e)
        {
            listaPaquetes = _paqueteService.GetAll();

            dgv.DataSource = null;
            dgv.DataSource = listaPaquetes;

            if (dgv.Columns.Contains("Id"))
                dgv.Columns["Id"].Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            string textoBuscar = txtBuscar.Text.Trim();

            ActualizarResultados(textoBuscar);
        }

        private void ActualizarResultados(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgv.DataSource = listaPaquetes;
            }
            else
            {
                var listaFiltrada = listaPaquetes.Where(p => p.Nombre.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)).ToList();

                dgv.DataSource = listaFiltrada;
            }
        }
    }
}
