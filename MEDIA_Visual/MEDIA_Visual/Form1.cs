using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MEDIA_Visual
{
    public partial class FormMedia : Form
    {
        public FormMedia()
        {
            InitializeComponent();
        }

        private void FormMedia_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void n4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void n3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void n2_Click(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void verifica_Click(object sender, EventArgs e)
        {
            int nt1 = 0, nt2 = 0, nt3 = 0, nt4 = 0, notamaior = 0;
            double media = 0;

            nt1 = int.Parse(n1c.Text);
            nt2 = int.Parse(n2c.Text);
            nt3 = int.Parse(n3c.Text);
            nt4 = int.Parse(n4c.Text);


            media = (nt1 + nt2 + nt3 + nt4) / 4;

            mediac.Text = media.ToString();

            if (media < 4)
            {
                sitc.Text = "Aluno Reprovado";
            }
            else if (media < 7)
            {
                sitc.Text = "Aluno de Exame";

            }

            else if (media >= 7)
            {
                sitc.Text = "Aluno Aprovado";
            }


            // maior nota

            if (nt1 > notamaior)
            {
                notamaior = nt1;
            }

            if (nt2 > notamaior)
            {
                notamaior = nt2;
            }

            if (nt3 > notamaior)
            {
                notamaior = nt3;
            }

            if (nt4 > notamaior)
            {
                notamaior = nt4;
            }
            nmaior.Text = notamaior.ToString();
        }

        private void nmaior_TextChanged(object sender, EventArgs e)
        {

        }
    }
}