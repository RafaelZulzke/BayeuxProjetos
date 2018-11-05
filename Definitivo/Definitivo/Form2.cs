using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Definitivo
{
    public partial class Form2 : Form
    {
        string caminho = "SERVER=localhost;DATABASE=emps;UID=root;PASSWORD=root;";

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
            string query = String.Format("SELECT * FROM tbgerente", "emps");
            conecta(query);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ListaDados();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            ModeloEmpresa moEmp = new ModeloEmpresa();
            cidal dcid = new cidal();

            moEmp.Nome = txtNome.Text;
            moEmp.Cidade = txtCidade.Text;
            moEmp.Estado = txtEstado.Text;

            dcid.cadastro(moEmp);

            txtNome.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";

            ListaDados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListaDados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            this.txtNome.Text = row.Cells[1].Value.ToString();
            this.txtCidade.Text = row.Cells[2].Value.ToString();
            this.txtEstado.Text = row.Cells[3].Value.ToString();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btExcluir_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja Realmente Excluir este registro?" + "\n";
            string registro = txtNome.Text + "\n" + txtCidade.Text + " - " + txtEstado.Text;

            if (MessageBox.Show(mensagem + "\n" + registro, "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = String.Format("DELETE FROM tbgerente WHERE Nome LIKE '%" + txtNome.Text + "%'", "emps");
                conecta(query);
            }
            else
            {
                txtNome.Focus(); 
            }
            ListaDados();
            txtNome.Clear(); 
        }

        private void btLocalizaG_Click(object sender, EventArgs e)
        {
            string query, encontre;

            encontre = "%" + (string)txtbusca2.Text + "%";

            if (txtbusca2.Text == "")
            {
                query = String.Format("Select * from tbgerente", "emps");
            }
            else
            {
                query = String.Format("Select * from tbgerente where Estado like '" + encontre + "'", "emps");
            }

            MySqlConnection conexao = new MySqlConnection(caminho);

            conexao.Open();

            MySqlCommand command = new MySqlCommand(query, conexao);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable data = new DataTable();

            adapter.Fill(data);

            dataGridView1.DataSource = data;

        }

    }
}
