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
    public partial class frmExcluirAluno : Form
    {
        string idClicado;
        ClassAluno aluno = new ClassAluno();
        public frmExcluirAluno()
        {
            InitializeComponent();
        }

        private void frmExcluirAluno_Load(object sender, EventArgs e)
        {
            //dgvAlunoExcluir.DataSource = aluno.RetAluno();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            //dgvAlunoExcluir.DataSource = aluno.RetAlunoBusca(txtBusca.Text);
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void dgvAlunoExcluir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlunoExcluir.Rows[e.RowIndex].Cells["raAluno"].Value.ToString() != "")
            {
                idClicado = (dgvAlunoExcluir.Rows[e.RowIndex].Cells["raAluno"].Value.ToString());
            }
            txtRa.Text = dgvAlunoExcluir.Rows[e.RowIndex].Cells["raAluno"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse aluno?", "Confirmação", MessageBoxButtons.YesNoCancel);
            //if (result == DialogResult.Yes)
            //{
            //    if (aluno.Excluir(idClicado) == true)
            //    {
            //        MessageBox.Show("Exclusão concluida com sucesso.");
            //        dgvAlunoExcluir.DataSource = alnuo.RetAluno();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Exclusão não concluída. Tente novamente.");
            //    }
            //}
        }
    }
}
