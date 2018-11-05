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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string caminho = "SERVER=localhost;DATABASE=dbexemplo;UID=root;PASSWORD=root;";
                MySqlConnection conexao = new MySqlConnection(caminho);
                MySqlCommand command = new MySqlCommand("select * from dbexemplo.senha where usuario='" + this.textBox1.Text + "' and senha='" + this.maskedTextBox1.Text + "';", conexao);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
