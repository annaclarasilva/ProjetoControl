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
    public partial class frmBuscarDados : Form
    {
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
    }
}
