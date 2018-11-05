using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _12_05_2014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            string str = "1000000000";
            int x = 0;
                float y= 0;
                try
                {
                    x = Convert.ToInt32(box1.Text);
                    box2.Text = x.ToString();
                    y = float.Parse(str);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 

                finally 
                {
                    MessageBox.Show("Tentativa de conversão Realizada.");
                }  
            }

        }
    }

