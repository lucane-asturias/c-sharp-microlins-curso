using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    public class Matriculas
    {
        SqlCommand comandoSql = new SqlCommand(); //Indica que irá utilizar comandos SQL.
        StringBuilder sql = new StringBuilder(); //Auxilia na concatenação das strings presentes na query SQL.
        DataTable dadosTabela = new DataTable(); //Armazena as informações que o banco retorna com o select dentro de uma tabela.

        //Método que irá Salvar as informações conforme os parâmetros que possui entre parênteses.
        public void Salvar(int idAluno, int idTurma, int vencimento, bool situacao)
        {
            //Estabelece a conexão com banco através da string de conexão.
            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                conexao.Open(); //Abre a conexão com o banco de dados.

                //Comando SQL para inserção de valores nos respectivos campos da tabela Aluno.
                sql.Append("INSERT INTO Matricula (ID_ALUNO, ID_TURMA, VENCIMENTO, SITUACAO)");
                sql.Append(" VALUES (@idAluno, @idTurma, @vencimento, @situacao)");

                //Relaciona cada valor com seu respectivo parâmetro.
                comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));
                comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));
                comandoSql.Parameters.Add(new SqlParameter("@vencimento", vencimento));
                comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));

                comandoSql.CommandText = sql.ToString(); //Indica que o que está definido na StringBuilder é a instrução que deverá ser executada.
                comandoSql.Connection = conexao; //Indica que a conexão dos comandos SQL é a que estamos utilizando.
                comandoSql.ExecuteNonQuery(); //Executa todo o comando para a inserção dos valores.
            }
        }

        //Método que irá Alterar as informações conforme os parâmetros que possui entre parênteses.
        public void Alterar(int idMatricula, int vencimento, bool situacao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Matricula");
                    sql.Append(" SET VENCIMENTO = @vencimento, SITUACAO = @situacao");
                    sql.Append(" WHERE (ID_MATRICULA = @idMatricula)");

                    comandoSql.Parameters.Add(new SqlParameter("@idMatricula", idMatricula));
                    comandoSql.Parameters.Add(new SqlParameter("@vencimento", vencimento));
                    comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));

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

        public void Excluir(int idMatricula)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Matricula");
                    sql.Append(" WHERE (ID_MATRICULA = @idMatricula)");

                    comandoSql.Parameters.Add(new SqlParameter("@idMatricula", idMatricula)); //Relacionando o parâmetro do método com o da query.

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

        //Método responsável por listar todas os alunos em ordem decrescente.
        public DataTable ListarTurmas() //listar só as turmas ou a matricula inteira? eis a questao 
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Matricula");
                    sql.Append(" ORDER BY ID_MATRICULA DESC"); //Ordem decrescente baseando-se no ID, ie, apresenta os alunos mais atuais primeiro.

                    comandoSql.CommandText = sql.ToString(); //Atribuindo ao CommandText a query SQL que está na StringBuilder.
                    comandoSql.Connection = conexao; //Definindo que o comandoSql será executado através da ligação estabelecida pela string de conexão.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //O carregamento do DataTable receberá como parâmetro a leitura do comando SQL.
                    return dadosTabela; //Após a leitura, retorna os dados capturados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarTurmas. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        public DataTable RetornarMatriculas(int idAluno)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Matricula.ID_MATRICULA, Matricula.ID_ALUNO, Matricula.SITUACAO, Matricula.VENCIMENTO, Modalidade.ID_MODALIDADE,");
                    sql.Append(" Modalidade.NOME_MODALIDADE, Modalidade.MENSALIDADE, Turma.ID_TURMA, Turma.NUMERO_TURMA");

                    //Junção da tabela Matricula com o da Turma; e uma condição que verifica se os dois valores consultados em ambas tabelas são iguais.
                    sql.Append(" FROM Matricula INNER JOIN Turma ON Matricula.ID_TURMA = Turma.ID_TURMA");

                    //E por último junta a tabela Modalidade; e a condição que verifica se os dois valores consultados em ambas tabelas são iguais.
                    sql.Append(" INNER JOIN Modalidade ON Modalidade.ID_MODALIDADE = Turma.ID_MODALIDADE");
                    sql.Append(" WHERE (Matricula.ID_ALUNO = @idAluno)");
                    sql.Append(" ORDER BY Matricula.ID_MATRICULA DESC"); //Ordem decrescente baseando-se no ID, ie, apresenta os alunos mais atuais primeiro.

                    comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));

                    comandoSql.CommandText = sql.ToString(); //Atribuindo ao CommandText a query SQL que está na StringBuilder.
                    comandoSql.Connection = conexao; //Definindo que o comandoSql será executado através da ligação estabelecida pela string de conexão.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //O carregamento do DataTable receberá como parâmetro a leitura do comando SQL.
                    return dadosTabela; //Após a leitura, retorna os dados capturados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarMatriculas. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        public DataTable RetornarTurmasMatriculadas(int idTurma, int idAluno)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Matricula");
                    sql.Append(" WHERE (ID_TURMA = @idTurma AND ID_ALUNO = @idAluno)"); // n sei se está de acordo com a aula (está hehe)
                    sql.Append(" ORDER BY ID_MATRICULA DESC"); //Ordem decrescente baseando-se no ID, ie, apresenta os alunos mais atuais primeiro.

                    comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));
                    comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));

                    comandoSql.CommandText = sql.ToString(); //Atribuindo ao CommandText a query SQL que está na StringBuilder.
                    comandoSql.Connection = conexao; //Definindo que o comandoSql será executado através da ligação estabelecida pela string de conexão.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //O carregamento do DataTable receberá como parâmetro a leitura do comando SQL.
                    return dadosTabela; //Após a leitura, retorna os dados capturados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarMatriculas. Caso o problema persista, entre em contato o administrador do sistema.");
            }

        }

        public int RetornarQuantidadeMatriculas(int idTurma)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    /* Instrução Count(*), que permite realizar a contagem de linhas existentes de uma determinada coluna que possua registros.
                     * Ela realizará uma seleção na tabela Matricula, mas não retornará dados e sim o resultado de uma conta. */
                    sql.Append("SELECT COUNT(*) FROM Matricula");

                    //Impõe uma condição ONDE deverá ser contabilizado somente as linhas referentes ao código da turma quando ela for igual ao valor passado por parâmetro.
                    sql.Append(" WHERE (ID_TURMA = @idTurma)");

                    //Referencia o parâmetro informado 
                    comandoSql.Parameters.Add(new SqlParameter("@idTurma", idTurma));

                    comandoSql.CommandText = sql.ToString(); //Atribuindo ao CommandText a query SQL que está na StringBuilder.
                    comandoSql.Connection = conexao; //Definindo que o comandoSql será executado através da ligação estabelecida pela string de conexão.

                    /* Insere o comando ExecuteScalar; ele executará apenas o resultado da contabilização das linhas da tabela Matricula. Nesseo caso, ele é o mais indicado,
                    pois possibilita retornar somente um valor, em vez de uma tabela. Por padrão ele não retorna tipo int, portanto, será preciso fazer o programa forçar
                    para que este seja interpretado pela variável total como um valor do tipo inteiro. E pra isso é utilizado a modalidade Casting, que é uma forma de dizer
                    quando queremos forçar uma variável ser outro tipo, ou como o próprio nome sugere, ele molda a variável para que outra receba seu valor. Essse tipo de
                    alteração é chamada de conversão explícita.

                    Cria uma variável para receber o valor dos dados que serão retornados; e através do casting, ela é moldada, tornando possível outra receber seu valor. */
                    int total = (int)comandoSql.ExecuteScalar();
                    return total; //Após executado, retorna os dados capturados.


                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarMatriculas. Caso o problema persista, entre em contato o administrador do sistema."); ;
            }
        }
    }
}
