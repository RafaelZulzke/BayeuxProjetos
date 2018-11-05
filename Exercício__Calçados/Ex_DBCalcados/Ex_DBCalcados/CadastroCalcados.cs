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
        private int Cod_ex = 0;
        private int linhaatual = 0;
        public void listarDados()
        {
            string query = String.Format("Select * From tabelacalçados", "calcados");

            MySqlConnection conect = new MySqlConnection(caminho);
            conect.Open();
            MySqlCommand comandos = new MySqlCommand(query, conect);
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

          private void obtemDadosGrid()
        {
            cCalcado cCalc = new cCalcado();
            banco bd = new banco();

            cCalc.codigo = int.Parse(dataGridView1 [0, linhaatual].Value.ToString());
            cCalc.nome = dataGridView1 [1, linhaatual].Value.ToString();
            cCalc.marca = dataGridView1 [2, linhaatual].Value.ToString();
            cCalc.tamanho = dataGridView1 [3,linhaatual].Value.ToString();
            cCalc.cor = dataGridView1 [4, linhaatual].Value.ToString();
            cCalc.tipo = dataGridView1 [5, linhaatual].Value.ToString();
            cCalc.preco = double.Parse(dataGridView1 [6, linhaatual].Value.ToString());
            cCalc.estoque = int.Parse (dataGridView1 [7,linhaatual].Value.ToString());

          
            txtNome.Text = cCalc.nome;
            txtMarca.Text = cCalc.marca;
            txtTamanho.Text = cCalc.tamanho;
            txtCor.Text = cCalc.cor;
            txtTipo.Text = cCalc.tipo;
            txtPreco.Text = Convert.ToString(cCalc.preco);
            txtEstoque.Text = Convert.ToString(cCalc.estoque);

        }


          private void excluirDados()
          {
              string conexao = "server=localhost;userid=root;password=root;database=calcados";
              string apaga = "delete from tabelacalçados where codigo = " + Convert.ToString(Cod_ex) + "";

              MySqlConnection dbconnection = new MySqlConnection(conexao);
              MySqlCommand exclui = new MySqlCommand(apaga, dbconnection);

              try
              {
                  dbconnection.Open();
                  exclui.ExecuteNonQuery();
                  MessageBox.Show("Dados Excluídos com Sucesso");
              }

              catch (MySqlException ex)
              {
                  MessageBox.Show("Erro." + ex.Message);

              }
              finally
              {
                  dbconnection.Close();
              }


          }


        private void btExcluir_Click(object sender, EventArgs e)
        {
            cCalcado excluir = new cCalcado();

            banco calcados = new banco();

            try
            { 
            Cod_ex = Convert.ToInt16(dataGridView1[0,linhaatual].Value.ToString());
            }

            catch (Exception ex)
            {
            MessageBox.Show("Erro." + ex.Message);
            }

            if (linhaatual <= 0 )
            {
            obtemDadosGrid();
            }

            if (MessageBox.Show("Confirmar exclusão? Sim/Não","Atenção",MessageBoxButtons.YesNo) == DialogResult.Yes)
        
            {
            excluirDados();
            }
    }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaatual = int.Parse(e.RowIndex.ToString());
        }

    }
}