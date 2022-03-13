using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPropriedadesCheckBox
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "") //se o txtNumero estiver vazio
            {
                //aparecerá uma caixa de mensagem avisando o usuário que ele deve digitar um número
                MessageBox.Show("Você precisa digitar um número para calcular a tabuada.",
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //senão
            {
                double numero, resultado; //declaração das variáveis
                numero = double.Parse(txtNumero.Text); //o número digitado no txtNumero é convertido

                for (int i = 0; i <= 10; i++) //laço de repetição FOR, onde há o
                {
                    resultado = numero * i; //cálculo do resultado e 
                    //o mesmo é exibido no txtTabuada
                    txtTabuada.Text += numero + " x " + i + " = " + resultado + "\r\n";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = ""; //o txtNumero ficará em branco
            txtTabuada.Text = ""; //e o txtTabuada também ficará em branco
        }
    }
}
