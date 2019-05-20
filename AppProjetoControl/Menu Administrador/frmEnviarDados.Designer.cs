namespace AppProjetoControl
{
    partial class frmEnviarDados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocalizaArquivoExcel = new System.Windows.Forms.Button();
            this.btnImportaExcel = new System.Windows.Forms.Button();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnExibirTodos = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlLogin.Controls.Add(this.button1);
            this.pnlLogin.Controls.Add(this.lblTitulo);
            this.pnlLogin.Controls.Add(this.btnFechar);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(933, 84);
            this.pnlLogin.TabIndex = 2;
            this.pnlLogin.TabStop = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 260;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(405, 27);
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
            this.btnFechar.Location = new System.Drawing.Point(901, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 28);
            this.btnFechar.TabIndex = 258;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.BackColor = System.Drawing.Color.White;
            this.lblRegistros.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRegistros.Location = new System.Drawing.Point(813, 560);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(106, 20);
            this.lblRegistros.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(697, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "No.  Registros ";
            // 
            // btnLocalizaArquivoExcel
            // 
            this.btnLocalizaArquivoExcel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizaArquivoExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLocalizaArquivoExcel.Location = new System.Drawing.Point(342, 560);
            this.btnLocalizaArquivoExcel.Name = "btnLocalizaArquivoExcel";
            this.btnLocalizaArquivoExcel.Size = new System.Drawing.Size(31, 26);
            this.btnLocalizaArquivoExcel.TabIndex = 25;
            this.btnLocalizaArquivoExcel.Text = "...";
            this.btnLocalizaArquivoExcel.UseVisualStyleBackColor = true;
            this.btnLocalizaArquivoExcel.Click += new System.EventHandler(this.btnLocalizaArquivoExcel_Click);
            // 
            // btnImportaExcel
            // 
            this.btnImportaExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportaExcel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportaExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImportaExcel.Location = new System.Drawing.Point(388, 555);
            this.btnImportaExcel.Name = "btnImportaExcel";
            this.btnImportaExcel.Size = new System.Drawing.Size(126, 32);
            this.btnImportaExcel.TabIndex = 24;
            this.btnImportaExcel.Text = "Importar Excel";
            this.btnImportaExcel.UseVisualStyleBackColor = true;
            this.btnImportaExcel.Click += new System.EventHandler(this.btnImportaExcel_Click);
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoExcel.Location = new System.Drawing.Point(28, 560);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(310, 26);
            this.txtArquivoExcel.TabIndex = 23;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(10, 136);
            this.dgvDados.Name = "dgvDados";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvDados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.Size = new System.Drawing.Size(909, 413);
            this.dgvDados.TabIndex = 22;
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirTodos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirTodos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExibirTodos.Location = new System.Drawing.Point(796, 102);
            this.btnExibirTodos.Name = "btnExibirTodos";
            this.btnExibirTodos.Size = new System.Drawing.Size(123, 28);
            this.btnExibirTodos.TabIndex = 31;
            this.btnExibirTodos.Text = "Exibir Todos";
            this.btnExibirTodos.UseVisualStyleBackColor = true;
            this.btnExibirTodos.Click += new System.EventHandler(this.btnExibirTodos_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // frmEnviarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 594);
            this.Controls.Add(this.btnExibirTodos);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLocalizaArquivoExcel);
            this.Controls.Add(this.btnImportaExcel);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.pnlLogin);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(933, 594);
            this.MinimumSize = new System.Drawing.Size(933, 594);
            this.Name = "frmEnviarDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocalizaArquivoExcel;
        private System.Windows.Forms.Button btnImportaExcel;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnExibirTodos;
        private System.Windows.Forms.OpenFileDialog ofd1;
    }
}