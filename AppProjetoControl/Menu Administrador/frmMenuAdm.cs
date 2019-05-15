using AppProjetoControl.Menu_Administrador;
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
    public partial class frmMenuAdm : Form
    {
        public frmMenuAdm()
        {
            InitializeComponent();
        }

        private void btnEnviarDados_Click(object sender, EventArgs e)
        {
            frmEnviarDados enviarDados = new frmEnviarDados();
            this.Hide();
            enviarDados.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnManterEmpresa_Click(object sender, EventArgs e)
        {
            frmManterEmpresa manterEmpresa = new frmManterEmpresa();
            this.Hide();
            manterEmpresa.Show();
        }

        private void btnManterAluno_Click(object sender, EventArgs e)
        {
            frmManterAluno manterAluno = new frmManterAluno();
            this.Hide();
            manterAluno.Show();
        }

        private void btnVincularAluno_Click(object sender, EventArgs e)
        {
            frmVincularAluno vincularAluno = new frmVincularAluno();
            this.Hide();
            vincularAluno.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarDados buscarDados = new frmBuscarDados();
            this.Hide();
            buscarDados.Show();
        }

        private void btnManterUsuario_Click(object sender, EventArgs e)
        {
            frmManterUsuario manterUsuario = new frmManterUsuario();
            this.Hide();
            manterUsuario.Show();
        }
    }
}
