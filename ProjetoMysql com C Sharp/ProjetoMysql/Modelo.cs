using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoMysql
{
    class Modelo
    {
        private int nCodigo;
        private string nNome;
        private string nEmail;

        public int Codigo
        {
            get { return nCodigo; }
            set { nCodigo = value; }
        }

        public string Nome
        {
            get { return nNome; }
            set { nNome = value; }
        }

        public string Email
        {
            get { return nEmail; }
            set { nEmail = value; }
        }

    }
}
