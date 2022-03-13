﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class NiveisRegraNegocio
    {
        AcessoDados.NivelAcessoDados novoNivel;

        public void Validar(string nome, string descricao)
        {
            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome não pode ser vazio!");
            }

            if (descricao.Trim().Length == 0)
            {
                throw new Exception("O campo Login não pode ser vazio!");
            }
        }

        public void Salvar(string nome, string descricao)
        {
            try
            {
                Validar(nome, descricao);

                novoNivel = new AcessoDados.NivelAcessoDados();
                novoNivel.Salvar(nome, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idNivel, string nome, string descricao)
        {
            try
            {
                Validar(nome, descricao);

                novoNivel = new AcessoDados.NivelAcessoDados();
                novoNivel.Alterar(idNivel, nome, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idNivel)
        {
            try
            {
                novoNivel = new AcessoDados.NivelAcessoDados();
                novoNivel.Excluir(idNivel);
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
                novoNivel = new AcessoDados.NivelAcessoDados();
                DataTable dadosTabela = new DataTable();

                dadosTabela = novoNivel.Listar();
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
