using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        double valorVisor = 0, valorAnterior = 0;
        string operacao = "";
        bool primeiraOperacao = true, botaoIgual = false;

        public frmCalculadora()
        {
            InitializeComponent();
        }
        
        private void ClicouBotao_Click(object sender, EventArgs e) //Evento Click dos botões
        {
            if (txtVisor.Text == "0" || botaoIgual == true) //Se o visor estiver com numero 0 ou botãoIgual estiver como true,
            {
                txtVisor.Clear(); //é para limpá-lo
                botaoIgual = false; //e deixa a variável botaoIgual como false
            }

            Button botaoAcionado = (Button)sender; //O objeto botão que foi clicado será carregado no botaoAcionado

            switch(botaoAcionado.Name) //Verifica e detecta o nome do botão acionado
            {
                case "btn1":                //Caso seja btn1 
                    txtVisor.Text += "1";   //A propriedade Text do visor receberá o número 1
                    break;                  //Parar a verificação

                case "btn2":                //Os próximos passos verificam qual botão foi acionado e envia para a
                    txtVisor.Text += "2";   //propriedade Text do mesmo, o número relacionado a ele.
                    break;                  //Após a detecção de qual botão foi acionado, a verificação é finalizada.   

                case "btn3":
                    txtVisor.Text += "3";
                    break;

                case "btn4":
                    txtVisor.Text += "4";
                    break;

                case "btn5":
                    txtVisor.Text += "5";
                    break;

                case "btn6":
                    txtVisor.Text += "6";
                    break;

                case "btn7":
                    txtVisor.Text += "7";
                    break;

                case "btn8":
                    txtVisor.Text += "8";
                    break;

                case "btn9":
                    txtVisor.Text += "9";
                    break;

                case "btn0":
                    txtVisor.Text += "0";
                    break;

                case "btnVirgula":
                    if (txtVisor.Text == "")
                    {
                        txtVisor.Text += "0,";
                    }
                    else
                    {
                        txtVisor.Text += ",";
                    }
                    break;
                default:
                    break;
            }
        }

        //Botão responsável por limpar os campos e os atributos, "resetando" as configurações da calculadora
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear(); 
            txtHistorico.Clear();
            valorAnterior = 0;
            valorVisor = 0;

            operacao = "";
            primeiraOperacao = true;
            botaoIgual = false;
        }

        private void btnBackSpace_Click(object sender, EventArgs e) //Botão responsável por apagar o último número
        {
            //O txtVisor terá seu último caractere removido ao passo da extensão da propriedade de texto do mesmo,
            //no sentido de apagar o texto da direita para esquerda.
            txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);
        }

        private void btnAdicao_Click(object sender, EventArgs e) //Botão responsável por realizar somas
        {
            if (primeiraOperacao) //se for a primeira operação realizada
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor

                if (botaoIgual == false) //se o botãoIgual estiver como false
                {
                    txtHistorico.Text += txtVisor.Text; //o txtHistorico adiciona o que estiver no txtVisor
                }

                txtVisor.Clear(); //limpa o txtVisor
                operacao = " + "; //determina que a operação realizada é adição
                primeiraOperacao = false; //primeiraOperacao passa a ser falsa
            }
            else //senão
            {
                valorVisor = Convert.ToDouble(txtVisor.Text); //converte o número do txtVisor para double
                    
                txtHistorico.Text += operacao + txtVisor.Text; //o txtHistorico recebe a operação realizada anteriormente

                //txtVisor.Text = Convert.ToString(valorAnterior + valorVisor); //realiza a soma dos números realizados e exibe no txtVisor
                txtVisor.Text = Convert.ToString(Calculo()); //realiza a soma dos números e exibe no txtVisor

                operacao = " + "; //determina que a operação realizada é adição
                txtHistorico.Text += " = " + txtVisor.Text; //txtHistorico recebe o sinal de = e o último número inserido no txtVisor
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor
                botaoIgual = true; //a variável botaoIgual passa a ser true
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao) //se for a primeira operação realizada
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor

                if (botaoIgual == false) //se o botãoIgual estiver como false
                {
                    txtHistorico.Text += txtVisor.Text; //o txtHistorico adiciona o que estiver no txtVisor
                }

                txtVisor.Clear(); //limpa o txtVisor
                operacao = " / "; //determina que a operação realizada é divisão
                primeiraOperacao = false; //primeiraOperacao passa a ser falsa
            }
            else //senão
            {
                valorVisor = Convert.ToDouble(txtVisor.Text); //converte o número do txtVisor para double

                txtHistorico.Text += operacao + txtVisor.Text; //o txtHistorico recebe a operação realizada anteriormente

                //txtVisor.Text = Convert.ToString(valorAnterior / valorVisor); //realiza a divisão dos números realizados e exibe no txtVisor
                txtVisor.Text = Convert.ToString(Calculo());

                operacao = " / "; //determina que a operação realizada é divisão
                txtHistorico.Text += " = " + txtVisor.Text; //txtHistorico recebe o sinal de = e o último número inserido no txtVisor
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor
                botaoIgual = true; //a variável botaoIgual passa a ser true
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao) //se for a primeira operação realizada
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor

                if (botaoIgual == false) //se o botãoIgual estiver como false
                {
                    txtHistorico.Text += txtVisor.Text; //o txtHistorico adiciona o que estiver no txtVisor
                }

                txtVisor.Clear(); //limpa o txtVisor
                operacao = " - "; //determina que a operação realizada é divisão
                primeiraOperacao = false; //primeiraOperacao passa a ser falsa
            }
            else //senão
            {
                valorVisor = Convert.ToDouble(txtVisor.Text); //converte o número do txtVisor para double

                txtHistorico.Text += operacao + txtVisor.Text; //o txtHistorico recebe a operação realizada anteriormente

                //txtVisor.Text = Convert.ToString(valorAnterior - valorVisor); //realiza a subtração dos números realizados e exibe no txtVisor
                txtVisor.Text = Convert.ToString(Calculo());

                operacao = " - "; //determina que a operação realizada é subtração
                txtHistorico.Text += " = " + txtVisor.Text; //txtHistorico recebe o sinal de = e o último número inserido no txtVisor
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor
                botaoIgual = true; //a variável botaoIgual passa a ser true
            }
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao) //se for a primeira operação realizada
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor

                if (botaoIgual == false) //se o botãoIgual estiver como false
                {
                    txtHistorico.Text += txtVisor.Text; //o txtHistorico adiciona o que estiver no txtVisor
                }

                txtVisor.Clear(); //limpa o txtVisor
                operacao = " * "; //determina que a operação realizada é multiplicação
                primeiraOperacao = false; //primeiraOperacao passa a ser falsa
            }
            else //senão
            {
                valorVisor = Convert.ToDouble(txtVisor.Text); //converte o número do txtVisor para double

                txtHistorico.Text += operacao + txtVisor.Text; //o txtHistorico recebe a operação realizada anteriormente

                //txtVisor.Text = Convert.ToString(valorAnterior * valorVisor); //realiza a multiplicação dos números realizados e exibe no txtVisor
                txtVisor.Text = Convert.ToString(Calculo());

                operacao = " * "; //determina que a operação realizada é multiplicação
                txtHistorico.Text += " = " + txtVisor.Text; //txtHistorico recebe o sinal de = e o último número inserido no txtVisor
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor
                botaoIgual = true; //a variável botaoIgual passa a ser true
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valorVisor = Convert.ToDouble(txtVisor.Text);

            txtHistorico.Text += operacao + txtVisor.Text;

            txtVisor.Text = Convert.ToString(Calculo());

            txtHistorico.Text += " = " + txtVisor.Text;

            valorAnterior = Convert.ToDouble(txtVisor.Text);

            botaoIgual = true;
            primeiraOperacao = true;
        }

        public double Calculo() //método para verificar qual operação deverá ser realizada
        {
            switch (operacao)
            {
                case " + ":
                    valorAnterior = valorAnterior + valorVisor;
                    break;
                case " - ":
                    valorAnterior = valorAnterior - valorVisor;
                    break;
                case " / ":
                    valorAnterior = valorAnterior / valorVisor;
                    break;
                case " * ":
                    valorAnterior = valorAnterior * valorVisor;
                    break;

                default:
                    break;
            }

            return valorAnterior;
        }
    }
}