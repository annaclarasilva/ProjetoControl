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
    class ClassUsuario
    {
        //Declarando as propriedades
        public string Usuario { get; set; }
        public string Cpf { get; set; }
        public int TipoFunc { get; set; }
        public string Senha { get; set; }


        //Criando o objeto da classe de conexão como banco de dados
        ClassConexaoBd bd = new ClassConexaoBd();

       
        public bool InserirUsuario()
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o INSERT
                bd.ExecutarComandosSql(String.Format("INSERT INTO Usuario VALUES ('{0}',{1},'{2}','{3}')",Usuario,TipoFunc, Senha,Cpf));

                //Desconectando o banco
                bd.Desconectar();
                //Se o INSERT der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o INSERT não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao adicionar os dados do usuário. ");
            }

        }

        
        public bool Editar(string cpfUsuarioEditar)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o UPDATE
                bd.ExecutarComandosSql(String.Format("UPDATE Usuario SET  usuario = '{0}', senha = '{1}', tipoFunc = {2} WHERE cpf= '{3}'",Usuario,Senha,TipoFunc,cpfUsuarioEditar ));
                //Desconectando o banco
                bd.Desconectar();
                //Se o UPDATE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o UPDATE não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao editar os dados deste usuário.");
            }
        }

      
        public bool Excluir(string cpfUsuarioExcluir)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o DELETE
                bd.ExecutarComandosSql(String.Format("DELETE FROM Usuario WHERE cpf LIKE '{0}'", cpfUsuarioExcluir));
                //Desconectando o banco
                bd.Desconectar();
                //Se o DELETE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o DELETE não der certo retorna uma mensagem de erro
                throw new Exception(ex.Message + "Erro ao excluir os dados do usuário. ");
            }
        }

        
        public DataTable RetUsuario()
        {
            //Conectando com o banco 
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario"));
            //Desconectando o banco
            bd.Desconectar();
            //Retornando o objeto do DataTable 
            return dt;
        }

        //Propriedade para verificar o CPF
        public string CpfDigitado { get; set; }
        //Método para validar se o cpf digitado já está no banco
        public bool ValidarCpf()
        {
            //Conectando o banco de dados
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE cpf LIKE '{0}'", CpfDigitado));
            // Desconectando o banco 
            bd.Desconectar();
            //Se o objeto dt não retornar nada ele não existe
            if (dt.Rows.Count == 0)
            {
                //Se não existe retorna true
                return false;
            } //Se retornar mais de uma linha ele já existe no banco
            else
            {
                //Se existe 
                return true;
            }
        }

      
        //Método para retornar um funcionário por busca
        public DataTable RetUsuarioBusca(string busca)
        {
            //Conectando com o banco 
            bd.Conectar();
            //Objeto que recebe o SELECT para buscar por código ou cpf do funcionario
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE cpf LIKE '%{0}%'", busca));
            //Desconectando com o banco
            bd.Desconectar();
            //Retornando o objeto com o SELECT
            return dt;
        }

        //Realizar o login
        public DataTable RealizarLogin()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE usuario LIKE '{0}' AND senha LIKE '{1}'", Usuario, Senha));
            bd.Desconectar();
            return dt;
        }

        
    }
}

