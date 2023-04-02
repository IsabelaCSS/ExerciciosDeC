using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosDeLooping
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exercicios1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmexercicio1 fm = new frmexercicio1();
            fm.Show();

        }

        private void exercicios2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmexercicio2 fm = new frmexercicio2();
            fm.Show();
        }
    }
}
