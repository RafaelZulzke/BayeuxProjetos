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
    public partial class Alterar : Form
    {
        public string codigo, produto, valor, estoque, validade;
        public Alterar()
        {
            InitializeComponent();
        }

        private void Alterar_Load(object sender, EventArgs e)
        {
            txtCodigoAlterar.Text = codigo;
            txtProdutoAlterar.Text = produto;
            txtValorAlterar.Text = valor;
            txtEstoqueAlterar.Text = estoque;
            txtDataValAlterar.Text = validade;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (validadados())
            {
                Alterardados();
            }
            else
            {
                MessageBox.Show("Dados invalidos");
            }
            txtCodigoAlterar.Focus();
            return;

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alterardados()
        {
            //define string de conexão - Provedor + fonte de dados (caminho do banco de dados e seu nome)
            string strConnection = "server=localhost;user id=root;password=root;database=estoquedeprodutos";

            //define a instrução SQL para atualizar os dados da tabela Clientes - UPDATE tabela SET campos
            string strSQL = "UPDATE produto  SET codprod ='" + txtCodigoAlterar.Text.Replace("'", "''") + "', produto='" + txtProdutoAlterar.Text + "', valor='" + txtValorAlterar.Text + "', estoque='" + txtEstoqueAlterar.Text + "', datavalidade='" + txtDataValAlterar.Text + "',WHERE codigo=" + int.Parse(codigo) + "";

            //cria a conexão com o banco de dados
            MySqlConnection dbConnection = new MySqlConnection(strConnection);
            //Cria o comando que inicia a instrução SQL para alteração
            MySqlCommand cmdAlterar = new MySqlCommand(strSQL, dbConnection);
            try
            {
                // abre o banco de dados
                dbConnection.Open();
                // executa a instrução SQL
                cmdAlterar.ExecuteNonQuery();
                //
                MessageBox.Show("Dados Alterados com sucesso.");
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

        private Boolean validadados()
        {
            if (txtCodigoAlterar.Text == string.Empty)
                return false;
            if (txtProdutoAlterar.Text == string.Empty)
                return false;
            if (txtValorAlterar.Text == string.Empty)
                return false;
            if (txtEstoqueAlterar.Text == string.Empty)
                return false;
            if (txtDataValAlterar.Text == string.Empty)
                return false;

            return true;

        }

        private void Alterar_Load_1(object sender, EventArgs e)
        {

        }



    }
}
