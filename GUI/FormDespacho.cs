using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity.Dto;
using Entity;

namespace GUI
{
    public partial class FormDespacho : Form
    {
        private readonly DespachoService _service;
        private readonly MensajeroService _mensajeroservice;
        private readonly ClienteService _clienteservice;
        private List<string> estados;
        public FormDespacho()
        {
            InitializeComponent();
            _service = new DespachoService();
            _mensajeroservice = new MensajeroService();
            _clienteservice = new ClienteService();
            CargarClientes();
            CargarMensajeros();
            estados = new List<string>{"Pendiente",
            "En Proceso",
            "Entregado" };
            CargarEstados();
            ConfigurarEventos();
        }


        private void CargarMensajeros()
        {
            try
            {
                var mensajeros = _mensajeroservice.GetAll();
                cbMensajeros.DataSource = mensajeros;
                cbMensajeros.DisplayMember = "Nombre";
                cbMensajeros.ValueMember = "Id";
                cbMensajeros.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar mensajeros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarClientes()
        {
            try
            {
                var nombres = _clienteservice.GetAll();
                cbClientes.DataSource = nombres;
                cbClientes.DisplayMember = "Nombre";
                cbClientes.ValueMember = "Id";
                cbClientes.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarEstados()
        {
            try
            {
                cbEstados.DataSource = estados;
                cbEstados.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarEventos()
        {
            cbClientes.SelectedIndexChanged += CmbClientes_SelectedIndexChanged;


        }
        private void CmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClientes.SelectedIndex != -1 && cbClientes.SelectedItem is Cliente clienteSeleccionado)
            {
                textTelefono.Text = clienteSeleccionado.Telefono ?? string.Empty;
                textDireccion.Text = clienteSeleccionado.Direccion ?? string.Empty;
            }
            else
            {
                textTelefono.Text = string.Empty;
                textDireccion.Text = string.Empty;
            }
        }
        private void LimpiarFormulario()
        {
            dtpFecha.Value = DateTime.Today;
            cbClientes.SelectedIndex = -1;
            textTelefono.Text = string.Empty;
            textDireccion.Text = string.Empty;
            cbMensajeros.SelectedIndex = -1;
            cbEstados.SelectedIndex = 0;
            numup.Value = 0;
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbClientes.SelectedIndex == -1 || cbMensajeros.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un cliente y un mensajero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(textTelefono.Text) || string.IsNullOrEmpty(textDireccion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (numup.Value <= 0)
                {
                    MessageBox.Show("El número de paquetes debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var clienteSeleccionado = cbClientes.SelectedItem as Cliente;
                var mensajeroSeleccionado = cbMensajeros.SelectedItem as Mensajero;

                if (clienteSeleccionado == null || mensajeroSeleccionado == null)
                {
                    MessageBox.Show("Error al obtener el cliente o mensajero seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var despacho = new Despacho
                {
                    FechaDespacho = dtpFecha.Value,
                    Estado = cbEstados.Text,
                    Cliente = new Cliente
                    {
                        Id = clienteSeleccionado.Id
                    },
                    Mensajero = new Mensajero
                    {
                        Id = mensajeroSeleccionado.Id
                    },
                    NumeroPaquetes = (int)numup.Value
                };

                string resultado = _service.Agregar(despacho);
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar despacho: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
