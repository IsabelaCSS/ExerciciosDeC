using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosDeLooping
{
    public partial class frmexercicio1 : Form
    {
        public frmexercicio1()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
        
            frmmenu menu = new frmmenu();
            menu.Show();

            this.Hide();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttipo.Clear();
            txtlitro.Clear();
            txtpreco.Clear();

            txttipo.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double l, result;
            char cod;

            l = Convert.ToDouble(txtlitro.Text);
            result = Convert.ToDouble(txtpreco.Text);
        }
    }
}
