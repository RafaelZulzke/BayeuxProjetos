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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string caminho = "SERVER=localhost;DATABASE=emps;UID=root;PASSWORD=root;";
                MySqlConnection conexao = new MySqlConnection(caminho);
                MySqlCommand command = new MySqlCommand("select * from emps.senha where usuario='" + this.textBox1.Text + "' and senha='" + this.maskedTextBox1.Text + "';", conexao);
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
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Usuário e Senha duplicados...Acesso Negado!");
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Incorretos." + "\n" + "Por favor, tente novamente!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        
        }

        private void btSairApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        }

    }
