using BLL;
using DAL;
using Entity.Dto;

namespace GUI
{
    public partial class gestion_despachos : Form
    {
        private DespachoService DespachoService = new DespachoService();
        public gestion_despachos()
        {
            InitializeComponent();
            dgvDespachos.AutoGenerateColumns = true;
            this.Load += Gestion_despachos_Load;

        }

        private void Gestion_despachos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }


        private void cargarDatos()
        {
            try
            {
                var despachos = DespachoService.ObtenerDespachos();

                dgvDespachos.DataSource = null;
                dgvDespachos.AutoGenerateColumns = true;
                dgvDespachos.DataSource = despachos;
                dgvDespachos.Refresh(); // Fuerza la actualización visual

                cbEstados.DataSource = despachos.Select(d => d.Estado.ToString()).Distinct().ToList();
                if (!dgvDespachos.Visible)
                {
                    dgvDespachos.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los despachos: {ex.Message}");
            }
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                var despachos = DespachoService.ObtenerDespachos();
                var estadoSeleccionado = cbEstados.SelectedItem.ToString();
                if (estadoSeleccionado != "Todos")
                {
                    despachos = despachos.Where(d => d.Estado.ToString() == estadoSeleccionado).ToList();
                }
                dgvDespachos.DataSource = despachos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar los despachos: {ex.Message}");
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormDespacho form = new FormDespacho();
            form.FormClosing += (s, args) =>
            {
                if (form.DialogResult == DialogResult.OK)
                {
                    cargarDatos();
                }
            };
            form.ShowDialog();
        }

        
    }
}
