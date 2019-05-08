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
    }
}
