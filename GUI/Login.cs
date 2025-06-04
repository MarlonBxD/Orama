using DAL;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var repo = new UsuarioRepository();
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = repo.ValidarCredenciales(usuario, contrasena);

            if (user != null)
            {
                MessageBox.Show("¡Bienvenido " + user.Nombre + "!", "Login correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                var menu = new Orama();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
