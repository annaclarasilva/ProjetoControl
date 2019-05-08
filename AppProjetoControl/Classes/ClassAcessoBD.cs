using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppProjetoControl.Classes
{
    class ClassAcessoBD
    {
        //Conexão com o bd
        private SqlConnection con;
        //Execução do comando SELECT  
        private SqlDataAdapter da;
        //Execução do INSERT/UPDATE/DELETE
        private SqlCommand cmd;
        //Retornar o resultado de um SELECT
        private DataTable dt;

        private string server = @"(localdb)\MSSQLLocalDB";
        private string database = "dbEducacaoDoFuturo";

        public void Conectar()
        {
            if (con != null)
                con.Close();
            string conStr = String.Format("server={0};" + "Initial Catalog={1};" + "Integrated Security=SSPI", server, database);
            try
            {
                con = new SqlConnection(conStr);
                con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + "Erro ao abrir conexão");
            }
        }
        public void Desconectar()
        {
            string conStr = String.Format("server={0};" + " Initial Catalog={1};" + "Integrated Security=SSPI", server, database);

            try
            {
                con = new SqlConnection(conStr);
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao fechar conexão.");
            }
        }
        public void ExecutarComandosSql(string comandoSql)
        {
            try
            {
                cmd = new SqlCommand(comandoSql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                //Retorna mensagem ao usuário
                throw new Exception(ex.Message + "Erro ao executar comando de " + "inserir, editar ou deletar.");
            }
        }
        public DataTable RetDataTable(string sql)
        {
            try
            {
                dt = new DataTable();
                da = new SqlDataAdapter(sql, con);

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao retornar DataTable.");
            }
        }
    }
}