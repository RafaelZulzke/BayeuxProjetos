using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace Ex_DBCalcados
{
    public partial class CadastroCalcados : Form
    {
        string caminho = "SERVER=localhost;DATABASE=calcados;UID=root;PASSWORD=root;";
        public CadastroCalcados()
        {
            InitializeComponent();
        }

        public void listarDados()
        {
            string query = String.Format("Select * From tabelacalçados", "calcados");

            MySqlConnection conect = new MySqlConnection(caminho);
            conect.Open();
            MySqlCommand comandos = new MySqlCommand(query,conect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comandos);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }


        private void CadastroCalcados_Load(object sender, EventArgs e)
        {
            listarDados();
        }


        private void txtSair_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            cCalcado cal = new cCalcado();
            banco bd = new banco();
            cal.nome = txtNome.Text;
            cal.marca = txtMarca.Text;
            cal.tamanho = txtTamanho.Text;
            cal.tipo = txtTipo.Text;
            cal.cor = txtCor.Text;
            cal.preco = double.Parse(txtPreco.Text);
            cal.estoque = int.Parse(txtEstoque.Text);

            bd.cadastro(cal);
            txtNome.Text = "";
            txtMarca.Text = "";
            txtTamanho.Text = "";
            txtTipo.Text = "";
            txtCor.Text = "";
            txtPreco.Text = "";
            txtEstoque.Text = "";

            MessageBox.Show("Produto cadastrado com sucesso!");
            listarDados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listarDados();
        }
    }
}
