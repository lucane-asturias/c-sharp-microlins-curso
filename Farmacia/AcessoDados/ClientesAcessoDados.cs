using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class ClientesAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void Salvar(string nome, string endereco, string bairro, string cidade, DateTime nascimento, string rg, string cpf, string telefone,
                           string celular, string observacao, DateTime data_cadastro)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Clientes (NOME_CLIENTE, ENDERECO, BAIRRO, CIDADE, NASCIMENTO, RG, CPF, TELEFONE, CELULAR, OBSERVACAO, DATA_CADASTRO)");
                    sql.Append(" VALUES (@nome, @endereco, @bairro, @cidade, @nascimento, @rg, @cpf, @telefone, @celular, @observacao, @data_cadastro)");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                    comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
                    comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
                    comandoSql.Parameters.Add(new SqlParameter("@nascimento", nascimento));
                    comandoSql.Parameters.Add(new SqlParameter("@rg", rg));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                    comandoSql.Parameters.Add(new SqlParameter("@celular", celular));
                    comandoSql.Parameters.Add(new SqlParameter("@observacao", observacao));
                    comandoSql.Parameters.Add(new SqlParameter("@data_cadastro", data_cadastro));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Salvar. Caso o erro persista, entre em contato o administrador do sistema.");
            }
        }

        public void Alterar(int idCliente, string nome, string endereco, string bairro, string cidade, DateTime nascimento, string rg, string cpf,
                            string telefone, string celular, string observacao, DateTime data_cadastro)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Clientes");
                    sql.Append(" SET NOME_CLIENTE = @nome, ENDERECO = @endereco, BAIRRO = @bairro, CIDADE = @cidade, NASCIMENTO = @nascimento,");
                    sql.Append(" RG = @rg, CPF = @cpf, TELEFONE = @telefone, CELULAR = @celular, OBSERVACAO = @observacao, DATA_CADASTRO = @data_cadastro");
                    sql.Append(" WHERE (ID_CLIENTE = @idCliente)");


                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                    comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
                    comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
                    comandoSql.Parameters.Add(new SqlParameter("@nascimento", nascimento));
                    comandoSql.Parameters.Add(new SqlParameter("@rg", rg));
                    comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                    comandoSql.Parameters.Add(new SqlParameter("@celular", celular));
                    comandoSql.Parameters.Add(new SqlParameter("@observacao", observacao));
                    comandoSql.Parameters.Add(new SqlParameter("@data_cadastro", data_cadastro));
                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Alterar. Caso o erro persista, entre em contato o administrador do sistema.");
            }
        }

        public void Excluir(int idCliente)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Clientes");
                    sql.Append(" WHERE (ID_CLIENTE = @idCliente");

                    comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));

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

        public DataTable PesquisarNome(string nome)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Clientes");
                    sql.Append(" WHERE (NOME_CLIENTE LIKE '%' + @nome + '%')");
                    sql.Append(" ORDER BY ID_CLIENTE DESC");

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

        public DataTable PesquisarCPF(string CPF)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Clientes");
                    sql.Append(" WHERE (CPF LIKE '%' + @CPF + '%')");
                    sql.Append(" ORDER BY ID_CLIENTE DESC");

                    comandoSql.Parameters.Add(new SqlParameter("@CPF", CPF));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisarCPF. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        public DataTable Listar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Clientes");
                    sql.Append(" ORDER BY ID_CLIENTE DESC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        public DataTable RetornarClientes(string CPF)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Clientes");
                    sql.Append(" WHERE (CPF = @CPF)");

                    comandoSql.Parameters.Add(new SqlParameter("@CPF", CPF));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarClientes. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }
    }
}
