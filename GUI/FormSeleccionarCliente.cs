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
    public partial class FormSeleccionarCliente : Form
    {
        private readonly ClienteService _clienteService = new ClienteService();
        private List<Cliente> listaClientes = new List<Cliente>();

        public FormSeleccionarCliente()
        {
            InitializeComponent();
        }

        private void FormSeleccionarCliente_Load(object sender, EventArgs e)
        {
            listaClientes = _clienteService.GetAll();

            dgv.DataSource = null;
            dgv.DataSource = listaClientes;

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
                dgv.DataSource = listaClientes;
            }
            else
            {
                var listaFiltrada = listaClientes.Where(c => c.Nombre.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)
                                                        || c.Apellido.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)).ToList();

                dgv.DataSource = listaFiltrada;
            }
        }

        public Cliente ClienteSeleccionado { get; private set; }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                ClienteSeleccionado = (Cliente)dgv.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
