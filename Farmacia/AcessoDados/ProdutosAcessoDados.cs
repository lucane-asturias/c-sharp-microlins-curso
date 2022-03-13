using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class ProdutosAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void Salvar(string codigoBarras, DateTime data, string nome, string detalhes, int idCategoria,
                           int minimo, int atual, decimal custo, decimal venda)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Produtos (CODIGO_BARRAS, DATA_CADASTRO, NOME_PRODUTO, DETALHES_PRODUTO, ID_CATEGORIA,");
                    sql.Append(" ESTOQUE_MINIMO, ESTOQUE_ATUAL, VALOR_CUSTO, VALOR_VENDA)");
                    sql.Append(" VALUES (@codigoBarras, @data, @nome, @detalhes, @idCategoria, @minimo, @atual, @custo, @venda)");

                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));
                    comandoSql.Parameters.Add(new SqlParameter("@data", data));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@detalhes", detalhes));
                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@minimo", minimo));
                    comandoSql.Parameters.Add(new SqlParameter("@atual", atual));
                    comandoSql.Parameters.Add(new SqlParameter("@custo", custo));
                    comandoSql.Parameters.Add(new SqlParameter("@venda", venda));

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

        public void Alterar(int idProduto, string codigoBarras, DateTime data_cadastro, string nome, string detalhes, int idCategoria,
                            int minimo, int atual, decimal custo, decimal venda)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Produtos");
                    sql.Append(" SET CODIGO_BARRAS = @codigoBarras, DATA_CADASTRO = @data_cadastro, NOME_PRODUTO = @nome, DETALHES_PRODUTO = @detalhes,");
                    sql.Append(" ID_CATEGORIA = @idCategoria, ESTOQUE_MINIMO = @minimo, ESTOQUE_ATUAL = @atual, VALOR_CUSTO = @custo, VALOR_VENDA = @venda");
                    sql.Append(" WHERE (ID_PRODUTO = @idProduto)");


                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));
                    comandoSql.Parameters.Add(new SqlParameter("@data_cadastro", data_cadastro));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@detalhes", detalhes));
                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@minimo", minimo));
                    comandoSql.Parameters.Add(new SqlParameter("@atual", atual));
                    comandoSql.Parameters.Add(new SqlParameter("@custo", custo));
                    comandoSql.Parameters.Add(new SqlParameter("@venda", venda));
                    comandoSql.Parameters.Add(new SqlParameter("@idProduto", idProduto));

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

        public void Excluir(int idProduto)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Produtos");
                    sql.Append(" WHERE (ID_PRODUTO = @idProduto)");

                    comandoSql.Parameters.Add(new SqlParameter("@idProduto", idProduto));

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

                    sql.Append("SELECT Produtos.*, Categorias.NOME_CATEGORIA FROM Produtos INNER JOIN Categorias");
                    sql.Append(" ON Produtos.ID_CATEGORIA = Categorias.ID_CATEGORIA");
                    sql.Append(" WHERE (Produtos.NOME_PRODUTO LIKE '%' + @nome + '%')");
                    sql.Append(" ORDER BY NOME_PRODUTO ASC");

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

        public DataTable PesquisarCategoria(string categoria)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Produtos.*, Categorias.NOME_CATEGORIA FROM Produtos INNER JOIN Categorias");
                    sql.Append(" ON Produtos.ID_CATEGORIA = Categorias.ID_CATEGORIA");
                    sql.Append(" WHERE (Categorias.NOME_CATEGORIA LIKE '%' + @categoria + '%')");
                    sql.Append(" ORDER BY NOME_PRODUTO ASC");

                    comandoSql.Parameters.Add(new SqlParameter("@categoria", categoria));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa a leitura de todos elementos da tabela e guarda na memória
                    return dadosTabela; //Retorna o objeto dadosTabela com as informações capturadas na leituras.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisarCategoria. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        public DataTable PesquisarCodigoBarras(string codigoBarras)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Produtos.*, Categorias.NOME_CATEGORIA FROM Produtos INNER JOIN Categorias");
                    sql.Append(" ON Produtos.ID_CATEGORIA = Categorias.ID_CATEGORIA");
                    sql.Append(" WHERE (Produtos.CODIGO_BARRAS LIKE '%' + @codigoBarras + '%')");
                    sql.Append(" ORDER BY NOME_PRODUTO ASC");

                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método PesquisarCodigoBarras. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        public DataTable Listar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Produtos.*, Categorias.NOME_CATEGORIA FROM Produtos INNER JOIN Categorias");
                    sql.Append(" ON Produtos.ID_CATEGORIA = Categorias.ID_CATEGORIA");
                    sql.Append(" ORDER BY NOME_PRODUTO ASC");

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

        public DataTable VerificaEstoqueBaixo()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Produtos.*, Categorias.NOME_CATEGORIA FROM Produtos INNER JOIN Categorias");
                    sql.Append(" ON Produtos.ID_CATEGORIA = Categorias.ID_CATEGORIA");
                    sql.Append(" WHERE (ESTOQUE_ATUAL < ESTOQUE_MINIMO)");
                    sql.Append(" ORDER BY NOME_PRODUTO ASC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método VerificaEstoqueBaixo. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }
    }
}
