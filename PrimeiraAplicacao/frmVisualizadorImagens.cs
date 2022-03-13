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
    public partial class frmVisualizadorImagens : Form
    {
        public frmVisualizadorImagens()
        {
            InitializeComponent();
        }

        private void btnMostrarImagem_Click(object sender, EventArgs e)
        {
            if (ofdImagens.ShowDialog() == DialogResult.OK)
            {
                pbImagens.Load(ofdImagens.FileName); //a imagem selecionada será exibida no picturebox
                btnMostrarImagem.Enabled = false; //desabilita o botão Mostrar Imagem
            }
        }

        private void rbStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStretch.Checked == true) //se o RadioButton Stretch estiver marcado
            {
                pbImagens.SizeMode = PictureBoxSizeMode.StretchImage; //a propriedade SizeMode da imagem no PB ficará Stretch
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked == true) //se o RadioButton Normal estiver marcado
            {
                pbImagens.SizeMode = PictureBoxSizeMode.Normal; //a propriedade SizeMode da imagem no PB ficará Normal
            }
        }

        private void btnLimparImagem_Click(object sender, EventArgs e)
        {
            pbImagens.Image = null; //limpa a imagem do PictureBox pbImagens
            btnMostrarImagem.Enabled = true; //habilita o botão Mostrar Imagem
        }
    }
}
