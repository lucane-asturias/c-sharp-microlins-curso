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
    public partial class frmCategorias : Form
    {
        frmProdutos formularioProdutos;

        public frmCategorias(frmProdutos formulario)
        {
            InitializeComponent();
            formularioProdutos = formulario;
        }

        RegraNegocio.CategoriasRegraNegocio novaCategoria;

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
                    novaCategoria = new RegraNegocio.CategoriasRegraNegocio();
                    novaCategoria.Salvar(txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Categoria cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarCategoria();
                    Limpar();
                    txtNome.Focus();

                    formularioProdutos.ListarCategorias(); //Atualiza o cboCategoria do formulario Produtos com o novo cadastro.
                }
                else
                {
                    novaCategoria = new RegraNegocio.CategoriasRegraNegocio();
                    novaCategoria.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Categoria alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarCategoria();
                    Limpar();
                    txtNome.Focus();

                    formularioProdutos.ListarCategorias(); //Atualiza o cboCategoria do formulario Produtos com o cadastro alterado.
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarCategoria()
        {
            try
            {
                novaCategoria = new RegraNegocio.CategoriasRegraNegocio();
                dtgCategorias.DataSource = novaCategoria.Listar();

                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgCategorias.Rows.Count; i += 2)
            {
                dtgCategorias.Rows[i].DefaultCellStyle.ForeColor = Color.LightSteelBlue;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgCategorias.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    txtCodigo.Text = dtgCategorias.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                    txtNome.Text = dtgCategorias.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
                    txtDescricao.Text = dtgCategorias.Rows[e.RowIndex].Cells["DESCRICAO"].Value.ToString();
                }
                else if (dtgCategorias.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                        MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novaCategoria = new RegraNegocio.CategoriasRegraNegocio();
                    novaCategoria.Excluir(Convert.ToInt32(dtgCategorias.Rows[e.RowIndex].Cells["IDCLIENTE"].Value));
                    MessageBox.Show("Categoria excluída com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            ListarCategoria();
        }
    }
}
