using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void consultasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorioDataSet.Consultas' table. You can move, or remove it, as needed.
            this.consultasTableAdapter.Fill(this.consultorioDataSet.Consultas);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rbMedico.Checked == true)
            {
                dtgPesquisas.DataSource = consultasTableAdapter.RetornarMedico(txtPesquisar.Text);
            }
            else
            {
                dtgPesquisas.DataSource = consultasTableAdapter.RetornarPaciente(txtPesquisar.Text);
            }
        }
    }
}
