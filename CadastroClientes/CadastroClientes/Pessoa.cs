using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientes
{
    public class Pessoa //ficará visível e funcional para outras classes
    {
        private string nome, endereco; //Atributos nome e endereço

        public void GravarPessoa(string nome, string endereco) //Método responsável por gravar o nome e o endereço
        {
            this.nome = nome;          //O atributo nome receberá o texto do parâmetro nome
            this.endereco = endereco;  //O atributo endereco receberá o texto do parâmetro endereco
        }

        public string MostrarNome()    //Método responsável por mostrar o texto do atributo nome
        {
            return nome;
        }
        
        public string MostrarEndereco() //Método responsável por mostrar o texto do atributo endereco
        {
            return endereco;
        }
    }
}
