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
    public partial class frmRetirada : Form
    {
        frmCaixa formularioCaixa;

        public frmRetirada(frmCaixa formularioCaixa)
        {
            InitializeComponent();

            this.formularioCaixa = formularioCaixa;
        }

        Caixa novoCaixa;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                novoCaixa = new Caixa();

                DataTable dadosTabela = new DataTable();
                dadosTabela = novoCaixa.ListarCaixa();

                novoCaixa = new Caixa();
                novoCaixa.SalvarDetalhes(Convert.ToInt32(dadosTabela.Rows[0]["ID_CAIXA"]), Convert.ToDecimal(txtDinheiro.Text), "RETIRADA", cboForma.Text);
                MessageBox.Show("Retirada registrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Chama o método de outro formulário ao confirmar uma retirada, que exibirá os detalhes da ação realizada.
                formularioCaixa.ListarDetalhesCaixa();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
