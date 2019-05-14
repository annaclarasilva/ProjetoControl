namespace AppProjetoControl.Menu_Secretario
{
    partial class frmSecretarioMenu
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
            this.btnVerEmpresas = new System.Windows.Forms.Button();
            this.btnVerAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerEmpresas
            // 
            this.btnVerEmpresas.FlatAppearance.BorderSize = 0;
            this.btnVerEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEmpresas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEmpresas.ForeColor = System.Drawing.Color.Black;
            this.btnVerEmpresas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVerEmpresas.Location = new System.Drawing.Point(222, 296);
            this.btnVerEmpresas.Name = "btnVerEmpresas";
            this.btnVerEmpresas.Size = new System.Drawing.Size(280, 31);
            this.btnVerEmpresas.TabIndex = 282;
            this.btnVerEmpresas.Text = "Ver Empresas";
            this.btnVerEmpresas.UseVisualStyleBackColor = true;
            this.btnVerEmpresas.Click += new System.EventHandler(this.btnVerEmpresas_Click);
            // 
            // btnVerAluno
            // 
            this.btnVerAluno.FlatAppearance.BorderSize = 0;
            this.btnVerAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerAluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAluno.ForeColor = System.Drawing.Color.Black;
            this.btnVerAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVerAluno.Location = new System.Drawing.Point(222, 259);
            this.btnVerAluno.Name = "btnVerAluno";
            this.btnVerAluno.Size = new System.Drawing.Size(280, 31);
            this.btnVerAluno.TabIndex = 281;
            this.btnVerAluno.Text = "Ver Alunos";
            this.btnVerAluno.UseVisualStyleBackColor = true;
            this.btnVerAluno.Click += new System.EventHandler(this.btnVerAluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(184, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 36);
            this.label1.TabIndex = 280;
            this.label1.Text = "Bem vindo, Secretário (a)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 98);
            this.panel1.TabIndex = 283;
            this.panel1.TabStop = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(312, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 36);
            this.label2.TabIndex = 259;
            this.label2.Text = "Control";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(712, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 28);
            this.button1.TabIndex = 258;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSecretarioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerEmpresas);
            this.Controls.Add(this.btnVerAluno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(741, 458);
            this.MinimumSize = new System.Drawing.Size(741, 458);
            this.Name = "frmSecretarioMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSecretarioMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerEmpresas;
        private System.Windows.Forms.Button btnVerAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}