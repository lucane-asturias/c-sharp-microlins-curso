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
    public partial class frmCaixa : Form
    {
        public frmPrincipal formularioPrincipal;
        string lblCaixa;

        public frmCaixa(frmPrincipal formularioPrincipal, string lblCaixa) //Instancia o frmPrincipal e a label dentro do frmCaixa
        {
            InitializeComponent();

            this.formularioPrincipal = formularioPrincipal; //Indica que o objeto passado como parâmetro é o mesmo instaciado nesse formulário
            this.lblCaixa = lblCaixa;
        }

        Caixa novoCaixa;

        public void VerificaComponentesCaixa()
        {
            if (lblCaixa == "ABERTO")
            {
                txtInicial.Enabled = false;
                txtEntrada.Enabled = false;
                txtRetirada.Enabled = false;
                txtSaldo.Enabled = false;

                btnSuprimento.Enabled = true;
                btnRetirada.Enabled = true;
                btnAbrirCaixa.Visible = false;
                btnFechar.Visible = true;
            }
            else
            {
                txtInicial.Enabled = true;
                txtEntrada.Enabled = true;
                txtRetirada.Enabled = true;
                txtSaldo.Enabled = true;
                btnFechar.Visible = false;

                btnSuprimento.Enabled = false;
                btnRetirada.Enabled = false;
                btnFechar.Visible = false;
                btnAbrirCaixa.Visible = true;
            }
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            frmAberturaCaixa AberturaCaixa = new frmAberturaCaixa();
            AberturaCaixa.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente fechar?", "Deseja fechar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novoCaixa = new Caixa(); //Cria um objeto da classe Caixa para acessar seus métodos
                    DataTable dadosTabela = new DataTable();
                    dadosTabela = novoCaixa.ListarCaixa(); //Lista todos os dados da tabela Caixa em forma decrescente e armazena na memória do DataTable

                    novoCaixa = new Caixa(); //Cria outro objeto da classe Caixa, para não sobrecarregá-lo, já que será a segunda vez usado.

                    /* Como o método ListarCaixa traz os registros de forma decrescente, o último caixa estará sempre em primeiro lugar dessa lista,
                     * ou seja, na posição 0. Assim, está sendo passado por parâmetro o ID do primeiro registro. Ele realizará uma consulta no ID_CAIXA
                     * e alterará a situação da primeira linha, ou seja, do primeiro caixa, para fechado. */
                    novoCaixa.Alterar(Convert.ToInt32(dadosTabela.Rows[0]["ID_CAIXA"]), false);
                    MessageBox.Show("Caixa fechado com sucesso!", "Caixa fechado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    formularioPrincipal.VerificaSituacaoCaixa(); //Exibe a situação do caixa, neste caso, que ele foi fechado.
                    VerificaComponentesCaixa();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCaixa_Activated(object sender, EventArgs e) //Quando o formulário for ativado, executará o método entre chaves.
        {
            VerificaComponentesCaixa(); //Verifica a situação do caixa, se seus componentes devem ficar habilitados ou não.
            ListarDetalhesCaixa(); //Método responsável por mostrar os valores no datagridview
        }

        private void btnSuprimento_Click(object sender, EventArgs e)
        {
            frmSuprimentoCaixa suprimento = new frmSuprimentoCaixa(this);
            suprimento.ShowDialog();
        }

        private void btnRetirada_Click(object sender, EventArgs e)
        {
            frmRetirada retirada = new frmRetirada(this);
            retirada.ShowDialog();
        }

        public void ListarDetalhesCaixa() //Método que mostrará os lançamentos atualizados do caixa atual
        {
            try
            {
                novoCaixa = new Caixa(); //Instancia um objeto da classe Caixa para acessar seus métodos
                dtgCaixa.DataSource = novoCaixa.ListarCaixa(); //Passa para a fonte de dados do dtgCaixa o resultado da query select * from Caixa

                int linhas = dtgCaixa.Rows.Count; //Guarda o total de linhas do dtgCaixa

                decimal entrada = 0; //Variável para armazenar o valor da entrada
                decimal retirada = 0; //Variável para armazenar o valor da retirada

                for (int i = 0; i < linhas; i++) //Percorre todas as linhas presentes do datagridview
                {
                    if (dtgCaixa.Rows[i].Cells["MOVIMENTO"].Value.ToString() == "SUPRIMENTO") //Se a coluna estiver com o valor 'SUPRIMENTO'
                    {
                        dtgCaixa.Rows[i].Cells["Imagem"].Value = Academia.Properties.Resources.suprir; //aparecerá uma seta pra cima de cor verde
                        entrada = entrada + Convert.ToDecimal(dtgCaixa.Rows[i].Cells["VALOR"].Value);
                    }
                    else //Senão tiver
                    {
                        dtgCaixa.Rows[i].Cells["Imagem"].Value = Academia.Properties.Resources.retirar; //aparecerá uma seta pra baixo de cor vermelha
                        retirada = retirada + Convert.ToDecimal(dtgCaixa.Rows[i].Cells["VALOR"].Value);
                    }

                    if (linhas > 0) //Verifica se há algum registro no dtgCaixa
                    {
                        txtEntrada.Text = entrada.ToString("c"); //Pega a variável entrada criada acima, converte para formato moeda e atribui para o txtEntrada
                        txtRetirada.Text = retirada.ToString("c"); //Chama a variável retirada, converte para formato moeda e atribui ao txtRetirada

                        string inicial = txtInicial.Text; //Atribui o texto do txtInicial para a variável inicial
                        decimal saldo_inicial = Convert.ToDecimal(inicial.Substring(3)); //Converte a variável inicial para decimal e atribui para a variável saldo

                        decimal total = (saldo_inicial + entrada) - retirada; //Soma o saldo inicial do caixa com a entrada, subtraindo desse valor o total de retiradas

                        txtSaldo.Text = total.ToString("c"); //Atribui o total convertido para moeda ao texto do txtSaldo
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
