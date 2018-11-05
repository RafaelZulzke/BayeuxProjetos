using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Ex_DBCalcados
{
    class cCalcado
    {
        private int vcodigo;
        private string vnome, vmarca, vtamanho, vcor, vtipo;
        private double vpreco;
        private int vestoque;



        public int codigo
        {
            get { return vcodigo; }
            set { vcodigo = value; }
        }

        public string   nome
        {
            get { return vnome; }
            set { vnome = value; }
        }

        public string marca
        {
            get { return vmarca; }
            set { vmarca = value; }
        }

        public string tamanho
        {
            get { return vtamanho; }
            set { vtamanho = value; }
        }

        public string cor
        {
            get { return vcor; }
            set { vcor = value; }
        }

        public string tipo
        {
            get { return vtipo; }
            set { vtipo = value; }
        }

        public double preco
        {
            get { return vpreco; }
            set { vpreco = value; }
        }

        public int estoque
        {
            get { return vestoque; }
            set { vestoque = value; }
        }



    }
}
