using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _05_05_2014
{
    public partial class Form1 : Form
    {
        string caminho = "server=localhost;database=cadastro;uid=root;password=root;";
        public Form1()
        {
            InitializeComponent();

        }

        public void Listadados()
        {
            string consulta = String.Format("Select*From clientes", "cadastro");
            MySqlConnection conexao = new MySqlConnection(caminho);
            conexao.Open();
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            MySqlDataAdapter mda = new MySqlDataAdapter(comando);
            DataTable dados = new DataTable();
            mda.Fill(dados);
            dataGridView1.DataSource = dados;

        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            Modelo mo = new Modelo(); //abreviação da classe
            DAL da = new DAL(); //abreviação da classe

            mo.nome = txtnome.Text;
            mo.email = txtemail.Text;

            da.Cadastro(mo);
            txtnome.Text = "";
            txtemail.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listadados();
        }
    }
}
