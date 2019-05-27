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
    public partial class frmBuscarDados : Form
    {
        ClassAluno aluno = new ClassAluno();
        public frmBuscarDados()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuAdm menuAdm = new frmMenuAdm();
            this.Hide();
            menuAdm.Show();
        }

        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvBuscarDados.DataSource = aluno.RetAlunoBuscaAvancada(txtBusca.Text);
        }

        private void frmBuscarDados_Load(object sender, EventArgs e)
        {
            dgvBuscarDados.DataSource = aluno.RetAluno();
        }
    }
}
