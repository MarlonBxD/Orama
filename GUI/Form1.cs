using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Face;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private VideoCapture captura;
        private CascadeClassifier detectorRostro;
        private Image<Gray, byte> rostroGuardado;

        public Form1()
        {
            InitializeComponent();
            detectorRostro = new CascadeClassifier("haarcascade_frontalface_default.xml");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            captura = new VideoCapture();
            captura.ImageGrabbed += ProcesarFrame;
            captura.Start();
        }

        private void ProcesarFrame(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            captura.Retrieve(frame);
            Image<Bgr, byte> imagen = frame.ToImage<Bgr, byte>();
            Image<Gray, byte> gris = imagen.Convert<Gray, byte>();

            Rectangle[] rostros = detectorRostro.DetectMultiScale(gris, 1.1, 4);

            foreach (Rectangle rostro in rostros)
            {
                imagen.Draw(rostro, new Bgr(Color.Red), 2);
            }

            pictureBox1.Image = imagen.ToBitmap();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            if (bmp == null)
            {
                MessageBox.Show("La imagen no es un Bitmap válido.");
                return;
            }
            Image<Bgr, byte> imagenActual = new Image<Bgr, byte>(bmp);
            Image<Gray, byte> gris = imagenActual.Convert<Gray, byte>();


            Rectangle[] rostros = detectorRostro.DetectMultiScale(gris, 1.1, 4);

            if (rostros.Length > 0)
            {
                // Tomar solo el primer rostro detectado
                Image<Gray, byte> rostroActual = gris.Copy(rostros[0]).Resize(100, 100, Inter.Cubic);

                if (rostroGuardado == null)
                {
                    // Guardamos el primer rostro como referencia
                    rostroGuardado = rostroActual;
                    MessageBox.Show("Rostro registrado.");
                }
                else
                {
                    // Comparamos con el rostro guardado
                    double diferencia = rostroActual.AbsDiff(rostroGuardado).GetSum().Intensity;

                    if (diferencia < 5000)
                        MessageBox.Show(" Rostro verificado. ¡Login exitoso!");
                    else
                        MessageBox.Show(" Rostro no coincide.");
                }
            }
            else
            {
                MessageBox.Show("No se detectó ningún rostro.");
            }
        }
    }
}
