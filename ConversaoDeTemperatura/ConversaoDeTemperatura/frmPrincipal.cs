using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversaoDeTemperatura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);

            //verifica se a opção Celsius do Groupbox Entrada está selecionada
            if (rbCelsius1.Checked == true)
            {
                //verifica qual opção está selecionada no GroupBox Saída e realiza a conversão
                //e atribui o resultado ao txtResultado

                if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = (valor + 273) + "°K";
                }
                else if (rbFahreint2.Checked == true)
                {
                    txtResultado.Text = (valor * 1.8 + 32) + "°F";
                }
                else
                {
                    txtResultado.Text = valor + "°C";
                }
            }
            //verifica se a opção Kelvin do Groupbox Entrada está selecionada
            else if (rbKelvin1.Checked == true)
            {
                //verifica qual opção está selecionada no GroupBox Saída e realiza a conversão
                //e atribui o resultado ao txtResultado

                if (rbCelsius2.Checked == true)
                {
                    txtResultado.Text = (valor - 273) + "°C";
                }
                else if (rbFahreint2.Checked == true)
                {
                    txtResultado.Text = (valor * 1.8 - 459.67) + "°F";
                }
                else
                {
                    txtResultado.Text = valor + "°K";
                }
            }

            //verifica se a opção Fahreint do Groupbox Entrada está selecionada
            else if (rbFahreint1.Checked == true)
            {
                //verifica qual opção está selecionada no GroupBox Saída e realiza a conversão
                //e atribui o resultado ao txtResultado

                if (rbCelsius2.Checked == true)
                {
                    txtResultado.Text = ((valor - 32) / 1.8) + "°C";
                }
                else if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = ((valor + 459.67) / 1.8) + "°K";
                }
                else
                {
                    txtResultado.Text = valor + "°F";
                }
            }
            else //no caso de não for marcado nenhuma conversão
            {
                txtResultado.Text = valor.ToString(); //... o programa irá atribuir o valor ao txtResultado
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtResultado.Clear();

            foreach (Control Componente in gbEntrada.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }

            foreach (Control Componente in gbSaida.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }
        }
    }
}
