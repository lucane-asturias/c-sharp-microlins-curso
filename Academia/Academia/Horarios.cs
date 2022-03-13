using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    public class Horarios
    {
        SqlCommand comandoSql = new SqlCommand(); //Indica que irá utilizar comandos SQL.
        StringBuilder sql = new StringBuilder(); //Auxilia na concatenação das strings presentes na query SQL.
        DataTable dadosTabela = new DataTable(); //Armazena as informações que o banco retorna com o select dentro de uma tabela.

        //Método que irá Salvar as informações conforme os parâmetros que possui entre parênteses.
        public void Salvar(int idTurma, string diaSemana, string inicio, string fim)
        {
            //Estabelece a conexão com banco através da string de conexão.
            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                conexao.Open(); //Abre a conexão com o banco de dados.

                //Comando SQL para inserção de valores nos respectivos campos da tabela Horario.
                sql.Append("INSERT INTO Horario (ID_TURMA, DIA_SEMANA, INICIO, FIM)");
                sql.Append(" VALUES (@idTurma, @diaSemana, @inicio, @fim)");

                //Relaciona cada valor com seu respectivo parâmetro.
                comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));
                comandoSql.Parameters.Add(new SqlParameter("@diaSemana", diaSemana));
                comandoSql.Parameters.Add(new SqlParameter("@inicio", inicio));
                comandoSql.Parameters.Add(new SqlParameter("@fim", fim));

                comandoSql.CommandText = sql.ToString(); //Indica que o que está definido na StringBuilder é a instrução que deverá ser executada.
                comandoSql.Connection = conexao; //Indica que a conexão dos comandos SQL é a que estamos utilizando.
                comandoSql.ExecuteNonQuery(); //Executa todo o comando para a inserção dos valores.
            }
        }

        //Método que irá Alterar as informações conforme os parâmetros que possui entre parênteses.
        public void Alterar(int idHorario, int idTurma, string diaSemana, string inicio, string fim)
        {
           
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Horario");
                    sql.Append(" SET ID_TURMA = @idTurma, DIA_SEMANA = @diaSemana, INICIO = @inicio, FIM = @fim");
                    sql.Append(" WHERE (ID_HORARIO = @idHorario)");

                    comandoSql.Parameters.Add(new SqlParameter("@idHorario", idHorario));
                    comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));
                    comandoSql.Parameters.Add(new SqlParameter("@diaSemana", diaSemana));
                    comandoSql.Parameters.Add(new SqlParameter("@inicio", inicio));
                    comandoSql.Parameters.Add(new SqlParameter("@fim", fim));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            
        }

        //Método responsável por listar em ordem decrescente.
        public DataTable Listar(int idTurma)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Horario");
                    sql.Append(" WHERE (ID_TURMA = @idTurma)");
                    sql.Append(" ORDER BY ID_HORARIO DESC");

                    comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));

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
        public void Excluir(int idHorario)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Horario");
                    sql.Append(" WHERE (ID_HORARIO = @idHorario");

                    comandoSql.Parameters.Add(new SqlParameter("@idHorario", idHorario)); //Relacionando o parâmetro do método com o da query.

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

        //Método para pesquisar conforme o nome da Modalidade.
        public DataTable PesquisarNomeModalidade(string nome)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Modalidade.*, Professor.NOME_PROFESSOR"); //Seleciona todas colunas da tabela Modalidade e o nome do professor

                    //Realiza a junção interna dos dados da tabela Modalidade com a da Professores (Junta duas tabelas com a instrução INNER JOIN)
                    //ON (quando o id modalidade da tabela modalidade for igual ao id professor da tabela professor
                    sql.Append(" FROM (Modalidade INNER JOIN Professor ON Modalidade.ID_PROFESSOR = Professor.ID_PROFESSOR)");

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

        //Método para pesquisar conforme o nome do Professor.
        public DataTable PesquisarNomeProfessor(string nome)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Modalidade.*, Professor.NOME_PROFESSOR");
                    sql.Append(" FROM (Modalidade INNER JOIN Professor ON Modalidade.ID_PROFESSOR = Professor.ID_PROFESSOR)");
                    sql.Append(" WHERE (Professor.NOME_PROFESSOR LIKE '%'+ @nome +'%')");
                    sql.Append(" ORDER BY Modalidade.ID_MODALIDADE DESC");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome)); //Relaciona o parâmetro @nome da instrução SQL com o parâmetro desse método.

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
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
