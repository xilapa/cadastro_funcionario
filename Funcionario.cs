using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
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
        private string dia { get; set; }
        private string mes { get; set; }
        private string ano { get; set; }

        public void AddValues(ref MySqlCommand c, string _q)
        // método para substituir os parâmetros da query de forma segura, impedindo ataques por SQL Injection
        {
            if ((Matricula != 0) && (_q.Contains("@matricula")))
            {
                c.Parameters.AddWithValue("@matricula", Matricula);
            }
            if ((!Cpf.Equals("")) && (_q.Contains("@cpf")))
            {
                c.Parameters.AddWithValue("@cpf", Cpf);
            }
            if ((!Nome.Equals("")) && (_q.Contains("@nome")))
            {
                c.Parameters.AddWithValue("@nome", Nome);
            }
            if ((!DataNascimento.Equals("  /  /")) && (_q.Contains("@data_nascimento")))
            {
                //ajuste da data de nascimento para o padrão do MySQL
                dia = DataNascimento.Substring(0, 2);
                mes = DataNascimento.Substring(3, 2);
                ano = DataNascimento.Substring(6, 4);
                DataNascimento = ano + "-" + mes + "-" + dia;
                c.Parameters.AddWithValue("@data_nascimento", DataNascimento);
            }
            if ((!Endereco.Equals("")) && (_q.Contains("@endereco")))
            {
                c.Parameters.AddWithValue("@endereco", Endereco);
            }
            
            

        }

        private void RunQuery(string q)
        // método criado para executar querys sem retorno de valores
        {
            try
            {
                MySqlConnection conexaoBD = new MySqlConnection(strConexaoBD);
                MySqlCommand comandoBD = new MySqlCommand(q, conexaoBD);
                //comandoBD.CommandText = q;

                conexaoBD.Open();
                comandoBD.Prepare();
                AddValues(ref comandoBD,q);
                comandoBD.ExecuteNonQuery();
                conexaoBD.Close();
            }
            catch (Exception e)
            {
                throw e;
            }


        }

        public DataTable Pesquisar()
            // DataTable retorna um objeto que é uma relação de registros do BD
        {
            try
            {
                StringBuilder query = new StringBuilder("select matricula as Matrícula, cpf as CPF, nome as Nome, data_nascimento as 'Data de Nascimento', endereco as Endereço from funcionarios where 1");
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
                if (!DataNascimento.Equals("  /  /"))
                {
                    query.Append(" and data_nascimento=@data_nascimento");
                }

                MySqlConnection conexaoBD = new MySqlConnection(strConexaoBD);
                // cria conexão com o BD

                MySqlCommand comandoBD_p = new MySqlCommand(query.ToString(), conexaoBD);
                // o comando enviado ao BD requer a query e uma conexão com o BD

                AddValues(ref comandoBD_p, query.ToString());

                //if (Matricula != 0)
                //{
                //    comandoBD_p.Parameters.AddWithValue("@matricula", Matricula);
                //}
                //if (!Cpf.Equals(""))
                //{
                //    comandoBD_p.Parameters.AddWithValue("@cpf", Cpf);
                //}
                //if (!Nome.Equals(""))
                //{
                //    comandoBD_p.Parameters.AddWithValue("@nome", Nome);
                //}
                //if (!DataNascimento.Equals("  /  /"))
                //{
                //    //ajuste da data de nascimento para o padrão do MySQL
                //    // TODO: utilizar formato date
                //    dia = DataNascimento.Substring(0, 2);
                //    mes = DataNascimento.Substring(3, 2);
                //    ano = DataNascimento.Substring(6, 4);
                //    DataNascimento = ano + "-" + mes + "-" + dia;
                //    comandoBD_p.Parameters.AddWithValue("@data_nascimento", DataNascimento);
                //}

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comandoBD_p);
                // executa o comando SQL
                // ou poderia ser adapter.SelectCommand = comandoBD;

                DataTable resultadoPesquisa = new DataTable();
                // dataTable para receber os registros da consulta
                dataAdapter.Fill(resultadoPesquisa);
                // preenchimento do dataTable
                return resultadoPesquisa;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //salvar
        public void Salvar()
        {
            StringBuilder query = new StringBuilder("insert into funcionarios(cpf,nome,data_nascimento,endereco) values (@cpf,@nome,@data_nascimento,@endereco);");
            RunQuery(query.ToString());
        }
        //excluir
        public void Excluir()
        {
            StringBuilder query = new StringBuilder("delete from funcionarios where matricula=@matricula");
            RunQuery(query.ToString());
        }


        //atualizar
   


    }
}
