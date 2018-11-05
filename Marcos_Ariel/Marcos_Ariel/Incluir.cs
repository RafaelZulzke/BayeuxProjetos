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
    public partial class Incluir : Form
    {
        public Incluir()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (validaDados())
                SalvaDados();
            else
                MessageBox.Show("Dados invalidos");

            txtNome.Focus();
            return;

        }
        private void SalvaDados()
        {
            //define string de conexão - Provedor + fonte de dados (caminho do banco de dados e seu nome)
            string strConnection = "server=localhost;user id=root;password=root;database=acessodados";

            //define instrução SQL para incluir dados na tabela CLientes - INSERT INTO tabela VALUES (campos)
            string strSQL = "INSERT INTO clientes(codigo,nome,endereco,cidade,estado,cep,telefone)"
            + " VALUES ('" + txtCodigo.Text + "','" + txtNome.Text + "','" + txtEndereço.Text + "','" + txtCidade.Text + "','" + txtEstado.Text + "','" + txtCEP.Text + "','" + txtTelefone.Text + "')";

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


        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Incluir_Load(object sender, EventArgs e)
        {

        }
    }
}
