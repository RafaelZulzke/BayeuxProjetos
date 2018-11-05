using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Definitivo
{
    public partial class Form1 : Form
    {
        string caminho = "SERVER=localhost;DATABASE=emps;UID=root;PASSWORD=root;";
        
        public Form1()
        {
            InitializeComponent();
        }

      /*  public void localiza()
        {
            string query, encontre;

            encontre = "%" + (string)txtbusca.Text + "%";

            if (txtbusca.Text == "")
            {
                query = String.Format("Select * from tbex", "emps");
            }
            else
            {
                query = String.Format("Select * from tbex where Nome like '" + encontre + "'", "emps");
            }

            MySqlConnection conexao = new MySqlConnection(caminho);

            conexao.Open();

            MySqlCommand command = new MySqlCommand(query, conexao);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable data = new DataTable();

            adapter.Fill(data);

            dataGridView1.DataSource = data;

        } */


        public void conecta(string query)
        {
            MySqlConnection conexao = new MySqlConnection(caminho);
            conexao.Open();
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;

        }

        public void ListaDados()
        {

            string query = String.Format("SELECT * FROM tbex", "emps");

            MySqlConnection conexao = new MySqlConnection(caminho);
            conexao.Open();
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {

            Modelo mo = new Modelo();
            dal da = new dal();

            mo.Nome = txtNome.Text;
            mo.Email = txtEmail.Text;

            da.cadastro(mo);

            txtNome.Text = "";
            txtEmail.Text = "";

        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            ListaDados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaDados();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void localDeFabricaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btExcFor_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja Realmente Excluir este registro?" + "\n";
            string registro = txtNome.Text + "\n" + txtEmail.Text;

            if (MessageBox.Show(mensagem + "\n" + registro, "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = String.Format("DELETE FROM tbex WHERE Nome LIKE '%" + txtNome.Text + "%'", "emps");
                conecta(query);
            }
            else
            {
                txtNome.Focus();
            }
            ListaDados();
            txtNome.Clear(); 
        }

        private void btLocaliza_Click(object sender, EventArgs e)
        {

            string query, encontre;

            encontre = "%" + (string)txtbusca.Text + "%";

            if (txtbusca.Text == "")
            {
                query = String.Format("Select * from tbex", "emps");
            }
            else
            {
                query = String.Format("Select * from tbex where Nome like '" + encontre + "'", "emps");
            }

            MySqlConnection conexao = new MySqlConnection(caminho);

            conexao.Open();

            MySqlCommand command = new MySqlCommand(query, conexao);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable data = new DataTable();

            adapter.Fill(data);

            dataGridView1.DataSource = data;

        }

        

    }
}
