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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controleConsultorioDataSet);

        }

        private void consultaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controleConsultorioDataSet);

        }

        private void consultaBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controleConsultorioDataSet);

        }

        private void consultaBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controleConsultorioDataSet);

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controleConsultorioDataSet.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.controleConsultorioDataSet.Paciente);
            // TODO: This line of code loads data into the 'controleConsultorioDataSet.Medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.controleConsultorioDataSet.Medico);
            // TODO: This line of code loads data into the 'controleConsultorioDataSet.Consulta' table. You can move, or remove it, as needed.
            this.consultaTableAdapter.Fill(this.controleConsultorioDataSet.Consulta);

        }
    }
}
