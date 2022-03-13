using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class frmPizzas : Form
    {
        public frmPizzas()
        {
            InitializeComponent();
        }

        public void ListarSabores()
        {
            /* Método para listar todos os sabores no DataGridView, o qual utiliza a query
             * RetornarSabores, criada no tableAdapter que seleciona os registros. */
            dtgSabores.DataSource = saborTableAdapter1.RetornarSabores();
        }

        public void Limpar()
        {
            // Método para limpar os campos do formulário
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtIngredientes.Clear();
        }

        private void frmPizzas_Load(object sender, EventArgs e)
        {
            /* Evento Load do formulário, que carrega os registros no respectivo DataGridView
             * assim que o formulário for carregado/exibido. */
            ListarSabores();
            ListarTamanho();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /* Evento do botão Salvar o qual verifica se o texto no txtCódigo é 0. Se for, ele entende como um
             * novo registro e salvar as informações através da query Salvar, criada no TableAdapter da tabela Sabor.
             * Senão, ele entenderá como uma ação de alteração de um registro e irá atualizar as informações no
             * respectivo campo no banco de dados através da query Alterar, criada no TableAdapter da tabela Sabor. */
            if (txtCodigo.Text == "0")
            {
                saborTableAdapter1.Salvar(txtNome.Text, txtIngredientes.Text);
                MessageBox.Show("Salvo com sucesso!");
                ListarSabores();
                Limpar();
            }
            else
            {
                saborTableAdapter1.Alterar(txtNome.Text, txtIngredientes.Text, Convert.ToInt32(txtCodigo.Text));
                MessageBox.Show("Alterado com sucesso!");
                ListarSabores();
                Limpar();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Evento do botão Novo, o qual chama o método Limpar.
            Limpar();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            /* Evento do botão Pesquisar, o qual utiliza a query RetornarPesquisa criada no TableAdapter
             * da tabela Sabor, que traz os registros de acordo com o nome do Sabor. */        
            dtgSabores.DataSource = saborTableAdapter1.RetornarPesquisa(txtPesquisa.Text); 
        }

        private void dtgSabores_DoubleClick(object sender, EventArgs e)
        {
            /* Evento do DataGridView dtgSabores, o qual através de um duplo clique sobre qualquer uma de suas linhas
             * exibe os dados daquele registro em seus respectivos TextBoxes no formulário. */
            txtCodigo.Text = dtgSabores.Rows[dtgSabores.CurrentRow.Index].Cells["CODIGO"].Value.ToString();
            txtNome.Text = dtgSabores.Rows[dtgSabores.CurrentRow.Index].Cells["NOME"].Value.ToString();
            txtIngredientes.Text = dtgSabores.Rows[dtgSabores.CurrentRow.Index].Cells["INGREDIENTES"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            /* Evento do botão Excluir, o qual verifica se o texto no txtCódigo é 0. Se for, ele não encontrará
             * registros no banco de dados e não deixará excluir. Senão, ele irá excluir o registro selecionado
             * de acordo com o código do mesmo. */
            if (txtCodigo.Text == "0")
            {
                MessageBox.Show("Impossível excluir!");
            }
            else
            {
                saborTableAdapter1.Excluir(Convert.ToInt32(txtCodigo.Text));
                MessageBox.Show("Registro excluído com sucesso!");
                ListarSabores();
                Limpar();
            }
        }

        // Segunda página do TabControl, que se refere ao tamanho das pizzas

        public void ListarTamanho()
        {
            /* Método para listar todos os tamanhos no DataGridView, o qual utiliza a query RetornarTamanho, 
             * criada no tableAdapter que seleciona os registros. */
            dtgTamanho.DataSource = tamanhoTableAdapter1.RetornarTamanho();
        }

        public void LimparTamanho()
        {
            // Método para limpar os campos do formulário
            txtCodigoTamanho.Text = "0";
            txtNomeTamanho.Clear();
            txtValor.Clear();
        }

        private void btnSalvarTamanho_Click(object sender, EventArgs e)
        {
            /* Evento do botão Salvar o qual verifica se o texto no txtCódigo é 0. Se for, ele entende como um
             * novo registro e salvar as informações através da query Salvar, criada no TableAdapter da tabela Tamanho.
             * Senão, ele entenderá como uma ação de alteração de um registro e irá atualizar as informações no
             * respectivo campo no banco de dados através da query AlterarTamanho, criada no TableAdapter da tabela Tamanho. */
            if (txtCodigoTamanho.Text == "0")
            {
                tamanhoTableAdapter1.SalvarTamanho(txtNomeTamanho.Text, Convert.ToDecimal(txtValor.Text));
                MessageBox.Show("Cadastro realizado com sucesso!");
                ListarTamanho();
                LimparTamanho();
            }
            else
            {
                tamanhoTableAdapter1.AlterarTamanho(txtNomeTamanho.Text, Convert.ToDecimal(txtValor.Text), Convert.ToInt32(txtCodigoTamanho.Text));
                MessageBox.Show("Alteração realizada com sucesso!");
                ListarTamanho();
                LimparTamanho();
            }
        }

        private void btnExcluirTamanho_Click(object sender, EventArgs e)
        {
            /* Evento do botão ExcluirTamanho, o qual verifica se o texto no txtCódigo é 0. Se for, ele não encontrará
             * registros no banco de dados e não deixará excluir. Senão, ele irá excluir o registro selecionado
             * de acordo com o código do mesmo. */
            if (txtCodigoTamanho.Text == "0")
            {
                MessageBox.Show("Impossível excluir!");
            }
            else
            {
                tamanhoTableAdapter1.ExcluirTamanho(Convert.ToInt32(txtCodigoTamanho.Text));
                MessageBox.Show("Excluído com sucesso!");
                ListarTamanho();
                LimparTamanho();
            }
        }

        private void btnNovoTamanho_Click(object sender, EventArgs e)
        {
            // Evento do botão NovoTamanho, o qual chama o método LimparTamanho.
            LimparTamanho();
        }

        private void dtgTamanho_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoTamanho.Text = dtgTamanho.Rows[dtgTamanho.CurrentRow.Index].Cells["CODIGO_TAMANHO"].Value.ToString();
            txtNomeTamanho.Text = dtgTamanho.Rows[dtgTamanho.CurrentRow.Index].Cells["NOME_TAMANHO"].Value.ToString();
            txtValor.Text = dtgTamanho.Rows[dtgTamanho.CurrentRow.Index].Cells["VALOR"].Value.ToString();
        }
    }
}
