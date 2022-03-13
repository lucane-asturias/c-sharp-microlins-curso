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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes novoCliente = new frmClientes();
            novoCliente.ShowDialog();
        }

        private void btnPizzas_Click(object sender, EventArgs e)
        {
            frmPizzas novaPizza = new frmPizzas();
            novaPizza.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos novoPedido = new frmPedidos();
            novoPedido.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            /* A fonte de dados do DataGridView recebe a consulta RetornarPedido,
               do TableAdapter da tabela Pedidos. */
            dtgPedidos.DataSource = pedidoTableAdapter1.RetornarPedidos();
            verificarPedido();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            /* Evento do botão Pesquisar que verifica qual opção de pesquisa o usuário escolheu,
             * o qual pode ser para mostrar apenas os pedidos entregues ou os que estão à espera.
             * Em cada caso, definimos qual Query, que foi criada no TableAdapter da tabela Pedido,
             * será chamada para retornar os dados específicos para cada opção desta pesquisa. */
            if (cbEntregue.Checked == true)
            {
                dtgPedidos.DataSource = pedidoTableAdapter1.RetornarEntregue();
            }
            else
            {
                if (cbEspera.Checked == true)
                {
                    dtgPedidos.DataSource = pedidoTableAdapter1.RetornarEspera();
                }
                else
                {
                    if (txtNomeCliente.Text == "")
                    {
                        dtgPedidos.DataSource = pedidoTableAdapter1.RetornarPedidos();
                    }
                    else
                    {
                        dtgPedidos.DataSource = pedidoTableAdapter1.RetornarCliente(txtNomeCliente.Text);
                    }
                }
            }

            verificarPedido();

        }
        /* Se for verificada a seleção da caixa do CheckBox destinada à espera do pedido,
         *  serão desabilitados o CheckBox referente à situação da entrega e a caixa de texto do nome do cliente.
         * Senão, os referidos objetos continuam ou voltam a ficar habilitados. */
        private void cbEntregue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEntregue.Checked == true)
            {
                cbEspera.Enabled = false;
                txtNomeCliente.Enabled = false;
            }
            else
            {
                cbEspera.Enabled = true;
                txtNomeCliente.Enabled = true;
            }
        }

        private void cbEspera_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEspera.Checked == true)
            {
                cbEntregue.Enabled = false;
                txtNomeCliente.Enabled = false;
            }
            else
            {
                cbEntregue.Enabled = true;
                txtNomeCliente.Enabled = true;
            }
        }

        private void verificarPedido()
        {

            //variável responsável por armazenar as linhas do DataGridView e sua contagem
            int linhas = dtgPedidos.Rows.Count;

            if (linhas > 0)
            {
                for (int i = 0; i < linhas; i++)
                {
                    if (Convert.ToBoolean(dtgPedidos.Rows[i].Cells["ENTREGUE"].Value = true && cbEntregue.Checked == true))
                    {
                        dtgPedidos.Rows[i].Cells["SITUACAO"].Value = "Entregue";
                        dtgPedidos.Rows[i].Cells["SITUACAO"].Style.BackColor = Color.ForestGreen;
                        dtgPedidos.Rows[i].Cells["SITUACAO"].Style.ForeColor = Color.White;
                    }
                    else
                    {
                        dtgPedidos.Rows[i].Cells["SITUACAO"].Value = "À Espera";
                        dtgPedidos.Rows[i].Cells["SITUACAO"].Style.BackColor = Color.Firebrick;
                        dtgPedidos.Rows[i].Cells["SITUACAO"].Style.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}
