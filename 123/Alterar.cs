using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
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
            txtCodigo.Text = codigo;
            txtProduto.Text = produto;
            txtValor.Text = valor;
            txtEstoque.Text = estoque;
            txtDatadevalidade.Text = validade;
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
            txtCodigo.Focus();
            return;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alterardados()
        {
            //define string de conexão - Provedor + fonte de dados (caminho do banco de dados e seu nome)
            string strConnection = "server=localhost;user id=root;password=root;database=acessodados";

            //define a instrução SQL para atualizar os dados da tabela Clientes - UPDATE tabela SET campos
            string strSQL = "UPDATE clientes SET nome ='" + txtNome.Text.Replace("'", "''") + "', endereco='" + txtEndereço.Text + "', cidade='" + txtCidade.Text + "', estado='" + txtEstado.Text + "', cep='" + txtCEP.Text + "', telefone='" + txtTelefone.Text + "' WHERE codigo=" + int.Parse(codigo) + "";

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
            if (txtCodigo.Text == string.Empty)
                return false;
            if (txtProduto.Text == string.Empty)
                return false;
            if (txtValor.Text == string.Empty)
                return false;
            if (txtEstoque.Text == string.Empty)
                return false;
            if (txtDatadevalidade.Text == string.Empty)
                return false;

            return true;

        }
    }
}
