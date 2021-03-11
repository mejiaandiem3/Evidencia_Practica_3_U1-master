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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            Form form = new frmEjemplo();
            form.ShowDialog();
        }

        private void btnSomalia_Click(object sender, EventArgs e)
        {
            Form form = new frmSomalia();
            form.ShowDialog();
        }

        private void btnColombia_Click(object sender, EventArgs e)
        {
            Form form = new frmColombia();
            form.ShowDialog();
        }

        private void btnTrinidad_Click(object sender, EventArgs e)
        {
            Form form = new frmTrinidad();
            form.ShowDialog();
        }
    }
}
