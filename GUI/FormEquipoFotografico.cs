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
    public partial class FormEquipoFotografico : Form
    {
        private readonly EquipoDefotografiaService _equipoService = new EquipoDefotografiaService();
        private readonly Action<Form> cambiarFormulario;
        private List<EquipoFotografico> listaEquipos = new();


        public FormEquipoFotografico(Action<Form> cambiarFormulario)
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
                EquipoFotografico equipo = new EquipoFotografico
                {
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Tipo = txtTipo.Text,
                    Estado = txtEstado.Text,
                    Cantidad = int.Parse(txtCantidad.Text)
                };

                _equipoService.Agregar(equipo);
                CargarEquipos();
                CargarTabla();
                LIAR();

                MessageBox.Show("Equipo fotográfico agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar equipo: {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un equipo para actualizar.");
                    return;
                }

                int idEquipo = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                var equipoActualizado = new EquipoFotografico
                {
                    Id = idEquipo,
                    Marca = txtMarca.Text.Trim(),
                    Modelo = txtModelo.Text.Trim(),
                    Tipo = txtTipo.Text.Trim(),
                    Estado = txtEstado.Text.Trim(),
                    Cantidad = int.TryParse(txtCantidad.Text, out int cantidad) ? cantidad : 0
                };

                _equipoService.Actualizar(equipoActualizado);

                CargarEquipos();

                dgv.DataSource = null;
                dgv.DataSource = listaEquipos;

                if (dgv.Columns.Contains("Id"))
                    dgv.Columns["Id"].Visible = false;

                MessageBox.Show("Equipo fotográfico actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar equipo: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un equipo para eliminar.");
                    return;
                }

                int idEquipo = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                var confirm = MessageBox.Show("¿Está seguro de eliminar este equipo?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _equipoService.EliminarEquipoFotografico(idEquipo);

                    CargarEquipos();
                    CargarTabla();

                    dgv.DataSource = null;
                    dgv.DataSource = listaEquipos;

                    if (dgv.Columns.Contains("Id"))
                        dgv.Columns["Id"].Visible = false;

                    MessageBox.Show("Equipo fotográfico eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar equipo: {ex.Message}");
            }
        }

        private void CargarEquipos()
        {
            try
            {
                listaEquipos = _equipoService.ObtenerEquiposFotograficos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar equipos fotográficos: {ex.Message}");
            }
        }
        private void CargarTabla()
        {
            dgv.DataSource = null;
            dgv.DataSource = listaEquipos;
            if (dgv.Columns.Contains("Id"))
                dgv.Columns["Id"].Visible = false;
        }

        private void btnVerEquipos_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void FormEquipoFotografico_Load(object sender, EventArgs e)
        {
            CargarEquipos();  
            CargarTabla();    
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                var fila = dgv.SelectedRows[0];
                txtMarca.Text = fila.Cells["Marca"].Value?.ToString();
                txtModelo.Text = fila.Cells["Modelo"].Value?.ToString();
                txtTipo.Text = fila.Cells["Tipo"].Value?.ToString();
                txtEstado.Text = fila.Cells["Estado"].Value?.ToString();
                txtCantidad.Text = fila.Cells["Cantidad"].Value?.ToString();
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
                dgv.DataSource = listaEquipos;
            }
            else
            {
                var listaFiltrada = listaEquipos.Where(e => e.Marca.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)
                                                        || e.Modelo.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)).ToList();

                dgv.DataSource = listaFiltrada;
            }
        }
        private void LIAR()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtTipo.Clear();
            txtEstado.Clear();
            txtCantidad.Clear();
            txtBuscar.Clear();
        }
    }
}
