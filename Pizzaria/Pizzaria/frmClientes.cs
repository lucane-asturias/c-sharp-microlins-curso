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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzariaDataSet);

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzariaDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.pizzariaDataSet.Cliente);

        }

        private void retornarNomeClienteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.retornarNomeCliente(this.pizzariaDataSet.Cliente, nomeClienteToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void retornarCPFToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.retornarCPF(this.pizzariaDataSet.Cliente, numCPFToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void retornarNomeClienteToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.retornarNomeCliente(this.pizzariaDataSet.Cliente, nomeClienteToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void retornarCPFToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.retornarCPF(this.pizzariaDataSet.Cliente, numCPFToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void retornarClientesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.retornarClientes(this.pizzariaDataSet.Cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
