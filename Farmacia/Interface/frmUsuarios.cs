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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        RegraNegocio.UsuariosRegraNegocio novoUsuario;
        RegraNegocio.NiveisRegraNegocio novoNivel;

        private void btnNiveis_Click(object sender, EventArgs e)
        {
            frmNiveis niveis = new frmNiveis();
            niveis.Show();
        }

        private void Limpar()
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            dtpDataCadastro.Value = DateTime.Today;
            txtLogin.Clear();
            cboNivel.SelectedIndex = -1;
            txtSenha.Clear();
            txtRedigite.Clear();
            cboStatus.SelectedIndex = -1;
        }

        public void ListarNivel()
        {
            try
            {
                novoNivel = new RegraNegocio.NiveisRegraNegocio();

                cboNivel.DataSource = novoNivel.Listar();
                cboNivel.DisplayMember = "NOME_NIVEL";
                cboNivel.ValueMember = "ID_NIVEL";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ListarNivel();
            ListarUsuarios();
            OrdenarColunas();
            cboNivel.SelectedIndex = -1;
        }

        private void OrdenarColunas()
        {
            dtgUsuarios.Columns["LOGIN_USUARIO"].DisplayIndex = 0;
            dtgUsuarios.Columns["STATUS_USUARIO"].DisplayIndex = 1;
            dtgUsuarios.Columns["NOME_NIVEL"].DisplayIndex = 2;
        }

        private void ListarUsuarios()
        {
            try
            {
                novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                dtgUsuarios.DataSource = novoUsuario.Listar();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                    novoUsuario.Salvar(txtNome.Text, dtpDataCadastro.Value.Date, txtLogin.Text, txtSenha.Text, txtRedigite.Text,
                                       cboStatus.Text, Convert.ToInt32(cboNivel.SelectedValue));
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarUsuarios();
                    OrdenarColunas();
                    Limpar();
                }
                else
                {
                    novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                    novoUsuario.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, dtpDataCadastro.Value.Date, txtLogin.Text, txtSenha.Text,
                                        txtRedigite.Text, cboStatus.Text, Convert.ToInt32(cboNivel.SelectedValue));
                    MessageBox.Show("Usuário alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgUsuarios.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                txtCodigo.Text = dtgUsuarios.Rows[e.RowIndex].Cells["ID_USUARIO"].Value.ToString();
                txtNome.Text = dtgUsuarios.Rows[e.RowIndex].Cells["NOME_USUARIO"].Value.ToString();
                dtpDataCadastro.Value = Convert.ToDateTime(dtgUsuarios.Rows[e.RowIndex].Cells["DATA_CADASTRO"].Value.ToString());
                txtLogin.Text = dtgUsuarios.Rows[e.RowIndex].Cells["LOGIN_USUARIO"].Value.ToString();
                cboNivel.Text = dtgUsuarios.Rows[e.RowIndex].Cells["NOME_NIVEL"].Value.ToString();
                txtSenha.Text = dtgUsuarios.Rows[e.RowIndex].Cells["SENHA_USUARIO"].Value.ToString();
                cboStatus.Text = dtgUsuarios.Rows[e.RowIndex].Cells["STATUS_USUARIO"].Value.ToString();
            }
            else if (dtgUsuarios.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                 MessageBox.Show("Deseja realmente excluir?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                novoUsuario.Excluir(Convert.ToInt32(dtgUsuarios.Rows[e.RowIndex].Cells["ID_USUARIO"].Value));
                MessageBox.Show("Usuário excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
