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
    public partial class frmManterSemestre : Form
    {
        public frmManterSemestre()
        {
            InitializeComponent();
        }

        private void AbrirFormPanel(object FormFilho)
        {
            if (this.pnlMostrar.Controls.Count > 0)
                this.pnlMostrar.Controls.RemoveAt(0);
            Form fh = FormFilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlMostrar.Controls.Add(fh);
            this.pnlMostrar.Tag = fh;
            fh.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuAdm menu = new frmMenuAdm();
            this.Hide();
            menu.Show();
        }

        private void btnNovoSemestre_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmNovoSemestre());
        }

        private void btnCadastrarEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmEditarSemestre());
        }
    }
}
