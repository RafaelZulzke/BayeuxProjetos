using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Definitivo
{
    class ModeloEmpresa
    {

        private int nCodigo;
        private string nNome;
        private string nCidade;
        private string nEstado;

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

        public string Cidade
        {
            get { return nCidade; }
            set { nCidade = value; }
        }

        public string Estado
        {
            get { return nEstado; }
            set { nEstado = value; }
        }

    }
}
