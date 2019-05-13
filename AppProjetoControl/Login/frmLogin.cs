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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        ClassUsuario usuario = new ClassUsuario();
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuario.Usuario = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;

            DataTable dt = usuario.RealizarLogin();

            // saber se foram retornados registros do select
            if (dt.Rows.Count > 0)
            {
                //Como usar os dados desta tabela
                string login = dt.Rows[0]["usuario"].ToString();
                string cpf = dt.Rows[0]["cpf"].ToString();
                int tipoFunc = int.Parse(dt.Rows[0]["tipoFunc"].ToString());

                if (tipoFunc == 1)
                {
                    frmMenuAdm menu = new frmMenuAdm();
                    this.Hide();
                    menu.Show();
                }
                else
                {                   
                    MessageBox.Show("è 2");
                    //this.Hide();
                    //menu.Show();
                }
            }
            else
            {
                MessageBox.Show("Login e senha errados. Tente novamente.");
            }            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
