namespace Pizzaria
{
    partial class frmPizzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgSabores = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INGREDIENTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgTamanho = new System.Windows.Forms.DataGridView();
            this.btnExcluirTamanho = new System.Windows.Forms.Button();
            this.btnSalvarTamanho = new System.Windows.Forms.Button();
            this.btnNovoTamanho = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNomeTamanho = new System.Windows.Forms.TextBox();
            this.txtCodigoTamanho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnValor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saborTableAdapter1 = new Pizzaria.PizzariaDataSetTableAdapters.SaborTableAdapter();
            this.tamanhoTableAdapter1 = new Pizzaria.PizzariaDataSetTableAdapters.TamanhoTableAdapter();
            this.CODIGO_TAMANHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_TAMANHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSabores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ingredientes:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 680);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgSabores);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.txtIngredientes);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sabores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgSabores
            // 
            this.dtgSabores.AllowUserToAddRows = false;
            this.dtgSabores.AllowUserToDeleteRows = false;
            this.dtgSabores.AllowUserToResizeColumns = false;
            this.dtgSabores.AllowUserToResizeRows = false;
            this.dtgSabores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSabores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOME,
            this.INGREDIENTES});
            this.dtgSabores.Location = new System.Drawing.Point(12, 450);
            this.dtgSabores.Name = "dtgSabores";
            this.dtgSabores.ReadOnly = true;
            this.dtgSabores.RowHeadersVisible = false;
            this.dtgSabores.RowTemplate.Height = 24;
            this.dtgSabores.Size = new System.Drawing.Size(563, 195);
            this.dtgSabores.TabIndex = 8;
            this.dtgSabores.DoubleClick += new System.EventHandler(this.dtgSabores_DoubleClick);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "ID_SABOR";
            this.CODIGO.HeaderText = "Código";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 75;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME_SABOR";
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 157;
            // 
            // INGREDIENTES
            // 
            this.INGREDIENTES.DataPropertyName = "INGREDIENTES";
            this.INGREDIENTES.HeaderText = "Ingredientes";
            this.INGREDIENTES.Name = "INGREDIENTES";
            this.INGREDIENTES.ReadOnly = true;
            this.INGREDIENTES.Width = 326;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisa);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 88);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(450, 23);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(95, 48);
            this.btnPesquisa.TabIndex = 6;
            this.btnPesquisa.Text = "*icone*";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(12, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(374, 30);
            this.txtPesquisa.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(462, 183);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 48);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(462, 117);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 48);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(462, 51);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 48);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(156, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(249, 30);
            this.txtNome.TabIndex = 3;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.Location = new System.Drawing.Point(17, 151);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(388, 167);
            this.txtIngredientes.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(21, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(83, 27);
            this.txtCodigo.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgTamanho);
            this.tabPage2.Controls.Add(this.btnExcluirTamanho);
            this.tabPage2.Controls.Add(this.btnSalvarTamanho);
            this.tabPage2.Controls.Add(this.btnNovoTamanho);
            this.tabPage2.Controls.Add(this.txtValor);
            this.tabPage2.Controls.Add(this.txtNomeTamanho);
            this.tabPage2.Controls.Add(this.txtCodigoTamanho);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnValor);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tamanho";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgTamanho
            // 
            this.dtgTamanho.AllowUserToAddRows = false;
            this.dtgTamanho.AllowUserToDeleteRows = false;
            this.dtgTamanho.AllowUserToResizeColumns = false;
            this.dtgTamanho.AllowUserToResizeRows = false;
            this.dtgTamanho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTamanho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_TAMANHO,
            this.NOME_TAMANHO,
            this.VALOR});
            this.dtgTamanho.Location = new System.Drawing.Point(12, 214);
            this.dtgTamanho.Name = "dtgTamanho";
            this.dtgTamanho.ReadOnly = true;
            this.dtgTamanho.RowHeadersVisible = false;
            this.dtgTamanho.RowTemplate.Height = 24;
            this.dtgTamanho.Size = new System.Drawing.Size(563, 431);
            this.dtgTamanho.TabIndex = 11;
            this.dtgTamanho.DoubleClick += new System.EventHandler(this.dtgTamanho_DoubleClick);
            // 
            // btnExcluirTamanho
            // 
            this.btnExcluirTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTamanho.Location = new System.Drawing.Point(445, 142);
            this.btnExcluirTamanho.Name = "btnExcluirTamanho";
            this.btnExcluirTamanho.Size = new System.Drawing.Size(95, 44);
            this.btnExcluirTamanho.TabIndex = 4;
            this.btnExcluirTamanho.Text = "Excluir";
            this.btnExcluirTamanho.UseVisualStyleBackColor = true;
            this.btnExcluirTamanho.Click += new System.EventHandler(this.btnExcluirTamanho_Click);
            // 
            // btnSalvarTamanho
            // 
            this.btnSalvarTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTamanho.Location = new System.Drawing.Point(445, 82);
            this.btnSalvarTamanho.Name = "btnSalvarTamanho";
            this.btnSalvarTamanho.Size = new System.Drawing.Size(95, 44);
            this.btnSalvarTamanho.TabIndex = 3;
            this.btnSalvarTamanho.Text = "Salvar";
            this.btnSalvarTamanho.UseVisualStyleBackColor = true;
            this.btnSalvarTamanho.Click += new System.EventHandler(this.btnSalvarTamanho_Click);
            // 
            // btnNovoTamanho
            // 
            this.btnNovoTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoTamanho.Location = new System.Drawing.Point(445, 22);
            this.btnNovoTamanho.Name = "btnNovoTamanho";
            this.btnNovoTamanho.Size = new System.Drawing.Size(95, 44);
            this.btnNovoTamanho.TabIndex = 2;
            this.btnNovoTamanho.Text = "Novo";
            this.btnNovoTamanho.UseVisualStyleBackColor = true;
            this.btnNovoTamanho.Click += new System.EventHandler(this.btnNovoTamanho_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(121, 126);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(128, 30);
            this.txtValor.TabIndex = 1;
            // 
            // txtNomeTamanho
            // 
            this.txtNomeTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTamanho.Location = new System.Drawing.Point(121, 77);
            this.txtNomeTamanho.Name = "txtNomeTamanho";
            this.txtNomeTamanho.Size = new System.Drawing.Size(249, 30);
            this.txtNomeTamanho.TabIndex = 0;
            // 
            // txtCodigoTamanho
            // 
            this.txtCodigoTamanho.Enabled = false;
            this.txtCodigoTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoTamanho.Location = new System.Drawing.Point(121, 32);
            this.txtCodigoTamanho.Name = "txtCodigoTamanho";
            this.txtCodigoTamanho.Size = new System.Drawing.Size(83, 30);
            this.txtCodigoTamanho.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Código:";
            // 
            // btnValor
            // 
            this.btnValor.AutoSize = true;
            this.btnValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValor.Location = new System.Drawing.Point(36, 129);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(70, 25);
            this.btnValor.TabIndex = 5;
            this.btnValor.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nome:";
            // 
            // saborTableAdapter1
            // 
            this.saborTableAdapter1.ClearBeforeFill = true;
            // 
            // tamanhoTableAdapter1
            // 
            this.tamanhoTableAdapter1.ClearBeforeFill = true;
            // 
            // CODIGO_TAMANHO
            // 
            this.CODIGO_TAMANHO.DataPropertyName = "ID_TAMANHO";
            this.CODIGO_TAMANHO.HeaderText = "Código";
            this.CODIGO_TAMANHO.Name = "CODIGO_TAMANHO";
            this.CODIGO_TAMANHO.ReadOnly = true;
            this.CODIGO_TAMANHO.Width = 75;
            // 
            // NOME_TAMANHO
            // 
            this.NOME_TAMANHO.DataPropertyName = "NOME_TAMANHO";
            this.NOME_TAMANHO.HeaderText = "Nome";
            this.NOME_TAMANHO.Name = "NOME_TAMANHO";
            this.NOME_TAMANHO.ReadOnly = true;
            this.NOME_TAMANHO.Width = 220;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "VALOR";
            this.VALOR.HeaderText = "Valor";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 190;
            // 
            // frmPizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 680);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPizzas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                Controle de Pizzas";
            this.Load += new System.EventHandler(this.frmPizzas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSabores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTamanho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeTamanho;
        private System.Windows.Forms.TextBox txtCodigoTamanho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluirTamanho;
        private System.Windows.Forms.Button btnSalvarTamanho;
        private System.Windows.Forms.Button btnNovoTamanho;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label btnValor;
        private PizzariaDataSetTableAdapters.SaborTableAdapter saborTableAdapter1;
        private System.Windows.Forms.DataGridView dtgSabores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn INGREDIENTES;
        private System.Windows.Forms.DataGridView dtgTamanho;
        private PizzariaDataSetTableAdapters.TamanhoTableAdapter tamanhoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_TAMANHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_TAMANHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
    }
}