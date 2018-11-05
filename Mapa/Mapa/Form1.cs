using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mapa
{
    public partial class Maps : Form
    {
        public Maps()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Maps_Load(object sender, EventArgs e)
        {

        }

        private void localiza_Click(object sender, EventArgs e)
        {
            string endereco = "http://www.maps.google.com/maps?q=";

            if (txtCidade.Text != "")
            {
                endereco=endereco + txtCidade.Text + ",";
            }

            if (txtEstado.Text != "")
            {
                endereco = endereco + txtEstado.Text + ",";
            }

            if (txtRua.Text != "")
            {
                endereco = endereco + txtRua.Text + ",";
            }
             if (txtCep.Text != "")
                {
                    endereco = endereco + txtCep.Text + ",";
                }


             this.Text = endereco;
             webBrowser1.Navigate(endereco);
            }
        }
    
}
