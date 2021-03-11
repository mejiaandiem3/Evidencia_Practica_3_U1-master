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
    public partial class frmColombia : Form
    {
        public frmColombia()
        {
            InitializeComponent();
        }

        private void frmColombia_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.FromArgb(239, 228, 16));

            SolidBrush sl = new SolidBrush(Color.FromArgb(27, 43, 154));
            graphics.FillRectangle(sl,0,this.Height/2,this.Width, this.Height/4);

            sl = new SolidBrush(Color.FromArgb(217, 61, 28));
            graphics.FillRectangle(sl, 0, (this.Height/4)*3, this.Width, this.Height/4);
        }
    }
}
