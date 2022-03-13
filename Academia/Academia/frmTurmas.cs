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
    public partial class frmTurmas : Form
    {
        public frmTurmas()
        {
            InitializeComponent();
        }

        Turmas novaTurma;
        Horarios novoHorario;

        //Lista as modalidades dentro do combobox Modalidade.
        public void listarModalidades()
        {
            try
            {
                Modalidades novaModalidade = new Modalidades();

                //Traz todas as informações da tabela Modalidade, porém, mostrará apenas os nomes e armazenará os códigos de cada um deles [...]
                cboModalidade.DataSource = novaModalidade.Listar(); //conforme a programação abaixo no DisplayMember e ValueMember.
                cboModalidade.DisplayMember = "NOME_MODALIDADE"; //Exibe no ComboBox a coluna NOME_MODALIDADE da tabela Modalidade do bd.
                cboModalidade.ValueMember = "ID_MODALIDADE"; //Armazena o valor do item adicionado no DisplayMember.

                cboModalidade.SelectedIndex = -1; //Define que o componente será apresentado em branco.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTurmas_Load(object sender, EventArgs e)
        {
            listarModalidades();
            listarTurmas();
            ordenarColunas();
        }

        private void ordenarColunas()
        {
            dtgTurmas.Columns["MODALIDADE"].DisplayIndex = 0;
            dtgTurmas.Columns["NUMERO"].DisplayIndex = 1;
            dtgTurmas.Columns["MAXIMO"].DisplayIndex = 2;
            dtgTurmas.Columns["btnEditar"].DisplayIndex = 3;
            dtgTurmas.Columns["btnExcluir"].DisplayIndex = 4;
        }

        //Método responsável por listar as Turmas dentro do DataGridView.
        private void listarTurmas()
        {
            try
            {
                novaTurma = new Turmas();
                dtgTurmas.DataSource = novaTurma.Listar(); //dtgModalidade receberá a lista das modalidades trazidas pelo método Listar.

                
                //implentar algo que não sei

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                novaTurma = new Turmas();

                //Verifica se a seleção dos itens do ComboBox está com seu valor inicial, ie, sem nenhuma seleção.
                if (cboModalidade.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione uma modalidade antes de salvar.", "Selecione um professor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtCodigo.Text == "0")
                    {
                        //Executa o método Salvar, mostra a mensagem de sucesso, lista as modalidades e depois limpa os campos.
                        novaTurma.Salvar(Convert.ToInt32(cboModalidade.SelectedValue), Convert.ToInt32(txtAlunos.Text), txtNumero.Text);
                        MessageBox.Show("Turma registrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listarTurmas();
                        ordenarColunas();
                        Limpar();
                    }
                    else
                    {
                        //Executa o método Alterar, mostra a mensagem de sucesso, lista as modalidades e depois limpa os campos.
                        novaTurma.Alterar(Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(cboModalidade.SelectedValue), Convert.ToInt32(txtAlunos.Text), txtNumero.Text);
                        MessageBox.Show("Turma alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listarTurmas();
                        ordenarColunas();
                        Limpar();
                    }
                    
                }
            }
            catch (Exception ex) //Captura a exceção e aparece a mensagem de erro.
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpar()
        {
            txtCodigo.Text = "0";
            cboModalidade.SelectedIndex = -1;
            txtNumero.Clear();
            txtAlunos.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dtgTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                novaTurma = new Turmas();

                if (dtgTurmas.Columns[e.ColumnIndex].Name == "btnEditar") //Se for a coluna com o nome "btnEditar"
                {
                    //Atribui aos txts a respectiva linha clicada do DataGrid 
                    txtCodigo.Text = dtgTurmas.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                    cboModalidade.Text = dtgTurmas.Rows[e.RowIndex].Cells["MODALIDADE"].Value.ToString();
                    txtNumero.Text = dtgTurmas.Rows[e.RowIndex].Cells["NUMERO"].Value.ToString();
                    txtAlunos.Text = dtgTurmas.Rows[e.RowIndex].Cells["MAXIMO"].Value.ToString();
                }
                else
                {
                    if (dtgTurmas.Columns[e.ColumnIndex].Name == "btnExcluir" &&  //Se for a coluna com o nome "btnEditar"
                        MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Exclui o registro com base no id do código
                        novaTurma.Excluir(Convert.ToInt32(dtgTurmas.Rows[e.RowIndex].Cells["CODIGO"].Value));
                        MessageBox.Show("Modalidade excluída com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listarTurmas();
                        Limpar();
                    }
                    else
                    {
                        if (dtgTurmas.Columns[e.ColumnIndex].Name == "btnHorario" && //Se for a coluna com o nome "btnHorario
                            MessageBox.Show("Deseja cadastrar horários para esta turma?", "Deseja cadastrar horários?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            frmHorarios frm = new frmHorarios(Convert.ToInt32(dtgTurmas.Rows[e.RowIndex].Cells["CODIGO"].Value),
                                dtgTurmas.Rows[e.RowIndex].Cells["MODALIDADE"].Value.ToString(), dtgTurmas.Rows[e.RowIndex].Cells["NUMERO"].Value.ToString());
                                frm.ShowDialog(); //para exibir o formulário e manter o foco nele
                        }
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
            ordenarColunas();
            novaTurma = new Turmas();
            dtgTurmas.DataSource = novaTurma.pesquisarTurma(txtPesquisa.Text);
        }

        private void dtgTurmas_DoubleClick(object sender, EventArgs e)
        {
            novoHorario = new Horarios();
            DataTable dadosTabela = new DataTable(); //Criação de um objeto do tipo DataTable para armazenar os resultados do método Listar em memória.
            dadosTabela = novoHorario.Listar(Convert.ToInt32(dtgTurmas.Rows[dtgTurmas.CurrentRow.Index].Cells["CODIGO"].Value));

            /*Quando não tiver nenhum valor para ser listado, aparecerá uma mensagem para o usuário dentro do DataGridView, dizendo que [...]
             *  não há nada para ser exibido da modalidade selecionada; mas quando tiver horários cadastrados, serão todos listados.  */
            if (dadosTabela.Rows.Count <= 0) //Se a quantidade de valores encontrados no banco de dados for igual ou menor a 0
            {
                int linhas = dtgExibirHorarios.Rows.Count; //Identifica quantas linhas possui o dtgExibirHorarios

                for (int i = 0; i < linhas; i++) //A cada passagem pelo for, uma linha será removida
                {
                    dtgExibirHorarios.Rows.Remove(dtgExibirHorarios.Rows[0]);
                }

                lblHorario.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Nenhum horário cadastrado";  //aprenda mexer com a location da label via codigo
            }
            else
            {
                lblHorario.Visible = false;
                lblAviso.Visible = false;

                /*Se o método Listar encontrar registros de horários para a turma selecionada, armazenará no Datatable,
                 * e assim será pedido para mostrar no dtgExibirHorarios as listagens encontradas */
                dtgExibirHorarios.DataSource = dadosTabela;

                //Para melhorar a aparência do DataGridView, o total de linhas será contado e as suas cores mudarão de forma alternada
                int linhas = dtgExibirHorarios.Rows.Count;
                
                for (int i = 0; i < linhas; i++)
                {
                    dtgExibirHorarios.Rows[i].DefaultCellStyle.BackColor = Color.SteelBlue;
                    i++;
                }
            }

        }
    }
}
