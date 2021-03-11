using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidencia_Practica_3_U1
{
    public partial class frmSomalia : Form
    {
        public frmSomalia()
        {
            InitializeComponent();
        }

        private void somalia_Paint(object sender, PaintEventArgs e)
        {
            Graphics lienzo = this.CreateGraphics();
            lienzo.Clear(Color.FromArgb(64, 136, 220));
            Estrella est = new Estrella((this.Width/2)-50,(this.Height/2)-50,100,100,Color.White);
            Estrella.DibujarEstrella(lienzo, est,2);
        }
    }
}
