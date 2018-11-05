using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tabuada_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calctab_Click(object sender, EventArgs e)
        {
   
          int mtp, rtab=0, nm=0;

            nm = int.Parse(ntext.Text);

            for (mtp = 1; mtp <= 10; mtp++)
            {

                //r = resultado da multiplicação; nm = número digitado pelo user; mtp = multiplicador do multiplicando_
                rtab = (nm * mtp);


                tablist.Items.Add(nm.ToString() + "x" + mtp.ToString() + "="+rtab.ToString());
           

            }

                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablist.Items.Clear();
            ntext.Clear();
            ntext.Text = "";
        }
    }
}
