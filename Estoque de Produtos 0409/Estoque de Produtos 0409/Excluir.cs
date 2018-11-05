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
    public partial class Excluir : Form
    {
        public string codigo, produto, valor, estoque, validade;
        public Excluir()
        {
            InitializeComponent();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusao (S/N)?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                excluirdados();
                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Excluir_Load(object sender, EventArgs e)
        {
            txtCodigoExcluir.Text = codigo;
            txtProdutoExcluir.Text = produto;
            txtValorExcluir.Text = valor;
            txtEstoqueExcluir.Text = estoque;
            txtDataValExcluir.Text = validade;
            //codigo, produto, valor, estoque, data de val

        }

        private void excluirdados()
        {
            //define uma string de conexao
            string strConnection = "Server=localhost; user id=root;password=root;database=estoquedeprodutos";

            //define uma instrucao SQL para excluir dados da tabela
            string strSQL = "Delete from produtos where codprod=" + int.Parse(codigo) + "";

            //cria a conexao com o banco de dados
            MySqlConnection dbConnection = new MySqlConnection(strConnection);

            //cria o comando que inicia a instrucao SQL para exclusao
            MySqlCommand cmdexcluir = new MySqlCommand(strSQL, dbConnection);
            // dbConnection = new MySqlConnection(strConnection);

            try
            {
                //abre o banco de dados
                dbConnection.Open();
                cmdexcluir.ExecuteNonQuery();

                MessageBox.Show("Dados excluidos com sucesso");
            }

            //trata a excecao
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }

        }


     

    }
}
