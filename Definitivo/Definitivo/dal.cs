﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Definitivo
{
    class dal
    {

        private MySqlConnection conexao;

        public void cadastro(Modelo mo)
        {
            string caminho = "SERVER=localhost;DATABASE=emps;UID=root;PASSWORD=root;";

            try
            {
                conexao = new MySqlConnection(caminho);

                conexao.Open();

                string inserir = "INSERT INTO tbex(nome,email) VALUES ('" + mo.Nome + "','" + mo.Email + "')";

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
