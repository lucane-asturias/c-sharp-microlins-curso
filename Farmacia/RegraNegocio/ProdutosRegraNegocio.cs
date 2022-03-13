using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class ProdutosRegraNegocio
    {
        AcessoDados.ProdutosAcessoDados novoProduto;

        public void Alterar(int idProduto, string codigoBarras, DateTime data, string nome, string detalhes, int idCategoria,
                            int estoqueMinimo, int estoqueAtual, string custo, string venda)
        {
            try
            {
                Validar(codigoBarras, nome, detalhes, idCategoria, custo, venda); //Validação para certificar que os campos não estão vazios

                //Considerando que o usuário pode querer alterar o código de barras, será necessário realizar uma busca no banco, procurando pelo dado informado.
                novoProduto = new AcessoDados.ProdutosAcessoDados();

                DataTable dadosTabela = new DataTable();
                dadosTabela = novoProduto.PesquisarCodigoBarras(codigoBarras);

                /* Pode ser que o usuário esteja querendo alterar outros campos que não seja o código de barras. Então se a pessquisa tiver algum resultado [...]
                 * no DataTable dadosTabela, é preciso verificar se ele é o produto que está sendo alterado no momento. */
                if (dadosTabela.Rows.Count > 0)
                {
                    //Caso haja mais de um registro, ou seja, mais de uma linha, irá percorrer todas elas e executar as verificações necessárias.
                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        /* Verifica se o conteúdo do campo ID_PRODUTO (que está armazenado no dadosTabela) é igual ao parâmetro idProduto desse método.
                         * Se a condição for verdadeira, significa que se trata do mesmo produto que está sendo alterado. E neses caso, a edição poderá ocorrer. */
                        if (Convert.ToInt32(dadosTabela.Rows[i]["ID_PRODUTO"]) == idCategoria)
                        {
                            novoProduto = new AcessoDados.ProdutosAcessoDados(); //Cria um novo objeto da classe, afinal, será utilizado um dos métodos presentes nela.
                            novoProduto.Alterar(idProduto, codigoBarras, data, nome, detalhes, idCategoria, estoqueMinimo, estoqueAtual, Convert.ToDecimal(custo), Convert.ToDecimal(venda));
                        }

                        /* Mas, se o campo ID_PRODUTO for diferente do parâmetro idProduto, quer dizer que o resultado da busca refere-se a um produto que [...]
                         * já está cadastrado. Nesse caso, a alteração não poderá ser realizada, e será informado ao usuário o nome do produto existente [...]
                         * com o código de barras correspondente. */
                        else
                        {
                            throw new Exception("Já existe um produto cadastrado com esse código de barras! \n Produto: " + dadosTabela.Rows[0]["NOME_PRODUTO"].ToString());
                        }
                    }
                }

                /* Caso contrário, se a pesquisa pelo código de barras não encontrar nenhum resultado no banco, significa que não existe nenhum produto cadastrado, [...]
                 *  sendo assim, temos que ditar ao programa que, se isso ocorrer, a alteração será permitida*/
                else
                {
                    novoProduto = new AcessoDados.ProdutosAcessoDados();
                    novoProduto.Alterar(idProduto, codigoBarras, data, nome, detalhes, idCategoria, estoqueMinimo, estoqueAtual, Convert.ToDecimal(custo), Convert.ToDecimal(venda));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idProduto)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                novoProduto.Excluir(idProduto);

                //Listar
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
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoProduto.Listar();

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarNome(string nome)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoProduto.PesquisarNome(nome);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarCodigoBarras(string codigoBarras)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoProduto.PesquisarCodigoBarras(codigoBarras);

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarCategoria(string categoria)
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoProduto.PesquisarCategoria(categoria);

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método para validar os campos do formulário
        private void Validar(string codigoBarras, string nome, string detalhes, int idCategoria, string custo, string venda)
        {
            if (codigoBarras.Trim().Length == 0)
            {
                throw new Exception("O campo Codigo de barras não pode ser vazio!");
            }

            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome não pode ser vazio!");
            }

            /* O campo cboCategoria possui um código que ao ser cadastrado no banco, será sempre diferente de zero. Portanto, para essa verificação
             * Portanto, para essa verificação será utilizado esse código: se for igual a zero, significa que o usuário não selecinou nenhuma das
             * categorias presentes no ComboBox. Ou seja, deixou-o vazio. */
            if (idCategoria == 0)
            {
                throw new Exception("O campo Categoria não pode ser vazio!");
            }

            if (detalhes.Trim().Length == 0)
            {
                throw new Exception("O campo Detalhes não pode ser vazio!");
            }

            /* Por padrão, os campos Custo e Venda possuem o número zero como texto, por isso será verificado se permanacem assim. Caso for digitado letras
             * em vez de números no campo Custo ou Valor, ele será tratado pela estrutura try/catch. Logo se o conteúdo não puder ser convertido, um erro será retornado. */

            //Completa ambos os campos com duas validações: verifica se é possível converter o valor inserido, impedindo letras; se puder, verifica se o valor é 0. 
            try
            {
                decimal valor = Convert.ToDecimal(custo); //Tenta converter o conteúdo do parâmetro custo para decimal.
            }
            catch (Exception)
            {
                throw new Exception("Entre com um valor numérico para o campo Custo."); //Evita que o erro ultrapasse a interface e chegue ao banco.
            }

            if (Convert.ToDecimal(custo) == 0)
            {
                throw new Exception("O campo Custo não pode ser vazio!");
            }

            try
            {
                decimal valor = Convert.ToDecimal(venda); //Tenta converter o conteúdo do parâmetro venda para decimal.
            }
            catch (Exception)
            {
                throw new Exception("Entre com um valor numérico para o campo Venda.");
            }

            if (Convert.ToDecimal(venda) == 0)
            {
                throw new Exception("O campo Venda não pode ser vazio!");
            }
        }

        public void Salvar(string codigoBarras, DateTime data, string nome, string detalhes, int idCategoria, int estoqueMinimo, int estoqueAtual,
                                                                                                                     string custo, string venda)
        {
            try
            {
                Validar(codigoBarras, nome, detalhes, idCategoria, custo, venda); //depois teste com produtos cadastrados

                novoProduto = new AcessoDados.ProdutosAcessoDados();

                DataTable dadosTabela = new DataTable();
                //Verifica se existem produtos cadastrados com o mesmo código de barras. Se existir(em), são armazenados em dadosTabela.
                dadosTabela = novoProduto.PesquisarCodigoBarras(codigoBarras);

                if (dadosTabela.Rows.Count > 0) //Verifica se a pesquisa retornou linhas. Se verdadeiro, o cadastro é interrompido.
                {
                    //Informa ao usuário que já existe um produto cadastrado, mostrando o nome dele.
                    throw new Exception("Já existe um produto com esse código de barras! \nProduto: " + dadosTabela.Rows[0]["NOME_PRODUTO"].ToString());
                }
                else //Caso contrário o cadastro é efetuado.
                {
                    novoProduto = new AcessoDados.ProdutosAcessoDados();
                    novoProduto.Salvar(codigoBarras, data, nome, detalhes, idCategoria, estoqueMinimo, estoqueAtual, Convert.ToDecimal(custo), Convert.ToDecimal(venda));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable VerificaEstoqueBaixo()
        {
            try
            {
                novoProduto = new AcessoDados.ProdutosAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoProduto.VerificaEstoqueBaixo();

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
