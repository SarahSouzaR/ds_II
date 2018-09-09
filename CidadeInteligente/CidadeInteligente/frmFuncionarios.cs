using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Classes;

namespace CidadeInteligente
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            CadastrarFuncionario();
            CarregarGrid();
        }

        private void LimparCampos()
        {
            txtCodFunc.Text = "";
            txtCodPessoaF.Text = "";
            txtCargo.Text = "";
            txtSalario.Text = "";
            txtRamal.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        List<Funcionario> lista_Funcionarios = new List<Funcionario>();

        private void CadastrarFuncionario()
        {
            Funcionario funcionario1 = new Funcionario();
            funcionario1.cd_Funcionario = txtCodFunc.Text;
            funcionario1.cd_Pessoa = txtCodPessoaF.Text;
            funcionario1.ds_Cargo = txtCargo.Text;
            funcionario1.nr_Salario = txtSalario.Text;
            funcionario1.nr_Ramal = txtRamal.Text;

            lista_Funcionarios.Add(funcionario1);
        }

        private void CarregarGrid()
        {
            dgvFuncionarios.DataSource = null;
            dgvFuncionarios.DataSource = lista_Funcionarios;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario();
            CarregarGrid();
            LimparCampos();

            /*
            CadastrarFuncionarios(Convert.ToInt32(txtCodPessoaF.Text), txtCargo.Text, txtSalario.Text, txtRamal.Text);
            LimparCampos();
            MessageBox.Show("Funcionários cadastrados!", "Cadastro - Funcionários");
            */
        }

        //PROGRAMA NÃO RECONHECEU O BANCO, deixar comentando em caso de ser a máquina e não o código

        /*
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
       */
    }
}
