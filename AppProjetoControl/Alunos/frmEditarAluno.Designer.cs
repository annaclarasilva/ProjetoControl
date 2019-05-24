namespace AppProjetoControl.Alunos
{
    partial class frmEditarAluno
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblGrauInstrucao = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtGrau = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblTelefoneResidencia = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblIdentidade = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCarteira = new System.Windows.Forms.TextBox();
            this.lblCarteira = new System.Windows.Forms.Label();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.lblNomePai = new System.Windows.Forms.Label();
            this.mskTelefonePai = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefonePai = new System.Windows.Forms.Label();
            this.mskTelefoneMae = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneMae = new System.Windows.Forms.Label();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.lblNomeMae = new System.Windows.Forms.Label();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.lblNomeCurso = new System.Windows.Forms.Label();
            this.txtCodTurma = new System.Windows.Forms.TextBox();
            this.lblCodTurma = new System.Windows.Forms.Label();
            this.txtStatusAluno = new System.Windows.Forms.TextBox();
            this.lblStatusAluno = new System.Windows.Forms.Label();
            this.mskTelefoneAluno = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneAluno = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtCodSemestre = new System.Windows.Forms.TextBox();
            this.lblCodigoSemestre = new System.Windows.Forms.Label();
            this.dgvEditarAlunos = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboContrato = new System.Windows.Forms.ComboBox();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 80);
            this.panel1.TabIndex = 32;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(176, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "FORMULÁRIO DE EDIÇÃO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(555, 876);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 32);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = "Editar Dados";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(82, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(346, 27);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 102);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 19);
            this.lblNome.TabIndex = 54;
            this.lblNome.Text = "Nome:";
            // 
            // lblGrauInstrucao
            // 
            this.lblGrauInstrucao.AutoSize = true;
            this.lblGrauInstrucao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrauInstrucao.Location = new System.Drawing.Point(19, 169);
            this.lblGrauInstrucao.Name = "lblGrauInstrucao";
            this.lblGrauInstrucao.Size = new System.Drawing.Size(151, 19);
            this.lblGrauInstrucao.TabIndex = 53;
            this.lblGrauInstrucao.Text = "Grau de Instrução:";
            // 
            // txtIdade
            // 
            this.txtIdade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(81, 127);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(78, 27);
            this.txtIdade.TabIndex = 5;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(15, 135);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(60, 19);
            this.lblIdade.TabIndex = 62;
            this.lblIdade.Text = "Idade:";
            // 
            // cboSexo
            // 
            this.cboSexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cboSexo.Location = new System.Drawing.Point(504, 92);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(121, 29);
            this.cboSexo.TabIndex = 3;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(448, 102);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(50, 19);
            this.lblSexo.TabIndex = 64;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtGrau
            // 
            this.txtGrau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrau.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrau.Location = new System.Drawing.Point(176, 161);
            this.txtGrau.Name = "txtGrau";
            this.txtGrau.Size = new System.Drawing.Size(308, 27);
            this.txtGrau.TabIndex = 6;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(168, 208);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(87, 19);
            this.lblEndereco.TabIndex = 67;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(20, 208);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(42, 19);
            this.lblCep.TabIndex = 69;
            this.lblCep.Text = "CEP:";
            // 
            // mskCep
            // 
            this.mskCep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCep.Location = new System.Drawing.Point(68, 200);
            this.mskCep.Mask = "99999-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(83, 27);
            this.mskCep.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(598, 200);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 27);
            this.txtNumero.TabIndex = 9;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(561, 208);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(31, 19);
            this.lblNumero.TabIndex = 72;
            this.lblNumero.Text = "N°:";
            // 
            // txtBairro
            // 
            this.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(83, 235);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(225, 27);
            this.txtBairro.TabIndex = 10;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(20, 243);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(57, 19);
            this.lblBairro.TabIndex = 74;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEstado
            // 
            this.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(399, 235);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(170, 27);
            this.txtEstado.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(330, 243);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(63, 19);
            this.lblEstado.TabIndex = 76;
            this.lblEstado.Text = "Estado:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComplemento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(479, 271);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(175, 27);
            this.txtComplemento.TabIndex = 13;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(347, 279);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(126, 19);
            this.lblComplemento.TabIndex = 80;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtCidade
            // 
            this.txtCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(97, 268);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(225, 27);
            this.txtCidade.TabIndex = 12;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(19, 279);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(72, 19);
            this.lblCidade.TabIndex = 78;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblTelefoneResidencia
            // 
            this.lblTelefoneResidencia.AutoSize = true;
            this.lblTelefoneResidencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneResidencia.Location = new System.Drawing.Point(19, 311);
            this.lblTelefoneResidencia.Name = "lblTelefoneResidencia";
            this.lblTelefoneResidencia.Size = new System.Drawing.Size(134, 19);
            this.lblTelefoneResidencia.TabIndex = 82;
            this.lblTelefoneResidencia.Text = "Telefone (Casa):";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(261, 200);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(281, 27);
            this.txtEndereco.TabIndex = 8;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(157, 303);
            this.mskTelefone.Mask = "(99) 99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(128, 27);
            this.mskTelefone.TabIndex = 14;
            // 
            // lblIdentidade
            // 
            this.lblIdentidade.AutoSize = true;
            this.lblIdentidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentidade.Location = new System.Drawing.Point(321, 311);
            this.lblIdentidade.Name = "lblIdentidade";
            this.lblIdentidade.Size = new System.Drawing.Size(99, 19);
            this.lblIdentidade.TabIndex = 84;
            this.lblIdentidade.Text = "Identidade:";
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(426, 303);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(175, 27);
            this.txtId.TabIndex = 15;
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(67, 340);
            this.mskCpf.Mask = "999\\.999\\.999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(122, 27);
            this.mskCpf.TabIndex = 16;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(21, 348);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(42, 19);
            this.lblCpf.TabIndex = 86;
            this.lblCpf.Text = "CPF:";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(273, 340);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(384, 27);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(204, 348);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 19);
            this.lblEmail.TabIndex = 89;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtCarteira
            // 
            this.txtCarteira.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarteira.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarteira.Location = new System.Drawing.Point(202, 372);
            this.txtCarteira.Name = "txtCarteira";
            this.txtCarteira.Size = new System.Drawing.Size(282, 27);
            this.txtCarteira.TabIndex = 18;
            // 
            // lblCarteira
            // 
            this.lblCarteira.AutoSize = true;
            this.lblCarteira.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteira.Location = new System.Drawing.Point(20, 380);
            this.lblCarteira.Name = "lblCarteira";
            this.lblCarteira.Size = new System.Drawing.Size(173, 19);
            this.lblCarteira.TabIndex = 91;
            this.lblCarteira.Text = "Carteira de Trabalho:";
            // 
            // txtNomePai
            // 
            this.txtNomePai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomePai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePai.Location = new System.Drawing.Point(140, 406);
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(234, 27);
            this.txtNomePai.TabIndex = 19;
            // 
            // lblNomePai
            // 
            this.lblNomePai.AutoSize = true;
            this.lblNomePai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePai.Location = new System.Drawing.Point(20, 414);
            this.lblNomePai.Name = "lblNomePai";
            this.lblNomePai.Size = new System.Drawing.Size(114, 19);
            this.lblNomePai.TabIndex = 93;
            this.lblNomePai.Text = "Nome do Pai:";
            // 
            // mskTelefonePai
            // 
            this.mskTelefonePai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefonePai.Location = new System.Drawing.Point(489, 406);
            this.mskTelefonePai.Mask = "(99) 99999-9999";
            this.mskTelefonePai.Name = "mskTelefonePai";
            this.mskTelefonePai.Size = new System.Drawing.Size(128, 27);
            this.mskTelefonePai.TabIndex = 20;
            // 
            // lblTelefonePai
            // 
            this.lblTelefonePai.AutoSize = true;
            this.lblTelefonePai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonePai.Location = new System.Drawing.Point(405, 414);
            this.lblTelefonePai.Name = "lblTelefonePai";
            this.lblTelefonePai.Size = new System.Drawing.Size(78, 19);
            this.lblTelefonePai.TabIndex = 95;
            this.lblTelefonePai.Text = "Telefone:";
            // 
            // mskTelefoneMae
            // 
            this.mskTelefoneMae.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefoneMae.Location = new System.Drawing.Point(489, 440);
            this.mskTelefoneMae.Mask = "(99) 99999-9999";
            this.mskTelefoneMae.Name = "mskTelefoneMae";
            this.mskTelefoneMae.Size = new System.Drawing.Size(128, 27);
            this.mskTelefoneMae.TabIndex = 22;
            // 
            // lblTelefoneMae
            // 
            this.lblTelefoneMae.AutoSize = true;
            this.lblTelefoneMae.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneMae.Location = new System.Drawing.Point(405, 448);
            this.lblTelefoneMae.Name = "lblTelefoneMae";
            this.lblTelefoneMae.Size = new System.Drawing.Size(78, 19);
            this.lblTelefoneMae.TabIndex = 99;
            this.lblTelefoneMae.Text = "Telefone:";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeMae.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMae.Location = new System.Drawing.Point(151, 440);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(234, 27);
            this.txtNomeMae.TabIndex = 21;
            // 
            // lblNomeMae
            // 
            this.lblNomeMae.AutoSize = true;
            this.lblNomeMae.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMae.Location = new System.Drawing.Point(19, 448);
            this.lblNomeMae.Name = "lblNomeMae";
            this.lblNomeMae.Size = new System.Drawing.Size(126, 19);
            this.lblNomeMae.TabIndex = 98;
            this.lblNomeMae.Text = "Nome da Mãe:";
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCurso.Location = new System.Drawing.Point(157, 475);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(234, 27);
            this.txtNomeCurso.TabIndex = 100;
            // 
            // lblNomeCurso
            // 
            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCurso.Location = new System.Drawing.Point(19, 482);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(133, 19);
            this.lblNomeCurso.TabIndex = 101;
            this.lblNomeCurso.Text = "Nome do Curso:";
            // 
            // txtCodTurma
            // 
            this.txtCodTurma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodTurma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTurma.Location = new System.Drawing.Point(172, 507);
            this.txtCodTurma.Name = "txtCodTurma";
            this.txtCodTurma.Size = new System.Drawing.Size(196, 27);
            this.txtCodTurma.TabIndex = 102;
            // 
            // lblCodTurma
            // 
            this.lblCodTurma.AutoSize = true;
            this.lblCodTurma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodTurma.Location = new System.Drawing.Point(19, 513);
            this.lblCodTurma.Name = "lblCodTurma";
            this.lblCodTurma.Size = new System.Drawing.Size(150, 19);
            this.lblCodTurma.TabIndex = 103;
            this.lblCodTurma.Text = "Código da Turma:";
            // 
            // txtStatusAluno
            // 
            this.txtStatusAluno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatusAluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusAluno.Location = new System.Drawing.Point(151, 541);
            this.txtStatusAluno.Name = "txtStatusAluno";
            this.txtStatusAluno.Size = new System.Drawing.Size(284, 27);
            this.txtStatusAluno.TabIndex = 104;
            // 
            // lblStatusAluno
            // 
            this.lblStatusAluno.AutoSize = true;
            this.lblStatusAluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusAluno.Location = new System.Drawing.Point(20, 545);
            this.lblStatusAluno.Name = "lblStatusAluno";
            this.lblStatusAluno.Size = new System.Drawing.Size(131, 19);
            this.lblStatusAluno.TabIndex = 105;
            this.lblStatusAluno.Text = "Status do Aluno:";
            // 
            // mskTelefoneAluno
            // 
            this.mskTelefoneAluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefoneAluno.Location = new System.Drawing.Point(104, 571);
            this.mskTelefoneAluno.Mask = "(99) 99999-9999";
            this.mskTelefoneAluno.Name = "mskTelefoneAluno";
            this.mskTelefoneAluno.Size = new System.Drawing.Size(128, 27);
            this.mskTelefoneAluno.TabIndex = 106;
            // 
            // lblTelefoneAluno
            // 
            this.lblTelefoneAluno.AutoSize = true;
            this.lblTelefoneAluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneAluno.Location = new System.Drawing.Point(20, 577);
            this.lblTelefoneAluno.Name = "lblTelefoneAluno";
            this.lblTelefoneAluno.Size = new System.Drawing.Size(78, 19);
            this.lblTelefoneAluno.TabIndex = 107;
            this.lblTelefoneAluno.Text = "Telefone:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(18, 609);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(151, 19);
            this.lblCnpj.TabIndex = 109;
            this.lblCnpj.Text = "CNPJ da Empresa:";
            // 
            // txtCodSemestre
            // 
            this.txtCodSemestre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodSemestre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSemestre.Location = new System.Drawing.Point(189, 638);
            this.txtCodSemestre.Name = "txtCodSemestre";
            this.txtCodSemestre.Size = new System.Drawing.Size(196, 27);
            this.txtCodSemestre.TabIndex = 110;
            this.txtCodSemestre.Leave += new System.EventHandler(this.txtCodSemestre_Leave);
            // 
            // lblCodigoSemestre
            // 
            this.lblCodigoSemestre.AutoSize = true;
            this.lblCodigoSemestre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoSemestre.Location = new System.Drawing.Point(18, 642);
            this.lblCodigoSemestre.Name = "lblCodigoSemestre";
            this.lblCodigoSemestre.Size = new System.Drawing.Size(169, 19);
            this.lblCodigoSemestre.TabIndex = 111;
            this.lblCodigoSemestre.Text = "Código do Semestre:";
            // 
            // dgvEditarAlunos
            // 
            this.dgvEditarAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditarAlunos.Location = new System.Drawing.Point(23, 697);
            this.dgvEditarAlunos.Name = "dgvEditarAlunos";
            this.dgvEditarAlunos.Size = new System.Drawing.Size(664, 166);
            this.dgvEditarAlunos.TabIndex = 112;
            this.dgvEditarAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditarAlunos_CellContentClick);
            // 
            // txtBusca
            // 
            this.txtBusca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusca.Location = new System.Drawing.Point(466, 664);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(221, 27);
            this.txtBusca.TabIndex = 113;
            this.txtBusca.Text = "Busque o aluno pelo RA";
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            this.txtBusca.Enter += new System.EventHandler(this.txtBusca_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 115;
            this.label1.Text = "Contrato:";
            // 
            // cboContrato
            // 
            this.cboContrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboContrato.FormattingEnabled = true;
            this.cboContrato.Items.AddRange(new object[] {
            "Fase Escolar",
            "Prática Sequencial ",
            "Concomitante ",
            "Sequencial ",
            "Dual "});
            this.cboContrato.Location = new System.Drawing.Point(442, 573);
            this.cboContrato.Name = "cboContrato";
            this.cboContrato.Size = new System.Drawing.Size(245, 29);
            this.cboContrato.TabIndex = 114;
            // 
            // mskCnpj
            // 
            this.mskCnpj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCnpj.Location = new System.Drawing.Point(172, 605);
            this.mskCnpj.Mask = "99\\.999\\.999/9999-99";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(156, 27);
            this.mskCnpj.TabIndex = 116;
            this.mskCnpj.Text = "28747588000160";
            // 
            // frmEditarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(706, 920);
            this.Controls.Add(this.mskCnpj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboContrato);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvEditarAlunos);
            this.Controls.Add(this.txtCodSemestre);
            this.Controls.Add(this.lblCodigoSemestre);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.mskTelefoneAluno);
            this.Controls.Add(this.lblTelefoneAluno);
            this.Controls.Add(this.txtStatusAluno);
            this.Controls.Add(this.lblStatusAluno);
            this.Controls.Add(this.txtCodTurma);
            this.Controls.Add(this.lblCodTurma);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.lblNomeCurso);
            this.Controls.Add(this.mskTelefoneMae);
            this.Controls.Add(this.lblTelefoneMae);
            this.Controls.Add(this.txtNomeMae);
            this.Controls.Add(this.lblNomeMae);
            this.Controls.Add(this.mskTelefonePai);
            this.Controls.Add(this.lblTelefonePai);
            this.Controls.Add(this.txtNomePai);
            this.Controls.Add(this.lblNomePai);
            this.Controls.Add(this.txtCarteira);
            this.Controls.Add(this.lblCarteira);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIdentidade);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.lblTelefoneResidencia);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtGrau);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblGrauInstrucao);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarAluno";
            this.Load += new System.EventHandler(this.frmEditarAluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblGrauInstrucao;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtGrau;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblTelefoneResidencia;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblIdentidade;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCarteira;
        private System.Windows.Forms.Label lblCarteira;
        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.Label lblNomePai;
        private System.Windows.Forms.MaskedTextBox mskTelefonePai;
        private System.Windows.Forms.Label lblTelefonePai;
        private System.Windows.Forms.MaskedTextBox mskTelefoneMae;
        private System.Windows.Forms.Label lblTelefoneMae;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.Label lblNomeMae;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Label lblNomeCurso;
        private System.Windows.Forms.TextBox txtCodTurma;
        private System.Windows.Forms.Label lblCodTurma;
        private System.Windows.Forms.TextBox txtStatusAluno;
        private System.Windows.Forms.Label lblStatusAluno;
        private System.Windows.Forms.MaskedTextBox mskTelefoneAluno;
        private System.Windows.Forms.Label lblTelefoneAluno;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtCodSemestre;
        private System.Windows.Forms.Label lblCodigoSemestre;
        private System.Windows.Forms.DataGridView dgvEditarAlunos;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboContrato;
        private System.Windows.Forms.MaskedTextBox mskCnpj;
    }
}