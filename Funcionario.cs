using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Text;
using Ubiety.Dns.Core.Records.General;

namespace cadastro_funcionario
{
    class Funcionario
    {
        private const string strConexaoBD = "Server=localhost;Port=3306;Database=empresa;Uid=root;Pwd=0022";
        // string de conexão com o banco de dados
        public int Matricula { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Endereco { get; set; }

        public DataTable Pesquisar()
            // DataTable retorna um objeto que é uma relação de registros do BD
        {
            StringBuilder query = new StringBuilder("select matricula as Matrícula, cpf as CPF, nome as Nome, data_nascimento as 'Data de Nacimento', endereco as Endereço from funcionarios where 1");
            // pq o where 1 no final?
            // criando a query base que sera passada ao banco de dados

            if (Matricula != 0)
            {
                query.Append(" and matricula=@matricula");
            }
            if (!Cpf.Equals(""))
            {
                query.Append(" and cpf=@cpf");
            }
            if (!Nome.Equals("")) 
            {
                query.Append(" and nome like @nome");
            }
            if (!DataNascimento.Equals(""))
            {
                query.Append(" and data_nascimento=@data_nascimento");
            }

            MySqlConnection conexaoBD = new MySqlConnection(strConexaoBD);
            // cria conexão com o BD

            MySqlCommand comandoBD = new MySqlCommand(query.ToString(), conexaoBD);
            // o comando enviado ao BD requer a query e uma conexão com o BD


            comandoBD.Parameters.AddWithValue("@matricula", Matricula);
            comandoBD.Parameters.AddWithValue("@cpf", Cpf);
            comandoBD.Parameters.AddWithValue("@nome", "%" + Nome + "%");
            // substituir os parâmetros da pesquisa de forma segura, impedindo ataques por SQL Injection

            MySqlDataAdapter adapter = new MySqlDataAdapter(comandoBD);
            // executa o comando SQL
            // ou poderia ser adapter.SelectCommand = comandoBD;

            DataTable resultadoPesquisa = new DataTable();
            // dataTable para receber os registros da consulta
            adapter.Fill(resultadoPesquisa);
            // preenchimento do dataTable
            return resultadoPesquisa;


        }
    }
}
