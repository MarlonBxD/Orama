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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirGestion_Click(object sender, EventArgs e)
        {
            // Create an instance of the Form2 class
            gestion_despachos gestion_Despachos = new gestion_despachos();
            // Show the Form2 instance as a dialog
            gestion_Despachos.ShowDialog();
        }
    }
}
