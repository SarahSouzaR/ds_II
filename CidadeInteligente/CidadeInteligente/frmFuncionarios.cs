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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtCodPessoaF.Text = "";
            txtCargo.Text = "";
            txtSalario.Text = "";
            txtRamal.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodPessoaF.Text = "";
            txtCargo.Text = "";
            txtSalario.Text = "";
            txtRamal.Text = "";
        }

        private void CadastrarFuncionarios(int cd_Pessoa, string ds_Cargo, string nr_Salario, string nr_Ramal)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CidadeInteligente.accdb; Persist Security Info=False;";
            conexao.Open();
            string insertFuncionarios = string.Concat("insert into tb_funcionario (cd_Pessoa, ds_Cargo, nr_Salario, nr_Ramal) values ('", cd_Pessoa, "', '", ds_Cargo, "', '", nr_Salario, "', '", nr_Ramal, "') ");
            SqlCommand comandoSql = new SqlCommand(insertFuncionarios, conexao);
            comandoSql.ExecuteNonQuery();
            conexao.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarFuncionarios(Convert.ToInt32(txtCodPessoaF.Text), txtCargo.Text, txtSalario.Text, txtRamal.Text);
            LimparCampos();
            MessageBox.Show("Funcionários cadastrados!", "Cadastro - Funcionários");
        }
    }
}
