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
    public partial class frmVerAluno : Form
    {
        ClassAluno aluno = new ClassAluno();
        public frmVerAluno()
        {
            InitializeComponent();
        }

        private void dgvVerAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmVerAluno_Load(object sender, EventArgs e)
        {
            dgvVerAlunos.DataSource = aluno.RetAluno();
        }
    }
}
