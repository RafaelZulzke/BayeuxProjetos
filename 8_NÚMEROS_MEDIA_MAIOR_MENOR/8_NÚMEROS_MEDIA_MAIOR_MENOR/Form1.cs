using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8_NÚMEROS_MEDIA_MAIOR_MENOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Verificanum_Click(object sender, EventArgs e)
        {
            int i;
            float media = 0, maiornum1 = 0, menornum1 = 9999, soma = 0;

            Nusados.Items.Clear();

            for (i = 1; i <= 8; i++) 
            { 
            Form2 segundoform = new Form2();
            segundoform.ShowDialog();
            Nusados.Items.Add(Class1.n.ToString());
            soma = soma + Class1.n;
            

            //maiornum
            if (Class1.n >= maiornum1)
            {
                maiornum1 = Class1.n;
            } 
            
            if (Class1.n <= menornum1)
            {
                menornum1 = Class1.n;
            }
         
            }
            media = soma / (i-1);
            MessageBox.Show (media.ToString());
            medianum.Text = media.ToString("#.00");
            maiornum.Text = maiornum1.ToString();
            menornum.Text = menornum1.ToString();
            }

        private void medianum_TextChanged(object sender, EventArgs e)
        {

        }

       
        }

  
    }

