using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7_4_2014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void entdados_Click(object sender, EventArgs e)
        {

            int i, soma=0,media=0;
            for (i = 1; i <= 5; i++)
            {
                Form2 SegundoForm = new Form2();
                SegundoForm.ShowDialog();
                listidades.Items.Add(Class1.idade);//talvez  necessite do .toString depois do .idade
                soma = soma + Class1.idade;
                somaids.Text = soma.ToString();
                //soma.Text = cont.ToString();
                media = soma / 5;
                Mdidades.Text = media.ToString();

            }
           
        }

        private void listidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Mdidades_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
