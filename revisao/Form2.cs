using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace revisao
{
    public partial class Form2 : Form
    {
        string caminho = "SERVER=localhost;DATABASE=loja;UID=root;PASSWORD=root;";
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void ListaDados()
        {
            string query = String.Format("SELECT * FROM produtos", "loja");

            MySqlConnection conexao = new MySqlConnection(caminho);
            conexao.Open();
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }
        private void btcadastrar_Click(object sender, EventArgs e)
        {
            cproduto po = new cproduto();
            banco bd = new banco();
            po.produto = txtprod.Text;
            po.marca = txtmarca.Text;
            po.valor = float.Parse(txtvalor.Text);
            po.estoque = int.Parse(txtestoque.Text);

            bd.cadastro(po);
            txtprod.Text = "";
            txtmarca.Text = "";
            txtvalor.Text="";
            txtestoque.Text = "";

            MessageBox.Show("Produto Cadastrado com Sucesso!");
            ListaDados();
        }
        


        private void Form2_Load(object sender, EventArgs e)
        {
            ListaDados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ListaDados();
        }
       
       

        }
    }

