using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_Visual
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, r;

            n1 = double.Parse(num1.Text);
            n2 = double.Parse(num2.Text);

            r = n1 + n2;

            result.Text = r.ToString();

        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, r;

            n1 = double.Parse(num1.Text);
            n2 = double.Parse(num2.Text);

            r = n1 - n2;

            result.Text = r.ToString();

        }

        private void mult_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, r;

            n1 = double.Parse(num1.Text);
            n2 = double.Parse(num2.Text);

            r = n1 * n2;

            result.Text = r.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, r;

            n1 = double.Parse(num1.Text);
            n2 = double.Parse(num2.Text);

            r = n1 / n2;

            result.Text = r.ToString();
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, r;

            n1 = double.Parse(num1.Text);
            n2 = double.Parse(num2.Text);

            r = Math.Sqrt(n1);

            result.Text = r.ToString();
        }

        private void pot_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, r;

            n1 = double.Parse(num1.Text);
            n2 = double.Parse(num2.Text);

            r = Math.Pow(n1, n2);

            result.Text = r.ToString();

        }

        private void zerar_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            result.Clear();
            num1.Focus();
        }

        private void desligar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Desligar a Calculadora?", "< Desligamento >",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }


        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}