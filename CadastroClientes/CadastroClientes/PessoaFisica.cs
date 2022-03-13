using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientes
{
    public class PessoaFisica : Pessoa    //Classe PessoaFisica herda a classe Pessoa
    {
        private string rg, cpf;           //atributos rg e cpf

        //Método responsável por gravar o nome, endereco, RG e CPF
        public void GravarPessoa (string nome, string endereco, string rg, string cpf)
        {
            base.GravarPessoa(nome, endereco);
            this.rg = rg;
            this.cpf = cpf;
        }

        public string MostrarRg()  //Método público mostrarRg
        {
            return rg;  //Retorna o valor gravado no atributo rg
        }
        public string MostrarCpf() //Método público mostrarCpf
        {
            return cpf; //Retorna o valor gravado no atributo cpf
        }
    }
}
