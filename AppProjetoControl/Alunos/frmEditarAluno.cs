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
            string cnpjSemMascara = mskCnpj.Text.Replace("/", "").Replace(".", "").Replace("-", "");
            if (Validar() == true)
            {
                if ((txtBusca.Text != "") && (cnpjSemMascara != "") && (txtCodSemestre.Text != "") && (cboContrato.Text != ""))
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
                    aluno.Empresa_cnpj = cnpjSemMascara;
                    aluno.Semestre_codSemestre = txtCodSemestre.Text;
                    aluno.TipoContrato = cboContrato.Text;

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
            }
            else
            {
                MessageBox.Show("Edição não concluída tente novamente.");
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

        private void dgvEditarAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEditarAlunos.Rows[e.RowIndex].Cells["raAluno"].Value.ToString() != "")
            {
                idClicado = (dgvEditarAlunos.Rows[e.RowIndex].Cells["raAluno"].Value.ToString());
            }

            txtNome.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["nomeAluno"].Value.ToString();
            txtIdade.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["idade"].Value.ToString();
            txtGrau.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["grau_instrucao"].Value.ToString();
            txtEndereco.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["rua"].Value.ToString();
            txtNumero.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            txtComplemento.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["complemento"].Value.ToString();
            txtBairro.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
            txtEstado.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            txtCidade.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
            mskCep.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["cep"].Value.ToString();
            mskTelefone.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["telefone1"].Value.ToString();
            txtId.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["identidade"].Value.ToString();
            mskCpf.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            txtEmail.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtCarteira.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["carteira_de_trabalho"].Value.ToString();
            txtNomePai.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["nomePai"].Value.ToString();
            txtNomeMae.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["nomeMae"].Value.ToString();
            mskTelefoneMae.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["telefoneMae"].Value.ToString();
            mskTelefonePai.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["telefonePai"].Value.ToString();
            txtNomeCurso.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["nomeCurso"].Value.ToString();
            txtCodTurma.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["codTurma"].Value.ToString();
            txtStatusAluno.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["statusAluno"].Value.ToString();
            mskTelefoneAluno.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["telefoneAluno2"].Value.ToString();
            mskCnpj.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["Empresa_cnpj"].Value.ToString();
            cboSexo.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["sexo"].Value.ToString();
            txtCodSemestre.Text = dgvEditarAlunos.Rows[e.RowIndex].Cells["Semestre_codSemestre"].Value.ToString();



        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvEditarAlunos.DataSource = aluno.RetAlunoBusca(txtBusca.Text);
        }

        public bool Validar()
        {

            if (txtCodSemestre.ForeColor == Color.Tomato)
            {
                MessageBox.Show("Código do Semestre inexistente. Tente novamente!");
                return false;
            }
            if (mskCnpj.ForeColor == Color.Tomato)
            {
                MessageBox.Show("CNPJ inexistente. Tente novamente!");
                return false;
            }

            return true;
        }

        ClassSemestre semestre = new ClassSemestre();
        private void txtCodSemestre_Leave(object sender, EventArgs e)
        {
            semestre.CodDigitado = txtCodSemestre.Text;
            if (semestre.ValidarCodSemestre() == false)
            {
                txtCodSemestre.ForeColor = Color.Black;
            }
            else
            {
                txtCodSemestre.ForeColor = Color.Tomato;

            }
        }

        ClassEmpresa empresa = new ClassEmpresa();
        private void txtCnpjEmpresa_Leave(object sender, EventArgs e)
        {
            string cnpjSemMascara = mskCnpj.Text.Replace("/", "").Replace(".", "").Replace("-", "");
            empresa.CnpjDigitado = cnpjSemMascara;
            if (empresa.ValidarCnpj() == false)
            {
                mskCnpj.ForeColor = Color.Black;

            }
            else
            {
                mskCnpj.ForeColor = Color.Tomato;

            }
        }
    }

}