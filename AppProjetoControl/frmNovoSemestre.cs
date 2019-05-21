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
    public partial class frmNovoSemestre : Form
    {
        public frmNovoSemestre()
        {
            InitializeComponent();
        }

        ClassSemestre semestre = new ClassSemestre();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (mskDataInicio.Text != "" && mskDataFim.Text != "" && txtNumAlunos.Text != "")
            {
                semestre.DataFim = Convert.ToDateTime(mskDataFim.Text).ToString("yyyy/MM/dd");
                semestre.DataInicio = Convert.ToDateTime(mskDataInicio.Text).ToString("yyyy/MM/dd");
                DataTable dt = semestre.RetSemestre();
                string codigo = (dt.Rows.Count > 0) ? dt.Rows[dt.Rows.Count - 1]["codSemestre"].ToString().Replace("SEM", "") : "0";
                codigo = "SEM" + (int.Parse(codigo) + 1).ToString().PadLeft(3, '0');
                semestre.CodSemestre = codigo;
                semestre.NumAlunos = int.Parse(txtNumAlunos.Text);
                if (semestre.InserirSemestre() == true)
                {
                    MessageBox.Show("Registro concluido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Registro não concluido.Tente novamente.");
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }
        }
    }
}
