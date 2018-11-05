using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Loja
{
    class tProduto
    {
        private int vcodigo;
        private string vproduto;
        private string vmarca;
        private double vvalor;
        private int vestoque;

        public int codigo
        {
            get { return vcodigo; }
            set { vcodigo = value; }
        }

        public string produto
        {
            get { return vproduto; }
            set { vproduto = value; }
        }

        public string marca
        {
            get { return vmarca;}
            set {vmarca = value;}

        }

        public double valor
        {
            get { return vvalor; }
            set { vvalor = value; }
        }

        public int estoque
        {
            get { return vestoque; }
            set { vestoque = value; }
        }

    }
}
