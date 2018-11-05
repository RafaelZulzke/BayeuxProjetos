using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Estoque_de_Produtos_0409
{
    public partial class Localizar : Form
    {
        private string criterio = "";
        public string sqlString = "";

        public Localizar()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            criterio = textBox1.Text.ToString();
            if (criterio != "")
            {
                sqlString = "Select * from Clientes where nome like '" + criterio + "%'";
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite o nome a ser localizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
