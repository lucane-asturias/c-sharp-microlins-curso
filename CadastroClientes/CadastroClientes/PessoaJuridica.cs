using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientes
{
    public class PessoaJuridica : Pessoa   //Classe PessoaJuridica herda a classe Pessoa
    {
        private string cnpj, ie;           //atributos cnpj e ie

        /*//Método responsável por gravar o nome, endereco, RG e CPF
        public void GravarPessoa(string nome, string endereco, string cnpj, string ie)*/

        //Método construtor
        public PessoaJuridica(string nome, string endereco, string cnpj, string ie)
        {
            base.GravarPessoa(nome, endereco); //O método GravarPessoa da classe base receberá os valores dos parâmetros
            this.cnpj = cnpj; //O atributo cnpj desta classe será igual ao parâmetro com o mesmo nome
            this.ie = ie;   //O atributo ie desta classe será igual ao parâmetro com o mesmo nome
        }

        public string MostrarCnpj()  //Método público MostrarCnpj
        {
            return cnpj;  //Retorna o valor gravado no atributo cnpj
        }
        public string MostrarIe() //Método público MostrarIe
        {
            return ie; //Retorna o valor gravado no atributo ie
        }
    }
}
