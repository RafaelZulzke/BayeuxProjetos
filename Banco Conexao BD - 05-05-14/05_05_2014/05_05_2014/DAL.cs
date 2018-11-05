using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient; // Depois de criar a conexão .NET (Botão Direito no projeto, no solution explorer --> Add Reference --> Mysql.Data)

namespace _05_05_2014
{
    class DAL
    {
        private MySqlConnection conexao; // conexao é a variavel
        public void Cadastro(Modelo mo)
        {
            string caminho = "server=localhost;database=cadastro;uid=root;password=root;";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                string inserir = "insert into clientes(Nome,Email) values ('"+mo.nome+"','"+mo.email+"')";
                MySqlCommand comandos = new MySqlCommand(inserir,conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }

            catch(Exception ex)
            {
                throw new Exception("Erro "+ ex.Message);
            }
    
            }
    }

    }
