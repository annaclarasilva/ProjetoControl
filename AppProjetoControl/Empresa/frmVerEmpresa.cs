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
    public partial class frmVerEmpresa : Form
    {
        ClassEmpresa empresa = new ClassEmpresa();
        public frmVerEmpresa()
        {
            InitializeComponent();
        }

        private void dgvVerEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvVerEmpresas.DataSource = empresa.RetEmpresa();
        }
    }
}