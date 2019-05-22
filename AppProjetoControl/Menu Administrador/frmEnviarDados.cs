using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AppProjetoControl
{
    public partial class frmEnviarDados : Form
    {
        public frmEnviarDados()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenuAdm menuAdm = new frmMenuAdm();
            this.Hide();
            menuAdm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMenuAdm menuAdm = new frmMenuAdm();
            this.Hide();
            menuAdm.Show();
        }

        public object ExcelReaderFactory { get; private set; }
        string arquivoExcel = @"C:\Users\Aluno\Downloads\excel\Consulta alunos matriculados 07-02-2019 (2).xlsx";

        private void CarregaDadosExcel()
        {
            try
            {

                //converte os dados do Excel para um DataTable
                DataTable dt = GetTabelaExcel(arquivoExcel);

                //ajusta a largura das colunas aos dados
                dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDados.DataSource = dt;

                //No total de registros
                lblRegistros.Text = (dgvDados.Rows.Count - 1).ToString();

                string[] listaNomeColunas = dt.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }

        private DataTable GetTabelaExcel(string arquivoExcel)
        {
            DataTable dt = new DataTable();
            try
            {
                //pega a extensão do arquivo
                string Ext = Path.GetExtension(arquivoExcel);
                string connectionString = "";
                //verifica a versão do Excel pela extensão
                if (Ext == ".xls")
                { //para o  Excel 97-03    
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                else if (Ext == ".xlsx")
                { //para o  Excel 07 e superior
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomePlanilha = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();
                //le todos os dados da planilha para o Data Table    
                conn.Open();
                cmd.CommandText = "SELECT `RA ALUNO`, `ALUNO NOME`,`NASCIMENTO`,`IDADE DO ALUNO`,`SEXO`,`GRAU_INSTRUCAO`,`RUA`,`NUMERO`,`COMPLEMENTO`,`BAIRRO`,`ESTADO`,`CIDADE`,`CEP`,`TELEFONE 1`,`IDENTIDADE`,`CPF`,`E-MAIL`,`CARTEIRA TRABALHO`,`NOME DO PAI`,`TELEFONE DO PAI`,`NOME MÃE`,`TELEFONE MÃE`,`NOME CURSO`,`CODIGO TURMA`,`STATUS`,`TELEFONE ALUNO 2` from [" + nomePlanilha + "] WHERE (`RA ALUNO` <> '')";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                conn.Close();
                string comando = "INSERT INTO Aluno (raAluno,nomeAluno, dataNas,idade,sexo,grau_instrucao,rua,numero,complemento,bairro,estado,cidade,cep,telefone1,identidade,cpf,email,carteira_de_trabalho,nomePai,telefonePai,nomeMae,telefoneMae,nomeCurso,codTurma,statusAluno,telefoneAluno2) VALUES ";
                for (int i = 0; i < dt.Rows.Count; i++) //Linha
                {
                    comando += "(";
                    for (int j = 0; j < 26; j++) //Coluna
                    {
                        string dado = dt.Rows[i][j].ToString(); //Valor
                        comando += (j < 25) ? "'" + dado + "'," : "'" + dado + "'";
                    }
                    comando += (i < (dt.Rows.Count - 1)) ? ")," : ");";
                }
                ClassConexaoBd conexaoBd = new ClassConexaoBd();
                conexaoBd.Conectar();
                conexaoBd.ExecutarComandosSql(comando);
                Console.WriteLine(dataAdapter.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }



        ClassAluno aluno = new ClassAluno();
        private void btnExibirTodos_Click(object sender, EventArgs e)
        {
            dgvDados.DataSource = aluno.RetAluno();
        }

        private void btnImportaExcel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArquivoExcel.Text) && File.Exists(txtArquivoExcel.Text))
            {
                arquivoExcel = txtArquivoExcel.Text;
                CarregaDadosExcel();
            }
            else
            {
                CarregaDadosExcel();
            }
        }

        private void btnLocalizaArquivoExcel_Click(object sender, EventArgs e)
        {
            DialogResult drResult = ofd1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtArquivoExcel.Text = ofd1.FileName;
        }
    }
}