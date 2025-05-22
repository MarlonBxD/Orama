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

        public FormFotografo(Action<Form> cambiarFormulario)
        {
            InitializeComponent();
            this.cambiarFormulario = cambiarFormulario;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cambiarFormulario(new FormFotografoConsulta(cambiarFormulario));
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
                Fotografo fotografo = new Fotografo
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Especialidad = txtEspecialidad.Text
                };

                _fotografoService.ActualizarFotografo(fotografo);
                MessageBox.Show("Fotografo actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar fotografo: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int idFotografo))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                _fotografoService.EliminarFotografo(idFotografo);
                MessageBox.Show("Fotografo eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar fotografo: {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int idFotografo))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                FotografoDTO fotografo = _fotografoService.ObtenerFotografoPorId(idFotografo);

                if (fotografo != null)
                {
                    txtNombre.Text = fotografo.Nombre;
                    txtApellido.Text = fotografo.Apellido;
                    txtTelefono.Text = fotografo.Telefono;
                    txtEmail.Text = fotografo.Email;
                    txtEspecialidad.Text = fotografo.Especialidad;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar fotografo: {ex.Message}");
            }
        }
    }
}
