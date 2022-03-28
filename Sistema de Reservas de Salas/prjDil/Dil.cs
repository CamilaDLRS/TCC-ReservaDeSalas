using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace prjDil
{
    public class Dil
    {
        /// <summary>
        /// =======================================================================
        /// Author:         Trevisan, Gilmar & Delarosa, Camila
        /// Create date:    01/06/2017
        /// Description:    Database Access Layer
        /// Public
        /// Properties:
        /// Public
        /// Error control:  Exceções são elevadas ao método chamador
        ///                 Mensagens de erro são registradas na biblioteca de classe prjBll
        /// Classe baseada no projeto 'prjCRUD13' de Gilmar Trevisan  
        /// =======================================================================
        /// </summary>

        // SqlConnection representa uma conexão com o database SQL Server.
        private SqlConnection Conn = null;

        // SqlParameterCollection representa uma coleção de parâmetros associados a um SqlCommand
        // e seus respectivos mapeamentos para colunas em um DataSet.
        // DataSet representa dados em um cache de memória.
        private SqlParameterCollection ParameterCollection = new SqlCommand().Parameters;

        public Dil()
        {

        }

        public void ClearParameterCollection()
        {
            ParameterCollection.Clear();
        }

        public void AddParameter(string parameterName, object parameterValue)
        {
            ParameterCollection.Add(new SqlParameter(parameterName, parameterValue));
        }

        public DataTable ExecuteStoredProcedureQuery(string storedProcedureName)
        {
            try
            {
                // Preapara a stored procedure para execução
                SqlCommand sqlCommand = PrepareSqlCommand(CommandType.StoredProcedure, storedProcedureName);

                // SqlDataAdapter representa um conjunto de comandos de dados e uma conexão de banco de
                // dados que são usados para preencher o DataSet e atualizar um banco de dados do SQL Server.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Representa uma tabela de dados na Memória.
                DataTable dataTable = new DataTable();

                // Manda o comando ir até o banco buscar os dados e o adaptador
                // preencher o dataTable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            // Captura um erro genérico
            catch (Exception ex)
            {
                // Envia a exceção para a o método chamador providenciar uma mensagem para o usuário.
                throw ex;
            }
            // Fecha a conexão se estiver aberta
            finally
            {
                if (this.Conn.State == ConnectionState.Open)
                    this.Conn.Close();
            }
        }

        public int ExecuteStoredProcedureNonQuery(string storedProcedureName)
        {
            try
            {
                // Preapara a stored procedure para execução
                SqlCommand sqlCommand = PrepareSqlCommand(CommandType.StoredProcedure, storedProcedureName);

                // Retorna o numero de registro afetados pela execução da stored procedure
                return sqlCommand.ExecuteNonQuery();

            }
            // Captura um erro genérico
            catch (Exception ex)
            {
                // Envia a exceção para a o método chamador providenciar uma mensagem para o usuário.
                throw ex;
            }
            finally
            {
                this.ClearParameterCollection();
                // Fecha a conexão se estiver aberta
                if (this.Conn.State == ConnectionState.Open)
                    this.Conn.Close();
            }
        }

        public DataTable ExecuteCommandQuery(string command)
        {
            try
            {
                // Preapara a stored procedure para execução
                SqlCommand sqlCommand = PrepareSqlCommand(CommandType.Text, command);

                // SqlDataAdapter representa um conjunto de comandos de dados e uma conexão de banco de
                // dados que são usados para preencher o DataSet e atualizar um banco de dados do SQL Server.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Representa uma tabela de dados na Memória.
                DataTable dataTable = new DataTable();

                // Manda o comando ir até o banco buscar os dados e o adaptador preencher o dataTable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            // Captura um erro genérico
            catch (Exception ex)
            {
                // Envia a exceção para a o método chamador providenciar uma mensagem para o usuário.
                throw ex;
            }
            // Fecha a conexão se estiver aberta
            finally
            {
                if (this.Conn.State == ConnectionState.Open)
                    this.Conn.Close();
            }
        }

        public object ExecuteCommandScalar(string command)
        {
            try
            {
                // Preapara a stored procedure para execução
                SqlCommand sqlCommand = PrepareSqlCommand(CommandType.Text, command);

                return sqlCommand.ExecuteScalar();
            }
            // Captura um erro genérico
            catch (Exception ex)
            {
                // Envia a exceção para a o método chamador providenciar uma mensagem para o usuário.
                throw ex;
            }
            // Fecha a conexão se estiver aberta
            finally
            {
                if (this.Conn.State == ConnectionState.Open)
                    this.Conn.Close();
            }
        }

        // Cria uma conexão com o database.
        // Prameters:
        // Retorno:   uma conexão com o database

        private SqlConnection NewConnection()
        {
            try
            {
                this.Conn = new SqlConnection();

                this.Conn.ConnectionString = Properties.Settings.Default.Conexao;

                return this.Conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SqlCommand PrepareSqlCommand(CommandType commandtype, string command)
        {
            try
            {
                // Cria uma conexão com o database
                this.Conn = this.NewConnection();

                // Abre a conexão com o database
                this.Conn.Open();

                // SqlCommand representa uma instrução Transact-SQL ou procedimento armazenado
                // para executar contra um banco de dados do SQL Server. Essa classe não pode ser herdada.
                SqlCommand sqlCommand = new SqlCommand();

                // Associa o sqlCommand à conexão existente
                sqlCommand.Connection = this.Conn;

                // Define comando do tipo stored procedure
                sqlCommand.CommandType = commandtype;

                // Define o nome da stored procedure
                sqlCommand.CommandText = command;

                // Tempo em segundos que o sistema aguarda pela execução da procedure.
                sqlCommand.CommandTimeout = 3600;


                // Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in ParameterCollection)
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                return sqlCommand;
            }
            // Captura um erro genérico
            catch (Exception ex)
            {
                // Envia a exceção para a o método chamador providenciar uma mensagem para o usuário.
                throw ex;
            }
        }

        public object ExecuteAFieldQuery(CommandType commandType, string command)
        {

            try
            {

                // Cria uma conexão com o database
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.Conexao);

                // Abre a conexão com o database
                sqlConnection.Open();
                // Criar o comando que vai levar as informações até o banco 
                //SqlCommand sqlCommand = new SqlCommand();
                SqlCommand sqlcommand = sqlConnection.CreateCommand();
                // Colocando as coisas dentro do comando (dentro da caixa) que vai trafegar até o banco
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandText = command;
                // Timeout -- o padrão é 30 segundos
                sqlcommand.CommandTimeout = 3600;

                // Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in ParameterCollection)
                    sqlcommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                return sqlcommand.ExecuteScalar();

            }
            catch (Exception)
            {
                // passa o erro para frente e não deixa explodir aqui.
                throw new Exception("Erro de sistema, solicite suporte técnico");
            }
        }
    }
}
