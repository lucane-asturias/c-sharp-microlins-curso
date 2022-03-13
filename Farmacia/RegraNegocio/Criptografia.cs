using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    //Classe Criptografia com métodos capazes de criptografar uma senha, deixando o registro no banco mais seguro.

    public class Criptografia
    {
        public string Criptografar(string senha) //Indica como parâmetro o que será criptografado, no caso, será a senha dos usuários
        {
            /* O primeiro passo para criptografar uma senha é transformar os caracteres inseridos em linguagem binária, que é o tipo de informação transmitida [...]
             * pelo computador. Depois, será utilizado a classe ASCIIEncoding, que é nativa do Visual Studio. Essa classe representa uma [...]
             * codificação de caracteres ASCII, que nada mais é que um conjunto de 7 bits, no entanto, representado por 8 bits, no qual, o oitavo, é utilizado apenas para
             * deteccção de possíveis erros. Assim, excluindo o oitavo bit, essa codificação contém 128 caracteres, incluindo os números de 0 a 9, [...]
             * as letras maiúsculas e minúsculas em inglês de A á Z, e alguns caracteres especiais. */

            /* Variável do tipo Byte que armazenará a senha inserida pelo usuário já convertida para uma cadeia de binária. [...]
             * Como a senha inserida pelo usuário é composta de caracteres, usamos a classe ASCIIEnconding (que pertence a namespace System.Text) [...] 
             * e a sua propriedade ASCII, que por meio do método GetBytes, essa senha será convertida para binário. */
            byte[] senhaBinaria = ASCIIEncoding.ASCII.GetBytes(senha);

            /* No banco de dados desse projeto, o campo relacionado à senha é do tipo nvarchar, ou seja, texto. Então, se ao salvar uma senha, chamarmos este método [...]
             * para que ela seja criptografada antes de ser armazenada no banco de dados, não será válido deixá-la sendo do tipo Byte. Logo, será necessário converter [...]
             * o conteúdo dessa variável (senhaBinaria) para sua representação em caracteres. E para armazená-lo, uma variável do tipo string será preciso. */

            /* Afim de converter a senha (que no momento está em binário), utiliza-se o método ToBase64String, o qual pertence à classe Convert.
             * A Base64 é utilizada para codificar os dados binários, tratando-o numericamente e traduzindo-os em uma representação de base 64, [...]
             * que possui esse nome devido ao fato de ser constituído de 64 caracteres. Entre parênteses, é necessário indicar o que será convertido para a base 64, [...]
             * ou seja, para a representação em caracteres. Nesse caso, queremos q seja a senha q foi convertida para binário e está armazenada na variável senhaBinaria. */

            //Variável do tipo string recebe o conteúdo da variável senhaBinaria convertido para a sua representação em caracteres (tobase64String).
            string senhaCripto = Convert.ToBase64String(senhaBinaria); //A variável senha que está em binário será convertida para texto e atribuída a variavel senhaCripto
            return senhaCripto; //Retorna o conteúdo da variável, já codificado e convertido para string.
        }
    }
}
