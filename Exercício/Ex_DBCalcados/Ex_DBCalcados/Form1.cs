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
    public partial class Form1 : Form
    {
        string caminho = "server = localhost;database = calcados; uid = root , password = root;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btEntrar_Click(object sender, EventArgs e)
        {

            try
            {
            string caminho = "SERVER=localhost;DATABASE=calcados;UID=root;PASSWORD=root;";
            MySqlConnection conexao = new MySqlConnection(caminho);
            MySqlCommand command = new MySqlCommand("select * from login where usuario='" + this.txtUsuario.Text + "' and senha='" + this.txtSenha.Text + "';", conexao);
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
                CadastroCalcados cadastro = new CadastroCalcados();
                cadastro.Show();
            }

            else if (count > 1)
            {
                MessageBox.Show("Usuário e Senha duplicados. Acesso Negado.");
            }

            else
            {
                MessageBox.Show("Usuário ou Senha incorretos." + "\n" + "Tente novamente.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
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

    

