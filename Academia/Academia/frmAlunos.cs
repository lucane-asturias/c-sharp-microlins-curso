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
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
            ListarAlunos();
        }

        Alunos novoAluno;
        frmControleAlunos controleAlunos; //Como é utilizado o frmControleAlunos em mais de um evento neste formulário, é melhor instanciá-lo fora dos eventos.

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            /* Passa esse (this) formulário, que é o frmAlunos, como parâmetro, pois ele será utilizado para ter o acesso ao método ListarAluno (criado aqui)
             * no formulário frmControleAlunos, cuja função será listar após ter salvado, editado ou excluído algum registro quando o form for fechado. */
            controleAlunos = new frmControleAlunos(this);
            controleAlunos.ShowDialog(); //Abre o formulário frmControleAlunos quando o evento click do btnAdicionar for acionado.
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            novoAluno = new Alunos();
            DataTable dadosTabela = new DataTable();

            if (rbNome.Checked == true)
            {
                dadosTabela = novoAluno.PesquisarNomeAluno(txtPesquisa.Text);
                dtgAlunos.DataSource = dadosTabela;
                Estilo();
            }
            else
            {
                if (rbCPF.Checked == true)
                {
                    dadosTabela = novoAluno.PesquisarCpfAluno(txtPesquisa.Text);
                    dtgAlunos.DataSource = dadosTabela;
                    Estilo();
                }
            }
        }

        private void Estilo()
        {
            int linhas = dtgAlunos.Rows.Count; //Calcula a quantidade de linhas 

            for (int i = 0; i < linhas; i++)
            {
                dtgAlunos.Rows[i].DefaultCellStyle.ForeColor = Color.LightSteelBlue;
                i++;

            }
        }

        public void ListarAlunos()
        {
            try
            {
                novoAluno = new Alunos();
                dtgAlunos.DataSource = novoAluno.Listar();
                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void frmAlunos_Enter(object sender, EventArgs e)
        {
            ListarAlunos(); //n entendi
        }

        /*Quando o usuário der um duplo clique numa linha, a variável alunoSelecionado será armazenada. Posteriormente, o método ExibirAlunos do [...]
         * frmControleALunos será chamado, exibindo o nome do aluno selecionado na barra de títulos do formulário.
         * Além disso, passará os valores de cada coluna do DataGridView(dtgAlunos) para seus respectivos textboxes. */

        private void dtgAlunos_DoubleClick(object sender, EventArgs e)
        {
            //Variável do tipo DataGridView que será armazenada dependendo da linha do dtgAlunos que o usuário der um duplo clique.
            DataGridView alunoSelecionado = dtgAlunos.Rows[dtgAlunos.CurrentRow.Index].DataGridView; //Envia a linha seleciona inteira para a variável.

            /* Como as informações da variável alunoSelecionado será passado por outro formulário, é preciso instanciá-la;
             * e concede acesso a todos os eventos e métodos do dtgAlunos, o indicando através do "this", para poder utilizar o método ListarAlunos no FormClosed. */
            controleAlunos = new frmControleAlunos(this);

            /* Para que os dados possam ser trazidos quando o formulário for exibido, será necessário chamar o método criado no frmControleAlunos.
             * No parâmetro do método frmControleALunos, foi definido uma variável do tipo DTV; então, para que os valores da linha selecionada [...]
             * sejam passadas por esse parâmetro, será preciso indicar a variável alunoSelecionado, que é do tipo DTV. */
            controleAlunos.ExibirAluno(alunoSelecionado);
            controleAlunos.ShowDialog();

        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            Estilo();
        }
    }
}
