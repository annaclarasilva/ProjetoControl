namespace AppProjetoControl
{
    partial class frmManterSemestre
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnNovoSemestre = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrarEmpresa = new System.Windows.Forms.Button();
            this.pnlMostrar = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnNovoSemestre);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnCadastrarEmpresa);
            this.pnlMenu.Controls.Add(this.pnlMostrar);
            this.pnlMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(909, 570);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnNovoSemestre
            // 
            this.btnNovoSemestre.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoSemestre.FlatAppearance.BorderSize = 0;
            this.btnNovoSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoSemestre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoSemestre.ForeColor = System.Drawing.Color.Black;
            this.btnNovoSemestre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNovoSemestre.Location = new System.Drawing.Point(5, 165);
            this.btnNovoSemestre.Name = "btnNovoSemestre";
            this.btnNovoSemestre.Size = new System.Drawing.Size(183, 54);
            this.btnNovoSemestre.TabIndex = 270;
            this.btnNovoSemestre.Text = "Gerar Novo Semestre";
            this.btnNovoSemestre.UseVisualStyleBackColor = false;
            this.btnNovoSemestre.Click += new System.EventHandler(this.btnNovoSemestre_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 119);
            this.panel1.TabIndex = 269;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(95, 539);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 28);
            this.btnVoltar.TabIndex = 268;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrarEmpresa
            // 
            this.btnCadastrarEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEmpresa.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrarEmpresa.Location = new System.Drawing.Point(5, 225);
            this.btnCadastrarEmpresa.Name = "btnCadastrarEmpresa";
            this.btnCadastrarEmpresa.Size = new System.Drawing.Size(183, 54);
            this.btnCadastrarEmpresa.TabIndex = 263;
            this.btnCadastrarEmpresa.Text = "Editar Semestre";
            this.btnCadastrarEmpresa.UseVisualStyleBackColor = false;
            this.btnCadastrarEmpresa.Click += new System.EventHandler(this.btnCadastrarEmpresa_Click);
            // 
            // pnlMostrar
            // 
            this.pnlMostrar.BackColor = System.Drawing.Color.LightGray;
            this.pnlMostrar.Location = new System.Drawing.Point(193, 3);
            this.pnlMostrar.Name = "pnlMostrar";
            this.pnlMostrar.Size = new System.Drawing.Size(713, 564);
            this.pnlMostrar.TabIndex = 0;
            // 
            // frmManterSemestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(933, 594);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(933, 594);
            this.MinimumSize = new System.Drawing.Size(933, 594);
            this.Name = "frmManterSemestre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManterSemestre";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnNovoSemestre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrarEmpresa;
        private System.Windows.Forms.Panel pnlMostrar;
    }
}