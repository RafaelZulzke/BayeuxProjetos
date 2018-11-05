using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Loja
{
    public partial class Form1 : Form
    {
        private int cod_Excluir;
        private int linhaatual = 0;

        string caminho = "SERVER=localhost;DATABASE=loja;UID=root;PASSWORD=root;";

        public Form1()
        {
            InitializeComponent();
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


        private void obtemDadosGrid()
        {
            tProduto tprod = new tProduto();
            Banco bd = new Banco();

            tprod.codigo = int.Parse (dataGridView1 [0, linhaatual].Value.ToString));
            tprod.produto = dataGridView1 [1, linhaatual].Value.toString();
            tprod.marca = dataGridView1 [2, linhaatual].Value.ToString();
            tprod.valor = float.Parse (dataGridView1 [3,linhaatual].Value.ToString());
            tprod.estoque = int.Parse (dataGridView1 [4,linhaatual].Value.ToString());

            txtCodigo.Text = Convert.ToString (tprod.codigo);
            txtProduto.Text = tprod.produto;
            txtMarca.Text = tprod.marca;
            txtValor.Text = Convert.ToString (tprod.valor);
            txtEstoque.Text = Convert.ToString (tprod.estoque);

        }


        private void excluirDados()
        {
            string conexao = "server=localhost;userid=root;password=root;database=loja";
            string apaga = "delete from produtos where codigo = " + Convert.ToString(cod_Excluir) + "";

            MySqlConnection dbconnection = new MySqlConnection(conexao);
            MySqlCommand exclui = new MySqlCommand(apaga, dbconnection);

            try
            {
                dbconnection.Open();
                exclui.ExecuteNonQuery();
                MessageBox.Show("Dados Excluídos com Sucesso");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro." + ex.Message);

            }
            finally
            {
                dbconnection.Close();
            }


        }


        private void btCadastrar_Click(object sender, EventArgs e)
        {
            tProduto po = new tProduto();
            Banco bd = new Banco();

            po.produto = txtProduto.Text;
            po.marca = txtMarca.Text;
            po.valor = double.Parse(txtValor.Text);
            po.estoque = int.Parse(txtEstoque.Text);

            bd.cadastro(po);
            txtProduto.Text = "";
            txtMarca.Text = "";
            txtValor.Text = "";
            txtEstoque.Text = "";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaDados();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            tProduto tprod = new tProduto();

            Banco bd = new Banco();
            try
            {
               cod_Excluir = dataGridView1[0, linhaatual].Value;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro." + ex.Message);
            }

            if (linhaatual <= 0)
            {
                obtemDadosGrid();
            }

            if (MessageBox.Show("Confirmar exclusão? Sim/Não?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes) // opção yes já selecionado (focado)
            {
                excluirDados();
            }

        }
    }
}
