using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace revisao
{
    class banco
    {
        private MySqlConnection conexao;
        public void cadastro(cproduto po)
        {
            string caminho = "SERVER=localhost;DATABASE=loja;UID=root;PASSWORD=root;";
            try//significa tentar
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();               //nome da tabela   //campos da tabela            variaves da classe produto
                string inserir = "insert into produtos (produto,marca,valor,estoque) values('" + po.produto + "','" + po.marca + "','" + po.valor + "','" + po.estoque + "')";

                MySqlCommand cmd = new MySqlCommand(inserir, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw (new Exception("Erro de cmds" + ex.Message));
            }
        }
    }

}
