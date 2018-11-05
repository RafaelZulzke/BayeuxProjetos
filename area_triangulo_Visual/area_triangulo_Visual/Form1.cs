using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace area_triangulo_Visual
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

        private void button1_Click(object sender, EventArgs e)
        {
            double area, b, alt;

            b = double.Parse(textBox3.Text);
            alt = double.Parse(textBox2.Text);

            area = (b * alt) / 2;

            textBox1.Text = area.ToString();
        }
    }
}
