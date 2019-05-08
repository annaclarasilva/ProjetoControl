using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace AppProjetoControl
{
    public partial class frmEnviarDados : Form
    {
        public frmEnviarDados()
        {
            InitializeComponent();
        }

        DataSet result;

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog() { Filter = "Excel Work Book 97-2003|*.xls|Excel Workbook|* .xlsx", ValidateNames = true })
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(of.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader;
                    if (of.FilterIndex == 1)
                        reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    else
                        reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                    result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true  // set to true to use excel first row as column in datagridview
                        }
                    });
                    cbbPlanilha.Items.Clear();
                    foreach (DataTable dt in result.Tables)
                    {
                        cbbPlanilha.Items.Add(dt.TableName);
                    }
                    reader.Close();
                }
            }
        }

        private void cbbPlanilha_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvExcel.DataSource = result.Tables[cbbPlanilha.SelectedIndex];
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //string[] aba = GetExcelSheetNames();
            //string abas = aba[0] + "$";
            //string caminho = textBox1.Text;

            //string connectionString = @"Data Source=SERVDOR;Initial Catalog=NOMEDOBANCO;Integrated Security=True";
            //SqlConnection cnn = new SqlConnection(connectionString);
            //cnn.Open();

            //string excelcn1 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + caminho + ";";
            //string excelcn2 = @"Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1""";

            //string excelConnectionString = excelcn1 + excelcn2;
            //using (OleDbConnection connection = new OleDbConnection(excelConnectionString))
            //{
            //    OleDbCommand command = new OleDbCommand("Select * FROM [" + abas + "]", connection);
            //    connection.Open();

            //    using (IDataReader dr = command.ExecuteReader())
            //    {
            //        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionString))
            //        {
            //            bulkCopy.DestinationTableName = "tb_planilhaQC";
            //            bulkCopy.WriteToServer(dr);
            //        }
            //    }
            //}
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

        //string[] aba = GetExcelSheetNames();
        //string abas = aba[0] + "$";
        //string caminho = txtCaminho.Text;

        //string connectionString = @"Data Source=SERVDOR;Initial Catalog=bdProjetoControl;Integrated Security=True";
        //SqlConnection cnn = new SqlConnection(connectionString);
        //cnn.Open();

        //string excelcn1 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + caminho + ";";
        //string excelcn2 = @"Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1""";

        //string excelConnectionString = excelcn1 + excelcn2;
        //using (OleDbConnection connection = new OleDbConnection(excelConnectionString))
        //{
        //    OleDbCommand command = new OleDbCommand("Select * FROM [" + abas + "]", connection);
        //    connection.Open();

        //    using (IDataReader dr = command.ExecuteReader())
        //    {
        //        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionString))
        //        {
        //            bulkCopy.DestinationTableName = "tb_planilhaQC";
        //            bulkCopy.WriteToServer(dr);
        //        }
        //    }
        //}
    }
}