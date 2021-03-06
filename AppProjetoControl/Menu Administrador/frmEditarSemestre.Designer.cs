﻿namespace AppProjetoControl
{
    partial class frmEditarSemestre
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.mskDataFim = new System.Windows.Forms.MaskedTextBox();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.mskDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvEditar = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 80);
            this.panel1.TabIndex = 18;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(147, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "FORMULÁRIO DE EDIÇÃO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mskDataFim
            // 
            this.mskDataFim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataFim.Location = new System.Drawing.Point(282, 148);
            this.mskDataFim.Mask = "99/99/9999";
            this.mskDataFim.Name = "mskDataFim";
            this.mskDataFim.Size = new System.Drawing.Size(100, 27);
            this.mskDataFim.TabIndex = 38;
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFim.Location = new System.Drawing.Point(17, 149);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(252, 23);
            this.lblDataFim.TabIndex = 39;
            this.lblDataFim.Text = "Data do Final do Semestre";
            // 
            // mskDataInicio
            // 
            this.mskDataInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataInicio.Location = new System.Drawing.Point(282, 107);
            this.mskDataInicio.Mask = "99/99/9999";
            this.mskDataInicio.Name = "mskDataInicio";
            this.mskDataInicio.Size = new System.Drawing.Size(100, 27);
            this.mskDataInicio.TabIndex = 36;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.Location = new System.Drawing.Point(17, 108);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(259, 23);
            this.lblDataInicio.TabIndex = 37;
            this.lblDataInicio.Text = "Data do Início do Semestre";
            // 
            // txtBusca
            // 
            this.txtBusca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusca.Location = new System.Drawing.Point(390, 247);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(278, 27);
            this.txtBusca.TabIndex = 114;
            this.txtBusca.Text = "Busque o semestre pelo código";
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            this.txtBusca.Enter += new System.EventHandler(this.txtBusca_Enter);
            // 
            // dgvEditar
            // 
            this.dgvEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditar.Location = new System.Drawing.Point(12, 280);
            this.dgvEditar.Name = "dgvEditar";
            this.dgvEditar.Size = new System.Drawing.Size(657, 158);
            this.dgvEditar.TabIndex = 113;
            this.dgvEditar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditar_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(530, 445);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 32);
            this.btnEditar.TabIndex = 115;
            this.btnEditar.Text = "Editar Dados";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmEditarSemestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 488);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvEditar);
            this.Controls.Add(this.mskDataFim);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.mskDataInicio);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarSemestre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarSemestre";
            this.Load += new System.EventHandler(this.frmEditarSemestre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox mskDataFim;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.MaskedTextBox mskDataInicio;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvEditar;
        private System.Windows.Forms.Button btnEditar;
    }
}