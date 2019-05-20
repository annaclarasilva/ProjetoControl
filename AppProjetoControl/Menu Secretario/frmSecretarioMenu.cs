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
    public partial class frmSecretarioMenu : Form
    {
        public frmSecretarioMenu()
        {
            InitializeComponent();
        }

        private void btnVerAluno_Click(object sender, EventArgs e)
        {
            frmAlunoVisualizar verAluno = new frmAlunoVisualizar();
            this.Hide();
            verAluno.Show();
        }

        private void btnVerEmpresas_Click(object sender, EventArgs e)
        {
            frmEmpresaVisualizar verEmpresa = new frmEmpresaVisualizar();
            this.Hide();
            verEmpresa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmRelatorioAluno relatorio = new frmRelatorioAluno();
            //this.Hide();
            //relatorio.Show();
        }
    }
}
