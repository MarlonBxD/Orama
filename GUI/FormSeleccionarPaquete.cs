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
        private List<PaqueteDeServicio> listaPaquetes = new List<PaqueteDeServicio>();

        public FormSeleccionarPaquete()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        public PaqueteDeServicio PaqueteSeleccionado { get; private set; }
        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                PaqueteSeleccionado = (PaqueteDeServicio)dataGridView1.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormSeleccionarPaquete_Load(object sender, EventArgs e)
        {
            try
            {
                listaPaquetes = _paqueteService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar paquetes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPaquetes;


            if (dataGridView1.Columns.Contains("Id"))
                dataGridView1.Columns["Id"].Visible = false;
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
