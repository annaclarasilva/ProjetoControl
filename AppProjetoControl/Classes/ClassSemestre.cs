using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace AppProjetoControl
{
    class ClassSemestre
    {
        //Declarando as propriedades
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public string CodSemestre { get; set; }
        public int NumAlunos { get; set; }


        //Criando o objeto da classe de conexão como banco de dados
        ClassConexaoBd bd = new ClassConexaoBd();

        public bool InserirSemestre()
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o INSERT
                bd.ExecutarComandosSql(String.Format("INSERT INTO Semestre VALUES ('{0}','{1}','{2}',{3})", DataInicio,DataFim,CodSemestre,NumAlunos));

                //Desconectando o banco
                bd.Desconectar();
                //Se o INSERT der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o INSERT não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao adicionar os dados desse semestre. ");
            }

        }

        //Método para editar Funcionário com o parametro do Código do Funcionário que irá ser editado
        public bool Editar(string codEditar)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o UPDATE
                bd.ExecutarComandosSql(String.Format("UPDATE Semestre SET dataInicio = '{0}', dataFim = '{1}',numAlunos = '{2}' WHERE codSemestre = '{3}'", DataInicio,DataFim,NumAlunos,codEditar));
                //Desconectando o banco
                bd.Desconectar();
                //Se o UPDATE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o UPDATE não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao editar os dados deste semestre.");
            }
        }

      
        //Método para retornar os dados do funcionário 
        public DataTable RetSemestre()
        {
            //Conectando com o banco 
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Semestre"));
            //Desconectando o banco
            bd.Desconectar();
            //Retornando o objeto do DataTable 
            return dt;
        }


        public DataTable RetSemestreBusca(string busca)
        {
            //Conectando com o banco 
            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa WHERE codSemestre LIKE '%{0}%' ", busca));
            //Desconectando com o banco
            bd.Desconectar();
            //Retornando o objeto com o SELECT
            return dt;
        }

    }
}
