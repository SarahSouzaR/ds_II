using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CidadeInteligente
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtCodPessoaC.Text = "";
            txtDtInclusao.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodPessoaC.Text = "";
            txtDtInclusao.Text = "";
        }

        private void CadastrarClientes(int cd_Pessoa, DateTime dt_Inclusao) 
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CidadeInteligente.accdb; Persist Security Info=False;";
            conexao.Open();
            string insertClientes = string.Concat("insert into tb_cliente (cd_Pessoa, dt_Inclusao) values ('", cd_Pessoa, "', '", dt_Inclusao, "') ");
            SqlCommand comandoSql = new SqlCommand(insertClientes, conexao);
            comandoSql.ExecuteNonQuery();
            conexao.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarClientes(Convert.ToInt32(txtCodPessoaC.Text), Convert.ToDateTime(txtDtInclusao.Text));
            LimparCampos();
            MessageBox.Show("Clientes cadastrados!", " Cadastro - Clientes");
        }
    }
}
