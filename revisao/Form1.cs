using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace revisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             try
            {
                string caminho = "SERVER=localhost;DATABASE=loja;UID=root;PASSWORD=root;";
                MySqlConnection conexao = new MySqlConnection(caminho);
                MySqlCommand command = new MySqlCommand("select * from usuarios where login='" + this.txtusuario.Text + "' and senha='" + this.txtsenha.Text + "';", conexao);
                MySqlDataReader Reader;
                conexao.Open();
                Reader = command.ExecuteReader();
                
                int count = 0;
                
                while (Reader.Read())
                {
                    count = count + 1;
                }
                
                if (count == 1)
                {
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Usuário e Senha duplicados...Acesso Negado!");
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Incorretos." + "\n" + "Por favor, tente novamente!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusuario.Focus();
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }
    }

