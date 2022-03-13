using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmNiveis : Form
    {
        public frmNiveis()
        {
            InitializeComponent();
        }

        RegraNegocio.NiveisRegraNegocio novoNivel;

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtDescricao.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "0")
                {
                    novoNivel = new RegraNegocio.NiveisRegraNegocio();
                    novoNivel.Salvar(txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Nível cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Listar();
                    Limpar();
                }
                else
                {
                    novoNivel = new RegraNegocio.NiveisRegraNegocio();
                    novoNivel.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Nível alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Listar();
                    Limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar()
        {
            try
            {
                novoNivel = new RegraNegocio.NiveisRegraNegocio();
                dtgNiveis.DataSource = novoNivel.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmNiveis_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dtgNiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgNiveis.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    txtCodigo.Text = dtgNiveis.Rows[e.RowIndex].Cells["ID_NIVEL"].Value.ToString();
                    txtNome.Text = dtgNiveis.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
                    txtDescricao.Text = dtgNiveis.Rows[e.RowIndex].Cells["DESCRICAO"].Value.ToString();
                }
                else if (dtgNiveis.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                    MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novoNivel = new RegraNegocio.NiveisRegraNegocio();
                    novoNivel.Excluir(Convert.ToInt32(dtgNiveis.Rows[e.RowIndex].Cells["ID_PRODUTO"].Value));
                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
