namespace Academia
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProfessores = new System.Windows.Forms.ToolStripButton();
            this.btnModalidade = new System.Windows.Forms.ToolStripButton();
            this.btnAlunos = new System.Windows.Forms.ToolStripButton();
            this.btnTurma = new System.Windows.Forms.ToolStripButton();
            this.btnCaixa = new System.Windows.Forms.ToolStripButton();
            this.lblCaixa = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProfessores,
            this.btnModalidade,
            this.btnAlunos,
            this.toolStripSeparator1,
            this.btnTurma,
            this.toolStripSeparator2,
            this.btnCaixa,
            this.lblCaixa,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(925, 77);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 77);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 77);
            // 
            // btnProfessores
            // 
            this.btnProfessores.Image = global::Academia.Properties.Resources.Professor;
            this.btnProfessores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProfessores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(88, 74);
            this.btnProfessores.Text = "Professores";
            this.btnProfessores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfessores.Click += new System.EventHandler(this.btnProfessores_Click);
            // 
            // btnModalidade
            // 
            this.btnModalidade.Image = global::Academia.Properties.Resources.Peso;
            this.btnModalidade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModalidade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModalidade.Name = "btnModalidade";
            this.btnModalidade.Size = new System.Drawing.Size(94, 74);
            this.btnModalidade.Text = "Modalidade";
            this.btnModalidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModalidade.Click += new System.EventHandler(this.btnModalidade_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.Image = global::Academia.Properties.Resources.frmPrincipalALUNOS;
            this.btnAlunos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAlunos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(58, 74);
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnTurma
            // 
            this.btnTurma.Image = global::Academia.Properties.Resources.Turma;
            this.btnTurma.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTurma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(55, 74);
            this.btnTurma.Text = "Turma";
            this.btnTurma.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Image = global::Academia.Properties.Resources.Cash_Register;
            this.btnCaixa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(54, 74);
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // lblCaixa
            // 
            this.lblCaixa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblCaixa.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(0, 74);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 74);
            this.toolStripLabel1.Text = "Caixa:";
            this.toolStripLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(925, 622);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                S" +
    "CA - Controle de Academia";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnProfessores;
        private System.Windows.Forms.ToolStripButton btnModalidade;
        private System.Windows.Forms.ToolStripButton btnAlunos;
        private System.Windows.Forms.ToolStripButton btnTurma;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCaixa;
        private System.Windows.Forms.ToolStripLabel lblCaixa;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

