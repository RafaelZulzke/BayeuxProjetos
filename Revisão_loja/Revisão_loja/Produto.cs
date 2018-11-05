using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Revisão_loja
{
    class Produto
    {
        private string VProd;
        private string VMarca;
        private double VValor;
        private int VEstoque;
        
        public string Prod
        {
            get {return VProd;}
            set { VProd = value;}
        }

        public string Marca
        {
            get { return VMarca; }
            set { VMarca = value; }
        }

        public double Valor
        {
            get { return VValor; }
            set { VValor = value; }
        }

        public int Estoque
        {
            get { return VEstoque; }
            set { VEstoque = value; }
        }


          
    }
}
