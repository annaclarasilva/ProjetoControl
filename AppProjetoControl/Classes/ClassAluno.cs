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
    class ClassAluno
    {
        //Declarando as propriedades
        public string RaAluno { get; set; }
        public string NomeAluno { get; set; }
        public string DataNas { get; set; }
        public string Sexo { get; set; }
        public string Grau_instrucao { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Telefone1 { get; set; }
        public string Identidade { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Carteira_de_trabalho { get; set; }
        public string NomePai { get; set; }
        public string TelefonePai { get; set; }
        public string NomeMae { get; set; }
        public string TelefoneMae { get; set; }
        public string NomeCurso { get; set; }
        public string CodTurma { get; set; }
        public string StatusAluno { get; set; }
        public string TelefoneAluno2 { get; set; }
        public string Empresa_cnpj { get; set; }
        public string Semestre_codSemestre { get; set; }
        public int Idade { get; set; }
        public string TipoContrato { get; set; }


        //Criando o objeto da classe de conexão como banco de dados
        ClassConexaoBd bd = new ClassConexaoBd();

        public bool InserirAluno()
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o INSERT
                bd.ExecutarComandosSql(String.Format("INSERT INTO Aluno VALUES ('{0}','{1}','{2}',{3},'{4}','{5}','{6}',{7},'{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}')", RaAluno, NomeAluno,DataNas,Idade,Sexo,Grau_instrucao,Rua,Numero,Complemento,Bairro,Estado,Cidade,Cep,Email,Carteira_de_trabalho,NomePai,TelefonePai,NomeMae,TelefoneMae,NomeCurso,CodTurma,StatusAluno,TelefoneAluno2,TipoContrato,Empresa_cnpj,Semestre_codSemestre));

                //Desconectando o banco
                bd.Desconectar();
                //Se o INSERT der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o INSERT não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao adicionar os dados do aluno. ");
            }

        }

        //Método para editar Funcionário com o parametro do Código do Funcionário que irá ser editado
        public bool Editar(string raAlunoEditar)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o UPDATE
                bd.ExecutarComandosSql(String.Format("UPDATE Aluno SET nomeAluno = '{0}', dataNas = '{1}', idade = '{2}', sexo = '{3}', grau_instrucao = '{4}',rua = '{5}',numero = {6},complemento = '{7}', bairro = '{8}', estado = '{9}', cidade = '{10}', cep = '{11}', telefone1 = '{12}', identidade = '{13}', email = '{14}',carteira_de_trabalho = '{15}', nomePai = '{16}',telefonePai = '{17}', nomeMae= '{18}',telefoneMae='{19}',nomeCurso = '{20}', codTurma='{21}', statusAluno = '{22}', telefoneAluno2 = '{23}',Empresa_cnpj = '{24}',Semestre_codSemestre='{25}',tipoContrato = '{26}'  WHERE raAluno = '{27}'", 
                    NomeAluno, DataNas, Idade, Sexo, Grau_instrucao, Rua, Numero, Complemento, Bairro, Estado, Cidade, Cep,Telefone1,Identidade,Email, Carteira_de_trabalho, NomePai, TelefonePai, NomeMae, TelefoneMae, NomeCurso, CodTurma, StatusAluno, TelefoneAluno2, Empresa_cnpj, Semestre_codSemestre,TipoContrato,raAlunoEditar));
                //Desconectando o banco
                bd.Desconectar();
                //Se o UPDATE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o UPDATE não der certo retorna uma messagem de erro.
                throw new Exception(ex.Message + "Erro ao editar os dados deste aluno.");
            }
        }


        public bool Excluir(string raAlunoExcluir)
        {
            try
            {
                //Conectando o banco 
                bd.Conectar();
                //Executando o DELETE
                bd.ExecutarComandosSql(String.Format("DELETE FROM Aluno WHERE raAluno LIKE '{0}'", raAlunoExcluir));
                //Desconectando o banco
                bd.Desconectar();
                //Se o DELETE der certo retorna true
                return true;
            }
            catch (Exception ex)
            {
                //Se o DELETE não der certo retorna uma mensagem de erro
                throw new Exception(ex.Message + "Erro ao excluir os dados do aluno. ");
            }
        }


        public DataTable RetAluno()
        {
            //Conectando com o banco 
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno "));
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
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno WHERE cpf LIKE '{0}'", CpfDigitado));
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


        //Propriedade para verificar a Carteira de Trabalho
        public string CarteiraDeTrabalhoDigitado { get; set; }
        //Método para validar se o Carteira de Trabalho digitado já está no banco
        public bool ValidarCarteiraDeTrabalho()
        {
            //Conectando o banco de dados
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno WHERE carteira_de_trabalho LIKE '{0}'", CarteiraDeTrabalhoDigitado));
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


        //Propriedade para verificar a Carteira de Trabalho
        public string RgDigitado { get; set; }
        //Método para validar se o Carteira de Trabalho digitado já está no banco
        public bool ValidarRg()
        {
            //Conectando o banco de dados
            bd.Conectar();
            //Usando o objeto do DataTable para o banco receber o comando do SELECT e retornar na tabela
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno WHERE identidade LIKE '{0}'", RgDigitado));
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



        //Método para retornar um aluno por busca
        public DataTable RetAlunoBusca(string busca)
        {
            //Conectando com o banco ,

            bd.Conectar();

            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno  WHERE raAluno LIKE '%{0}%'", busca));
            //Desconectando com o banco
            bd.Desconectar();
            //Retornando o objeto com o SELECT
            return dt;
        }

        public DataTable verificarRA(string ra)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno WHERE raAluno LIKE '{0}'", ra));
            bd.Desconectar();
            return dt;
        }


    }
}

