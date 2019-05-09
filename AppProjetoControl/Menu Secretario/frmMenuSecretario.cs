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
    public partial class frmMenuSecretario : Form
    {
        public frmMenuSecretario()
        {
            InitializeComponent();
        }

        private void btnVerAluno_Click(object sender, EventArgs e)
        {
            frmVisualizarAluno verAluno = new frmVisualizarAluno();
            this.Hide();
            verAluno.Show();
        }

        private void btnVerEmpresas_Click(object sender, EventArgs e)
        {
            frmVisualizarEmpresa verEmpresa = new frmVisualizarEmpresa();
            this.Hide();
            verEmpresa.Show();
        }
    }
}
