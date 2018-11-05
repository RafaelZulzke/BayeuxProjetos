using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Marcos_Ariel
{
    public partial class Form5 : Form
    {
        private string criterio = "";
        public string sqlString = "";


        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            criterio = textBox1.Text.ToString();
            if (criterio != "")
            {
                sqlString = "Select * from Clientes where nome like '" + criterio + "%'";
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite o nome a ser localizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
