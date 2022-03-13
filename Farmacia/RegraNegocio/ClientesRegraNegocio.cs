using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class ClientesRegraNegocio
    {
        AcessoDados.ClientesAcessoDados novoCliente;
        RegraNegocio.ValidaDocumentos novoDocumento;

        public void Salvar(string nome, string endereco, string bairro, string cidade, DateTime nascimento, string rg, string cpf, string telefone,
                           string celular, string observacao, DateTime data_cadastro)
        {
            try
            {
                Validar(nome, endereco, bairro, cidade, nascimento, rg, telefone);

                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoCliente.RetornarClientes(cpf);

                if (dadosTabela.Rows.Count > 0)
                {
                    throw new Exception("CPF já cadastrado!");
                }
                else
                {
                    novoDocumento = new ValidaDocumentos();

                    if (novoDocumento.ValidaCpf(cpf) == false)
                    {
                        throw new Exception("CPF inválido.\nDigite um CPF válido para continuar com o cadastro.");
                    }
                    else
                    {
                        novoCliente = new AcessoDados.ClientesAcessoDados();
                        novoCliente.Salvar(nome, endereco, bairro, cidade, nascimento, rg, cpf, telefone, celular, observacao, data_cadastro);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idCliente, string nome, string endereco, string bairro, string cidade, DateTime nascimento, string rg, string cpf,
                           string telefone, string celular, string observacao, DateTime data_cadastro)
        {
            try
            {
                Validar(nome, endereco, bairro, cidade, nascimento, rg, telefone);

                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoCliente.RetornarClientes(cpf);

                novoDocumento = new ValidaDocumentos();

                if (novoDocumento.ValidaCpf(cpf) == false)
                {
                    throw new Exception("CPF inválido.\nDigite um CPF válido para continuar com o cadastro.");
                }

                if (dadosTabela.Rows.Count > 0) //Se a quantidade de registros é maior que 0, ou seja, verifica se o CPF informado já existe no banco
                {
                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        //Faz uma verificação linha por linha para detectar o ID do Cliente, que deverá ser igual ao do botão Alterar quando ele for acionado.
                        if (Convert.ToInt32(dadosTabela.Rows[i]["ID_CLIENTE"]) == idCliente)
                        {
                            novoCliente = new AcessoDados.ClientesAcessoDados();
                            novoCliente.Alterar(idCliente, nome, endereco, bairro, cidade, nascimento, rg, cpf, telefone, celular, observacao, data_cadastro);
                        }
                        else
                        {
                            throw new Exception("CPF já cadastrado!");
                        }
                    }
                }
                else //Senão for maior que 0, significa que é um novo CPF
                {
                    novoCliente = new AcessoDados.ClientesAcessoDados();
                    novoCliente.Alterar(idCliente, nome, endereco, bairro, cidade, nascimento, rg, cpf, telefone, celular, observacao, data_cadastro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idCliente)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();

                novoCliente.Excluir(idCliente);
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
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.PesquisarNome(nome);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarCPF(string CPF)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.PesquisarCPF(CPF);
                return dadosTabela;
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
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornarClientes(string CPF)
        {
            try
            {
                novoCliente = new AcessoDados.ClientesAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoCliente.RetornarClientes(CPF);
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ValidaCPF(string CPF) //n é usado? 
        {
            try
            {
                novoDocumento = new ValidaDocumentos();

                if (novoDocumento.ValidaCpf(CPF))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validar(string nome, string endereco, string bairro, string cidade, DateTime nascimento, string rg, string telefone)
        {
            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome não pode ser vazio!");
            }

            if (endereco.Trim().Length == 0)
            {
                throw new Exception("O campo Endereço não pode ser vazio!");
            }

            if (bairro.Trim().Length == 0)
            {
                throw new Exception("O campo Bairro não pode ser vazio!");
            }

            if (cidade.Trim().Length == 0)
            {
                throw new Exception("O campo Cidade não pode ser vazio!");
            }

            if (nascimento.Date == DateTime.Today)
            {
                throw new Exception("O campo Nascimento não pode ter a data de hoje!");
            }

            string novoRg = rg.Replace(".", "").Replace("-", "").Replace(" ", ""); //Limpa a variável RG de caracteres indesejados q padrão da másc

            if (novoRg == "")
            {
                throw new Exception("O campo RG não pode ser vazio!");
            }

            string novoTelefone = telefone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""); //Filtra

            if (novoTelefone == "")
            {
                throw new Exception("O campo Telefone Residencial não pode ser vazio!");
            }
        }
    }
}
