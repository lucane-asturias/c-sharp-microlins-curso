using System.Windows.Forms;

namespace Academia
{
    partial class frmCaixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtRetirada = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbLancamentos = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.btnRetirada = new System.Windows.Forms.Button();
            this.btnSuprimento = new System.Windows.Forms.Button();
            this.dtgCaixa = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID_CAIXA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DETALHES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.MOVIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_PAGAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SITUACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gbInformacoes.SuspendLayout();
            this.gbLancamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(128, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(421, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data do pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formas de pagamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movimento";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(220, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 30);
            this.comboBox2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 30);
            this.comboBox1.TabIndex = 0;
            // 
            // gbInformacoes
            // 
            this.gbInformacoes.Controls.Add(this.txtSaldo);
            this.gbInformacoes.Controls.Add(this.txtRetirada);
            this.gbInformacoes.Controls.Add(this.txtEntrada);
            this.gbInformacoes.Controls.Add(this.txtInicial);
            this.gbInformacoes.Controls.Add(this.label7);
            this.gbInformacoes.Controls.Add(this.label6);
            this.gbInformacoes.Controls.Add(this.label5);
            this.gbInformacoes.Controls.Add(this.label4);
            this.gbInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacoes.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbInformacoes.Location = new System.Drawing.Point(916, 23);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Size = new System.Drawing.Size(188, 347);
            this.gbInformacoes.TabIndex = 0;
            this.gbInformacoes.TabStop = false;
            this.gbInformacoes.Text = "Informações";
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.White;
            this.txtSaldo.Location = new System.Drawing.Point(10, 290);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(163, 28);
            this.txtSaldo.TabIndex = 2;
            // 
            // txtRetirada
            // 
            this.txtRetirada.BackColor = System.Drawing.Color.White;
            this.txtRetirada.Location = new System.Drawing.Point(10, 213);
            this.txtRetirada.Name = "txtRetirada";
            this.txtRetirada.Size = new System.Drawing.Size(163, 28);
            this.txtRetirada.TabIndex = 2;
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.Color.White;
            this.txtEntrada.Location = new System.Drawing.Point(10, 137);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(163, 28);
            this.txtEntrada.TabIndex = 2;
            // 
            // txtInicial
            // 
            this.txtInicial.BackColor = System.Drawing.Color.White;
            this.txtInicial.Location = new System.Drawing.Point(10, 67);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(163, 28);
            this.txtInicial.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Saldo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Retirada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Inicial:";
            // 
            // gbLancamentos
            // 
            this.gbLancamentos.Controls.Add(this.btnFechar);
            this.gbLancamentos.Controls.Add(this.btnAbrirCaixa);
            this.gbLancamentos.Controls.Add(this.btnRetirada);
            this.gbLancamentos.Controls.Add(this.btnSuprimento);
            this.gbLancamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLancamentos.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbLancamentos.Location = new System.Drawing.Point(916, 383);
            this.gbLancamentos.Name = "gbLancamentos";
            this.gbLancamentos.Size = new System.Drawing.Size(188, 183);
            this.gbLancamentos.TabIndex = 0;
            this.gbLancamentos.TabStop = false;
            this.gbLancamentos.Text = "Lançamentos";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFechar.Image = global::Academia.Properties.Resources._lock;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(20, 130);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(153, 35);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar Caixa";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaixa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbrirCaixa.Image = global::Academia.Properties.Resources.lock_open;
            this.btnAbrirCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(20, 130);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(153, 35);
            this.btnAbrirCaixa.TabIndex = 3;
            this.btnAbrirCaixa.Text = "Abrir Caixa";
            this.btnAbrirCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // btnRetirada
            // 
            this.btnRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRetirada.Image = global::Academia.Properties.Resources.retirar;
            this.btnRetirada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetirada.Location = new System.Drawing.Point(20, 77);
            this.btnRetirada.Name = "btnRetirada";
            this.btnRetirada.Size = new System.Drawing.Size(143, 33);
            this.btnRetirada.TabIndex = 3;
            this.btnRetirada.Text = "Retirada";
            this.btnRetirada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetirada.UseVisualStyleBackColor = true;
            this.btnRetirada.Click += new System.EventHandler(this.btnRetirada_Click);
            // 
            // btnSuprimento
            // 
            this.btnSuprimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuprimento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuprimento.Image = global::Academia.Properties.Resources.suprir;
            this.btnSuprimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuprimento.Location = new System.Drawing.Point(20, 36);
            this.btnSuprimento.Name = "btnSuprimento";
            this.btnSuprimento.Size = new System.Drawing.Size(143, 33);
            this.btnSuprimento.TabIndex = 3;
            this.btnSuprimento.Text = "Suprimento";
            this.btnSuprimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuprimento.UseVisualStyleBackColor = true;
            this.btnSuprimento.Click += new System.EventHandler(this.btnSuprimento_Click);
            // 
            // dtgCaixa
            // 
            this.dtgCaixa.AllowUserToAddRows = false;
            this.dtgCaixa.AllowUserToDeleteRows = false;
            this.dtgCaixa.AllowUserToResizeColumns = false;
            this.dtgCaixa.AllowUserToResizeRows = false;
            this.dtgCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CAIXA,
            this.ID_DETALHES,
            this.Imagem,
            this.MOVIMENTO,
            this.DATA,
            this.TIPO_PAGAMENTO,
            this.VALOR,
            this.SITUACAO});
            this.dtgCaixa.Location = new System.Drawing.Point(12, 163);
            this.dtgCaixa.Name = "dtgCaixa";
            this.dtgCaixa.ReadOnly = true;
            this.dtgCaixa.RowHeadersVisible = false;
            this.dtgCaixa.RowTemplate.Height = 24;
            this.dtgCaixa.Size = new System.Drawing.Size(889, 403);
            this.dtgCaixa.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Image = global::Academia.Properties.Resources.out_door;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(970, 578);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Image = global::Academia.Properties.Resources.filter;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(814, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Academia.Properties.Resources.Despesas;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ID_CAIXA
            // 
            this.ID_CAIXA.DataPropertyName = "ID_CAIXA";
            this.ID_CAIXA.HeaderText = "idCaixa";
            this.ID_CAIXA.Name = "ID_CAIXA";
            this.ID_CAIXA.ReadOnly = true;
            this.ID_CAIXA.Visible = false;
            // 
            // ID_DETALHES
            // 
            this.ID_DETALHES.DataPropertyName = "ID_DETALHES";
            this.ID_DETALHES.HeaderText = "idDetalhes";
            this.ID_DETALHES.Name = "ID_DETALHES";
            this.ID_DETALHES.ReadOnly = true;
            this.ID_DETALHES.Visible = false;
            // 
            // Imagem
            // 
            this.Imagem.HeaderText = "";
            this.Imagem.Name = "Imagem";
            this.Imagem.ReadOnly = true;
            this.Imagem.Width = 52;
            // 
            // MOVIMENTO
            // 
            this.MOVIMENTO.DataPropertyName = "MOVIMENTO";
            this.MOVIMENTO.HeaderText = "Movimento";
            this.MOVIMENTO.Name = "MOVIMENTO";
            this.MOVIMENTO.ReadOnly = true;
            this.MOVIMENTO.Width = 280;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DATA.DefaultCellStyle = dataGridViewCellStyle1;
            this.DATA.HeaderText = "Data";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 120;
            // 
            // TIPO_PAGAMENTO
            // 
            this.TIPO_PAGAMENTO.DataPropertyName = "TIPO_PAGAMENTO";
            this.TIPO_PAGAMENTO.HeaderText = "Forma";
            this.TIPO_PAGAMENTO.Name = "TIPO_PAGAMENTO";
            this.TIPO_PAGAMENTO.ReadOnly = true;
            this.TIPO_PAGAMENTO.Width = 160;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "VALOR";
            this.VALOR.HeaderText = "Valor";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 160;
            // 
            // SITUACAO
            // 
            this.SITUACAO.DataPropertyName = "SITUACAO";
            this.SITUACAO.HeaderText = "Situação";
            this.SITUACAO.Name = "SITUACAO";
            this.SITUACAO.ReadOnly = true;
            this.SITUACAO.Visible = false;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 620);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dtgCaixa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbLancamentos);
            this.Controls.Add(this.gbInformacoes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCaixa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                          SCA - Controle de Caixa";
            this.Activated += new System.EventHandler(this.frmCaixa_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            this.gbLancamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbInformacoes;
        private System.Windows.Forms.GroupBox gbLancamentos;
        private System.Windows.Forms.DataGridView dtgCaixa;
        private System.Windows.Forms.Button btnSuprimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.Button btnRetirada;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtRetirada;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSair;
        private DataGridViewTextBoxColumn ID_CAIXA;
        private DataGridViewTextBoxColumn ID_DETALHES;
        private DataGridViewImageColumn Imagem;
        private DataGridViewTextBoxColumn MOVIMENTO;
        private DataGridViewTextBoxColumn DATA;
        private DataGridViewTextBoxColumn TIPO_PAGAMENTO;
        private DataGridViewTextBoxColumn VALOR;
        private DataGridViewTextBoxColumn SITUACAO;
    }
}