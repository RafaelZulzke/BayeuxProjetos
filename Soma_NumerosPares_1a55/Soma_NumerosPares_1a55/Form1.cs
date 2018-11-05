using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soma_NumerosPares_1a55
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

        private void soma_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {

            int n, cont=0, rsoma;
                       

            for (n = 1; n <= 55; n++)
            { 

                if (n % 2 == 0)
                {
                    cont = cont+n;
                }    
            }

            rsoma = cont;

            soma.Text = cont.ToString();

        }

        private void sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar o Programa?", "Finalizar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        
            {
                Close();
            }
            
            
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            relogiolabel.Text = DateTime.Now.ToLongTimeString(); //Data e hora - ToLongTimeString apenas p/ mostrar a hora
            

        }

        private void dglabrir_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dglabrir.ShowDialog();

            if (dglabrir.FileName != "") ; 
           {
               picimagem.Load(dglabrir.FileName);


           }
        }
        }
    }

