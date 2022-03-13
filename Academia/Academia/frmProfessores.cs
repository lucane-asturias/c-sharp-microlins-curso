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
    public partial class frmProfessores : Form
    {
        public frmProfessores()
        {
            InitializeComponent();
        }

        Professores novoProfessor = new Professores();

        //Evento do botão Salvar o qual grava as informações através do método Salvar, criado na classe Professor.
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                novoProfessor = new Professores();

                if (txtCodigo.Text == "0")
                {
                    novoProfessor.Salvar(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCEP.Text,
                              txtCPF.Text, Convert.ToDecimal(txtSalario.Text), txtTelefone.Text, txtObservacoes.Text);

                    MessageBox.Show("Professor salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novoProfessor.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text,
                    txtCidade.Text, txtCEP.Text, txtCPF.Text, Convert.ToDecimal(txtSalario.Text), txtTelefone.Text, txtObservacoes.Text);
                    MessageBox.Show("Professor alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                listarProfessores();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listarProfessores()
        {
            try
            {
                novoProfessor = new Professores();
                dtgProfessores.DataSource = novoProfessor.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpar()
        {
            //Limpa os campos do formulário frmProfessores.
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtCEP.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtSalario.Clear();
        }

        private void frmProfessores_Load(object sender, EventArgs e)
        {
            //Assim que carregar o formulário, os registros dos professores serão mostrados no DataGridView.
            listarProfessores();
        }

        //Carrega a 'área de cadastro' com os dados da linha selecionada no DataGridView.
        private void dtgProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica o nome da coluna que recebeu o clique.
            if (dtgProfessores.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                //Atribui a todos os campos o conteúdo das respectivas colunas referentes a linha selecionada.
                txtCodigo.Text = dtgProfessores.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                txtNome.Text = dtgProfessores.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
                txtEndereco.Text = dtgProfessores.Rows[e.RowIndex].Cells["ENDERECO"].Value.ToString();
                txtBairro.Text = dtgProfessores.Rows[e.RowIndex].Cells["BAIRRO"].Value.ToString();
                txtCidade.Text = dtgProfessores.Rows[e.RowIndex].Cells["CIDADE"].Value.ToString();
                txtCEP.Text = dtgProfessores.Rows[e.RowIndex].Cells["CEP"].Value.ToString();
                txtCPF.Text = dtgProfessores.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                txtTelefone.Text = dtgProfessores.Rows[e.RowIndex].Cells["TELEFONE"].Value.ToString();
                txtSalario.Text = dtgProfessores.Rows[e.RowIndex].Cells["SALARIO"].Value.ToString();
                txtObservacoes.Text = dtgProfessores.Rows[e.RowIndex].Cells["OBSERVACAO"].Value.ToString();
            }
            else if (dtgProfessores.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?",
                                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    novoProfessor = new Professores();
                    novoProfessor.Excluir(Convert.ToInt32(dtgProfessores.Rows[e.RowIndex].Cells["CODIGO"].Value));
                    MessageBox.Show("Professor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarProfessores();
                    Limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            /* Evento do txtPesquisa, o qual verifica se desejamos pesquisar por um nome ou CPF e exiba  os resultados
               de acordo com o que for digitado no mesmo. */

            novoProfessor = new Professores();

            try
            {

                if (rbNome.Checked == true)
                {
                    dtgProfessores.DataSource = novoProfessor.PesquisarNome(txtPesquisa.Text);
                }
                else
                {
                    dtgProfessores.DataSource = novoProfessor.PesquisarCPF(txtPesquisa.Text);
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
