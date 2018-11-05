using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Estoque_de_Produtos_0409
{
    public partial class Incluir : Form
    {
        public string codigo, nome, endereco, cidade, estado, cep, telefone;

        public Incluir()
        {
            InitializeComponent();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            if (validaDados())
                SalvaDados();
            else
                MessageBox.Show("Dados invalidos");

            txtCodigoIncluir.Focus();
            return;
        }

        private void SalvaDados()
        {
            //define string de conexão - Provedor + fonte de dados (caminho do banco de dados e seu nome)
            string strConnection = "server=localhost;user id=root;password=root;database=estoquedeprodutos";

            //define instrução SQL para incluir dados na tabela CLientes - INSERT INTO tabela VALUES (campos)
            string strSQL = "INSERT INTO produto(codprod,produto,valor,estoque,datavalidade)"
            + " VALUES ('" + txtCodigoIncluir.Text + "','" + txtProdutoIncluir.Text + "','" + txtDataValIncluir.Text + "')";

            //cria a conexão com o banco de dados
            MySqlConnection dbConnection = new MySqlConnection(strConnection);
            // executa a instrução SQL para incluir dados
            MySqlCommand cmdIncluir = new MySqlCommand(strSQL, dbConnection);
            try
            {
                // abre o banco
                dbConnection.Open();
                // executa a query
                cmdIncluir.ExecuteNonQuery();
                //
                MessageBox.Show("Dados Salvos com sucesso.");
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

        private Boolean validaDados()
        {
            if (txtCodigoIncluir.Text == string.Empty)
                return false;

            if (txtProdutoIncluir.Text == string.Empty)
                return false;

            if (txtValorIncluir.Text == string.Empty)
                return false;

            if (txtEstoqueIncluir.Text == string.Empty)
                return false;

            if (txtDataValIncluir.Text == string.Empty)
                return false;

            

            return true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Incluir_Load(object sender, EventArgs e)
        {
            txtCodigoIncluir.Text = codigo;
            txtProdutoIncluir.Text = nome;
            txtValorIncluir.Text = endereco;
            txtEstoqueIncluir.Text = cidade;
            txtDataValIncluir.Text = estado;
            
        }

        private void Incluir_Load_1(object sender, EventArgs e)
        {

        }

    }
}
