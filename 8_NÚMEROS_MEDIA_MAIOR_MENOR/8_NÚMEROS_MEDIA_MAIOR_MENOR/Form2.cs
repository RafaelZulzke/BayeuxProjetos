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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Verificadados_Click(object sender, EventArgs e)
        {
            Class1.n = int.Parse(num8vezes.Text);
            this.Close();
        }
    }
}
