using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{

    public partial class FormCliente : Form
    {
        private ClienteSerive clienteService = new ClienteSerive();
        public FormCliente()
        {
            InitializeComponent();
            clienteService = new ClienteSerive();
        }
        private void EnviarCorreo()
        {   
            string destinatario = txtDestinatario.Text;
            string telefono = txtTelefono.Text;
            string mensaje = txtMensaje.Text;
            if (string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            try
            {
                string resultado = clienteService.EnviarCorreo(destinatario,telefono, mensaje);
                MessageBox.Show(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el mensaje: {ex.Message}");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarCorreo();
        }
    }
}
