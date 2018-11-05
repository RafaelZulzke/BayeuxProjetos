using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu
{
	public partial class FRMPrincipal: Form
	{
		public FRMPrincipal()
		{
			InitializeComponent();
		}

        int i=0;
        float media = 0, somaM=0 , maiornum1 = 0, menornum = 9999;  

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nusados.Text = menornum.ToString();
        }

     
        private void calcularMédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nusados.Items.Add("----------------");
            Nusados.Items.Add(media.ToString());
         }

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= 2; i++)
            {
                Form2 segundoform = new Form2();
                segundoform.ShowDialog();
                Nusados.Items.Add(class1.n.ToString());
                somaM = somaM + class1.n;
                media = somaM / i;

                //maiornum
                if (class1.n >= maiornum1)
                {
                    maiornum1 = class1.n;
                }

                if (class1.n <= menornum)
                {
                    menornum = class1.n;
                }

            }

            
            

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nusados.Items.Add("----------------");
            Nusados.Items.Add(somaM.ToString());
        }

        private void somarValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nusados.Text = maiornum1.ToString();
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

       
        }    
	}

