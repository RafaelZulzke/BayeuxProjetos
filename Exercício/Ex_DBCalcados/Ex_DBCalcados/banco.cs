using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Ex_DBCalcados
{
    class banco
    {
        private MySqlConnection conexao;

        public void cadastro(cCalcado cal)
        {
            string caminho = "SERVER=localhost;DATABASE=calcados;UID=root;PASSWORD=root;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                string inserir = "insert into tabelacalçados (nome, marca, tamanho, cor, tipo, preco, estoque) values('" + cal.nome + "','" + cal.marca + "','" + cal.tamanho + "','" + cal.cor + "' ,'" + cal.tipo + "' ,'" + cal.preco + "' ,'" + cal.estoque + "')";

                MySqlCommand cmd = new MySqlCommand(inserir, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }

            catch (Exception ex)
            {
                throw (new Exception("Erro de comandos" + ex.Message));
            }
        }
    }
}
