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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            Class1.idade = int.Parse(idadebox.Text);
            this.Close();
        
        }
    }
}
