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
    public partial class frmTrinidad : Form
    {
        public frmTrinidad()
        {
            InitializeComponent();
        }

        private void trinidadTobgo_Paint(object sender, PaintEventArgs e)
        {
            Graphics gp = this.CreateGraphics();
            gp.Clear(Color.FromArgb(190, 0, 39));

            Point[] linea = {
                new Point(0, 0),
                new Point((this.Width/3)*2,this.Height),
                new Point(this.Width, this.Height),
                new Point(this.Width/3, 0)
            };

            gp.FillPolygon(Brushes.White, linea);

            linea[0].X+=30;
            linea[1].X+=30;
            linea[2].X-=30;
            linea[3].X-=30;

            gp.FillPolygon(Brushes.Black, linea);

        }
    }
}
