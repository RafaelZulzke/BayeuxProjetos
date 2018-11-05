using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Impar_Par_Visual
{
    public partial class FrmVerifica : Form
    {
        public FrmVerifica()
        {
            InitializeComponent();
        }

        private void btVerifica_Click(object sender, EventArgs e)
        {
            int n = 0;
            n = int.Parse(txtnum.Text);
            if (n % 2 == 0)
            {
                lblresultado.Text = "O Número " + n.ToString() + " é PAR";
            }
            else
            {
                lblresultado.Text = "O Número " + n.ToString() + " é ÍMPAR";
            }

        }

        private void btCancela_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            lblresultado.Text = "";
            txtnum.Focus();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Programa ?", "**** FINALIZANDO ****",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtnum.Clear();
                lblresultado.Text = "";
                txtnum.Focus();
            }
        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
