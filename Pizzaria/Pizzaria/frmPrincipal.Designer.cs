namespace Pizzaria
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPizzas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPedidos = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbEspera = new System.Windows.Forms.CheckBox();
            this.cbEntregue = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.SITUACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TAMANHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_SABOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTREGUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_SABOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_TAMANHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoTableAdapter1 = new Pizzaria.PizzariaDataSetTableAdapters.PedidoTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.toolStripSeparator1,
            this.btnPizzas,
            this.toolStripSeparator2,
            this.btnPedidos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(908, 73);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::Pizzaria.Properties.Resources.Clientes_ToolStrip;
            this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(65, 70);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
            // 
            // btnPizzas
            // 
            this.btnPizzas.Image = global::Pizzaria.Properties.Resources.PlZZA;
            this.btnPizzas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPizzas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPizzas.Name = "btnPizzas";
            this.btnPizzas.Size = new System.Drawing.Size(53, 70);
            this.btnPizzas.Text = "Pizzas";
            this.btnPizzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPizzas.Click += new System.EventHandler(this.btnPizzas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Image = global::Pizzaria.Properties.Resources.Pedidos;
            this.btnPedidos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(66, 70);
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.cbEspera);
            this.groupBox1.Controls.Add(this.cbEntregue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(459, 92);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(380, 30);
            this.txtNomeCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Busque o pedido pelo nome do cliente:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(318, 151);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(175, 49);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbEspera
            // 
            this.cbEspera.AutoSize = true;
            this.cbEspera.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspera.Location = new System.Drawing.Point(262, 90);
            this.cbEspera.Name = "cbEspera";
            this.cbEspera.Size = new System.Drawing.Size(123, 30);
            this.cbEspera.TabIndex = 2;
            this.cbEspera.Text = "À Espera";
            this.cbEspera.UseVisualStyleBackColor = true;
            this.cbEspera.CheckedChanged += new System.EventHandler(this.cbEspera_CheckedChanged);
            // 
            // cbEntregue
            // 
            this.cbEntregue.AutoSize = true;
            this.cbEntregue.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEntregue.Location = new System.Drawing.Point(262, 54);
            this.cbEntregue.Name = "cbEntregue";
            this.cbEntregue.Size = new System.Drawing.Size(126, 30);
            this.cbEntregue.TabIndex = 1;
            this.cbEntregue.Text = "Entregue";
            this.cbEntregue.UseVisualStyleBackColor = true;
            this.cbEntregue.CheckedChanged += new System.EventHandler(this.cbEntregue_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Situação do Pedido:";
            // 
            // dtgPedidos
            // 
            this.dtgPedidos.AllowUserToAddRows = false;
            this.dtgPedidos.AllowUserToDeleteRows = false;
            this.dtgPedidos.AllowUserToResizeColumns = false;
            this.dtgPedidos.AllowUserToResizeRows = false;
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SITUACAO,
            this.ID_PEDIDO,
            this.ID_CLIENTE,
            this.ID_TAMANHO,
            this.ID_SABOR,
            this.ENTREGUE,
            this.NOME_CLIENTE,
            this.NOME_SABOR,
            this.NOME_TAMANHO,
            this.TOTAL});
            this.dtgPedidos.Location = new System.Drawing.Point(12, 332);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.ReadOnly = true;
            this.dtgPedidos.RowHeadersVisible = false;
            this.dtgPedidos.RowTemplate.Height = 24;
            this.dtgPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPedidos.Size = new System.Drawing.Size(878, 334);
            this.dtgPedidos.TabIndex = 2;
            // 
            // SITUACAO
            // 
            this.SITUACAO.HeaderText = "Situação";
            this.SITUACAO.Name = "SITUACAO";
            this.SITUACAO.ReadOnly = true;
            this.SITUACAO.Width = 110;
            // 
            // ID_PEDIDO
            // 
            this.ID_PEDIDO.DataPropertyName = "ID_PEDIDO";
            this.ID_PEDIDO.HeaderText = "Código";
            this.ID_PEDIDO.Name = "ID_PEDIDO";
            this.ID_PEDIDO.ReadOnly = true;
            this.ID_PEDIDO.Width = 75;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "ID_CLIENTE";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Visible = false;
            // 
            // ID_TAMANHO
            // 
            this.ID_TAMANHO.DataPropertyName = "ID_TAMANHO";
            this.ID_TAMANHO.HeaderText = "ID_TAMANHO";
            this.ID_TAMANHO.Name = "ID_TAMANHO";
            this.ID_TAMANHO.ReadOnly = true;
            this.ID_TAMANHO.Visible = false;
            // 
            // ID_SABOR
            // 
            this.ID_SABOR.DataPropertyName = "ID_SABOR";
            this.ID_SABOR.HeaderText = "ID_SABOR";
            this.ID_SABOR.Name = "ID_SABOR";
            this.ID_SABOR.ReadOnly = true;
            this.ID_SABOR.Visible = false;
            // 
            // ENTREGUE
            // 
            this.ENTREGUE.DataPropertyName = "ENTREGUE";
            this.ENTREGUE.HeaderText = "ENTREGUE";
            this.ENTREGUE.Name = "ENTREGUE";
            this.ENTREGUE.ReadOnly = true;
            this.ENTREGUE.Visible = false;
            // 
            // NOME_CLIENTE
            // 
            this.NOME_CLIENTE.DataPropertyName = "NOME_CLIENTE";
            this.NOME_CLIENTE.HeaderText = "Cliente";
            this.NOME_CLIENTE.Name = "NOME_CLIENTE";
            this.NOME_CLIENTE.ReadOnly = true;
            this.NOME_CLIENTE.Width = 210;
            // 
            // NOME_SABOR
            // 
            this.NOME_SABOR.DataPropertyName = "NOME_SABOR";
            this.NOME_SABOR.HeaderText = "Sabor";
            this.NOME_SABOR.Name = "NOME_SABOR";
            this.NOME_SABOR.ReadOnly = true;
            this.NOME_SABOR.Width = 140;
            // 
            // NOME_TAMANHO
            // 
            this.NOME_TAMANHO.DataPropertyName = "NOME_TAMANHO";
            this.NOME_TAMANHO.HeaderText = "Tamanho";
            this.NOME_TAMANHO.Name = "NOME_TAMANHO";
            this.NOME_TAMANHO.ReadOnly = true;
            this.NOME_TAMANHO.Width = 110;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "Total";
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 110;
            // 
            // pedidoTableAdapter1
            // 
            this.pedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 678);
            this.Controls.Add(this.dtgPedidos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    " Sistema de Controle de Pizzaria";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPedidos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPizzas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbEspera;
        private System.Windows.Forms.CheckBox cbEntregue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn SITUACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TAMANHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SABOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTREGUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_SABOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_TAMANHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private PizzariaDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter1;
    }
}

