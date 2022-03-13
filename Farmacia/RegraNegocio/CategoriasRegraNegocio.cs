using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class CategoriasRegraNegocio
    {
        AcessoDados.CategoriaAcessoDados novaCategoria;

        private void Validar(string nome)
        {
            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome não pode ser vazio!");
            }
        }

        public void Salvar(string nome, string descricao)
        {
            try
            {
                Validar(nome);

                novaCategoria = new AcessoDados.CategoriaAcessoDados();
                novaCategoria.Salvar(nome, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idCategoria, string nome, string descricao)
        {
            try
            {
                Validar(nome);

                novaCategoria = new AcessoDados.CategoriaAcessoDados();
                novaCategoria.Alterar(idCategoria, nome, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idCategoria)
        {
            try
            {
                novaCategoria = new AcessoDados.CategoriaAcessoDados();
                novaCategoria.Excluir(idCategoria);
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
                novaCategoria = new AcessoDados.CategoriaAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novaCategoria.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable VerificaCategorias()
        {
            try
            {
                novaCategoria = new AcessoDados.CategoriaAcessoDados();

                DataTable dadosTabela = new DataTable();
                dadosTabela = novaCategoria.Listar(); //Armazena o resultado do Listar no DataTable
                
                if (dadosTabela.Rows.Count == 0) //Se não houver nenhuma categoria cadastrada no banco, ou seja, nenhum registro.
                {
                    throw new Exception("Nenhuma Categoria foi cadastrada até o momento. \nCadastre pelo menos uma categoria.");
                }

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
