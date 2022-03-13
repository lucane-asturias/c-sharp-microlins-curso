using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    public class Caixa
    {
        SqlCommand comandoSql = new SqlCommand(); //Indica que irá utilizar comandos SQL.
        StringBuilder sql = new StringBuilder(); //Auxilia na concatenação das strings presentes na query SQL.
        DataTable dadosTabela = new DataTable(); //Armazena as informações que o banco retorna com o select dentro de uma tabela.

        //Método que irá Salvar as informações conforme os parâmetros que possui entre parênteses.
        public void Salvar(DateTime data, DateTime hora, decimal saldo_inicial, bool situacao)
        {
            try
            {
                //Estabelece a conexão com banco através da string de conexão.
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open(); //Abre a conexão com o banco de dados.

                    //Comando SQL para inserção de valores nos respectivos campos da tabela Aluno.
                    sql.Append("INSERT INTO Caixa (DATA, HORA, SALDO_INICIAL, SITUACAO)");
                    sql.Append(" VALUES (@data, @hora, @saldo_inicial, @situacao)");

                    //Relaciona cada valor com seu respectivo parâmetro.
                    comandoSql.Parameters.Add(new SqlParameter("@data", data));
                    comandoSql.Parameters.Add(new SqlParameter("@hora", hora));
                    comandoSql.Parameters.Add(new SqlParameter("@saldo_inicial", saldo_inicial));
                    comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));

                    comandoSql.CommandText = sql.ToString(); //Indica que o que está definido na StringBuilder é a instrução que deverá ser executada.
                    comandoSql.Connection = conexao; //Indica que a conexão dos comandos SQL é a que estamos utilizando.
                    comandoSql.ExecuteNonQuery(); //Executa todo o comando para a inserção dos valores.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Salvar. Caso o problema persista, entre em contato com o administrador do sistema.");
            }
        }

        public void Alterar(int idCaixa, bool situacao)
        {
            try
            {
                //Estabelece a conexão com banco através da string de conexão.
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open(); //Abre a conexão com o banco de dados.

                    //Comando SQL para inserção de valores nos respectivos campos da tabela Aluno.
                    sql.Append("UPDATE Caixa");
                    sql.Append(" SET SITUACAO = @situacao");               
                    sql.Append(" WHERE (ID_CAIXA = @idCaixa)");

                    //Relaciona cada valor com seu respectivo parâmetro.
                    comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));
                    comandoSql.Parameters.Add(new SqlParameter("@idCaixa", idCaixa));

                    comandoSql.CommandText = sql.ToString(); //Indica que o que está definido na StringBuilder é a instrução que deverá ser executada.
                    comandoSql.Connection = conexao; //Indica que a conexão dos comandos SQL é a que estamos utilizando.
                    comandoSql.ExecuteNonQuery(); //Executa todo o comando para a inserção dos valores.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Alterar. Caso o problema persista, entre em contato com o administrador do sistema.");
            }
        }

        public void SalvarDetalhes(int idCaixa, decimal valor, string movimento, string tipo_pagamento)
        {
            try
            {
                //Estabelece a conexão com banco através da string de conexão.
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open(); //Abre a conexão com o banco de dados.

                    //Comando SQL para inserção de valores nos respectivos campos da tabela Aluno.
                    sql.Append("INSERT INTO Detalhes_Caixa (ID_CAIXA, VALOR, MOVIMENTO, TIPO_PAGAMENTO");
                    sql.Append(" VALUES (@idCaixa, @valor, @movimento, @tipo_pagamento)");

                    //Relaciona cada valor com seu respectivo parâmetro.
                    comandoSql.Parameters.Add(new SqlParameter("@idCaixa", idCaixa));
                    comandoSql.Parameters.Add(new SqlParameter("@valor", valor));
                    comandoSql.Parameters.Add(new SqlParameter("@movimento", movimento));
                    comandoSql.Parameters.Add(new SqlParameter("@tipo_pagamento", tipo_pagamento));

                    comandoSql.CommandText = sql.ToString(); //Indica que o que está definido na StringBuilder é a instrução que deverá ser executada.
                    comandoSql.Connection = conexao; //Indica que a conexão dos comandos SQL é a que estamos utilizando.
                    comandoSql.ExecuteNonQuery(); //Executa todo o comando para a inserção dos valores.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método SalvarDetalhes. Caso o problema persista, entre em contato com o administrador do sistema.");
            }
        }

        public DataTable ListarCaixa()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Caixa");
                    sql.Append(" ORDER BY ID_CAIXA DESC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa a leitura de todos elementos da tabela e guarda na memória
                    return dadosTabela; //Retorna os dados capturados na leitura
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método ListarCaixa. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }
    }
}
