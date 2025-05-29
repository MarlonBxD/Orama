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
    public partial class FormFotografo : Form
    {
        private readonly FotografoService _fotografoService = new FotografoService();
        private readonly Action<Form> cambiarFormulario;
        private List<Fotografo> listaFotografos;

        public FormFotografo(Action<Form> cambiarFormulario)
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
                Fotografo fotografo = new Fotografo
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Especialidad = txtEspecialidad.Text
                };

                _fotografoService.AgregarFotografo(fotografo);
                MessageBox.Show("Fotografo agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar fotografo: {ex.Message}");
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

                Fotografo fotografo = listaFotografos.FirstOrDefault(f => f.Id == idCliente);

                if (fotografo != null)
                {
                    fotografo.Nombre = txtNombre.Text.Trim();
                    fotografo.Apellido = txtApellido.Text.Trim();
                    fotografo.Email = txtEmail.Text.Trim();
                    fotografo.Telefono = txtTelefono.Text.Trim();
                    fotografo.Especialidad = txtEspecialidad.Text.Trim();

                    _fotografoService.ActualizarFotografo(fotografo);

                    CargarFotografos();

                    dgv.DataSource = null;
                    dgv.DataSource = listaFotografos;

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
                    MessageBox.Show("Seleccione un fotógrafo para eliminar.");
                    return;
                }

                int idCliente = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                var confirmar = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmar != DialogResult.Yes) return;

                _fotografoService.EliminarFotografo(idCliente);

                CargarFotografos();

                dgv.DataSource = null;
                dgv.DataSource = listaFotografos;

                if (dgv.Columns.Contains("Id"))
                    dgv.Columns["Id"].Visible = false;

                if (dgv.Columns.Contains("NombreCompleto"))
                    dgv.Columns["NombreCompleto"].Visible = false;

                MessageBox.Show("Fotógrafo eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar fotógrafo: {ex.Message}");
            }
        }

        private void FormFotografo_Load(object sender, EventArgs e)
        {
            CargarFotografos();
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
                txtEspecialidad.Text = fila.Cells["Especialidad"].Value?.ToString();
            }
        }

        private void CargarFotografos()
        {
            try
            {
                listaFotografos = _fotografoService.ObtenerFotografos();
                dgv.DataSource = null;
                dgv.DataSource = listaFotografos;

                if (dgv.Columns.Contains("Id"))
                    dgv.Columns["Id"].Visible = false;

                if (dgv.Columns.Contains("NombreCompleto"))
                    dgv.Columns["NombreCompleto"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar fotógrafos: {ex.Message}");
            }
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
                dgv.DataSource = listaFotografos;
            }
            else
            {
                var listaFiltrada = listaFotografos.Where(f => f.Nombre.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)
                                                        || f.Apellido.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)).ToList();

                dgv.DataSource = listaFiltrada;
            }
        }

        private void btnVerFotografos_Click(object sender, EventArgs e)
        {
            CargarFotografos();
        }
        private void LimpiarFormulario()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEspecialidad.Text = string.Empty;
        }
    }
}
