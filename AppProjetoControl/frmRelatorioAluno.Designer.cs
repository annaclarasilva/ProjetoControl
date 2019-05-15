namespace AppProjetoControl
{
    partial class frmRelatorioAluno
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdProjetoControlDataSet1 = new AppProjetoControl.bdProjetoControlDataSet1();
            this.vwAlunosEmpregadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwAlunosEmpregadosTableAdapter = new AppProjetoControl.bdProjetoControlDataSet1TableAdapters.vwAlunosEmpregadosTableAdapter();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdProjetoControlDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAlunosEmpregadosBindingSource)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSetDBProjetoControl";
            reportDataSource2.Value = this.vwAlunosEmpregadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppProjetoControl.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(898, 414);
            this.reportViewer1.TabIndex = 0;
            // 
            // bdProjetoControlDataSet1
            // 
            this.bdProjetoControlDataSet1.DataSetName = "bdProjetoControlDataSet1";
            this.bdProjetoControlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwAlunosEmpregadosBindingSource
            // 
            this.vwAlunosEmpregadosBindingSource.DataMember = "vwAlunosEmpregados";
            this.vwAlunosEmpregadosBindingSource.DataSource = this.bdProjetoControlDataSet1;
            // 
            // vwAlunosEmpregadosTableAdapter
            // 
            this.vwAlunosEmpregadosTableAdapter.ClearBeforeFill = true;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlLogin.Controls.Add(this.btnVoltar);
            this.pnlLogin.Controls.Add(this.lblTitulo);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(922, 84);
            this.pnlLogin.TabIndex = 3;
            this.pnlLogin.TabStop = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(310, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(287, 36);
            this.lblTitulo.TabIndex = 259;
            this.lblTitulo.Text = "RELATÓRIO ALUNOS";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Transparent;
            this.btnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(82, 29);
            this.btnVoltar.TabIndex = 265;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmRelatorioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 516);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(922, 516);
            this.MinimumSize = new System.Drawing.Size(922, 516);
            this.Name = "frmRelatorioAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioAluno";
            this.Load += new System.EventHandler(this.frmRelatorioAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdProjetoControlDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAlunosEmpregadosBindingSource)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vwAlunosEmpregadosBindingSource;
        private bdProjetoControlDataSet1 bdProjetoControlDataSet1;
        private bdProjetoControlDataSet1TableAdapters.vwAlunosEmpregadosTableAdapter vwAlunosEmpregadosTableAdapter;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVoltar;
    }
}