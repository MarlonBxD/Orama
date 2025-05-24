using BLL;
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
    public partial class FormProductoConsulta : Form
    {
        private readonly ProductoService _productoService = new ProductoService();
        private readonly Action<Form> cambiarFormulario;

        public FormProductoConsulta(Action<Form> cambiarFormulario)
        {
            InitializeComponent();
            this.cambiarFormulario = cambiarFormulario;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            cambiarFormulario(new FormProducto(cambiarFormulario));
        }

        private void FormProductoConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                var listaProductos = _productoService.Obtener();

                var listaFormateada = listaProductos.Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    p.Descripcion,
                    p.Precio,
                    p.stock
                }).ToList();

                dgvConsulta.DataSource = null;
                dgvConsulta.Columns.Clear();
                dgvConsulta.DataSource = listaFormateada;

                dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }
    }
}
