using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class UsuariosAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public void Salvar(string nome, DateTime data, string login, string senha, string status, int idNivel)
        {
            
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Usuarios (NOME_USUARIO, DATA_CADASTRO, LOGIN_USUARIO, SENHA_USUARIO, STATUS_USUARIO, ID_NIVEL)");
                    sql.Append(" VALUES (@nome, @data, @login, @senha, @status, @idNivel)");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@data", data));
                    comandoSql.Parameters.Add(new SqlParameter("@login", login));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));
                    comandoSql.Parameters.Add(new SqlParameter("@idNivel", idNivel));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            

        public void Alterar(int idUsuario, string nome, DateTime data, string login, string senha, string status, int idNivel)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Usuarios");
                    sql.Append(" SET NOME_USUARIO = @nome, DATA_CADASTRO = @data, LOGIN_USUARIO = @login,");
                    sql.Append(" SENHA_USUARIO = @senha, STATUS_USUARIO = @status, ID_NIVEL = @idNivel");
                    sql.Append(" WHERE (ID_USUARIO = @idUsuario)");


                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@data", data));
                    comandoSql.Parameters.Add(new SqlParameter("@login", login));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));
                    comandoSql.Parameters.Add(new SqlParameter("@idNivel", idNivel));
                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

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

        public void Excluir(int idUsuario)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Usuarios");
                    sql.Append(" WHERE (ID_USUARIO = @idUsuario)");

                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

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

        public DataTable Listar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Usuarios.*, Nivel_Acesso.NOME_NIVEL FROM Usuarios INNER JOIN Nivel_Acesso");
                    sql.Append(" ON Usuarios.ID_NIVEL = Nivel_Acesso.ID_NIVEL");
                    sql.Append(" ORDER BY ID_USUARIO ASC");

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

        public DataTable Login(string login, string senha)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Usuarios");
                    //Realiza a busca no campo LOGIN_USUARIO para o mesmo armazenado no parâmetro login e no campo SENHA_USUARIO, igual ao parâmetro senha.
                    sql.Append(" WHERE LOGIN_USUARIO = @login AND SENHA_USUARIO = @senha");

                    comandoSql.Parameters.Add(new SqlParameter("@login", login));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa a leitura de todos elementos da tabela e guarda na memória
                    return dadosTabela; //Retorna o objeto dadosTabela com as informações capturadas na leituras.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Login. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        public DataTable RetornarLogin(string login)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Usuarios");
                    sql.Append(" WHERE LOGIN_USUARIO = @login");

                    comandoSql.Parameters.Add(new SqlParameter("@login", login));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader()); //Executa a leitura de todos elementos da tabela e guarda na memória
                    return dadosTabela; //Retorna o objeto dadosTabela com as informações capturadas na leituras.
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarLogin. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }

        public DataTable RetornarUsuario(int idUsuario)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Usuarios.*, Nivel_Acesso.NOME_NIVEL FROM Usuarios INNER JOIN Nivel_Acesso");
                    sql.Append(" ON Usuarios.ID_NIVEL = Nivel_Acesso.ID_NIVEL");
                    sql.Append(" WHERE ID_USUARIO = @idUsuario");

                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método RetornarUsuario. Caso o problema persista, entre em contato o administrador do sistema.");
            }
        }
    }
}