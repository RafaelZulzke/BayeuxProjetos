using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Localizar : Form
    {
        private string criterio = "";
        public string sqlString = "";
        public Localizar()
        {
            InitializeComponent();
        }

        private void Localizar_Load(object sender, EventArgs e)
        {
            criterio = txtLocalizar.Text.ToString();
            if (criterio != "")
            {
            sqlString = "Select * from  produtos where Codigo like'"+criterio+"%'";
             this.Close();
            }
            else
            {
                MessageBox.Show("Digite o nome a ser localizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocalizar.Focus();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
