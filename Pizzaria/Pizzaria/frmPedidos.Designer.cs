namespace Pizzaria
{
    partial class frmPedidos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            System.Windows.Forms.Label iD_PEDIDOLabel;
            System.Windows.Forms.Label iD_CLIENTELabel;
            System.Windows.Forms.Label iD_TAMANHOLabel;
            System.Windows.Forms.Label iD_SABORLabel;
            System.Windows.Forms.Label tOTALLabel;
            System.Windows.Forms.Label eNTREGUELabel;
            this.pizzariaDataSet = new Pizzaria.PizzariaDataSet();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new Pizzaria.PizzariaDataSetTableAdapters.PedidoTableAdapter();
            this.tableAdapterManager = new Pizzaria.PizzariaDataSetTableAdapters.TableAdapterManager();
            this.pedidoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pedidoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_PEDIDOTextBox = new System.Windows.Forms.TextBox();
            this.iD_CLIENTEComboBox = new System.Windows.Forms.ComboBox();
            this.iD_TAMANHOComboBox = new System.Windows.Forms.ComboBox();
            this.iD_SABORComboBox = new System.Windows.Forms.ComboBox();
            this.tOTALTextBox = new System.Windows.Forms.TextBox();
            this.eNTREGUECheckBox = new System.Windows.Forms.CheckBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Pizzaria.PizzariaDataSetTableAdapters.ClienteTableAdapter();
            this.tamanhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tamanhoTableAdapter = new Pizzaria.PizzariaDataSetTableAdapters.TamanhoTableAdapter();
            this.saborBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saborTableAdapter = new Pizzaria.PizzariaDataSetTableAdapters.SaborTableAdapter();
            this.vALORTextBox = new System.Windows.Forms.TextBox();
            iD_PEDIDOLabel = new System.Windows.Forms.Label();
            iD_CLIENTELabel = new System.Windows.Forms.Label();
            iD_TAMANHOLabel = new System.Windows.Forms.Label();
            iD_SABORLabel = new System.Windows.Forms.Label();
            tOTALLabel = new System.Windows.Forms.Label();
            eNTREGUELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pizzariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).BeginInit();
            this.pedidoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamanhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saborBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pizzariaDataSet
            // 
            this.pizzariaDataSet.DataSetName = "PizzariaDataSet";
            this.pizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.pizzariaDataSet;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.PedidoTableAdapter = this.pedidoTableAdapter;
            this.tableAdapterManager.SaborTableAdapter = this.saborTableAdapter;
            this.tableAdapterManager.TamanhoTableAdapter = this.tamanhoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Pizzaria.PizzariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pedidoBindingNavigator
            // 
            this.pedidoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pedidoBindingNavigator.BindingSource = this.pedidoBindingSource;
            this.pedidoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pedidoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pedidoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pedidoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pedidoBindingNavigatorSaveItem});
            this.pedidoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pedidoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pedidoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pedidoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pedidoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pedidoBindingNavigator.Name = "pedidoBindingNavigator";
            this.pedidoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pedidoBindingNavigator.Size = new System.Drawing.Size(565, 27);
            this.pedidoBindingNavigator.TabIndex = 0;
            this.pedidoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pedidoBindingNavigatorSaveItem
            // 
            this.pedidoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pedidoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidoBindingNavigatorSaveItem.Image")));
            this.pedidoBindingNavigatorSaveItem.Name = "pedidoBindingNavigatorSaveItem";
            this.pedidoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.pedidoBindingNavigatorSaveItem.Text = "Save Data";
            this.pedidoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pedidoBindingNavigatorSaveItem_Click_1);
            // 
            // iD_PEDIDOLabel
            // 
            iD_PEDIDOLabel.AutoSize = true;
            iD_PEDIDOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_PEDIDOLabel.Location = new System.Drawing.Point(55, 82);
            iD_PEDIDOLabel.Name = "iD_PEDIDOLabel";
            iD_PEDIDOLabel.Size = new System.Drawing.Size(81, 25);
            iD_PEDIDOLabel.TabIndex = 1;
            iD_PEDIDOLabel.Text = "Código:";
            // 
            // iD_PEDIDOTextBox
            // 
            this.iD_PEDIDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "ID_PEDIDO", true));
            this.iD_PEDIDOTextBox.Enabled = false;
            this.iD_PEDIDOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_PEDIDOTextBox.Location = new System.Drawing.Point(175, 82);
            this.iD_PEDIDOTextBox.Name = "iD_PEDIDOTextBox";
            this.iD_PEDIDOTextBox.Size = new System.Drawing.Size(73, 30);
            this.iD_PEDIDOTextBox.TabIndex = 2;
            // 
            // iD_CLIENTELabel
            // 
            iD_CLIENTELabel.AutoSize = true;
            iD_CLIENTELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_CLIENTELabel.Location = new System.Drawing.Point(57, 126);
            iD_CLIENTELabel.Name = "iD_CLIENTELabel";
            iD_CLIENTELabel.Size = new System.Drawing.Size(79, 25);
            iD_CLIENTELabel.TabIndex = 3;
            iD_CLIENTELabel.Text = "Cliente:";
            // 
            // iD_CLIENTEComboBox
            // 
            this.iD_CLIENTEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pedidoBindingSource, "ID_CLIENTE", true));
            this.iD_CLIENTEComboBox.DataSource = this.clienteBindingSource;
            this.iD_CLIENTEComboBox.DisplayMember = "NOME_CLIENTE";
            this.iD_CLIENTEComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_CLIENTEComboBox.FormattingEnabled = true;
            this.iD_CLIENTEComboBox.Location = new System.Drawing.Point(175, 126);
            this.iD_CLIENTEComboBox.Name = "iD_CLIENTEComboBox";
            this.iD_CLIENTEComboBox.Size = new System.Drawing.Size(320, 33);
            this.iD_CLIENTEComboBox.TabIndex = 4;
            this.iD_CLIENTEComboBox.ValueMember = "ID_CLIENTE";
            // 
            // iD_TAMANHOLabel
            // 
            iD_TAMANHOLabel.AutoSize = true;
            iD_TAMANHOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_TAMANHOLabel.Location = new System.Drawing.Point(34, 173);
            iD_TAMANHOLabel.Name = "iD_TAMANHOLabel";
            iD_TAMANHOLabel.Size = new System.Drawing.Size(102, 25);
            iD_TAMANHOLabel.TabIndex = 5;
            iD_TAMANHOLabel.Text = "Tamanho:";
            // 
            // iD_TAMANHOComboBox
            // 
            this.iD_TAMANHOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pedidoBindingSource, "ID_TAMANHO", true));
            this.iD_TAMANHOComboBox.DataSource = this.tamanhoBindingSource;
            this.iD_TAMANHOComboBox.DisplayMember = "NOME_TAMANHO";
            this.iD_TAMANHOComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_TAMANHOComboBox.FormattingEnabled = true;
            this.iD_TAMANHOComboBox.Location = new System.Drawing.Point(175, 173);
            this.iD_TAMANHOComboBox.Name = "iD_TAMANHOComboBox";
            this.iD_TAMANHOComboBox.Size = new System.Drawing.Size(170, 33);
            this.iD_TAMANHOComboBox.TabIndex = 6;
            this.iD_TAMANHOComboBox.ValueMember = "ID_TAMANHO";
            // 
            // iD_SABORLabel
            // 
            iD_SABORLabel.AutoSize = true;
            iD_SABORLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_SABORLabel.Location = new System.Drawing.Point(65, 220);
            iD_SABORLabel.Name = "iD_SABORLabel";
            iD_SABORLabel.Size = new System.Drawing.Size(71, 25);
            iD_SABORLabel.TabIndex = 7;
            iD_SABORLabel.Text = "Sabor:";
            // 
            // iD_SABORComboBox
            // 
            this.iD_SABORComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pedidoBindingSource, "ID_SABOR", true));
            this.iD_SABORComboBox.DataSource = this.saborBindingSource;
            this.iD_SABORComboBox.DisplayMember = "NOME_SABOR";
            this.iD_SABORComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_SABORComboBox.FormattingEnabled = true;
            this.iD_SABORComboBox.Location = new System.Drawing.Point(175, 220);
            this.iD_SABORComboBox.Name = "iD_SABORComboBox";
            this.iD_SABORComboBox.Size = new System.Drawing.Size(170, 33);
            this.iD_SABORComboBox.TabIndex = 8;
            this.iD_SABORComboBox.ValueMember = "ID_SABOR";
            // 
            // tOTALLabel
            // 
            tOTALLabel.AutoSize = true;
            tOTALLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tOTALLabel.Location = new System.Drawing.Point(74, 267);
            tOTALLabel.Name = "tOTALLabel";
            tOTALLabel.Size = new System.Drawing.Size(62, 25);
            tOTALLabel.TabIndex = 9;
            tOTALLabel.Text = "Total:";
            // 
            // tOTALTextBox
            // 
            this.tOTALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "TOTAL", true));
            this.tOTALTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOTALTextBox.Location = new System.Drawing.Point(175, 267);
            this.tOTALTextBox.Name = "tOTALTextBox";
            this.tOTALTextBox.Size = new System.Drawing.Size(121, 30);
            this.tOTALTextBox.TabIndex = 10;
            // 
            // eNTREGUELabel
            // 
            eNTREGUELabel.AutoSize = true;
            eNTREGUELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eNTREGUELabel.Location = new System.Drawing.Point(39, 310);
            eNTREGUELabel.Name = "eNTREGUELabel";
            eNTREGUELabel.Size = new System.Drawing.Size(95, 25);
            eNTREGUELabel.TabIndex = 11;
            eNTREGUELabel.Text = "Situação:";
            // 
            // eNTREGUECheckBox
            // 
            this.eNTREGUECheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pedidoBindingSource, "ENTREGUE", true));
            this.eNTREGUECheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eNTREGUECheckBox.Location = new System.Drawing.Point(175, 311);
            this.eNTREGUECheckBox.Name = "eNTREGUECheckBox";
            this.eNTREGUECheckBox.Size = new System.Drawing.Size(121, 32);
            this.eNTREGUECheckBox.TabIndex = 12;
            this.eNTREGUECheckBox.Text = "Entregue";
            this.eNTREGUECheckBox.UseVisualStyleBackColor = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.pizzariaDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tamanhoBindingSource
            // 
            this.tamanhoBindingSource.DataMember = "Tamanho";
            this.tamanhoBindingSource.DataSource = this.pizzariaDataSet;
            // 
            // tamanhoTableAdapter
            // 
            this.tamanhoTableAdapter.ClearBeforeFill = true;
            // 
            // saborBindingSource
            // 
            this.saborBindingSource.DataMember = "Sabor";
            this.saborBindingSource.DataSource = this.pizzariaDataSet;
            // 
            // saborTableAdapter
            // 
            this.saborTableAdapter.ClearBeforeFill = true;
            // 
            // vALORTextBox
            // 
            this.vALORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tamanhoBindingSource, "VALOR", true));
            this.vALORTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vALORTextBox.Location = new System.Drawing.Point(175, 267);
            this.vALORTextBox.Name = "vALORTextBox";
            this.vALORTextBox.Size = new System.Drawing.Size(121, 30);
            this.vALORTextBox.TabIndex = 14;
            this.vALORTextBox.TextChanged += new System.EventHandler(this.vALORTextBox_TextChanged);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 386);
            this.Controls.Add(this.vALORTextBox);
            this.Controls.Add(iD_PEDIDOLabel);
            this.Controls.Add(this.iD_PEDIDOTextBox);
            this.Controls.Add(iD_CLIENTELabel);
            this.Controls.Add(this.iD_CLIENTEComboBox);
            this.Controls.Add(iD_TAMANHOLabel);
            this.Controls.Add(this.iD_TAMANHOComboBox);
            this.Controls.Add(iD_SABORLabel);
            this.Controls.Add(this.iD_SABORComboBox);
            this.Controls.Add(tOTALLabel);
            this.Controls.Add(this.tOTALTextBox);
            this.Controls.Add(eNTREGUELabel);
            this.Controls.Add(this.eNTREGUECheckBox);
            this.Controls.Add(this.pedidoBindingNavigator);
            this.Name = "frmPedidos";
            this.ShowIcon = false;
            this.Text = "                                     Controle de Pedidos - Disk Entregas";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizzariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).EndInit();
            this.pedidoBindingNavigator.ResumeLayout(false);
            this.pedidoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamanhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saborBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PizzariaDataSet pizzariaDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private PizzariaDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private PizzariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pedidoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pedidoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_PEDIDOTextBox;
        private System.Windows.Forms.ComboBox iD_CLIENTEComboBox;
        private System.Windows.Forms.ComboBox iD_TAMANHOComboBox;
        private System.Windows.Forms.ComboBox iD_SABORComboBox;
        private System.Windows.Forms.TextBox tOTALTextBox;
        private System.Windows.Forms.CheckBox eNTREGUECheckBox;
        private PizzariaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private PizzariaDataSetTableAdapters.TamanhoTableAdapter tamanhoTableAdapter;
        private System.Windows.Forms.BindingSource tamanhoBindingSource;
        private PizzariaDataSetTableAdapters.SaborTableAdapter saborTableAdapter;
        private System.Windows.Forms.BindingSource saborBindingSource;
        private System.Windows.Forms.TextBox vALORTextBox;
    }
}