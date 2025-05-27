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
    public partial class Orama : Form
    {
        private TelegramBotService _bot = new TelegramBotService();

        public Orama()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            _bot.Iniciar();
        }

        private Form formActivo = null;
        private void CambiarFormulario(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();

            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelFormHijo.Controls.Add(formHijo);
            panelFormHijo.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CambiarFormulario(new FormCliente1(CambiarFormulario));
        }

        private void btnFotografos_Click(object sender, EventArgs e)
        {
            CambiarFormulario(new FormFotografo(CambiarFormulario));
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            CambiarFormulario(new FormProducto(CambiarFormulario));
        }

        private void btnEquipoFotografico_Click(object sender, EventArgs e)
        {
            CambiarFormulario(new FormEquipoFotografico(CambiarFormulario));
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            CambiarFormulario(new FormProducto(CambiarFormulario));
        }

        private void btnMensajeros_Click(object sender, EventArgs e)
        {
            CambiarFormulario(new FormMensajero(CambiarFormulario));
        }

        private void btnDespachos_Click(object sender, EventArgs e)
        {
            CambiarFormulario(new FormDespacho1(CambiarFormulario));
        }
    }
}
