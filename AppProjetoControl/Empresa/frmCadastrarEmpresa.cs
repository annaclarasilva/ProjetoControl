using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProjetoControl.Menu_Administrador
{
    public partial class frmCadastrarEmpresa : Form
    {
        ClassEmpresa empresa = new ClassEmpresa();
        public frmCadastrarEmpresa()
        {
            InitializeComponent();
        }
        public bool Validar()
        {
        
            if (mskCnpj.ForeColor == Color.Tomato)
            {
                MessageBox.Show("CNPJ inválido.");
                return false;
            }
            if (txtEmail.ForeColor == Color.Tomato)
            {
                MessageBox.Show("Email inválido.");
                return false;
            }
            return true;
        }

        private void txtNomeFantasia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtRazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void mskTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void mskCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string cnpjSemMascara = mskCnpj.Text.Replace("/", "").Replace(".", "").Replace("-", "");
            string cepSemMascara = mskCep.Text.Replace("-", "");

            if ((txtNomeFantasia.Text != "") && (mskTelefone.Text != "") && (txtRazaoSocial.Text != "") && (mskCnpj.Text != "") && (txtEmail.Text != "") && (txtResponsavel.Text != "") && (txtRua.Text != "") && (txtNumero.Text != "") && (txtComplemento.Text != "") && (txtBairro.Text != "") && (txtEstado.Text != "") && (txtCidade.Text != "") && (mskCep.Text != "") && (txtQuantContratos.Text != ""))
            {

                if (Validar() == true)
                {
                    empresa.NomeFantasia = txtNomeFantasia.Text;
                    empresa.Telefone = telefoneSemMascara;
                    empresa.RazaoSocial = txtRazaoSocial.Text;
                    empresa.Cnpj = cnpjSemMascara;
                    empresa.Email = txtEmail.Text;
                    empresa.Responsavel= txtResponsavel.Text;
                    empresa.Rua = txtRua.Text;
                    empresa.Numero = int.Parse(txtNumero.Text);
                    empresa.Complemento = txtComplemento.Text;
                    empresa.Bairro = txtBairro.Text;
                    empresa.Estado = txtEstado.Text;
                    empresa.Cidade = txtCidade.Text;
                    empresa.Cep = cepSemMascara;
                    empresa.NumMenorAprendiz = int.Parse(txtQuantContratos.Text!= "" ?txtQuantContratos.Text: "0");
                    empresa.NumFaseEscolar = int.Parse(txtFaseEscolar.Text!=""?txtFaseEscolar.Text:"0");
                    empresa.NumPraticaSequencial = int.Parse(txtPraticaSequencial.Text != "" ? txtPraticaSequencial.Text : "0");
                    empresa.NumConcomitante = int.Parse(txtConcomitante.Text != "" ? txtConcomitante.Text : "0");
                    empresa.NumSequencial = int.Parse(txtSequencial.Text != "" ? txtSequencial.Text : "0");
                    empresa.NumDual = int.Parse(txtDual.Text != "" ? txtDual.Text : "0");
                    DataTable dt = empresa.RetEmpresa();

                    if (empresa.InserirEmpresa() == true)
                    {
                        MessageBox.Show("Registro concluido com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Registro não concluido.");
                    }

                }
                else
                {
                    MessageBox.Show("Registro não concluido.");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados.");

            }
        }

        private void mskCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }


        private void txtEmail_Leave(object sender, EventArgs e)
        {
            empresa.EmailDigitado = txtEmail.Text;
            if (empresa.ValidarEmail() == true)
            {
                txtEmail.ForeColor = Color.Tomato;
            }
            else
            {
                txtEmail.ForeColor = Color.Black;
            
            }
        }

        private void mskCnpj_Leave(object sender, EventArgs e)
        {
            string cnpjSemMascara = mskCnpj.Text.Replace("/", "").Replace(".", "").Replace("-", "");
            empresa.CnpjDigitado = cnpjSemMascara;
            if (empresa.ValidarCnpj() == true)
            {
                mskCnpj.ForeColor = Color.Tomato;

            }
            else
            {
                mskCnpj.ForeColor = Color.Black;

            }
        }

        private void frmCadastrarEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}