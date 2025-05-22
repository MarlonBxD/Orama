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
    public partial class FormFotografoConsulta : Form
    {
        private readonly FotografoService _fotografoService = new FotografoService();
        private readonly Action<Form> cambiarFormulario;

        public FormFotografoConsulta(Action<Form> cambiarFormulario)
        {
            InitializeComponent();
            this.cambiarFormulario = cambiarFormulario;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            cambiarFormulario(new FormFotografo(cambiarFormulario));
        }

        private void FormFotografoConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                var listaFotografos = _fotografoService.ObtenerFotografos();

                var listaFormateada = listaFotografos.Select(f => new
                {
                    f.Nombre,
                    f.Apellido,
                    f.Telefono,
                    f.Email,
                    f.Especialidad
                }).ToList();

                dgvConsulta.DataSource = null;
                dgvConsulta.Columns.Clear();
                dgvConsulta.DataSource = listaFormateada;

                dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }
    }
}
