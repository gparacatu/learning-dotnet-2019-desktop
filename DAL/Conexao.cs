using DAL.Properties;
using System;
//Bibliotecas para acesso ao banco
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Conexao
    {
        private string RetornaStringConexao()
        {
            //faz leitura do arquivo de configuracao
            string arquivo;
            System.IO.StreamReader file = new System.IO.StreamReader(@"asql.txt");
            arquivo = file.ReadLine() + ("User ID=sa;Password=8944989");

            return arquivo;

        }
        //Cria a conexão
        private SqlConnection CriarConexao()
        {

            return new SqlConnection(RetornaStringConexao());

        }

        //Parametros que vão para o banco
        SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        //Persistencia - Incluir Alterar Excluir

        public object ExecutarManipulacao(CommandType commandType, string storedProcedureOuTextoSql)
        {
            try
            {
                //Criar Conexao
                SqlConnection sqlConnection = CriarConexao();

                //Abrir Conexao
                sqlConnection.Open();

                //Criar o command que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //Populando o command
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = storedProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 600; //Tempo que desconectara do banco caso não encontre. Em segundos.

                //Adicionar os parametros no command
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Executar command , enviar para o banco e receber um retorno de apenas um valor
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consulta Registros no Banco de Dados
        public DataTable ExecutarConsulta(CommandType commandType, string storedProcedureOuTextoSql)
        {

            try
            {
                //Criar Conexao
                SqlConnection sqlConnection = CriarConexao();

                //Abrir Conexao
                sqlConnection.Open();

                //Criar o command que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //Populando o command
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = storedProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 600; //Tempo que desconectara do banco caso não encontre. Em segundos.

                //Adicionar os parametros no command
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Criar um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //DataTable = tabela de dados vazia onde vão ficar os dados que serão retornados no banco
                DataTable dataTable = new DataTable();
                //Enviar o comando para buscar os dados no banco e preencher o DataTable com o adptador
                sqlDataAdapter.Fill(dataTable);

                //Retorna o DataTable
                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
