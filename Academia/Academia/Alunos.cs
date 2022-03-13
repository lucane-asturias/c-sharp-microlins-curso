using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    public class Alunos
    {
        SqlCommand comandoSql = new SqlCommand(); //Indica que irá utilizar comandos SQL.
        StringBuilder sql = new StringBuilder(); //Auxilia na concatenação das strings presentes na query SQL.
        DataTable dadosTabela = new DataTable(); //Armazena as informações que o banco retorna com o select dentro de uma tabela.

        //Método que irá Salvar as informações conforme os parâmetros que possui entre parênteses.
        public void Salvar(string nome, string endereco, string bairro, string cidade, string cep, string cpf, string telefone,
                                                                                       string celular, string sexo, string observacao)
        {
            //Estabelece a conexão com banco através da string de conexão.
            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                conexao.Open(); //Abre a conexão com o banco de dados.

                //Comando SQL para inserção de valores nos respectivos campos da tabela Aluno.
                sql.Append("INSERT INTO Aluno (NOME_ALUNO, ENDERECO_ALUNO, BAIRRO_ALUNO, CIDADE_ALUNO, CEP_ALUNO, CPF_ALUNO,");
                sql.Append(" TELEFONE_ALUNO, CELULAR_ALUNO, SEXO, OBSERVACAO)");
                sql.Append(" VALUES (@nome, @endereco, @bairro, @cidade, @cep, @cpf, @telefone, @celular, @sexo, @observacao)");

                //Relaciona cada valor com seu respectivo parâmetro.
                comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
                comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
                comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
                comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                comandoSql.Parameters.Add(new SqlParameter("@celular", celular));
                comandoSql.Parameters.Add(new SqlParameter("@sexo", sexo));
                comandoSql.Parameters.Add(new SqlParameter("@observacao", observacao));

                comandoSql.CommandText = sql.ToString(); //Indica que o que está definido na StringBuilder é a instrução que deverá ser executada.
                comandoSql.Connection = conexao; //Indica que a conexão dos comandos SQL é a que estamos utilizando.
                comandoSql.ExecuteNonQuery(); //Executa todo o comando para a inserção dos valores.
            }
        }

        //Método que irá Alterar as informações conforme os parâmetros que possui entre parênteses.
        public void Alterar(int idAluno, string nome, string endereco, string bairro, string cidade, string cep, string cpf, string telefone,
                                                                                      string celular, string sexo, string observacao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Aluno");
                    sql.Append(" SET NOME_ALUNO = @nome, ENDERECO_ALUNO = @endereco, BAIRRO_ALUNO = @bairro, CIDADE_ALUNO = @cidade, CEP_ALUNO = @cep,");
                    sql.Append(" CPF_ALUNO = @cpf, TELEFONE_ALUNO = @telefone, CELULAR_ALUNO = @celular, SEXO = @sexo, OBSERVACAO = @observacao");
                    sql.Append(" WHERE (ID_ALUNO = @idAluno)");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                    comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
                    comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
                    comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                    comandoSql.Parameters.Add(new SqlParameter("@celular", celular));
                    comandoSql.Parameters.Add(new SqlParameter("@sexo", sexo));
                    comandoSql.Parameters.Add(new SqlParameter("@observacao", observacao));
                    comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Alterar. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        //Método responsável por listar todas os alunos em ordem decrescente.
        public DataTable Listar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Aluno");
                    sql.Append(" ORDER BY ID_ALUNO DESC"); //Ordem decrescente baseando-se no ID, ie, apresenta os alunos mais atuais primeiro.

                    comandoSql.CommandText = sql.ToString(); //Atribuindo ao CommandText a query SQL que está na StringBuilder.
                    comandoSql.Connection = conexao; //Definindo que o comandoSql será executado através da ligação estabelecida pela string de conexão.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //O carregamento do DataTable receberá como parâmetro a leitura do comando SQL.
                    return dadosTabela; //Após a leitura, retorna os dados capturados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        //Método para excluir registros
        public void Excluir(int idAluno)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Aluno");
                    sql.Append(" WHERE (ID_ALUNO = @idAluno)"); //Deleta um aluno com base no ID dele

                    comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno)); //Relaciona o parâmetro do método com o da query.

                    comandoSql.CommandText = sql.ToString(); //Indica ao programa que esse comando deverá ser executado por esse método.
                    comandoSql.Connection = conexao; //Informa que a conexão usada aqui é a mesma que está definida na string de conexão.
                    comandoSql.ExecuteNonQuery(); //Executa o comando de exclusão.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        //Método para pesquisar conforme o nome do Aluno.
        public DataTable PesquisarNomeAluno(string nome)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Aluno"); //Seleciona todas as colunas da tabela Aluno
                    sql.Append(" WHERE (NOME_ALUNO LIKE '%' + @nome + '%')"); //Aondeo nome aluno for like @name
                    sql.Append(" ORDER BY ID_ALUNO DESC"); //Ordena o ID do aluno em forma decrescente

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome)); //Relaciona o parâmetro do método com o da query

                    comandoSql.CommandText = sql.ToString(); //Indica que oq está entre os parenteses do sql.Append é a querySQL a ser executada
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa a leitura de todos elementos da tabela e guarda na memória
                    return dadosTabela; //Retorna o objeto dadosTabela com as informações capturadas na leituras.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisarNomeAluno. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        //Método para pesquisar conforme o CPF.
        public DataTable PesquisarCpfAluno(string CPF)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Aluno");
                    sql.Append(" WHERE (CPF_ALUNO LIKE '%' + @CPF + '%')");
                    sql.Append(" ORDER BY ID_ALUNO DESC");

                    comandoSql.Parameters.Add(new SqlParameter("@CPF", CPF));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa a leitura de todos elementos da tabela e guarda na memória
                    return dadosTabela; //Retorna o objeto dadosTabela com as informações capturadas na leituras.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisarCpfAluno. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }
    }
}
