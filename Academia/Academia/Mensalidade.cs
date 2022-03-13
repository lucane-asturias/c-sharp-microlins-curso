using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    public class Mensalidade
    {
        SqlCommand comandoSql = new SqlCommand(); //Indica que irá utilizar comandos SQL.
        StringBuilder sql = new StringBuilder(); //Auxilia na concatenação das strings presentes na query SQL.
        DataTable dadosTabela = new DataTable(); //Armazena as informações que o banco retorna com o select dentro de uma tabela.

        //Método que irá Salvar as informações conforme os parâmetros que possui entre parênteses.
        public void Salvar(int idMatricula, DateTime data_vencimento, bool situacao)
        {
            //Estabelece a conexão com banco através da string de conexão.
            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                conexao.Open(); //Abre a conexão com o banco de dados.

                //Comando SQL para inserção de valores nos respectivos campos da tabela Professor.
                sql.Append("INSERT INTO Mensalidade (ID_MATRICULA, DATA_VENCIMENTO, SITUACAO)");
                sql.Append(" VALUES (@idMatricula, @data_venciemnto, @situacao)");

                //Relaciona cada valor com seu respectivo parâmetro.
                comandoSql.Parameters.Add(new SqlParameter("@idMatricula", idMatricula));
                comandoSql.Parameters.Add(new SqlParameter("@data_vencimento", data_vencimento));
                comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));

                comandoSql.CommandText = sql.ToString(); //Indica que o que está definido na StringBuilder é a instrução que deverá ser executada.
                comandoSql.Connection = conexao; //Indica que a conexão dos comandos SQL é a que estamos utilizando.
                comandoSql.ExecuteNonQuery(); //Executa todo o comando para a inserção dos valores.
            }
        }

        //Método que irá Alterar as informações conforme os parâmetros que possui entre parênteses.
        public void Alterar(int idMensalidade, DateTime data_vencimento, bool situacao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Mensalidade");
                    sql.Append(" SET DATA_VENCIMENTO = @data_vencimento, SITUACAO = @situacao");
                    sql.Append(" WHERE (ID_MENSALIDADE = @idMensalidade)");

                    comandoSql.Parameters.Add(new SqlParameter("@idMensalidade", idMensalidade));
                    comandoSql.Parameters.Add(new SqlParameter("@data_vencimento", data_vencimento));
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

        public DataTable ListarMensalidades()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Modalidade");
                    sql.Append(" ORDER BY Modalidade.ID_MODALIDADE DESC"); //Ordem decrescente baseando-se no ID, ie, apresenta as modalidades mais atuais primeiro.

                    comandoSql.CommandText = sql.ToString(); //Atribuindo ao CommandText a query SQL que está na StringBuilder.
                    comandoSql.Connection = conexao; //Definindo que o comandoSql será executado através da ligação estabelecida pela string de conexão.
                    dadosTabela.Load(comandoSql.ExecuteReader()); //O carregamento do DataTable receberá como parâmetro a leitura do comando SQL.
                    return dadosTabela; //Após a leitura, retorna os dados capturados.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarMensalidades. Caso o problema persista, entre em contato o administrador do sistema.");
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

                    sql.Append("SELECT Modalidade.ID_MODALIDADE, Modalidade.NOME_MODALIDADE, Modalidade.MENSALIDADE,");
                    sql.Append(" Modalidade.ID_PROFESSOR, Professor.NOME_PROFESSOR");

                    //Junção da tabela Modalidade com a Professor; e uma condição que verifica se os dois valores consultados em ambas tabelas são iguais.
                    sql.Append(" FROM (Modalidade INNER JOIN Professor ON Modalidade.ID_PROFESSOR = Professor.ID_PROFESSOR)");
                    sql.Append(" ORDER BY Modalidade.ID_MODALIDADE DESC"); //Ordem decrescente baseando-se no ID, ie, apresenta as modalidades mais atuais primeiro.

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
        public void Excluir(int idModalidade)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Modalidade");
                    sql.Append(" WHERE (ID_MODALIDADE = @idModalidade");

                    comandoSql.Parameters.Add(new SqlParameter("@idModalidade", idModalidade)); //Relacionando o parâmetro do método com o da query.

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
    }
}
