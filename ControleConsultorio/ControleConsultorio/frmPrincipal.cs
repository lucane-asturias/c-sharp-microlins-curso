using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleConsultorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            //evento Click do btnMedicos em que o formulário frmMedicos é instanciado e exibido
            frmMedicos novoMedico = new frmMedicos();
            novoMedico.ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            //evento CLick do btnPaciente em que o formulário frmPacientes é instanciado e exibido
            frmPacientes novoPaciente = new frmPacientes();
            novoPaciente.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            //evento CLick do btnConsultas em que o formulário frmConsultas é instanciado e exibido
            frmConsultas novaConsulta = new frmConsultas();
            novaConsulta.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            /* Evento do botão pesquisar, o qual traz os registros de acordo com um determinado intervalo de datas
            ou com o nome no textbox e a opção nome ou paciente, indicada no radioButton selecionado
            e para isso é necessário indicar que a fonte desses dados é o respectivo método criado no Table Adapter */

            if (txtPesquisar.Text == "")
            {
                dtgConsultas.DataSource = consultaTableAdapter1.retornarConsultas(dtpPrimeiro.Value);
            }
            else
            {
                if (rbMedico.Checked == true)
                {
                    dtgConsultas.DataSource = consultaTableAdapter1.retornarMedicos(txtPesquisar.Text, dtpPrimeiro.Value,
                        dtpSegundo.Value);
                }
                else
                {
                    if (rbPaciente.Checked == true)
                    {
                        dtgConsultas.DataSource = consultaTableAdapter1.retornarPacientes(txtPesquisar.Text, dtpPrimeiro.Value,
                        dtpSegundo.Value);
                    }
                }
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dtgConsultas.DataSource = consultaTableAdapter1.retornarConsultas(dtpPrimeiro.Value);
        }
    }
}
