using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProjetoControl.Alunos
{
    public partial class frmEditarAluno : Form
    {
        string idClicado;
        ClassAluno aluno = new ClassAluno();
        public frmEditarAluno()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            string telefoneCasaSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string cepSemMascara = mskCep.Text.Replace("-", "");
            string telefoneMaeSemMascara = mskTelefoneMae.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string telefonePaiSemMascara = mskTelefonePai.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string telefoneAlunoSemMascara = mskTelefoneAluno.Text.Replace("/", "").Replace(".", "").Replace("-", "");
            string cpfSemMascara = mskCpf.Text.Replace(".", "").Replace("-", "");

            if (txtBusca.Text != "")
            {
                if ((txtNome.Text != "") && (cboSexo.Text != "") && (txtIdade.Text != "") && (txtGrau.Text != "") && (mskCep.Text != "") && (txtEndereco.Text != "") && (txtNumero.Text != "") && (txtBairro.Text != "") && (txtEstado.Text != "") && (txtCidade.Text != "") && (txtComplemento.Text != "") && (mskTelefone.Text != "") && (txtId.Text != "") && (mskCpf.Text != "") && (txtEmail.Text != "") && (txtCarteira.Text != "") && (txtNomePai.Text != "") && (txtNomeMae.Text != "") && (mskTelefonePai.Text != "") && (mskTelefoneMae.Text != "") && (txtNomeCurso.Text != "") && (txtCodTurma.Text != "") && (txtStatusAluno.Text != "") && (mskTelefoneAluno.Text != "") && (txtCnpjEmpresa.Text != "") && (txtCodSemestre.Text != ""))
                {
                    aluno.NomeAluno = txtNome.Text;
                    aluno.Sexo = cboSexo.Text;
                    aluno.Idade = int.Parse(txtIdade.Text);
                    aluno.Grau_instrucao = txtGrau.Text;
                    aluno.Cep = cepSemMascara;
                    aluno.Rua = txtEndereco.Text;
                    aluno.Numero = int.Parse(txtNumero.Text);
                    aluno.Bairro = txtBairro.Text;
                    aluno.Cidade = txtCidade.Text;
                    aluno.Estado = txtEstado.Text;
                    aluno.Cidade = txtCidade.Text;
                    aluno.Telefone1 = mskTelefone.Text;
                    aluno.Identidade = txtId.Text;
                    aluno.Cpf = cpfSemMascara;
                    aluno.Email = txtEmail.Text;
                    aluno.Carteira_de_trabalho = txtCarteira.Text;
                    aluno.NomePai = txtNomePai.Text;
                    aluno.NomeMae = txtNomeMae.Text;
                    aluno.TelefonePai = telefonePaiSemMascara;
                    aluno.TelefoneMae = telefoneMaeSemMascara;
                    aluno.NomeCurso = txtNomeCurso.Text;
                    aluno.CodTurma = txtCodTurma.Text;
                    aluno.StatusAluno = txtStatusAluno.Text;
                    aluno.TelefoneAluno2 = mskTelefoneAluno.Text;
                    aluno.Empresa_cnpj = txtCnpjEmpresa.Text;
                    aluno.Semestre_codSemestre = txtCodSemestre.Text;

                    if (aluno.Editar(idClicado) == true)
                    {
                        MessageBox.Show("Edição concluida com sucesso.");
                        dgvEditarAlunos.DataSource = aluno.RetAluno();
                    }
                    else
                    {
                        MessageBox.Show("Edição não concluída tente novamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os dados.");
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo de busca .");
            }
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void frmEditarAluno_Load(object sender, EventArgs e)
        {
            dgvEditarAlunos.DataSource = aluno.RetAluno();
        }
    }
}