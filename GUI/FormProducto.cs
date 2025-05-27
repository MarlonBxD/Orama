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

    public partial class FormProducto : Form
    {
        private readonly ProductoService _productoService = new ProductoService();
        private readonly Action<Form> cambiarFormulario;
        private List<Producto> listaProductos;

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
                    Precio = double.Parse(txtPrecio.Text),
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
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para actualizar.");
                    return;
                }

                int idProducto = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                _productoService.UpdateName(idProducto, txtNombre.Text.Trim());

                CargarProductos();

                dgv.DataSource = null;
                dgv.DataSource = listaProductos;

                if (dgv.Columns.Contains("Id"))
                    dgv.Columns["Id"].Visible = false;

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
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para eliminar.");
                    return;
                }

                int idProducto = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                var confirm = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _productoService.Eliminar(idProducto);

                    CargarProductos();

                    dgv.DataSource = null;
                    dgv.DataSource = listaProductos;

                    if (dgv.Columns.Contains("Id"))
                        dgv.Columns["Id"].Visible = false;

                    MessageBox.Show("Producto eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}");
            }
        }

        private void CargarProductos()
        {
            try
            {
                listaProductos = _productoService.Obtener();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}");
            }
        }

        private void btnVerEquipos_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = listaProductos;

            if (dgv.Columns.Contains("Id"))
                dgv.Columns["Id"].Visible = false;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                var fila = dgv.SelectedRows[0];
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value?.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value?.ToString();
                txtStock.Text = fila.Cells["stock"].Value?.ToString();
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
                dgv.DataSource = listaProductos;
            }
            else
            {
                var listaFiltrada = listaProductos.Where(e => e.Nombre.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)).ToList();

                dgv.DataSource = listaFiltrada;
            }
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
