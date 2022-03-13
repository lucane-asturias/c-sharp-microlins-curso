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
    public partial class frmModalidades : Form
    {
        public frmModalidades()
        {
            InitializeComponent();
        }

        Modalidades novaModalidade = new Modalidades();

        public void listarProfessores()
        {
            try
            {
                Professores novoProfessor = new Professores();

                //Traz todas as informações da tabela Professor, porém, mostrará apenas os nomes e armazenará os códigos de cada um deles [...]
                cboProfessor.DataSource = novoProfessor.Listar(); //conforme a programação abaixo no DisplayMember e ValueMember.
                cboProfessor.DisplayMember = "NOME_PROFESSOR"; //Exibe no ComboBox a coluna NOME_PROFESSOR da tabela Professor do bd.
                cboProfessor.ValueMember = "ID_PROFESSOR"; //Armazena o valor do item adicionado no DisplayMember.

                cboProfessor.SelectedIndex = -1; //Definindo que o componente será apresentado em branco.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmModalidades_Load(object sender, EventArgs e)
        {
            listarProfessores(); //Carrega os nomes dos professores dentro do ComboBox assim que o formulário for instanciado.
            listarModalidades(); //Carrega a listagem das modalidades assim que o formulário for instanciado.
        }

        //Método responsável por listar as modalidades  dentro do DataGridView.
        private void listarModalidades()
        {
            try
            {
                novaModalidade = new Modalidades();
                dtgModalidade.DataSource = novaModalidade.Listar(); //dtgModalidade receberá a lista das modalidades trazidas pelo método Listar.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            novaModalidade = new Modalidades();

            try
            {
                novaModalidade = new Modalidades();

                //Verifica se a seleção dos itens do ComboBox está com seu valor inicial, ie, sem nenhuma seleção.
                if (cboProfessor.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um professor antes de salvar.", "Selecione um professor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtCodigo.Text == "0")
                    {
                        //Executa o método Salvar, mostra a mensagem de sucesso, lista as modalidades e depois limpa os campos.
                        novaModalidade.Salvar(txtNome.Text, Convert.ToDecimal(txtMensalidade.Text), Convert.ToInt32(cboProfessor.SelectedValue));
                        MessageBox.Show("Modalidade registrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listarModalidades();
                        Limpar();
                    }
                    else
                    {
                        //Executa o método Alterar, mostra a mensagem de sucesso, lista as modalidades e depois limpa os campos.
                        novaModalidade.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, Convert.ToDecimal(txtMensalidade.Text), Convert.ToInt32(cboProfessor));
                        MessageBox.Show("Modalidade alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listarModalidades();
                        Limpar();
                    }
                    
                }
            }
            catch (Exception ex) //Captura a exceção e aparece a mensagem de erro.
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método responsável por limpar todos os componentes do formulário frmModalidades.
        private void Limpar()
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtMensalidade.Clear();
            cboProfessor.SelectedIndex = -1;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dtgModalidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                novaModalidade = new Modalidades();

                if (dtgModalidade.Columns[e.ColumnIndex].Name == "btnEditar") //Se for a coluna com o nome "btnEditar"
                {
                    //Atribui aos txts a respectiva linha clicada do DataGrid 
                    txtCodigo.Text = dtgModalidade.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                    txtMensalidade.Text = dtgModalidade.Rows[e.RowIndex].Cells["MENSALIDADE"].Value.ToString();
                    txtNome.Text = dtgModalidade.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
                    cboProfessor.Text = dtgModalidade.Rows[e.RowIndex].Cells["PROFESSOR"].Value.ToString();
                }
                else
                {
                    if (dtgModalidade.Columns[e.ColumnIndex].Name == "btnExcluir" &&  //Se for a coluna com o nome "btnEditar"
                        MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Exclui o registro com base no id do código
                        novaModalidade.Excluir(Convert.ToInt32(dtgModalidade.Rows[e.RowIndex].Cells["CODIGO"].Value));
                        MessageBox.Show("Modalidade excluída com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listarModalidades();
                        Limpar();
                    }
                    else
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            novaModalidade = new Modalidades();

            try
            {
                if (rbModalidade.Checked == true)
                {
                    dtgModalidade.DataSource = novaModalidade.PesquisarNomeModalidade(txtPesquisa.Text);
                }
                else
                {
                    dtgModalidade.DataSource = novaModalidade.PesquisarNomeProfessor(txtPesquisa.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
