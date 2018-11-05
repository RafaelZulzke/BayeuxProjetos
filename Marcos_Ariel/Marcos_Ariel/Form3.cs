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
    public partial class Form3 : Form
    {

        public string codigo, nome, endereco, cidade, estado, cep, telefone;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = codigo;
            txtNome.Text = nome;
            txtEndereço.Text = endereco;
            txtCidade.Text = cidade;
            txtEstado.Text = estado;
            txtCEP.Text = cep;
            txtTelefone.Text = telefone;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (validadados())
            {
                Alterardados();
            }
            else
            {
                MessageBox.Show("Dados invalidos");
            }
            txtNome.Focus();
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
            if (txtNome.Text == string.Empty)
                return false;
            if (txtEndereço.Text == string.Empty)
                return false;
            if (txtCidade.Text == string.Empty)
                return false;
            if (txtEstado.Text == string.Empty)
                return false;
            if (txtCEP.Text == string.Empty)
                return false;
            if (txtTelefone.Text == string.Empty)
                return false;

            return true;
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }
    }
}
