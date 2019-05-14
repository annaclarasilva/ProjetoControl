namespace AppProjetoControl
{
    partial class frmMenuAdm
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManterEmpresa = new System.Windows.Forms.Button();
            this.btnEnviarDados = new System.Windows.Forms.Button();
            this.btnVincularAluno = new System.Windows.Forms.Button();
            this.btnManterAluno = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnManterUsuario = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlLogin.Controls.Add(this.lblTitulo);
            this.pnlLogin.Controls.Add(this.btnFechar);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(741, 98);
            this.pnlLogin.TabIndex = 1;
            this.pnlLogin.TabStop = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(312, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 36);
            this.lblTitulo.TabIndex = 259;
            this.lblTitulo.Text = "Control";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.Location = new System.Drawing.Point(712, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 28);
            this.btnFechar.TabIndex = 258;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(191, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 36);
            this.label1.TabIndex = 267;
            this.label1.Text = "Bem vindo, Administrador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnManterEmpresa
            // 
            this.btnManterEmpresa.FlatAppearance.BorderSize = 0;
            this.btnManterEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManterEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManterEmpresa.ForeColor = System.Drawing.Color.Black;
            this.btnManterEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnManterEmpresa.Location = new System.Drawing.Point(234, 211);
            this.btnManterEmpresa.Name = "btnManterEmpresa";
            this.btnManterEmpresa.Size = new System.Drawing.Size(280, 31);
            this.btnManterEmpresa.TabIndex = 271;
            this.btnManterEmpresa.Text = "Manter Empresa";
            this.btnManterEmpresa.UseVisualStyleBackColor = true;
            this.btnManterEmpresa.Click += new System.EventHandler(this.btnManterEmpresa_Click);
            // 
            // btnEnviarDados
            // 
            this.btnEnviarDados.FlatAppearance.BorderSize = 0;
            this.btnEnviarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarDados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarDados.ForeColor = System.Drawing.Color.Black;
            this.btnEnviarDados.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnviarDados.Location = new System.Drawing.Point(234, 248);
            this.btnEnviarDados.Name = "btnEnviarDados";
            this.btnEnviarDados.Size = new System.Drawing.Size(280, 31);
            this.btnEnviarDados.TabIndex = 272;
            this.btnEnviarDados.Text = "Enviar Dados";
            this.btnEnviarDados.UseVisualStyleBackColor = true;
            this.btnEnviarDados.Click += new System.EventHandler(this.btnEnviarDados_Click);
            // 
            // btnVincularAluno
            // 
            this.btnVincularAluno.FlatAppearance.BorderSize = 0;
            this.btnVincularAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincularAluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVincularAluno.ForeColor = System.Drawing.Color.Black;
            this.btnVincularAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVincularAluno.Location = new System.Drawing.Point(234, 285);
            this.btnVincularAluno.Name = "btnVincularAluno";
            this.btnVincularAluno.Size = new System.Drawing.Size(280, 31);
            this.btnVincularAluno.TabIndex = 273;
            this.btnVincularAluno.Text = "Vincular Aluno";
            this.btnVincularAluno.UseVisualStyleBackColor = true;
            this.btnVincularAluno.Click += new System.EventHandler(this.btnVincularAluno_Click);
            // 
            // btnManterAluno
            // 
            this.btnManterAluno.FlatAppearance.BorderSize = 0;
            this.btnManterAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManterAluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManterAluno.ForeColor = System.Drawing.Color.Black;
            this.btnManterAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnManterAluno.Location = new System.Drawing.Point(234, 322);
            this.btnManterAluno.Name = "btnManterAluno";
            this.btnManterAluno.Size = new System.Drawing.Size(280, 31);
            this.btnManterAluno.TabIndex = 274;
            this.btnManterAluno.Text = "Manter Aluno";
            this.btnManterAluno.UseVisualStyleBackColor = true;
            this.btnManterAluno.Click += new System.EventHandler(this.btnManterAluno_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(234, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 31);
            this.button1.TabIndex = 275;
            this.button1.Text = "Buscar Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManterUsuario
            // 
            this.btnManterUsuario.FlatAppearance.BorderSize = 0;
            this.btnManterUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManterUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManterUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnManterUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnManterUsuario.Location = new System.Drawing.Point(234, 396);
            this.btnManterUsuario.Name = "btnManterUsuario";
            this.btnManterUsuario.Size = new System.Drawing.Size(280, 31);
            this.btnManterUsuario.TabIndex = 276;
            this.btnManterUsuario.Text = "Manter Usuário";
            this.btnManterUsuario.UseVisualStyleBackColor = true;
            // 
            // frmMenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 458);
            this.Controls.Add(this.btnManterUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnManterAluno);
            this.Controls.Add(this.btnVincularAluno);
            this.Controls.Add(this.btnEnviarDados);
            this.Controls.Add(this.btnManterEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlLogin);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuAdm";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManterEmpresa;
        private System.Windows.Forms.Button btnEnviarDados;
        private System.Windows.Forms.Button btnVincularAluno;
        private System.Windows.Forms.Button btnManterAluno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnManterUsuario;
    }
}