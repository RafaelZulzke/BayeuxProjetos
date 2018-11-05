using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ProjetoMysql
{
    public partial class Form2 : Form
    {
        string caminho = "SERVER=localhost;DATABASE=dbexemplo;UID=root;PASSWORD=root;";

        public Form2()
        {
            InitializeComponent();            
        }


        public void conecta(string query)
        {
            MySqlConnection conexao = new MySqlConnection(caminho);
            conexao.Open();
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            
        }

        public void ListaDados()
        {
            string query = String.Format("SELECT * FROM tbcidade", "dbexemplo");
            conecta(query);            
        }

        public void PesqCodigo(int Cod)
        {
            string query = String.Format("SELECT * FROM tbcidade WHERE Codigo = " + Cod, "dbexemplo");
            conecta(query);
        }

        public void PesqNome(string Nom)
        {
            string query = String.Format("SELECT * FROM tbcidade WHERE Nome LIKE '%"+Nom+"%'", "dbexemplo");
            conecta(query);            
        }

        public void PesqCidade(string Cid)
        {
            string query = String.Format("SELECT * FROM tbcidade WHERE Cidade LIKE '%" + Cid + "%'", "dbexemplo");
            conecta(query);
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            modeloCidade moCid = new modeloCidade();
            cidal dcid = new cidal();

            moCid.Nome = txtNome.Text;
            moCid.Cidade = txtCidade.Text;
            moCid.Estado = txtEstado.Text;

            dcid.cadastro(moCid);

            txtNome.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";

            ListaDados();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ListaDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                if (rbPesqCod.Checked == true)
                {
                    PesqCodigo(int.Parse(txtPesquisa.Text));
                }
                else if (rbPesqNome.Checked == true)
                {
                    PesqNome(txtPesquisa.Text);
                }
                else if (rbPesqCidade.Checked == true)
                {
                    PesqCidade(txtPesquisa.Text);
                }
            }
            else
            {
                MessageBox.Show("A sua pesquisa está em branco. Impossível Pesquisar!");
                txtPesquisa.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {   
            string mensagem = "Deseja Realmente Excluir este registro?" + "\n";
            string registro = txtNome.Text + "\n" + txtCidade.Text + " - " + txtEstado.Text;
            
            if (MessageBox.Show(mensagem + "\n" + registro, "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = String.Format("DELETE FROM tbcidade WHERE Nome LIKE '%" + txtNome.Text + "%'", "dbexemplo");
                conecta(query);
            }
            else
            {
                txtPesquisa.Focus();
            }
            ListaDados();
            txtPesquisa.Clear();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string query = String.Format("UPDATE tbcidade SET Nome = '" + txtNome.Text + "',Cidade = '" + txtCidade.Text + "', Estado = '" + txtEstado.Text + "' WHERE Nome LIKE '%" + txtPesquisa.Text + "%'", "dbexemplo");
            conecta(query);

            ListaDados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            this.txtNome.Text = row.Cells[1].Value.ToString();
            this.txtCidade.Text = row.Cells[2].Value.ToString();
            this.txtEstado.Text = row.Cells[3].Value.ToString();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            ListaDados();
        }
    }
}
