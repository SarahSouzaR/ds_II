using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace frmAlunos
{
    class Conexao
    {
        //Declarando o objeto de conexão passando como parâmetro a string de conexão
      
        //MUDAR NOME E LUGAR DO BANCO
        private static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD_alunos.accdb;";

        //variável que representa a conexao com o banco
        private static OleDbConnection conn = null;

        //método que permite obter a conexão
        public static OleDbConnection obterConexao()
        {
            //Criando a conexão
            conn = new OleDbConnection(connString);

            //a conexão foi feita com sucesso?
            try
            {
                //Abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (Exception)
            {
                conn = null;
                MessageBox.Show("Conexão não estabelecida!!");
                //Ops! O que aconteceu?
                //Uma boa ideia aqui é gravar a exceção em um arquivo de log
            }
            return conn;
        }

        //método que permite fechar a conexão
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
