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
    public partial class frmSuprimento : Form
    {
        int idMensalidade;
        string valor; //Usa o tipo string, já que, juntamente ao valor da mensalidade, aparecerá o símbolo da nossa moeda

        frmControleAlunos formulario;
        Caixa novoCaixa;
        Mensalidade novaMensalidade;

        //A variável que está como parâmetro do método deve obedecer ao tipo de dado que o banco recebe, que no caso são número decimais
        public frmSuprimento(int idMensalidade, decimal valor, frmControleAlunos formulario)
        {
            //Método construtor que carrega os valores para o formulário frmSuprimento assim que ele é acessado 
            InitializeComponent();
            //Cada atributo será igual às variáveis dos parâmetros e realiza a conversão (ToString) necessária para o valor
            this.idMensalidade = idMensalidade;
            this.valor = valor.ToString("c");
            txtDinheiro.Text = this.valor;
            this.formulario = formulario;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Botão responsável por confirmar e realizar o pagamento da mensalidade do aluno
            try
            {

                DataTable dadosTabela = new DataTable();
                novoCaixa = new Caixa();
                dadosTabela = novoCaixa.ListarCaixa(); //Atribui ao DataTable o listamento da tabela Caixa

                novoCaixa = new Caixa();
                novoCaixa.SalvarDetalhes(Convert.ToInt32(dadosTabela.Rows[0]["ID_CAIXA"]), Convert.ToDecimal(valor.Substring(3)), "SUPRIMENTO", cboForma.Text);
                MessageBox.Show("Entrada registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                novaMensalidade = new Mensalidade();
                novaMensalidade.Alterar(idMensalidade, DateTime.Now.Date, true);

                //formulario.ListarMensalidades();              depois cria método listar na classe mensalidade (criado)
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
