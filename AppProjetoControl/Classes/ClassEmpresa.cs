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
    class ClassEmpresa
    {
        //Declarando as propriedades
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Responsavel { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public int NumMenorAprendiz { get; set; }
        public int NumFaseEscolar { get; set; }
        public int NumPraticaSequencial { get; set; }
        public int NumConcomitante { get; set; }
        public int NumSequencial { get; set; }
        public int NumDual { get; set; }
        public int Fpass { get; set; }

        //Criando o objeto da classe de conexão como banco de dados
        ClassConexaoBd bd = new ClassConexaoBd();

      
        public bool InserirEmpresa()
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o INSERT
                bd.ExecutarComandosSql(String.Format("INSERT INTO Empresa (nomeFantasia,telefone,razaoSocial,cnpj,email,responsavel,rua,numero,complemento,bairro,estado,cidade,cep,numMenorAprendiz,numFaseEscolar,numPraticaSequencial,numConcomitante,numSequencial,numDual,fpass) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}','{9}','{10}','{11}','{12}',{13},{14},{15},{16},{17},{18},{19})", NomeFantasia, Telefone, RazaoSocial, Cnpj, Email, Responsavel, Rua, Numero, Complemento, Bairro, Estado, Cidade, Cep,NumMenorAprendiz,NumFaseEscolar,NumPraticaSequencial,NumConcomitante,NumSequencial,NumDual,Fpass));
                //Desconectando o banco
                bd.Desconectar();
                //Se o INSERT der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o INSERT não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao adicionar os dados da empresa. ");
            }

        }

        
        public bool Editar(string cnpjEditar)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o UPDATE
                bd.ExecutarComandosSql(String.Format("UPDATE Empresa SET nomeFantasia = '{0}', telefone = '{1}',email = '{2}',responsavel = '{3}', rua = '{4}',numero = '{5}',complemento = '{6}',bairro = '{7}',estado = '{8}',cidade = '{9}',cep='{10}',numMenorAprendiz = {11},numFaseEscolar = {12}, numPraticaSequencial = {13}, numConcomitante = {14}, numSequencial = {15}, numDual = {16}, fpass = {17} WHERE cnpj= '{18}'", NomeFantasia, Telefone,Email,Responsavel,Rua,Numero,Complemento,Bairro,Estado,Cidade,Cep,NumMenorAprendiz,NumFaseEscolar,NumPraticaSequencial,NumConcomitante,NumSequencial,NumDual,Fpass,cnpjEditar));
                //Desconectando o banco
                bd.Desconectar();
                //Se o UPDATE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o UPDATE não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao editar os dados deste empresa.");
            }
        }

      
        
        public DataTable RetEmpresa()
        {
            //Conectando com o banco 
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa "));
            //Desconectando o banco
            bd.Desconectar();
            //Retornando o objeto do DataTable 
            return dt;
        }


        public string CnpjDigitado { get; set; }

        public bool ValidarCnpj()
        {
            //Conectando o banco de dados
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa WHERE cnpj LIKE '{0}'", CnpjDigitado));
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
       
        public DataTable RetEmpresaBusca(string busca)
        {
            //Conectando com o banco 
            bd.Conectar();
            
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa  WHERE nomeFantasia LIKE '%{0}%' OR cnpj LIKE '%{0}%' ", busca));
            //Desconectando com o banco
            bd.Desconectar();
            //Retornando o objeto com o SELECT
            return dt;
        }



        //Propriedade para validar o email 
        public string EmailDigitado { get; set; }
        //Método para validar se o email digitado já está no banco
        public bool ValidarEmail()
        {
            //Conectando o banco de dados
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa WHERE email LIKE '{0}'", EmailDigitado));
            // Desconectando o banco 
            bd.Desconectar();
            //Se o objeto dt não retornar nada ele não existe
            if (dt.Rows.Count == 0)
            {
                //Se não existe retorna true
                return false;
            }
            else //Se retornar mais de uma linha ele já existe no banco
            {
                //Declarando a váriavel local
                bool teste = false;
                //Um for para percorrer o email digitado 
                for (int i = 0; i < EmailDigitado.Length; i++)
                {
                    //um if para conferir se o email possui @
                    if (EmailDigitado[i] == char.Parse("@"))
                    {
                        //Se tiver o teste recebe tur
                        teste = true;
                    }
                }
                //If para conferir se o email tem mais de 5 caracteres
                if ((EmailDigitado.Length > 5) && (teste == true))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

       
       
    }
}