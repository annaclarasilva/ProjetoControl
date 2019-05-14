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
    public partial class frmEmpresaVisualizar : Form
    {
        ClassEmpresa empresa = new ClassEmpresa();
        public frmEmpresaVisualizar()
        {
            InitializeComponent();
        }

        private void dgvVisualizarEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvVisualizarEmpresa.DataSource = empresa.RetEmpresa();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmSecretarioMenu menu = new frmSecretarioMenu();
            this.Hide();
            menu.Show();
        }
    }
}
