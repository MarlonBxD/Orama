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

    public partial class FormProducto : Form
    {
        private readonly ProductoService _productoService = new ProductoService();
        private readonly Action<Form> cambiarFormulario;

        public FormProducto(Action<Form> cambiarFormulario)
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
                Producto producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    stock = int.Parse(txtStock.Text)
                };

                _productoService.Agregar(producto);
                MessageBox.Show("Producto agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int idProducto))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                string nuevoNombre = txtNombre.Text;

                _productoService.UpdateName(idProducto, nuevoNombre);
                MessageBox.Show("Nombre del producto actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar nombre: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int idProducto))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                _productoService.Eliminar(idProducto);
                MessageBox.Show("Producto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Pendiente método buscar por id
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cambiarFormulario(new FormProductoConsulta(cambiarFormulario));
        }
    }
}
