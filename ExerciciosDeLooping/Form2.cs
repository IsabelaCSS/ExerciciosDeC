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
            double l, total;
            char cod;
            //comentario
            cod = Convert.ToChar (txttipo.Text);
            l = Convert.ToDouble (txtlitro.Text);

            if (cod.Equals ('A')) {
                if (l <= 20)
                {
                    total = l * (4.30 - (4.30 * 3 / 100));

                    txtpreco.Text = total.ToString();
                }
                else 
                
                    if (l >= 20) {

                        total = l * (4.30 - (4.30 * 5 / 100));

                        txtpreco.Text = total.ToString();
                    }
            }
                    if (cod.Equals ('G')) {
                        if (l <= 20)
                        {
                            total = l * (5.50 - (5.50 * 4 / 100));

                            txtpreco.Text = total.ToString();
                        }
                        else 
                        
                            if (l >= 20) {
                                total = l * (5.50 - (5.50 * 6 / 100));

                                txtpreco.Text = total.ToString();
                            }
                    }

            }

        private void txtpreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltipo_Click(object sender, EventArgs e)
        {

        }
    }
    
}
