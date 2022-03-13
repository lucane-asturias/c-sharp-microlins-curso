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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            frmPropriedadesCheckBox propriedades = new frmPropriedadesCheckBox(); //instanciação
            propriedades.ShowDialog(); //o formulário é exibido através do ShowDialog
        }

        private void btnImagens_Click(object sender, EventArgs e)
        {
            frmVisualizadorImagens Imagens = new frmVisualizadorImagens(); //instanciação
            Imagens.ShowDialog(); //o formulário é exibido através do ShowDialog
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            frmTabuada tabuada = new frmTabuada();
            tabuada.ShowDialog();
        }

        private void btnYoukoso_Click(object sender, EventArgs e)
        {
            btnCheckBox.Enabled = true; //habilita o botão btnCheckBox
            btnImagens.Enabled = true; //habilita o botão btnImagens
            btnTabuada.Enabled = true; //habilita o botão btnTabuada
        }
    }
}
