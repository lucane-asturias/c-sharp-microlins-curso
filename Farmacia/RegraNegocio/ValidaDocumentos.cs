using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class ValidaDocumentos
    {
        /* Método público que será responsável por retornar sua condição, seja verdadeira ou falsa. 
         * Tendo como parâmetro a string do cpf que será verificado. */
        public bool ValidaCpf(string cpf)
        {
            try
            {
                /* Para realizar cálculos de multiplicações para os dois dígitos verificadores, cada um deles deverá possuir uma sequência [...]
                 * certa para as operações. Para isso foi usada a estrutura array, as quais possibilitam ordenar seus elementos. */
                int[] multiplicador1 = new int[9] {10, 9, 8, 7, 6, 5, 4, 3, 2};
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                /* Em seguida, são criadas duas variáveis do tipo string. Uma sera responsável por receber uma parte dos números do CPF (os 9 dígitos)
                 * e a outra armazenará os dígitos verificadores */
                string tempCpf;
                string digito;

                //Logo após, são criadas mais duas variáveis, do tipo int, que guardarão os valores da soma e do resto de cada operação. 
                int soma;
                int resto;

                /* E, como os números do CPF contêm caracteres que virão da máscara do componente MaskedTextBox, é aplicado os métodos Trim para retirar [...]
                 * caracteres em branco da variável cpf e depois o método Replace, para substituir o ponto e o hífen por vazio. */
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");

                /* A próxima providência foi verificar a primeira regra do CPF, isto é, se ele possui 11 caracteres. Se a extensão da variável (propriedade Legnth) [...]
                 * for diferente desse valor, é para retornar a condição false. */
                if (cpf.Length != 11)
                {
                    return false;
                }

                /* Se o número digitado possuir 11 dígitos, a seguinte etapa será realizar a multiplicação dos 9 primeiros. Portanto, será utilizado a variável cpf [...]
                 * e atribuído o método Substring nela, a qual pegará apenas os 9 primeiros números do CPF. Além disso, é dado o valor 0 para a variável soma. */
                tempCpf = cpf.Substring(0, 9);
                soma = 0;

                /* Em seguida, é dado inicio ao cálculo, no qual foi utilizado a estrutura de repetição "for" para que seja realizada a multiplicação dos 9 números [...]
                 * e sua soma, usando o array "multiplicador 1". Sendo que a variável resto será igual a essa soma dividido por 11 e utilizando apenas a sobra dessa conta.
                 * O operador "%" já realiza isso, ele divide e usa apenas o resto desse cálculo, sem a dizima periódica. */
                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                }

                resto = soma % 11;

                /* Após encontrar o resto da divisão, verifica se o valor é menor que 2. Se isso for verdade, o valor do primeiro dígito será igual a 0.
                 * Se não for, realiza um outro cálculo, no qual pegará o 11 e subtrair pela sobra. */
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                //Então, o primeiro dígito verificador será igual ao resto, que antes era do tipo int e agora precisa ser transformado numa string.
                digito = resto.ToString();

                /* Feito isso, partimos para o segundo dígito, utilizando os mesmos procedimentos do primeiro, no qual realiza [...].
                 * a segunda multiplicação e a soma do seu resultado dividido por 11. Logo após, verifica se o resto desse cálculo  é menor que 2 para [...]
                 * chegarmos ao resultado do segundo dígito verificador. */

                tempCpf = tempCpf + digito;
                soma = 0;

                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                }

                resto = soma % 11;

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                //Depois disso, a variável digíto será igual a ela própria, somando com o resto que foi obtido do segundo cálculo.
                digito = digito + resto.ToString();

                /* Por fim, pede para retornar true ou false, após a comparação dos dígitos finais da variável cpf com os resultados obtidos [...]
                 * pelos cálculos armazenados na variável dígito. */
                return cpf.EndsWith(digito);
            }
            catch (Exception)
            {

                throw new Exception("Ocorreu um erro no método ValidaCpf. Caso o problema persista, entre em contato com o Administrador.");
            }
        }
    }
}
