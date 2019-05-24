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
    public partial class frmEditarSemestre : Form
    {
        string idClicado;
        public frmEditarSemestre()
        {
            InitializeComponent();
        }
        ClassSemestre semestre = new ClassSemestre();
        private void txtBusca_Enter(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.ForeColor = Color.Black;
        }

        private void frmEditarSemestre_Load(object sender, EventArgs e)
        {
            dgvEditar.DataSource = semestre.RetSemestre();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvEditar.DataSource = semestre.RetSemestreBusca(txtBusca.Text);
        }

        private void dgvEditar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEditar.Rows[e.RowIndex].Cells["codSemestre"].Value.ToString() != "")
            {
                idClicado = (dgvEditar.Rows[e.RowIndex].Cells["codSemestre"].Value.ToString());
            }

           
            mskDataFim.Text = dgvEditar.Rows[e.RowIndex].Cells["dataFim"].Value.ToString();
            mskDataInicio.Text = dgvEditar.Rows[e.RowIndex].Cells["dataInicio"].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((mskDataFim.Text != "") && (mskDataInicio.Text != "") )
            {
                semestre.DataFim = Convert.ToDateTime(mskDataFim.Text).ToString("yyyy/MM/dd");
                semestre.DataInicio = Convert.ToDateTime(mskDataInicio.Text).ToString("yyyy/MM/dd");
              

                if (semestre.Editar(idClicado) == true)
                {
                    MessageBox.Show("Edição concluida com sucesso.");
                    dgvEditar.DataSource = semestre.RetSemestre();
                }
                else
                {
                    MessageBox.Show("Edição não concluída tente novamente.");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados.");
            }
        }
    }
}
