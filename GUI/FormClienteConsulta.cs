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
    public partial class FormClienteConsulta : Form
    {
        private readonly ClienteService _clienteService = new ClienteService();
        private readonly Action<Form> cambiarFormulario;

        public FormClienteConsulta(Action<Form> cambiarFormulario)
        {
            InitializeComponent();
            this.cambiarFormulario = cambiarFormulario;
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            try
            {
                var listaClientes = _clienteService.ObtenerTodos();

                var listaFormateada = listaClientes.Select(c => new
                {
                    c.Id,
                    c.Nombre,
                    c.Apellido,
                    c.Email,
                    c.Direccion
                }).ToList();

                dgvConsulta.DataSource = null;
                dgvConsulta.Columns.Clear();
                dgvConsulta.DataSource = listaFormateada;

                dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            cambiarFormulario(new FormCliente1(cambiarFormulario));
        }

        private void FormClienteConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int idCliente))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                var listaPagos = _clienteService.ObtenerPagosPorCliente(idCliente);

                if (listaPagos == null || listaPagos.Count == 0)
                {
                    MessageBox.Show("No se encontraron pagos para este cliente");
                    return;
                }

                var listaFormateada = listaPagos.Select(p => new
                {
                    p.Id,
                    p.Fecha,
                    p.Monto,
                    p.Descripcion,
                    p.MetodoPago,
                }).ToList();

                dgvConsulta.DataSource = null;
                dgvConsulta.Columns.Clear();
                dgvConsulta.DataSource = listaFormateada;

                dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pagos del cliente {ex.Message}");
            }
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int idCliente))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                var reservas = _clienteService.ObtenerReservasPorCliente(idCliente);

                if (reservas == null || reservas.Count == 0)
                {
                    MessageBox.Show("No se encontraron reservas.");
                    return;
                }

                var reservasFormateadas = reservas.Select(r => new
                {
                    r.Id,
                    r.FechaReserva,
                    r.FechaEvento,
                    r.EstadoReserva,
                    r.Observaciones,
                    Cliente = r.Cliente?.Nombre,
                    Evento = r.Evento?.Tipo,
                    Paquete = r.PaqueteDeServicio?.Nombre
                }).ToList();

                dgvConsulta.DataSource = null;
                dgvConsulta.Columns.Clear();
                dgvConsulta.DataSource = reservasFormateadas;
                dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar reservas: " + ex.Message);
            }
        }

        private void btnDespachos_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int idCliente))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                var despachos = _clienteService.ObtenerDespachosPorCliente(idCliente);

                if (despachos == null || despachos.Count == 0)
                {
                    MessageBox.Show("No se encontraron despachos.");
                    return;
                }

                var despachosFormateados = despachos.Select(d => new
                {
                    d.Id,
                    d.FechaDespacho,
                    d.Estado,
                    d.NumeroPaquetes,
                    Paquete = d.PaqueteDeServicio?.Nombre,
                    Cliente = d.Cliente?.Nombre,
                    Mensajero = d.Mensajero?.Nombre
                }).ToList();

                dgvConsulta.DataSource = null;
                dgvConsulta.Columns.Clear();
                dgvConsulta.DataSource = despachosFormateados;
                dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar despachos: " + ex.Message);
            }
        }
    }
}
