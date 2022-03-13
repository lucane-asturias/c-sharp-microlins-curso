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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        RegraNegocio.ClientesRegraNegocio novoCliente; //Instancia o projeto RegraNegocio

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            dtpNascimento.Value = DateTime.Today;
            txtRG.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtObservacao.Clear();
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgClientes.Rows.Count; i += 2)
            {
                dtgClientes.Rows[i].DefaultCellStyle.ForeColor = Color.Honeydew;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "0")
                {
                    novoCliente = new RegraNegocio.ClientesRegraNegocio();
                    novoCliente.Salvar(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, dtpNascimento.Value.Date, txtRG.Text, txtCPF.Text,
                                       txtTelefone.Text, txtCelular.Text, txtObservacao.Text, dtpDataCadastro.Value.Date);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarClientes();
                }
                else
                {
                    novoCliente = new RegraNegocio.ClientesRegraNegocio();
                    novoCliente.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, dtpNascimento.Value.Date,
                                        txtRG.Text, txtCPF.Text, txtTelefone.Text, txtCelular.Text, txtObservacao.Text, dtpDataCadastro.Value.Date);
                    MessageBox.Show("Cliente alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    txtCodigo.Text = dtgClientes.Rows[e.RowIndex].Cells["IDCLIENTE"].Value.ToString();
                    txtNome.Text = dtgClientes.Rows[e.RowIndex].Cells["NOME_CLIENTE"].Value.ToString();
                    txtEndereco.Text = dtgClientes.Rows[e.RowIndex].Cells["ENDERECO"].Value.ToString();
                    txtBairro.Text = dtgClientes.Rows[e.RowIndex].Cells["BAIRRO"].Value.ToString();
                    txtCidade.Text = dtgClientes.Rows[e.RowIndex].Cells["CIDADE"].Value.ToString();
                    txtTelefone.Text = dtgClientes.Rows[e.RowIndex].Cells["TELEFONE"].Value.ToString();
                    txtCelular.Text = dtgClientes.Rows[e.RowIndex].Cells["CELULAR"].Value.ToString();
                    txtRG.Text = dtgClientes.Rows[e.RowIndex].Cells["RG"].Value.ToString();
                    txtCPF.Text = dtgClientes.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                    txtObservacao.Text = dtgClientes.Rows[e.RowIndex].Cells["OBSERVACAO"].Value.ToString();
                    dtpDataCadastro.Value = Convert.ToDateTime(dtgClientes.Rows[e.RowIndex].Cells["DATA"].Value);
                    dtpNascimento.Value = Convert.ToDateTime(dtgClientes.Rows[e.RowIndex].Cells["NASCIMENTO"].Value);
                }
                else if (dtgClientes.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                        MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novoCliente = new RegraNegocio.ClientesRegraNegocio();
                    novoCliente.Excluir(Convert.ToInt32(dtgClientes.Rows[e.RowIndex].Cells["IDCLIENTE"].Value));
                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarClientes();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListarClientes()
        {
            try
            {
                novoCliente = new RegraNegocio.ClientesRegraNegocio();
                dtgClientes.DataSource = novoCliente.Listar();

                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrdenarColunas()
        {
            dtgClientes.Columns["NOME_CLIENTE"].DisplayIndex = 0;
            dtgClientes.Columns["ENDERECO"].DisplayIndex = 1;
            dtgClientes.Columns["CIDADE"].DisplayIndex = 2;
            dtgClientes.Columns["TELEFONE"].DisplayIndex = 3;
            dtgClientes.Columns["CPF"].DisplayIndex = 4;
            dtgClientes.Columns["btnEditar"].DisplayIndex = 5;
            dtgClientes.Columns["btnExcluir"].DisplayIndex = 6;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
            OrdenarColunas();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            novoCliente = new RegraNegocio.ClientesRegraNegocio();

            try
            {
                if (rbNome.Checked)
                {
                    dtgClientes.DataSource = novoCliente.PesquisarNome(txtPesquisa.Text);
                    OrdenarColunas();
                }
                else if (rbCPF.Checked)
                {
                    dtgClientes.DataSource = novoCliente.PesquisarCPF(txtPesquisa.Text);
                    OrdenarColunas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
