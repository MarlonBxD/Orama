using BLL;
using Entity;
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
    public partial class FormCliente1 : Form
    {
        private readonly ClienteService _clienteService = new ClienteService();
        private readonly Action<Form> cambiarFormulario;
        private List<Cliente> listaClientes = new List<Cliente>();

        public FormCliente1(Action<Form> cambiarFormulario)
        {
            InitializeComponent();
            this.cambiarFormulario = cambiarFormulario;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }
                Cliente cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Direccion = txtDireccion.Text
                };

                _clienteService.Agregar(cliente);
                CargarClientes();
                cargarTabla();

                MessageBox.Show("Cliente agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar cliente: {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un cliente primero.");
                    return;
                }

                int idCliente = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                Cliente cliente = listaClientes.FirstOrDefault(c => c.Id == idCliente);

                if (cliente != null)
                {
                    cliente.Nombre = txtNombre.Text.Trim();
                    cliente.Apellido = txtApellido.Text.Trim();
                    cliente.Email = txtEmail.Text.Trim();
                    cliente.Telefono = txtTelefono.Text.Trim();
                    cliente.Direccion = txtDireccion.Text.Trim();

                    _clienteService.Actualizar(cliente);

                    CargarClientes();

                    dgv.DataSource = null;
                    dgv.DataSource = listaClientes;

                    if (dgv.Columns.Contains("Id"))
                        dgv.Columns["Id"].Visible = false;

                    if (dgv.Columns.Contains("NombreCompleto"))
                        dgv.Columns["NombreCompleto"].Visible = false;

                    MessageBox.Show("Cliente modificado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar cliente: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un cliente para eliminar.");
                    return;
                }

                int idCliente = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                var confirmar = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmar != DialogResult.Yes) return;

                _clienteService.Delete(idCliente);

                CargarClientes();
                cargarTabla();

                dgv.DataSource = null;
                dgv.DataSource = listaClientes;

                if (dgv.Columns.Contains("Id"))
                    dgv.Columns["Id"].Visible = false;

                if (dgv.Columns.Contains("NombreCompleto"))
                    dgv.Columns["NombreCompleto"].Visible = false;

                MessageBox.Show("Cliente eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cliente: {ex.Message}");
            }
        }

        private void CargarClientes()
        {
            try
            {
                listaClientes = _clienteService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes {ex.Message}");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
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
                dgv.DataSource = listaClientes;
            }
            else
            {
                var listaFiltrada = listaClientes.Where(c => c.Nombre.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)
                                                        || c.Apellido.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)).ToList();

                dgv.DataSource = listaFiltrada;
            }
        }

        private void FormCliente1_Load(object sender, EventArgs e)
        {
            CargarClientes();
            cargarTabla();
        }

        private void cargarTabla()
        {
            dgv.DataSource = null;
            dgv.DataSource = listaClientes;

            if (dgv.Columns.Contains("Id"))
                dgv.Columns["Id"].Visible = false;

            if (dgv.Columns.Contains("NombreCompleto"))
                dgv.Columns["NombreCompleto"].Visible = false;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv.Rows[e.RowIndex];


                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value?.ToString();
                txtEmail.Text = fila.Cells["Email"].Value?.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString();
            }
        }

        private void btnDespachos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un cliente para continuar");
                    return;
                }

                int idCliente = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                var despachos = _clienteService.ObtenerDespachosPorCliente(idCliente);
                if(despachos == null || despachos.Count == 0)
                {
                    MessageBox.Show("No se encontraron despachos para el cliente seleccionado.");
                    return;
                }

                dgv.DataSource = despachos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar despachos: {ex.Message}");
            }
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un cliente para continuar");
                    return;
                }

                int idCliente = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                var reservas = _clienteService.ObtenerReservasPorCliente(idCliente);

                dgv.DataSource = reservas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reservas: {ex.Message}");
            }
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un cliente para continuar");
                    return;
                }

                int idCliente = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                var pagos = _clienteService.ObtenerPagosPorCliente(idCliente);

                dgv.DataSource = pagos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pagos: {ex.Message}");
            }
        }
    }
}
