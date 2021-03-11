using System;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Evidencia_Practica_3_U1
{
    public partial class frmEjemplo : Form
    {
        int mitadW, mitadH, cuartW, cuartH;
        Estrella est1, est2;

        private void frmEjemplo_Resize(object sender, EventArgs e)
        {
            EstablecerDistribucion();
        }

        public frmEjemplo()
        {
            InitializeComponent();
            EstablecerDistribucion();
        }

        private void EstablecerDistribucion() 
        {
            mitadW = this.Width / 2;
            mitadH = this.Height / 2;
            cuartW = this.Width / 4;
            cuartH = this.Height / 4;
        }

        Graphics E;

        private void frmEjemplo_Paint(object sender, PaintEventArgs e)
        {
            E = this.CreateGraphics();
            E.Clear(Color.White);
            E.FillRectangle(Brushes.Blue, 0, mitadH, mitadW, mitadH);
            E.FillRectangle(Brushes.Red, mitadW, 0, mitadW, mitadH);

            est1 = new Estrella(cuartW-50,cuartH-50,100,100,Color.Blue);
            est2 = new Estrella(cuartW*3 - 50, cuartH*3 - 50, 100, 100, Color.Red);

            Estrella.DibujarEstrella(E, est1, 2);
            Estrella.DibujarEstrella(E, est2, 2);

        }
    }
}

