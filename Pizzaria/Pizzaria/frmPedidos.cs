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
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzariaDataSet);

        }

        private void pedidoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzariaDataSet);

        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzariaDataSet.Sabor' table. You can move, or remove it, as needed.
            this.saborTableAdapter.Fill(this.pizzariaDataSet.Sabor);
            // TODO: This line of code loads data into the 'pizzariaDataSet.Tamanho' table. You can move, or remove it, as needed.
            this.tamanhoTableAdapter.Fill(this.pizzariaDataSet.Tamanho);
            // TODO: This line of code loads data into the 'pizzariaDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.pizzariaDataSet.Cliente);
            // TODO: This line of code loads data into the 'pizzariaDataSet.Pedido' table. You can move, or remove it, as needed.
            this.pedidoTableAdapter.Fill(this.pizzariaDataSet.Pedido);

        }

        private void vALORTextBox_TextChanged(object sender, EventArgs e)
        {
            tOTALTextBox.Text = vALORTextBox.Text;
        }
    }
}
