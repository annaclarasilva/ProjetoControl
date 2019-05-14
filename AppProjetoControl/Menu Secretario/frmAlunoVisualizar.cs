using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProjetoControl.Menu_Secretario
{
    public partial class frmAlunoVisualizar : Form
    {
        ClassAluno aluno = new ClassAluno();
        public frmAlunoVisualizar()
        {
            InitializeComponent();
        }

        private void dgvVisualizarAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvVisualizarAluno.DataSource = aluno.RetAluno();
        }

        private void frmAlunoVisualizar_Load(object sender, EventArgs e)
        {
            dgvVisualizarAluno.DataSource = aluno.RetAluno();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmSecretarioMenu menu = new frmSecretarioMenu();
            this.Hide();
            menu.Show();
        }
    }
}
