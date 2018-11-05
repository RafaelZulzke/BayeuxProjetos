using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Prog_Agenda
{
    class Sql
    {
        private MySqlConnection Conexao;
        public void Cadastro(Modelo Mo)
        {
            string Caminho = "Server = localhost; DataBase = agenda; UID = root; Password = root";
            try
            {
                Conexao = new MySqlConnection(Caminho);
                Conexao.Open();
                string Inserir = "Insert Into contatos(nome, endereco, cep, bairro, cidade, estado, email, ddd, celular) Values ('" + Mo.Nome + "','" + Mo.Endereco + "','" + Mo.Cep + "','" + Mo.Bairro + "','" + Mo.Cidade +"','" + Mo.Estado +"','" + Mo.Email +"','" + Mo.Ddd +"','" + Mo.Celular + "')";
                MySqlCommand Comandos = new MySqlCommand(Inserir, Conexao);
                Comandos.ExecuteNonQuery();
                Conexao.Close();
            }
            catch (Exception EX)
            {
                throw new Exception("Erro " + EX.Message);
            }
        }
    }
}
