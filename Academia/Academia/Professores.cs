using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    public class Professores
    {
        SqlCommand comandoSql = new SqlCommand(); //Indica que irá utilizar comandos SQL.
        StringBuilder sql = new StringBuilder(); //Auxilia na concatenação das strings presentes na query SQL.
        DataTable dadosTabela = new DataTable(); //Armazena as informações que o banco retorna com o select dentro de uma tabela.

        //Método que irá Salvar as informações conforme os parâmetros que possui entre parênteses.
        public void Salvar(string nome, string endereco, string bairro, string cidade, string cep, string cpf,
                                                                        decimal salario, string telefone, string observacao)
        {
            try //Estrutura try, a qual tenta realizar o que está dentro das suas chaves.
            {
                //Estabelece a conexão com banco através da string de conexão.
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open(); //Abre a conexão com o banco de dados.

                    //Comando SQL para inserção de valores nos respectivos campos da tabela Professor.
                    sql.Append("INSERT INTO Professor (NOME_PROFESSOR, ENDERECO_PROFESSOR, BAIRRO_PROFESSOR, CIDADE_PROFESSOR,");
                    sql.Append(" CEP_PROFESSOR, CPF_PROFESSOR, SALARIO, TELEFONE_PROFESSOR, OBSERVACAO)");
                    sql.Append(" VALUES (@nome, @endereco, @bairro, @cidade, @cep, @cpf, @salario, @telefone, @observacao)");

                    //Relaciona cada valor com seu respectivo parâmetro.
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                    comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
                    comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
                    comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@salario", salario));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                    comandoSql.Parameters.Add(new SqlParameter("@observacao", observacao));

                    comandoSql.CommandText = sql.ToString(); //Indica que o que está definido na StringBuilder é a instrução que deverá ser executada.
                    comandoSql.Connection = conexao; //Indica que a conexão dos comandos SQL é a que estamos utilizando.
                    comandoSql.ExecuteNonQuery(); //Executa todo o comando para a inserção dos valores.
                }
            }
            catch (Exception)
            {
                //Caso ocorra um erro no bloco try, entrará no catch, onde irá detectá-lo.
                throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o administrador do sistema.");
            }
        }

        public DataTable Listar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Professor");
                    sql.Append(" ORDER BY ID_PROFESSOR DESC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa a leitura de todos elementos da tabela e guarda na memória
                    return dadosTabela; //Retorna os dados capturados na leitura
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        public void Alterar(int idProfessor, string nome, string endereco, string bairro, string cidade, string cep,
                                                          string cpf, decimal salario, string telefone, string observacao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Professor");
                    sql.Append(" SET NOME_PROFESSOR = @nome, ENDERECO_PROFESSOR = @endereco, BAIRRO_PROFESSOR = @bairro,");
                    sql.Append(" CIDADE_PROFESSOR = @cidade, CEP_PROFESSOR = @CEP, CPF_PROFESSOR = @CPF,");
                    sql.Append(" SALARIO = @salario, TELEFONE_PROFESSOR = @telefone, OBSERVACAO = @observacao");
                    sql.Append(" Where (ID_PROFESSOR = @idProfessor)");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                    comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
                    comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
                    comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@salario", salario));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                    comandoSql.Parameters.Add(new SqlParameter("@observacao", observacao));
                    comandoSql.Parameters.Add(new SqlParameter("@idProfessor", idProfessor));

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

        //Método para excluir registros
        public void Excluir(int idProfessor)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Professor");
                    sql.Append(" WHERE (ID_PROFESSOR = @idProfessor");

                    comandoSql.Parameters.Add(new SqlParameter("@idProfessor", idProfessor));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        //Método para pesquisar conforme o Nome.
        public DataTable PesquisarNome(string nome)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Professor");
                    sql.Append(" WHERE (NOME_PROFESSOR LIKE '%' + @nome + '%')");
                    sql.Append(" ORDER BY ID_PROFESSOR DESC");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa a leitura de todos elementos da tabela e guarda na memória
                    return dadosTabela; //Retorna o objeto dadosTabela com as informações capturadas na leituras.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisarNome. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        //Método para pesquisar conforme o CPF.
        public DataTable PesquisarCPF(string CPF)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Professor");
                    sql.Append(" WHERE (CPF_PROFESSOR LIKE '%' + @CPF + '%')");
                    sql.Append(" ORDER BY ID_PROFESSOR DESC");

                    comandoSql.Parameters.Add(new SqlParameter("@CPF", CPF));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa a leitura de todos elementos da tabela e guarda na memória
                    return dadosTabela; //Retorna o objeto dadosTabela com as informações capturadas na leituras.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisarNome. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }
    }
}

