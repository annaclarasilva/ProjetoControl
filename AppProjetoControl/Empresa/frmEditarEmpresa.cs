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
    public partial class frmEditarEmpresa : Form
    {
        string idClicado;
        ClassEmpresa empresa = new ClassEmpresa();
        public frmEditarEmpresa()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string telefoneSemMascara = mskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string cnpjSemMascara = mskCnpj.Text.Replace("/", "").Replace(".", "").Replace("-", "");
            string cepSemMascara = mskCep.Text.Replace("-", "");

            if (txtBusca.Text != "")
            {
                if ((txtNomeFantasia.Text != "") && (mskTelefone.Text != "") && (txtRazaoSocial.Text != "") && (mskCnpj.Text != "") && (txtEmail.Text != "") && (txtResponsavel.Text != "") && (txtRua.Text != "") && (txtNumero.Text != "") && (txtComplemento.Text != "") && (txtBairro.Text != "") && (txtEstado.Text != "") && (txtCidade.Text != "") && (mskCep.Text != ""))
                {
                    empresa.NomeFantasia = txtNomeFantasia.Text;
                    empresa.Telefone = telefoneSemMascara;
                    empresa.RazaoSocial = txtRazaoSocial.Text;
                   
                    empresa.Email = txtNomeFantasia.Text;
                    empresa.Responsavel = telefoneSemMascara;
                    empresa.Rua = txtRua.Text;
                    empresa.Numero = int.Parse(txtNumero.Text);
                    empresa.Complemento = txtComplemento.Text;
                    empresa.Bairro = txtBairro.Text;
                    empresa.Estado = txtEstado.Text;
                    empresa.Cidade = txtCidade.Text;
                    empresa.Cep = cepSemMascara;
                    empresa.NumMenorAprendiz = int.Parse(txtQuantContratos.Text != "" ? txtQuantContratos.Text : "0");
                    empresa.NumFaseEscolar = int.Parse(txtFaseEscolar.Text != "" ? txtFaseEscolar.Text : "0");
                    empresa.NumPraticaSequencial = int.Parse(txtPraticaSequencial.Text != "" ? txtPraticaSequencial.Text : "0");
                    empresa.NumConcomitante = int.Parse(txtConcomitante.Text != "" ? txtConcomitante.Text : "0");
                    empresa.NumSequencial = int.Parse(txtSequencial.Text != "" ? txtSequencial.Text : "0");
                    empresa.NumDual = int.Parse(txtDual.Text != "" ? txtDual.Text : "0");

                    if (empresa.Editar(idClicado) == true)
                    {
                        MessageBox.Show("Edição concluida com sucesso.");
                        dgvEditarEmpresa.DataSource = empresa.RetEmpresa();
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

        private void dgvEditarEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEditarEmpresa.Rows[e.RowIndex].Cells["cnpj"].Value.ToString() != "")
            {
                idClicado = (dgvEditarEmpresa.Rows[e.RowIndex].Cells["cnpj"].Value.ToString());
            }

            txtNomeFantasia.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["nomeFantasia"].Value.ToString();
            mskTelefone.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtRazaoSocial.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["razaoSocial"].Value.ToString();
            mskCnpj.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();
            txtEmail.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtResponsavel.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["responsavel"].Value.ToString();
            txtRua.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["rua"].Value.ToString();
            txtNumero.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            txtComplemento.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["complemento"].Value.ToString();
            txtBairro.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
            txtEstado.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            txtCidade.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
            mskCep.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["cep"].Value.ToString();
            txtQuantContratos.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["numMenorAprendiz"].Value.ToString();
            txtFaseEscolar.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["numFaseEscolar"].Value.ToString();
            txtPraticaSequencial.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["numPraticaSequencial"].Value.ToString();
            txtConcomitante.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["numConcomitante"].Value.ToString();
            txtSequencial.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["numSequencial"].Value.ToString();
            txtDual.Text = dgvEditarEmpresa.Rows[e.RowIndex].Cells["numDual"].Value.ToString();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvEditarEmpresa.DataSource = empresa.RetEmpresaBusca(txtBusca.Text);
        }

        private void frmEditarEmpresa_Load(object sender, EventArgs e)
        {
            dgvEditarEmpresa.DataSource = empresa.RetEmpresa();
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }
    }
}
