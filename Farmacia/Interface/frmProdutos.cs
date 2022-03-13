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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        RegraNegocio.CategoriasRegraNegocio novaCategoria;
        RegraNegocio.ProdutosRegraNegocio novoProduto;

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            VerificaEstoqueBaixo();
            VerificaCategorias(); //Quando o frmProdutos for acionado, será verificado se existe alguma categoria cadastrada.
            ListarCategorias(); //Lista os nomes das categorias no cboCategoria 
            ListarProdutos(); //Lista os produtos cadastrados no dtgProdutos
            OrdenarColunas(); //Ordena as colunas
            cboCategoria.SelectedIndex = -1; //Mostra o índice -1 do cboCategoria, ou seja, nenhuma informação
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "0")
                {
                    novoProduto = new RegraNegocio.ProdutosRegraNegocio();

                    novoProduto.Salvar(txtCodigoBarras.Text, dtpDataCadastro.Value.Date, txtNome.Text, txtDetalhes.Text, Convert.ToInt32(cboCategoria.SelectedValue),
                    Convert.ToInt32(txtEstoqueMinimo.Text), Convert.ToInt32(txtEstoqueAtual.Text), txtCusto.Text, txtVenda.Text);

                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarProdutos();
                    VerificaEstoqueBaixo();
                    OrdenarColunas();   
                    Limpar();
                }
                else
                {
                    novoProduto = new RegraNegocio.ProdutosRegraNegocio();

                    novoProduto.Alterar(Convert.ToInt32(txtCodigo.Text), txtCodigoBarras.Text, dtpDataCadastro.Value.Date, txtNome.Text, txtDetalhes.Text,
                    Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(txtEstoqueMinimo.Text), Convert.ToInt32(txtEstoqueAtual.Text), txtCusto.Text, txtVenda.Text);

                    MessageBox.Show("Produto alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarProdutos();
                    VerificaEstoqueBaixo();
                    OrdenarColunas();
                    Limpar();
                    txtCodigoBarras.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias(this);
            categorias.Show();
        }

        public void ListarCategorias()
        {
            try
            {
                novaCategoria = new RegraNegocio.CategoriasRegraNegocio();

                cboCategoria.DataSource = novaCategoria.Listar();
                cboCategoria.DisplayMember = "NOME_CATEGORIA";
                cboCategoria.ValueMember = "ID_CATEGORIA";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListarProdutos()
        {
            try
            {
                novoProduto = new RegraNegocio.ProdutosRegraNegocio();
                dtgProdutos.DataSource = novoProduto.Listar();
                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Limpar()
        {
            txtCodigo.Text = "0";
            txtCodigoBarras.Clear();
            dtpDataCadastro.Value = DateTime.Today;
            txtNome.Clear();
            cboCategoria.SelectedIndex = -1;
            txtDetalhes.Clear();
            txtEstoqueMinimo.Text = "0";
            txtEstoqueAtual.Text = "0";
            txtCusto.Text = "0";
            txtVenda.Text = "0";
            txtPesquisa.Clear();
        }

        private void OrdenarColunas()
        {
            dtgProdutos.Columns["CODIGO_BARRAS"].DisplayIndex = 0;
            dtgProdutos.Columns["NOME"].DisplayIndex = 1;
            dtgProdutos.Columns["DETALHES"].DisplayIndex = 2;
            dtgProdutos.Columns["ESTOQUE_ATUAL"].DisplayIndex = 3;
            dtgProdutos.Columns["VENDA"].DisplayIndex = 4;
            dtgProdutos.Columns["CATEGORIA"].DisplayIndex = 5;
            dtgProdutos.Columns["btnEditar"].DisplayIndex = 6;
            dtgProdutos.Columns["btnExcluir"].DisplayIndex = 7;
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgProdutos.Rows.Count; i += 2)
            {
                dtgProdutos.Rows[i].DefaultCellStyle.ForeColor = Color.Honeydew;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbNome.Checked)
                {
                    novoProduto = new RegraNegocio.ProdutosRegraNegocio();
                    dtgProdutos.DataSource = novoProduto.PesquisarNome(txtPesquisa.Text);
                    OrdenarColunas();
                }
                else if (rbCategoria.Checked)
                {
                    novoProduto = new RegraNegocio.ProdutosRegraNegocio();
                    dtgProdutos.DataSource = novoProduto.PesquisarCategoria(txtPesquisa.Text);
                    OrdenarColunas();
                }
                else if (rbCodigoBarras.Checked)
                {
                    novoProduto = new RegraNegocio.ProdutosRegraNegocio();
                    dtgProdutos.DataSource = novoProduto.PesquisarCodigoBarras(txtPesquisa.Text);
                    OrdenarColunas();
                }

                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgProdutos.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    txtCodigo.Text = dtgProdutos.Rows[e.RowIndex].Cells["ID_PRODUTO"].Value.ToString();
                    txtNome.Text = dtgProdutos.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
                    txtCodigoBarras.Text = dtgProdutos.Rows[e.RowIndex].Cells["CODIGO_BARRAS"].Value.ToString();
                    txtDetalhes.Text = dtgProdutos.Rows[e.RowIndex].Cells["DETALHES"].Value.ToString();
                    txtEstoqueMinimo.Text = dtgProdutos.Rows[e.RowIndex].Cells["ESTOQUE_MINIMO"].Value.ToString();
                    txtEstoqueAtual.Text = dtgProdutos.Rows[e.RowIndex].Cells["ESTOQUE_ATUAL"].Value.ToString();
                    txtCusto.Text = dtgProdutos.Rows[e.RowIndex].Cells["CUSTO"].Value.ToString();
                    txtVenda.Text = dtgProdutos.Rows[e.RowIndex].Cells["VENDA"].Value.ToString();
                    cboCategoria.Text = dtgProdutos.Rows[e.RowIndex].Cells["CATEGORIA"].Value.ToString();
                    dtpDataCadastro.Value = Convert.ToDateTime(dtgProdutos.Rows[e.RowIndex].Cells["DATA"].Value);
                }
                else if (dtgProdutos.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                    MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novoProduto = new RegraNegocio.ProdutosRegraNegocio();
                    novoProduto.Excluir(Convert.ToInt32(dtgProdutos.Rows[e.RowIndex].Cells["ID_PRODUTO"].Value));
                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarProdutos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void VerificaCategorias()
        {
            try
            {
                novaCategoria = new RegraNegocio.CategoriasRegraNegocio();

                DataTable dadosTabela = new DataTable();
                dadosTabela = novaCategoria.VerificaCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Método que verifica produtos com estoque baixo e exibe eles num DataGridView.
        private void VerificaEstoqueBaixo()
        {
            try
            {
                novoProduto = new RegraNegocio.ProdutosRegraNegocio();
                dtgEstoqueProdutos.DataSource = novoProduto.VerificaEstoqueBaixo();

                for (int i = 0; i < dtgEstoqueProdutos.Rows.Count; i += 2)
                {
                    dtgEstoqueProdutos.Rows[i].DefaultCellStyle.ForeColor = Color.LightSteelBlue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Quando o usuário der um duplo clique no DataGrid do estoque, os valores serão enviados para suas devidas caixas de textos, a fim de serem alterados.
        private void dtgEstoqueProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                novoProduto = new RegraNegocio.ProdutosRegraNegocio();

                DataTable dadosTabela = new DataTable();
                dadosTabela = novoProduto.PesquisarCodigoBarras(dtgEstoqueProdutos.Rows[dtgEstoqueProdutos.CurrentRow.Index].Cells["CODIGO_BARRAS_PRODUTOS"].Value.ToString());

                txtCodigo.Text = dadosTabela.Rows[0]["ID_PRODUTO"].ToString();
                txtCodigoBarras.Text = dadosTabela.Rows[0]["CODIGO_BARRAS"].ToString();
                txtNome.Text = dadosTabela.Rows[0]["NOME_PRODUTO"].ToString();
                cboCategoria.SelectedValue = dadosTabela.Rows[0]["ID_CATEGORIA"].ToString();
                txtDetalhes.Text = dadosTabela.Rows[0]["DETALHES_PRODUTO"].ToString();
                txtEstoqueMinimo.Text = dadosTabela.Rows[0]["ESTOQUE_MINIMO"].ToString();
                txtEstoqueAtual.Text = dadosTabela.Rows[0]["ESTOQUE_ATUAL"].ToString();
                txtCusto.Text = dadosTabela.Rows[0]["VALOR_CUSTO"].ToString();
                txtVenda.Text = dadosTabela.Rows[0]["VALOR_VENDA"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
