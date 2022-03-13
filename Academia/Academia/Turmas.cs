using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    public class Turmas
    {
        SqlCommand comandoSql = new SqlCommand(); //Indica que irá utilizar comandos SQL.
        StringBuilder sql = new StringBuilder(); //Auxilia na concatenação das strings presentes na query SQL.
        DataTable dadosTabela = new DataTable(); //Armazena as informações que o banco retorna com o select dentro de uma tabela.

        //Método que irá Salvar as informações conforme os parâmetros que possui entre parênteses.
        public void Salvar(int idModalidade, int maximoAlunos, string numeroTurma)
        {
            //Estabelece a conexão com banco através da string de conexão.
            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                conexao.Open(); //Abre a conexão com o banco de dados.

                //Comando SQL para inserção de valores nos respectivos campos da tabela Professor.
                sql.Append("INSERT INTO Turma (ID_MODALIDADE, MAXIMO_ALUNOS, NUMERO_TURMA)");
                sql.Append(" VALUES (@idModalidade, @maximoAlunos, @numeroTurma)");

                //Relaciona cada valor com seu respectivo parâmetro.
                comandoSql.Parameters.Add(new SqlParameter("@idModalidade", idModalidade));
                comandoSql.Parameters.Add(new SqlParameter("@maximoALunos", maximoAlunos));
                comandoSql.Parameters.Add(new SqlParameter("@numeroTurma", numeroTurma));

                comandoSql.CommandText = sql.ToString(); //Indica que o que está definido na StringBuilder é a instrução que deverá ser executada.
                comandoSql.Connection = conexao; //Indica que a conexão dos comandos SQL é a que estamos utilizando.
                comandoSql.ExecuteNonQuery(); //Executa todo o comando para a inserção dos valores.
            }
        }

        //Método que irá Alterar as informações conforme os parâmetros que possui entre parênteses.
        public void Alterar(int idTurma, int idModalidade, int maximoAlunos, string numeroTurma)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Turma");
                    sql.Append(" SET ID_MODALIDADE = @idModalidade, MAXIMO_ALUNOS = @maximoAlunos, NUMERO_TURMA = @numeroTurma");
                    sql.Append(" WHERE (ID_TURMA = @idTurma)");

                    comandoSql.Parameters.Add(new SqlParameter("@idModalidade", idModalidade));
                    comandoSql.Parameters.Add(new SqlParameter("@maximoAlunos", maximoAlunos));
                    comandoSql.Parameters.Add(new SqlParameter("@numeroTurma", numeroTurma));
                    comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));

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

        public void AlterarVagas(int idTurma, int maximoAlunos)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Turma");
                    sql.Append(" SET MAXIMO_ALUNOS = @maximoAlunos");
                    sql.Append(" WHERE (ID_TURMA = @idTurma)");

                    comandoSql.Parameters.Add(new SqlParameter("@idModalidade", idTurma));
                    comandoSql.Parameters.Add(new SqlParameter("@maximoAlunos", maximoAlunos));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método AlterarVagas. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        //Método responsável por listar todas as modalidades em ordem decrescente.
        public DataTable Listar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Turma.*, Modalidade.NOME_MODALIDADE");

                    //Junção da tabela Modalidade com a Professor; e uma condição que verifica se os dois valores consultados em ambas tabelas são iguais.
                    sql.Append(" FROM (Turma INNER JOIN Modalidade ON Turma.ID_TURMA = Modalidade.ID_MODALIDADE)");
                    sql.Append(" ORDER BY Turma.ID_TURMA DESC"); //Ordem decrescente baseando-se no ID, ie, apresenta as modalidades mais atuais primeiro.

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
        public void Excluir(int idTurma)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Turma");
                    sql.Append(" WHERE (ID_TURMA = @idTurma");

                    comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma)); //Relacionando o parâmetro do método com o da query.

                    comandoSql.CommandText = sql.ToString(); //Indicando ao programa que esse comando deverá ser executado por esse método.
                    comandoSql.Connection = conexao; //Informando que a conexão usada aqui é a mesma que está definida na string de conexão.
                    comandoSql.ExecuteNonQuery(); //Executa o comando de exclusão.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Excluir. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        //Método para pesquisar conforme o nome da Turma e o ID da Modalidade.
        public DataTable pesquisarTurma(string nome)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Turma.*, Modalidade.NOME_MODALIDADE");
                    //OK_HAND
                    sql.Append(" FROM (Turma INNER JOIN Modalidade ON Turma.ID_MODALIDADE = Modalidade.ID_Modalidade)");

                    //Aplica a instrução o comando LIKE, que realiza a busca pelo texto que for passado como parâmetro, independente se estiver no começo, meio ou fim.
                    sql.Append(" WHERE (Modalidade.NOME_MODALIDADE LIKE '%'+ @nome +'%')");

                    //Ordena pelo ID (código) da modalidade em decrescente
                    sql.Append(" ORDER BY Modalidade.ID_MODALIDADE DESC");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome)); //Relaciona o parâmetro @nome da instrução SQL com o parâmetro desse método.

                    comandoSql.CommandText = sql.ToString(); //Atribui ao comandoSQL a instrução acima no Append
                    comandoSql.Connection = conexao; //Diz que a conexão utilizada será a definida será a stringConexao da classe Conexao
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Carrega no DataTable as informações obtidas e  guarda na memória
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
