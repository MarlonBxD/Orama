namespace GUI
{
    public partial class gestion_despachos : Form
    {
        private readonly DAL.DespachoRepository _despachoRepository;
        public gestion_despachos()
        {
            InitializeComponent();
            _despachoRepository = new DAL.DespachoRepository();
            cargarDatos();
        }

        private void cargarDatos()
        {
            try
            {
                var despachos = _despachoRepository.ObtenerDespachos();
                dgvDespachos.DataSource = despachos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los despachos: {ex.Message}");
            }
        }
    }
}
