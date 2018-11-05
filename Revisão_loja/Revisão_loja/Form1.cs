using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Revisão_loja
{
    public partial class Form1 : Form
    {
        string caminho = "server = localhost;database = loja; uid = root , password = root;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto Po = new Produto();
            Banco BD = new Banco();
            Po.Prod = textBox1.Text;
            Po.Marca = textBox2.Text;
            Po.Valor = double.Parse(textBox3.Text);
            Po.Estoque = int.Parse(textBox4.Text);
            BD.Cadastro(Po);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
    }
}
