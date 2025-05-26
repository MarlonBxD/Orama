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
    public partial class FormDespacho1 : Form
    {
        private readonly DespachoService _despachoService = new DespachoService();
        private readonly Action<Form> cambiarFormulario;
        private List<DespachoDTO> listaDespachos = new List<DespachoDTO>();

        public FormDespacho1(Action<Form> cambiarFormulario)
        {
            InitializeComponent();
            this.cambiarFormulario = cambiarFormulario;
        }

        private void panelBuscar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDespacho1_Load(object sender, EventArgs e)
        {
            CargarDespachos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteSeleccionado == null)
                {
                    MessageBox.Show("Cliente sin asignar");
                }

                if (mensajeroSeleccionado == null)
                {
                    MessageBox.Show("Mensajero sin asignar");
                }

                if (paqueteSeleccionado == null)
                {
                    MessageBox.Show("Paquete de servicio sin asignar");
                }

                Despacho despacho = new Despacho
                {
                    FechaDespacho = dtFecha.Value,
                    Estado = txtEstado.Text,
                    NumeroPaquetes = int.Parse(txtNumPaquetes.Text),
                    Cliente = clienteSeleccionado,
                    PaqueteDeServicio = paqueteSeleccionado,
                    Mensajero = mensajeroSeleccionado
                };

                _despachoService.Agregar(despacho);
                MessageBox.Show("Despacho agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar Despacho: {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un despacho primero.");
                    return;
                }

                int idCliente = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                DespachoDTO despacho = listaDespachos.FirstOrDefault(c => c.Id == idCliente);

                if (despacho != null)
                {
                    Despacho despachoCompleto = new Despacho();

                    despachoCompleto.Estado = despacho.Estado;
                    despachoCompleto.NumeroPaquetes = despacho.NumeroPaquetes;
                    despachoCompleto.FechaDespacho = despachoCompleto.FechaDespacho;

                    despachoCompleto.Estado = txtEstado.Text;
                    despachoCompleto.NumeroPaquetes = int.Parse(txtNumPaquetes.Text);
                    despachoCompleto.FechaDespacho = dtFecha.Value;

                    _despachoService.Update(despachoCompleto);

                    CargarDespachos();

                    dgv.DataSource = null;
                    dgv.DataSource = listaDespachos;

                    if (dgv.Columns.Contains("Id"))
                        dgv.Columns["Id"].Visible = false;

                    MessageBox.Show("Despacho modificado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar despacho: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un despacho para eliminar.");
                    return;
                }

                int idCliente = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                var confirmar = MessageBox.Show("¿Está seguro de eliminar este despacho?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmar != DialogResult.Yes) return;

                _despachoService.Delete(idCliente);

                CargarDespachos();

                dgv.DataSource = null;
                dgv.DataSource = listaDespachos;

                if (dgv.Columns.Contains("Id"))
                    dgv.Columns["Id"].Visible = false;

                MessageBox.Show("Despacho eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar despacho: {ex.Message}");
            }
        }

        private void btnVerDespachos_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = listaDespachos;

            if (dgv.Columns.Contains("Id"))
                dgv.Columns["Id"].Visible = false;
        }

        private ClienteDTO clienteSeleccionado;
        private void btnAsignarCliente_Click(object sender, EventArgs e)
        {
            using (var formBuscarCliente = new FormSeleccionarCliente())
            {
                if (formBuscarCliente.ShowDialog() == DialogResult.OK)
                {
                    clienteSeleccionado = formBuscarCliente.ClienteSeleccionado;
                }
            }
        }

        private MensajeroDTO mensajeroSeleccionado;
        private void btnAsignarMensajero_Click(object sender, EventArgs e)
        {
            using (var formSeleccionarMensajero = new FormSeleccionarMensajero())
            {
                if (formSeleccionarMensajero.ShowDialog() == DialogResult.OK)
                {
                    mensajeroSeleccionado = formSeleccionarMensajero.MensajeroSeleccionado;
                }
            }
        }

        private PaqueteDeServicioDTO paqueteSeleccionado;
        private void btnAsignarPaquete_Click(object sender, EventArgs e)
        {
            using (var formSeleccionarPaquete = new FormSeleccionarPaquete())
            {
                if (formSeleccionarPaquete.ShowDialog() == DialogResult.OK)
                {
                    paqueteSeleccionado = formSeleccionarPaquete.PaqueteSeleccionado;
                }
            }
        }

        private void CargarDespachos()
        {
            listaDespachos = _despachoService.GetAll();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv.Rows[e.RowIndex];


                txtEstado.Text = fila.Cells["Estado"].Value?.ToString();
                txtNumPaquetes.Text = fila.Cells["NumeroPaquetes"].Value?.ToString();
                dtFecha.Value = Convert.ToDateTime(fila.Cells["FechaDespacho"].Value);
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
                dgv.DataSource = listaDespachos;
            }
            else
            {
                var listaFiltrada = listaDespachos.Where(d => d.NombreCliente.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)).ToList();

                dgv.DataSource = listaFiltrada;
            }
        }
    }
}
