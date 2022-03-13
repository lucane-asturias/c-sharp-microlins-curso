using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPropriedadesCheckBox
{
    public partial class frmPropriedadesCheckBox : Form
    {
        public frmPropriedadesCheckBox()
        {
            InitializeComponent();
        }

        private void chkPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPessoaFisica.Checked == true)
            {
                pnlPessoaFisica.Visible = true;
            }
            else
            {
                pnlPessoaFisica.Visible = false;
            }
        }

        private void chkPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPessoaJuridica.Checked == true)
            {
                pnlPessoaJuridica.Visible = true;
            }
            else
            {
                pnlPessoaJuridica.Visible = false;
            }
        }
    }
}
