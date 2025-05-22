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
                if (!int.TryParse(txtId.Text, out int idEquipo))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                EquipoFotografico equipo = new EquipoFotografico
                {
                    Id = idEquipo,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Tipo = txtTipo.Text,
                    Estado = txtEstado.Text,
                    Cantidad = int.Parse(txtCantidad.Text)
                };

                _equipoService.Actualizar(equipo);
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
                if (!int.TryParse(txtId.Text, out int idEquipo))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                _equipoService.EliminarEquipoFotografico(idEquipo);
                MessageBox.Show("Equipo fotográfico eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar equipo: {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int idEquipo))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                EquipoFotografico equipo = _equipoService.GetById(idEquipo);

                if (equipo != null)
                {
                    txtMarca.Text = equipo.Marca;
                    txtModelo.Text = equipo.Modelo;
                    txtTipo.Text = equipo.Tipo;
                    txtEstado.Text = equipo.Estado;
                    txtCantidad.Text = equipo.Cantidad.ToString();
                }
                else
                {
                    MessageBox.Show("Equipo no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar equipo: {ex.Message}");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cambiarFormulario(new FormEquipoConsulta(cambiarFormulario));
        }
    }
}
