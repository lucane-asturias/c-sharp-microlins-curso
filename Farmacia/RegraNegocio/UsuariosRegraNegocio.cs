using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class UsuariosRegraNegocio
    {
        AcessoDados.UsuariosAcessoDados novoUsuario;
        Criptografia criptografar;


        private void Validar(string nome, string login, int idNivel, string senha, string senha2, string status)
        {
            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome não pode ser vazio!");
            }

            if (login.Trim().Length == 0)
            {
                throw new Exception("O campo Login não pode ser vazio!");
            }

            if (idNivel == -1)
            {
                throw new Exception("O campo Nível não pode ser vazio!");
            }

            if (senha.Trim().Length == 0 && senha2.Trim().Length == 0)
            {
                throw new Exception("O campo Senha não pode ser vazio!");
            }

            if (senha.Trim().Length > 8)
            {
                throw new Exception("O campo Senha não pode ter mais de 8 (oito) caracteres!");
            }

            if (senha != senha2) //Verifica os campos Senha e Redigite estão com os mesmos caracteres
            {
                throw new Exception("As senhas não conferem. Digite-as novamente.");
            }

            if (status.Trim().Length == -1)
            {
                throw new Exception("O campo Status de barras não pode ser vazio!");
            }
        }

        public void Salvar(string nome, DateTime data, string login, string senha, string senha2, string status, int idNivel)
        {
            try
            {
                Validar(nome, login, idNivel, senha, senha2, status);

                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoUsuario.RetornarLogin(login); //Define que o objeto dadosTabela receberá o login que o método RetornarLogin retornar da tabela.

                if (dadosTabela.Rows.Count > 0) //Verifica se há retorno de linhas é maior que 0, pois se for, é sinal que o login escolhido já está cadastrado no banco.
                {
                    throw new Exception("Este Login já foi utilizado, cadastre outro! \nUsuário " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString());
                }
                else //Senão for retornado nenhuma linha, poderá realizar a programação de salvar.
                {
                    criptografar = new Criptografia(); //Instância da classe Criptografia. A codificação será antes das informações serem levadas ao banco.
                    /* Após a senha ser criptografada, ela será armazenada em uma variável do tipo string afim de que essa informação, já codificada posteriormente, [...]
                     * seja passada para o método Salvar da classe UsuarioAcessoDados. */
                    string senhaCripto = criptografar.Criptografar(senha); //Indica como parâmetro o que será criptografado, no caso, a senha.

                    novoUsuario = new AcessoDados.UsuariosAcessoDados();
                    novoUsuario.Salvar(nome, data, login, senhaCripto, status, idNivel); //Criptografa a senha para armazenar no banco.
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idUsuario, string nome, DateTime data, string login, string senha, string senha2, string status, int idNivel)
        {
            try
            {
                Validar(nome, login, idNivel, senha, senha2, status);

                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoUsuario.RetornarLogin(login);

                criptografar = new Criptografia(); //Cria um objeto da classe Criptografia para poder usar seus métodos.
                string senhaCripto = criptografar.Criptografar(senha); //Chama o método Criptografar para criptografar a senha e armazena o conteúdo já codificado em uma variável string.

                if (dadosTabela.Rows.Count > 0) //Se for o mesmo login sendo alterado, checa a busca linha a linha pelo seu id e confirma se é o mesmo.
                {
                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dadosTabela.Rows[i]["ID_USUARIO"]) == idUsuario)
                        {
                            novoUsuario = new AcessoDados.UsuariosAcessoDados();
                            novoUsuario.Alterar(idUsuario, nome, data, login, senhaCripto, status, idNivel);
                        }
                        else
                        {
                            throw new Exception("Este Login já foi utilizado, cadastre outro! \nUsuário " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString());
                        }
                    }
                }
                else //Caso não for o mesmo login, ou seja, um novo login, ele também será alterado.
                {
                    novoUsuario = new AcessoDados.UsuariosAcessoDados();
                    novoUsuario.Alterar(idUsuario, nome, data, login, senhaCripto, status, idNivel);
                }

                /* Podemos dizer então que temos dois locais nos quais o método Alterar está sendo chamado, e para não precisarmos [...]
                 * realizar a criptografia duas vezes aqui, faremos isso apenas uma vez, sendo esta antes da verificação do resultado da busca pelo login. */
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idUsuario)
        {
            try
            {
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                novoUsuario.Excluir(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoUsuario.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Login(string usuario, string senha)
        {
            try
            {
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoUsuario.Login(usuario, senha);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornarUsuario(int idUsuario)
        {
            try
            {
                novoUsuario = new AcessoDados.UsuariosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoUsuario.RetornarUsuario(idUsuario);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
