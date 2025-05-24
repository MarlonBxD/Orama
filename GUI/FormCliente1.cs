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

        public FormCliente1(Action<Form> cambiarFormulario)
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
            cambiarFormulario(new FormClienteConsulta(cambiarFormulario));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Direccion = txtDireccion.Text
                };

                _clienteService.Agregar(cliente);
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
                Cliente cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Direccion = txtDireccion.Text
                };

                _clienteService.Actualizar(cliente);
                MessageBox.Show("Cliente actualizado correctamente");
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
                if (!int.TryParse(txtId.Text, out int idCliente))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                _clienteService.Delete(idCliente);
                MessageBox.Show("Cliente eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cliente: {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int idCliente))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                Cliente cliente = _clienteService.GetById(idCliente);

                if(cliente != null)
                {
                    txtNombre.Text = cliente.Nombre;
                    txtApellido.Text = cliente.Apellido;
                    txtTelefono.Text = cliente.Telefono;
                    txtEmail.Text = cliente.Email;
                    txtDireccion.Text = cliente.Direccion;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar cliente: {ex.Message}");
            }
        }
    }
}
