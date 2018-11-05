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
    public partial class Incluir : Form
    {
        public string codigo, produto, valor, estoque, validade;
        public Incluir()
        {
            InitializeComponent();
        }

        private void brIncluir_Click(object sender, EventArgs e)
        {
            if (validadados())
            
                SalvaDados();
            
            else
                MessageBox.Show("Dados Incorretos, Digite Novamente");
            txtCodigo.Focus();
            return;
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
        private void SalvaDados() 
        {
            string minhaConection = "server = localhost;user id =root;password = root;database=estoquedeprodutos";

            string meuSQL = "INSERT INTO produtos(codprod,produto,valor,estoque,datavalidade)" + "VALUES('" + txtCodigo.Text + "','" + txtProduto.Text + "','" + txtValor.Text + "','" + txtEstoque.Text + "','" + txtDatadevalidade.Text + "')";

            MySqlConnection bancodedados = new MySqlConnection(minhaConection);
            MySqlCommand comandinhodoincluir = new MySqlCommand(meuSQL, bancodedados);

            try
            {
                bancodedados.Open();
                comandinhodoincluir.ExecuteNonQuery();
                MessageBox.Show("Dados Cadastrados com Sucesso");
            }

            catch (MySqlException xe)
            {
                MessageBox.Show("Erro:" + xe.Message);
            }
            finally 
            {
                bancodedados.Clone();
            }


        }

        private void Incluir_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = codigo;
            txtProduto.Text = produto;
            txtValor.Text = valor;
            txtEstoque.Text = estoque;
            txtDatadevalidade.Text = validade;
        }
    }
}
