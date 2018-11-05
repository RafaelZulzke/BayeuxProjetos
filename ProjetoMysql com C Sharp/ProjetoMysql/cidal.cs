using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ProjetoMysql
{
    class cidal
    {
         private MySqlConnection conexao;

         public void cadastro(modeloCidade moCid)
         {
             string caminho = "SERVER=localhost;DATABASE=dbexemplo;UID=root;PASSWORD=root;";
            
             try
             {
                 conexao = new MySqlConnection(caminho);

                 conexao.Open();

                 string inserir = "INSERT INTO tbcidade(nome,cidade,estado) VALUES ('" + moCid.Nome + "','" + moCid.Cidade +  "','" + moCid.Estado + "')";

                 MySqlCommand comandos = new MySqlCommand(inserir, conexao);

                 comandos.ExecuteNonQuery();

                 conexao.Close();
             }
             catch (Exception ex)
             {
                 throw new Exception("Erro de comandos: " + ex.Message);
             }
         }
    }
}
