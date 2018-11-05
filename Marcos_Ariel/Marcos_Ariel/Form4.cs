using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Marcos_Ariel
{
    public partial class Form4 : Form
    {

        public string codigo, nome, endereco, cidade, estado, cep, telefone;
        public Form4()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirma exclusao (S/N)?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                excluirdados();
                this.Close();
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = codigo;
            txtNome.Text = nome;
            txtEndereço.Text = endereco;
            txtCidade.Text = cidade;
            txtEstado.Text = estado;
            txtCEP.Text = cep;
            txtTelefone.Text = telefone;

        }
        private void excluirdados()
        {
            //define uma string de conexao
            string strConnection = "Server=localhost; user id=root;password=root;database=acessodados";

            //define uma instrucao SQL para excluir dados da tabela
            string strSQL = "Delete from clientes where codigo=" + int.Parse(codigo) + "";

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
