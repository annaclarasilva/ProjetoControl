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
    public partial class frmEditarUsuario : Form
    {
        string idClicado;
        ClassUsuario usuario = new ClassUsuario();
        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            dgvEditarUsuario.DataSource = usuario.RetUsuario();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvEditarUsuario.DataSource = usuario.RetUsuarioBusca(txtBusca.Text);
        }

        private void dgvEditarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEditarUsuario.Rows[e.RowIndex].Cells["cpf"].Value.ToString() != "")
            {
                idClicado = (dgvEditarUsuario.Rows[e.RowIndex].Cells["cpf"].Value.ToString());
            }

            txtUsuario.Text = dgvEditarUsuario.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            txtSenha.Text = dgvEditarUsuario.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            mskCpf.Text = dgvEditarUsuario.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            cboTipo.Text = dgvEditarUsuario.Rows[e.RowIndex].Cells["tipoFunc"].Value.ToString();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            string cpfSemMascara = mskCpf.Text.Replace("/", "").Replace(".", "").Replace("-", "");            
            
                if ((txtUsuario.Text != "") && (mskCpf.Text != "") && (cboTipo.Text != "") && (txtSenha.Text != ""))
                {
                    usuario.Usuario = txtUsuario.Text;
                    usuario.Senha = txtSenha.Text;
                    usuario.Cpf = cpfSemMascara;
                    usuario.TipoFunc = cboTipo.SelectedIndex + 1;

                    if (usuario.Editar(idClicado) == true)
                    {
                        MessageBox.Show("Edição concluida com sucesso.");
                        dgvEditarUsuario.DataSource = usuario.RetUsuario();
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
    }
}
