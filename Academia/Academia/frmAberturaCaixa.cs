using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmAberturaCaixa : Form
    {
        Caixa novoCaixa;

        public frmAberturaCaixa()
        {
            InitializeComponent();
        }

        private void frmAberturaCaixa_Load(object sender, EventArgs e)
        {
            //Usa a propriedade Text desse formulário e atribui um texto concatenado com a data e a hora atual, ambos em formato curto
            this.Text = "Abertura do Caixa - Data: " + DateTime.Today.Date.ToShortDateString() + " - Hora: " + DateTime.Now.ToShortTimeString();
        }

        private void cboValorInicial_SelectedIndexChanged(object sender, EventArgs e) //Evento que reconhece qual item foi clicado dentro dele
        {
            if (cboValorInicial.Text == "Zerado") //Verifica se o item selecionado foi a opção "Zerado"
            {
                tcDados.Enabled = false;
                txtDinheiro.Text = "0,00";
                txtCheque.Text = "0,00";
                txtCaixa.Text = "0,00";
            }
            else
            {
                if (cboValorInicial.Text == "Com os valores que eu digitar")
                {
                    tcDados.Enabled = true;
                    txtDinheiro.Text = "0,00";
                    txtCheque.Text = "0,00";
                    txtCaixa.Text = "0,00";
                    txtDinheiro.Focus(); //o cursor de digitação ficará dentro desse textbox
                }
            }
        }
        
        private void AtualizarAberturaCaixa() //Método que atualiza o valor do campo referente à soma
        {
            string dinheiro, cheque;
            dinheiro = txtDinheiro.Text;
            cheque = txtCheque.Text;

            //Define a soma do dinheiro e do cheque, com a conversão necessária pro banco de dados; e o uso da Substring para eliminar o símbolo R$
            txtCaixa.Text = (Convert.ToDecimal(dinheiro.Substring(3)) + Convert.ToDecimal(cheque.Substring(3))).ToString("c");
        }

        private void txtDinheiro_Leave(object sender, EventArgs e) //Evento responsável por verificar quando o usuário sai de um componente
        {
            /* A ação que deverá ocorrer quando o usuário sair deste campo será a conversão para números decimais e atribuir
             * o formato padrão da nossa moeda. Além de atualizar a soma, através do método AtualizarAberturaCaixa. */
            txtDinheiro.Text = Convert.ToDecimal(txtDinheiro.Text).ToString("c");
            AtualizarAberturaCaixa();
        }

        private void txtCheque_Leave(object sender, EventArgs e)
        {
            txtCheque.Text = Convert.ToDecimal(txtCheque.Text).ToString("c");
            AtualizarAberturaCaixa();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {   /* Verifica se a propriedade SelectedIndex, a qual informa o item selecionado, é igual a -1, isto é, se não foi escolhido nenhuma opção,
                 * já que a contagem do seu conteúdo começa pelo 0. */
                if (cboValorInicial.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um modo de abertura do caixa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novoCaixa = new Caixa();

                    string caixa = txtCaixa.Text;
                    novoCaixa.Salvar(DateTime.Now.Date, DateTime.Now, Convert.ToDecimal(caixa.Substring(3)), true);
                    MessageBox.Show("Caixa aberto com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close(); //DIFICIIL TRABALHAR COM TIMESPAN, vou colocar datetime mesmo
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
