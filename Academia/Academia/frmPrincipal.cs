using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Evento Load do formulário Principal.
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Estabelece a conexão com o banco através da classe Conexao e seu método stringConexao
            using (SqlConnection novaConexao = new SqlConnection(Conexao.stringConexao))
            {
                try //Tenta realizar as linhas de comandos dentro das chaves.
                {
                    novaConexao.Open(); //Abre a conexão com o banco de dados.
                    MessageBox.Show("Conectou!"); //Mostra caixa de mensagem com o texto "Conectou!"
                }
                catch (Exception) //Se houver um erro no bloco try, o programa captura o mesmo e realiza a ação entre chaves.
                {
                    MessageBox.Show("Não conectou!");
                }
                finally //Por fim ele realiza a ação informada entre chaves, com ou sem erro.
                {
                    MessageBox.Show("Bem vindo ao sistema de academia!");
                }
            }

            VerificaSituacaoCaixa(); //Verifica se aparecerá ABERTO ou FECHADO em relação ao caixa.
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            //Evento Click do btnProfessores em que o formulário frmProfessores é instanciado e exibido.
            frmProfessores professor = new frmProfessores();
            professor.Show();
        }

        private void btnModalidade_Click(object sender, EventArgs e)
        {
            frmModalidades modalidade = new frmModalidades();
            modalidade.Show();
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            frmTurmas turma = new frmTurmas();
            turma.Show();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            frmAlunos aluno = new frmAlunos();
            aluno.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa caixa = new frmCaixa(this, lblCaixa.Text); //Passa o frmPrincipal e o texto da lblCaixa como parâmetro
            caixa.Show();
        }

        public void VerificaSituacaoCaixa()
        {
            try
            {
                Caixa novoCaixa = new Caixa(); //Cria um objeto da classe Caixa para poder acessá-la.
                DataTable dadosTabela = new DataTable(); //Cria objeto DataTable para armazenar registros de uma tabela.
                dadosTabela = novoCaixa.ListarCaixa(); //Armazena os dados da tabela Caixa e os armazena em memória, aguardando o próximo passo.

                /*Verifica se o valor da coluna SITUACAO é true, no qual está definida como bit no banco de dados.
                 Será usado essa verificação para direcionar o texto do para o lblCaixa, mostrando sua situação. */
                if (Convert.ToBoolean(dadosTabela.Rows[0]["SITUACAO"]) == true)
                {
                    lblCaixa.Text = "ABERTO";
                    lblCaixa.ForeColor = Color.DarkGreen;
                }
                else
                {
                    lblCaixa.Text = "FECHADO";
                    lblCaixa.ForeColor = Color.Firebrick;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
