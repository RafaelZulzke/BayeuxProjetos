using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace Revisão_loja
{
    class Banco
    {
        private MySqlConnection Conect;
        public void Cadastro(Produto Po)
        {
            string caminho = "server = localhost;database = loja; uid = root , password = root;";
            try
            {
                Conect = new MySqlConnection(caminho);
                Conect.Open();
                string Inserir = "insert into produtos(Produto,Marca,Valor,Estoque) values ('" + Po.Prod + "','" + Po.Marca + "','" + Po.Valor + "','" + Po.Estoque + "')";
                MySqlCommand Comandos = new MySqlCommand(Inserir, Conect);
                Comandos.ExecuteNonQuery();
                Conect.Clone();

            }

            catch (Exception Ex)
            { 
            throw new Exception("Erro de Comandos"+Ex.Message);
            }
        }
    }
}
