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
    public partial class Form1 : Form
    {
        private MySqlConnection con;
        private MySqlDataAdapter da;
        private DataSet ds;

        private int linhaatual = 0;
        //Variaveis para os campos da tabela clientes
        private string codigo, nome, endereco, cidade, estado, cep, telefone;


        public Form1()
        {
            InitializeComponent();
        }

        private void obtemdadosgrid()
        {
            nome = dataGridView1[1, linhaatual].Value.ToString();
            endereco = dataGridView1[2, linhaatual].Value.ToString();
            cidade = dataGridView1[3, linhaatual].Value.ToString();
            estado = dataGridView1[4, linhaatual].Value.ToString();
            cep = dataGridView1[5, linhaatual].Value.ToString();
            telefone = dataGridView1[6, linhaatual].Value.ToString();


        }


        private void btIncluir_Click(object sender, EventArgs e)
        {
            //Instancia o formulario 2 para incluir e exibi-lo de forma modal
            Incluir frm2 = new Incluir();
            frm2.ShowDialog();
            iniciaacesso();


        }

        private void btAlterar_Click(object sender, EventArgs e)
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
                Form3 f3 = new Form3();

                f3.codigo = codigo;
                f3.nome = nome;
                f3.endereco = endereco;
                f3.cidade = cidade;
                f3.estado = estado;
                f3.cep = cep;
                f3.telefone = telefone;

                f3.ShowDialog();
                //Exibe o formulario para alteracao

                //atualiza o grid e reexibe os dados
                dataGridView1.Update();
                iniciaacesso();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
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
                Form4 f4 = new Form4();

                f4.codigo  = codigo;
                f4.nome = nome;
                f4.endereco = endereco;
                f4.cidade = cidade;
                f4.estado = estado;
                f4.cep = cep;
                f4.telefone = telefone;

                f4.ShowDialog();
                //Exibe o formulario para alteracao

                //atualiza o grid e reexibe os dados
                dataGridView1.Update();
                iniciaacesso();
            }


        }

        private void btProcurar_Click(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.ShowDialog();

            if (f5.sqlString != null && f5.sqlString != "")
                carregagrid(f5.sqlString);

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
    }





    }

