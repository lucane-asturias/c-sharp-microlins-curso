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
    public partial class frmHorarios : Form
    {
        Horarios novoHorario = new Horarios();

        //Variáveis que irão trazer os respectivos valores da turma selecionada no DataGridView do frmTurmas.
        private int codigo;
        private string modalidade, turma;
        private int idHorario;

        public frmHorarios(int codigo, string modalidade, string turma)
        {
            InitializeComponent();

            //As variáveis declaradas receberão os valores do CODIGO, MODALIDADE e NUMERO que foram passadas para o frmHorário no dtgTurmas.
            this.codigo = codigo;
            this.modalidade = modalidade;
            this.turma = turma;

            ListarHorarios();
        }

        //Método construtor do formulário que vai trazer as informações da turma selecionada.
        private void frmHorarios_Load(object sender, EventArgs e)
        {
            try
            {
                //O nome da modalidade escolhida e o número da turma ficará na barra de títulos do formulário.
                this.Text = modalidade + " - Turma: " + turma;

                cboDia.SelectedIndex = 0; //Mostra a primeira linha do índice do cboDia
                ListarHorarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Estilo();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cboDia.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um dia da semana", "Operação inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    novoHorario = new Horarios();

                    if (idHorario == 0)
                    {
                        novoHorario.Salvar(codigo, Convert.ToString(cboDia.SelectedItem), Convert.ToString(dtpInicio.Value), Convert.ToString(dtpFim.Value));
                        MessageBox.Show("Horário adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        ListarHorarios();
                    }
                    else
                    {
                        novoHorario.Alterar(idHorario, codigo, Convert.ToString(cboDia.SelectedItem), Convert.ToString(dtpInicio.Value), Convert.ToString(dtpFim.Value));
                        MessageBox.Show("Horário alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        ListarHorarios();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                novoHorario = new Horarios();

                if (MessageBox.Show("Deseja realmente excluir esse horário?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    novoHorario.Excluir(Convert.ToInt32(dtgHorarios.Rows[dtgHorarios.CurrentRow.Index].Cells["CODIGO_HORARIO"].Value));
                    MessageBox.Show("Horário excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    ListarHorarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            novoHorario = new Horarios();

            try
            {
                if (idHorario == 0)
                {
                    MessageBox.Show("Selecione um registro para editar", "Selecione um registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    novoHorario.Alterar(idHorario, codigo, Convert.ToString(cboDia.SelectedItem), Convert.ToString(dtpInicio.Value), Convert.ToString(dtpFim.Value));
                    MessageBox.Show("Horário alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    ListarHorarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            idHorario = 0;
            cboDia.SelectedIndex = 0;
            dtpInicio.Value = DateTime.Now;
            dtpFim.Value = DateTime.Now;
        }

        private void dtgHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idHorario = Convert.ToInt32(dtgHorarios.Rows[e.RowIndex].Cells["ID_HORARIO"].Value);
            cboDia.SelectedItem = Convert.ToString(dtgHorarios.Rows[e.RowIndex].Cells["DIA_SEMANA"].Value);
            dtpInicio.Value = Convert.ToDateTime(dtgHorarios.Rows[e.RowIndex].Cells["INICIO"].Value.ToString());
            dtpFim.Value = Convert.ToDateTime(dtgHorarios.Rows[e.RowIndex].Cells["FIM"].Value.ToString());
        }

        private void ListarHorarios()
        {
            try
            {
                novoHorario = new Horarios();
                /*dtgHorarios.Columns[2].DefaultCellStyle.Format = "HH:mm";
                dtgHorarios.Columns[3].DefaultCellStyle.Format = "HH:mm";*/
                dtgHorarios.DataSource = novoHorario.Listar(codigo); //Busca apenas os registros de horários da turma selecionada
                Estilo();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método que faz as linhas do dtgHorarios apresentarem cores intercaladas.
        private void Estilo()
        {
            int linhas = dtgHorarios.Rows.Count; //Calcula a quantidade de linhas 

            for (int i = 0; i < linhas; i++)
            {
                dtgHorarios.Rows[i].DefaultCellStyle.BackColor = Color.SteelBlue;
                i++;

            }
        }
    }
}
