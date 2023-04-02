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
    public partial class frmexercicio2 : Form
    {
        public frmexercicio2()
        {
            InitializeComponent();
        }

        private void frmexercicio2_Load(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.Show();

            this.Hide();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresultado.Clear();

            txtnum.Focus();
        }

        private void bntcalcular_Click(object sender, EventArgs e)
        {
            int num, resultado, i;

            num = Convert.ToInt32(txtnum.Text); 
            
            for (i = 0; i <= 10; i++)
            {
                resultado = num * i;

                txtresultado.Text = String.Concat (txtresultado.Text, "\r\n", resultado.ToString());

            }
        }
    }
}
