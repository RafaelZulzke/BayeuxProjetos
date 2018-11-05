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
    public partial class Form1 : Form
    {
        private MySqlConnection con;
        private MySqlDataAdapter da;
        private DataSet ds;

        private int linhaatual = 0;
        //Variaveis para os campos da tabela clientes
        public string codigo, produto, valor, estoque, validade;


        public Form1()
        {
            InitializeComponent();
        }

        private void obtemdadosgrid()
        {
            codigo = dataGridView1[1, linhaatual].Value.ToString();
            produto = dataGridView1[2, linhaatual].Value.ToString();
            valor = dataGridView1[3, linhaatual].Value.ToString();
            estoque = dataGridView1[4, linhaatual].Value.ToString();
            validade = dataGridView1[5, linhaatual].Value.ToString();


        }


        private void btIncluir_Click(object sender, EventArgs e)
        {
            //Instancia o formulario 2 para incluir e exibi-lo de forma modal
            Alterar frm2 = new Alterar();
            frm2.ShowDialog();
            iniciaacesso();


        }

        private void carregagrid(string criteriosql)
        {
            //define o dataset
            ds = new DataSet();

            //cria uma conexao usando a string de conexao
            MySqlConnection con = new MySqlConnection("Server=localhost; user id=root;password=root;database=acessodados");
            try
            {
                //abre conexao
                con.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            if (con.State == ConnectionState.Open)
            {
                da = new MySqlDataAdapter(criteriosql, con);
                da.Fill(ds, "Tabela");

                //exibe os dados na datagridview
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Tabela";
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sair do sistema (S/N) ?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            iniciaacesso();
        }

        private void iniciaacesso()
        {
            //Define o dataset
            ds = new DataSet();

            //cria uma conexao usando a string de conexao
            MySqlConnection con = new MySqlConnection("Server=localhost; user id=root;password=root;database=acessodados");
            try
            {
                //abre conexao
                con.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            if (con.State == ConnectionState.Open)
            {
                da = new MySqlDataAdapter("Select * from clientes", con);
                da.Fill(ds, "Tabela");

                //exibe os dados na datagridview
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Tabela";
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }


        private void btIncluir_Click_1(object sender, EventArgs e)
        {
            Incluir Form2 = new Incluir();
            Form2.Show();
            iniciaacesso();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaatual = int.Parse(e.RowIndex.ToString());
        }

        private void btAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                //obtem o codigo do cliente a partir da linha selecionada na dataview
                codigo = dataGridView1[0, linhaatual].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
            if (linhaatual >= 0)
            {
                //obtem dados da dataview e atribui as variaveis definidas no Form3
                obtemdadosgrid();
                Excluir f3 = new Excluir();

                f3.codigo = codigo;
                f3.produto = produto;
                f3.valor = valor;
                f3.estoque = estoque;
                f3.validade = validade;


                f3.ShowDialog();
                //Exibe o formulario para alteracao

                //atualiza o grid e reexibe os dados
                dataGridView1.Update();
                iniciaacesso();
            }
        }

        private void btExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                //obtem o codigo do cliente a partir da linha selecionada na dataview
                codigo = dataGridView1[0, linhaatual].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
            if (linhaatual >= 0)
            {
                //obtem dados da dataview e atribui as variaveis definidas no Form3
                obtemdadosgrid();
                Excluir f4 = new Excluir();

                f4.codigo = codigo;
                f4.produto = produto;
                f4.valor = valor;
                f4.estoque = estoque;
                f4.validade = validade;

                f4.ShowDialog();
                //Exibe o formulario para alteracao

                //atualiza o grid e reexibe os dados
                dataGridView1.Update();
                iniciaacesso();

            }





        }

        private void btSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btProcurar_Click_1(object sender, EventArgs e)
        {

            Localizar f5 = new Localizar();
            f5.ShowDialog();

            if (f5.sqlString != null && f5.sqlString != "")
                carregagrid(f5.sqlString);
        }
    }
}
