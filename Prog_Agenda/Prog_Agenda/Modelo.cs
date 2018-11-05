using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Prog_Agenda
{
    class Modelo
    {

        private int VCodigo;
        private string VNome;
        private string VEndereco;
        private string VCep;
        private string VBairro;
        private string VCidade;
        private string VEstado;
        private string VEmail;
        private string VDdd;
        private string VCelular;

        public int Codigo
        {
            get { return VCodigo; }
            set { VCodigo = value; }
        }

        public string Nome
        {
            get { return VNome; }
            set { VNome = value; }
        }

        public string Endereco
        {
            get { return VEndereco; }
            set { VEndereco = value; }
        }

        public String Cep
        {
            get { return VCep; }
            set { VCep = value; }
        }

        public string Bairro
        {
            get { return VBairro; }
            set { VBairro = value; }
        }

        public string Cidade
        {
            get { return VCidade; }
            set { VCidade = value; }
        }
        public string Estado
        {
            get { return VEstado; }
            set { VEstado = value; }
        }

        public String Email
        {
            get { return VEmail; }
            set { VEmail = value; }
        }

        public string Ddd
        {
            get { return VDdd; }
            set { VDdd = value; }
        }

        public string Celular
        {
            get { return VCelular; }
            set { VCelular = value; }
        }


    }
}
