using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Loja
{
    class Banco
    {
        private MySqlConnection conexao;

        public void cadastro (tProduto po)
        {

            string caminho = "server=localhost;database=loja;uid=root;password=root;";
            //database --> banco de dados

        try
    {
        conexao = new MySqlConnection (caminho);
            conexao.Open();
            string inserir = "insert into produtos (produto,marca,valor,estoque) values ('"+ po.produto + "', '"+po.marca+"', '"+po.valor+"', '"+po.estoque+"')";
                // produtos --> tabela produto do bd ; entre prtss são os campos da mesma

                MySqlCommand comandos = new MySqlCommand (inserir, conexao);

            comandos.ExecuteNonQuery();
            conexao.Close();
        }

            catch (Exception ex)
        {
                throw new Exception ("Erro de Comandos"+ ex.Message);
            }
        }
                
    }
}
