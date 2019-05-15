using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProjetoControl
{
    public partial class frmCadastrarUsuario : Form
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }
        ClassUsuario usuario = new ClassUsuario();
        public bool Validar()
        {

            if (mskCpf.ForeColor == Color.Tomato)
            {
                MessageBox.Show("CPF inválido.");
                return false;
            }
            if (txtSenha.ForeColor == Color.Tomato)
            {
                MessageBox.Show("Senha inválida.");
                return false;
            }
            return true;
        }
        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            string cpfSemMascara = mskCpf.Text.Replace(".", "");
            usuario.CpfDigitado = cpfSemMascara;
            if (usuario.ValidarCpf() == true)
            {
                mskCpf.ForeColor = Color.Tomato;

            }
            else
            {
                mskCpf.ForeColor = Color.Black;

            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length > 8)
            {
                txtSenha.ForeColor = Color.Tomato;
            }
            else
            {
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
          
            string cpfSemMascara = mskCpf.Text.Replace(".", "");


            if ((txtUsuario.Text != "") && (txtSenha.Text != "") && (cboTipo.Text != "") && (mskCpf.Text != ""))
            {

                if (Validar() == true)
                {
                    usuario.Usuario = txtUsuario.Text;
                    usuario.Senha = txtSenha.Text;
                    usuario.Cpf = cpfSemMascara;
                    usuario.TipoFunc = cboTipo.SelectedIndex + 1;
                    //DataTable dt = empresa.RetEmpresa();

                    if (usuario.InserirUsuario() == true)
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

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.ForeColor = Color.Black;
        }
    }
}
