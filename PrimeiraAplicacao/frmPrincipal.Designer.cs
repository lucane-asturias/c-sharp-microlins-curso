namespace frmPropriedadesCheckBox
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
            this.btnTabuada = new System.Windows.Forms.Button();
            this.btnImagens = new System.Windows.Forms.Button();
            this.btnCheckBox = new System.Windows.Forms.Button();
            this.btnYoukoso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTabuada
            // 
            this.btnTabuada.Enabled = false;
            this.btnTabuada.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabuada.Image = global::frmPropriedadesCheckBox.Properties.Resources.Calculator__6_;
            this.btnTabuada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTabuada.Location = new System.Drawing.Point(215, 3);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(97, 72);
            this.btnTabuada.TabIndex = 2;
            this.btnTabuada.Text = "Tabuada";
            this.btnTabuada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // btnImagens
            // 
            this.btnImagens.Enabled = false;
            this.btnImagens.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagens.Image = global::frmPropriedadesCheckBox.Properties.Resources.Camera__8_;
            this.btnImagens.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImagens.Location = new System.Drawing.Point(112, 3);
            this.btnImagens.Name = "btnImagens";
            this.btnImagens.Size = new System.Drawing.Size(97, 72);
            this.btnImagens.TabIndex = 1;
            this.btnImagens.Text = "Imagens";
            this.btnImagens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImagens.UseVisualStyleBackColor = true;
            this.btnImagens.Click += new System.EventHandler(this.btnImagens_Click);
            // 
            // btnCheckBox
            // 
            this.btnCheckBox.Enabled = false;
            this.btnCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBox.Image = global::frmPropriedadesCheckBox.Properties.Resources.OK__2_;
            this.btnCheckBox.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheckBox.Location = new System.Drawing.Point(9, 3);
            this.btnCheckBox.Name = "btnCheckBox";
            this.btnCheckBox.Size = new System.Drawing.Size(97, 72);
            this.btnCheckBox.TabIndex = 0;
            this.btnCheckBox.Text = "CheckBox";
            this.btnCheckBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheckBox.UseVisualStyleBackColor = true;
            this.btnCheckBox.Click += new System.EventHandler(this.btnCheckBox_Click);
            // 
            // btnYoukoso
            // 
            this.btnYoukoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYoukoso.Location = new System.Drawing.Point(76, 175);
            this.btnYoukoso.Name = "btnYoukoso";
            this.btnYoukoso.Size = new System.Drawing.Size(157, 47);
            this.btnYoukoso.TabIndex = 3;
            this.btnYoukoso.Text = "ようこそ";
            this.btnYoukoso.UseVisualStyleBackColor = true;
            this.btnYoukoso.Click += new System.EventHandler(this.btnYoukoso_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 262);
            this.Controls.Add(this.btnYoukoso);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.btnImagens);
            this.Controls.Add(this.btnCheckBox);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primeiro Aplicativo em C#";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckBox;
        private System.Windows.Forms.Button btnImagens;
        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.Button btnYoukoso;


    }
}

