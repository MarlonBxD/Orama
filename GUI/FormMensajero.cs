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
    public partial class FormMensajero : Form
    {
        private readonly MensajeroService _mensajeroService = new MensajeroService();
        private readonly Action<Form> cambiarFormulario;
        private List<Mensajero> listaMensajeros = new List<Mensajero>();

        public FormMensajero(Action<Form> cambiarFormulario)
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
                Mensajero mensajero = new Mensajero
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Direccion = txtDireccion.Text
                };

                _mensajeroService.Agregar(mensajero);
                MessageBox.Show("Mensajero agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar mensajero: {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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

                _mensajeroService.Delete(idCliente);

                CargarMensajeros();

                dgv.DataSource = null;
                dgv.DataSource = listaMensajeros;

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un mensajero para eliminar.");
                    return;
                }

                int idCliente = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                var confirmar = MessageBox.Show("¿Está seguro de eliminar este mensajero?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmar != DialogResult.Yes) return;

                _mensajeroService.Delete(idCliente);

                CargarMensajeros();

                dgv.DataSource = null;
                dgv.DataSource = listaMensajeros;

                if (dgv.Columns.Contains("Id"))
                    dgv.Columns["Id"].Visible = false;

                if (dgv.Columns.Contains("NombreCompleto"))
                    dgv.Columns["NombreCompleto"].Visible = false;

                MessageBox.Show("Mensajero eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar mensajero: {ex.Message}");
            }
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = listaMensajeros;

            if (dgv.Columns.Contains("Id"))
                dgv.Columns["Id"].Visible = false;

            if (dgv.Columns.Contains("NombreCompleto"))
                dgv.Columns["NombreCompleto"].Visible = false;
        }

        private void FormMensajero_Load(object sender, EventArgs e)
        {
            CargarMensajeros();
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

        private void CargarMensajeros()
        {
            try
            {
                listaMensajeros = _mensajeroService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar mensajeros: {ex.Message}");
            }
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

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
