﻿using System;
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
    public partial class frmVincularAluno : Form
    {
        public frmVincularAluno()
        {
            InitializeComponent();
        }

        private void frmVincularAluno_Load(object sender, EventArgs e)
        {
            this.reportViewer2.RefreshReport();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuAdm menu = new frmMenuAdm();
            this.Hide();
            menu.Show();
        }
    }
}
