using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoMysql
{
    public partial class Form1 : Form
    {
        string caminho = "SERVER=localhost;DATABASE=dbexemplo;UID=root;PASSWORD=root;";

        public Form1()
        {
            InitializeComponent();
        }

        public void ListaDados()
        {
            string query = String.Format("SELECT * FROM tbexemplo", "dbexemplo");

            MySqlConnection conexao = new MySqlConnection(caminho);
            conexao.Open();
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Modelo mo = new Modelo();
            dal da = new dal();

            mo.Nome = txtNome.Text;
            mo.Email = txtEmail.Text;

            da.cadastro(mo);

            txtNome.Text = "";
            txtEmail.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListaDados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            //criar formulário para Cadastrar Usuário e Senha
            MessageBox.Show("Opção à Programar....", "Atenção");
        }
    }
}
