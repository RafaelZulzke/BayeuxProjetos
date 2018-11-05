using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prog_Agenda
{
    public partial class Form1 : Form
    {
        private int linha_atual = 0;
        private int codigo_a_excluir;

        string Caminho = "Server = localhost; DataBase = agenda; UID = root; Password = root";


        public Form1()
        {
            InitializeComponent();
        }

        public void ListaDados()
        {
            string Consulta = string.Format("Select * From contatos", " agenda");
            MySqlConnection CONEXAO = new MySqlConnection(Caminho);
            CONEXAO.Open();
            MySqlCommand Comando = new MySqlCommand(Consulta, CONEXAO);
            MySqlDataAdapter MDA = new MySqlDataAdapter(Comando);
            DataTable Dados = new DataTable();
            MDA.Fill(Dados);
            dataGridView1.DataSource = Dados;
        }

        private void obtemDadosGrid()
        {
            Modelo Mo = new Modelo();
            Sql Da = new Sql();

            //obtem os dados do datagridview da linha selecionada usando as posições das colunas
            //a primeira coluna é a coluna 0 a segunda é a coluna 1 , e , assim por diante
            Mo.Nome = dataGridView1[1, linha_atual].Value.ToString();
            Mo.Endereco = dataGridView1[2, linha_atual].Value.ToString();
            Mo.Cep = dataGridView1[3, linha_atual].Value.ToString();
            Mo.Bairro = dataGridView1[4, linha_atual].Value.ToString();
            Mo.Cidade = dataGridView1[5, linha_atual].Value.ToString();
            Mo.Estado = dataGridView1[6, linha_atual].Value.ToString();
            Mo.Email = dataGridView1[7, linha_atual].Value.ToString();
            Mo.Ddd = dataGridView1[8, linha_atual].Value.ToString();
            Mo.Celular = dataGridView1[9, linha_atual].Value.ToString();

            txtNome.Text = Mo.Nome;
            txtEndereco.Text = Mo.Endereco;
            txtCEP.Text = Mo.Cep;
            txtBairro.Text = Mo.Bairro;
            txtCidade.Text = Mo.Cidade;
            txtEstado.Text = Mo.Estado;
            txtEmail.Text = Mo.Email;
            txtDDD.Text = Mo.Ddd;
            txtCelular.Text = Mo.Celular;

        }

        private void ExcluirDados()
        {
            //define string de conexão - Provedor + fonte de dados (caminho do banco de dados e seu nome)
            string strConnection = "server=localhost;user id=root;password=root;database=agenda";

            //define instrução SQL para excluir dados da tabela Clientes - DELETE FROM tabela Where <criterio>
            string strSQL = "DELETE FROM contatos WHERE codigo=" + Convert.ToString(codigo_a_excluir) + "";

            //cria a conexão com o banco de dados
            MySqlConnection dbConnection = new MySqlConnection(strConnection);
            //Cria o comando que inicia a instrução SQL para exclusão
            MySqlCommand cmdExcluir = new MySqlCommand(strSQL, dbConnection);
            try
            {
                // abre o banco de dados
                dbConnection.Open();
                // executa a instrução SQL
                cmdExcluir.ExecuteNonQuery();
                //
                MessageBox.Show("Dados Excluídos com sucesso.");
            }
            //Trata a exceção
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //fecha a conexao 
                dbConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaDados();
        }

      

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Modelo Mo = new Modelo();
            Sql Da = new Sql();

            try
            {
                /* obtem o nome do jogo a partir da linha selecionada na datagrid */
                codigo_a_excluir = Convert.ToInt16(dataGridView1[0, linha_atual].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
            if (linha_atual >= 0)
            {
                obtemDadosGrid();
            }

            if (MessageBox.Show("Confirmar exclusão?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExcluirDados();
                ListaDados();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linha_atual = int.Parse(e.RowIndex.ToString());
            // MessageBox.Show(linha_atual.ToString());
        }

        private void btIncluir_Click_1(object sender, EventArgs e)
        {
            Modelo Mo = new Modelo();
            Sql Da = new Sql();

            Mo.Nome = txtNome.Text;
            Mo.Endereco = txtEndereco.Text;
            Mo.Cep = txtCEP.Text;
            Mo.Bairro = txtBairro.Text;
            Mo.Cidade = txtCidade.Text;
            Mo.Estado = txtEstado.Text;
            Mo.Email = txtEmail.Text;
            Mo.Ddd = txtDDD.Text;
            Mo.Celular = txtCelular.Text;

            Da.Cadastro(Mo);

            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCEP.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtEmail.Text = "";
            txtDDD.Text = "";
            txtCelular.Text = "";

            ListaDados();
        }



    }
}
