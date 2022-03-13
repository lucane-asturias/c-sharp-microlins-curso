namespace Academia
{
    partial class frmHorarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTurma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.dtgHorarios = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.ID_HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TURMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_SEMANA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTurma
            // 
            this.txtTurma.AutoSize = true;
            this.txtTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurma.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTurma.Location = new System.Drawing.Point(26, 20);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(143, 20);
            this.txtTurma.TabIndex = 12;
            this.txtTurma.Text = "Dia da Semana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(235, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(356, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fim:";
            // 
            // cboDia
            // 
            this.cboDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Items.AddRange(new object[] {
            ":: Selecione um dia ::",
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado",
            "Domingo"});
            this.cboDia.Location = new System.Drawing.Point(30, 46);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(165, 26);
            this.cboDia.TabIndex = 0;
            // 
            // dtgHorarios
            // 
            this.dtgHorarios.AllowUserToAddRows = false;
            this.dtgHorarios.AllowUserToDeleteRows = false;
            this.dtgHorarios.AllowUserToResizeColumns = false;
            this.dtgHorarios.AllowUserToResizeRows = false;
            this.dtgHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HORARIO,
            this.ID_TURMA,
            this.DIA_SEMANA,
            this.INICIO,
            this.FIM});
            this.dtgHorarios.Location = new System.Drawing.Point(25, 99);
            this.dtgHorarios.Name = "dtgHorarios";
            this.dtgHorarios.ReadOnly = true;
            this.dtgHorarios.RowHeadersVisible = false;
            this.dtgHorarios.RowTemplate.Height = 24;
            this.dtgHorarios.Size = new System.Drawing.Size(337, 229);
            this.dtgHorarios.TabIndex = 16;
            this.dtgHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHorarios_CellContentClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::Academia.Properties.Resources.savehoras;
            this.btnAdicionar.Location = new System.Drawing.Point(397, 99);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 45);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Academia.Properties.Resources.lapis;
            this.btnEditar.Location = new System.Drawing.Point(397, 223);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 45);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::Academia.Properties.Resources.deletar;
            this.btnExcluir.Location = new System.Drawing.Point(397, 161);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 45);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Academia.Properties.Resources.new_tab;
            this.btnNovo.Location = new System.Drawing.Point(397, 285);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 45);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtpFim
            // 
            this.dtpFim.CustomFormat = "HH:mm";
            this.dtpFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(360, 46);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.ShowUpDown = true;
            this.dtpFim.Size = new System.Drawing.Size(91, 26);
            this.dtpFim.TabIndex = 17;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "HH:mm";
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(239, 46);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowUpDown = true;
            this.dtpInicio.Size = new System.Drawing.Size(91, 26);
            this.dtpInicio.TabIndex = 17;
            // 
            // ID_HORARIO
            // 
            this.ID_HORARIO.DataPropertyName = "ID_HORARIO";
            this.ID_HORARIO.HeaderText = "idHorario";
            this.ID_HORARIO.Name = "ID_HORARIO";
            this.ID_HORARIO.ReadOnly = true;
            this.ID_HORARIO.Visible = false;
            // 
            // ID_TURMA
            // 
            this.ID_TURMA.DataPropertyName = "ID_TURMA";
            this.ID_TURMA.HeaderText = "idTurma";
            this.ID_TURMA.Name = "ID_TURMA";
            this.ID_TURMA.ReadOnly = true;
            this.ID_TURMA.Visible = false;
            // 
            // DIA_SEMANA
            // 
            this.DIA_SEMANA.DataPropertyName = "DIA_SEMANA";
            this.DIA_SEMANA.HeaderText = "Dia da Semana";
            this.DIA_SEMANA.Name = "DIA_SEMANA";
            this.DIA_SEMANA.ReadOnly = true;
            this.DIA_SEMANA.Width = 137;
            // 
            // INICIO
            // 
            this.INICIO.DataPropertyName = "INICIO";
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            this.INICIO.DefaultCellStyle = dataGridViewCellStyle1;
            this.INICIO.HeaderText = "Início";
            this.INICIO.Name = "INICIO";
            this.INICIO.ReadOnly = true;
            this.INICIO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.INICIO.Width = 98;
            // 
            // FIM
            // 
            this.FIM.DataPropertyName = "FIM";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.FIM.DefaultCellStyle = dataGridViewCellStyle2;
            this.FIM.HeaderText = "Fim";
            this.FIM.Name = "FIM";
            this.FIM.ReadOnly = true;
            this.FIM.Width = 98;
            // 
            // frmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 352);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtgHorarios);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cboDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHorarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtTurma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDia;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgHorarios;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HORARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TURMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_SEMANA;
        private System.Windows.Forms.DataGridViewTextBoxColumn INICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIM;
    }
}