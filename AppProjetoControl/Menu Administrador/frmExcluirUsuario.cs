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
    public partial class frmExcluirUsuario : Form
    {
        string idClicado;
        ClassUsuario usuario = new ClassUsuario();
        public frmExcluirUsuario()
        {
            InitializeComponent();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvExcluir.DataSource = usuario.RetUsuarioBusca(txtBusca.Text);
        }

        private void frmExcluirUsuario_Load(object sender, EventArgs e)
        {
            dgvExcluir.DataSource = usuario.RetUsuario();
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }
        
        private void dgvExcluir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvExcluir.Rows[e.RowIndex].Cells["cpf"].Value.ToString() != "")
            {
                idClicado = (dgvExcluir.Rows[e.RowIndex].Cells["cpf"].Value.ToString());
            }
            txtCpf.Text = dgvExcluir.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse usuário?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (usuario.Excluir(idClicado) == true)
                {
                    MessageBox.Show("Exclusão concluida com sucesso.");
                    dgvExcluir.DataSource = usuario.RetUsuario();
                }
                else
                {
                    MessageBox.Show("Exclusão não concluída. Tente novamente.");
                }
            }
        }
    }
}
