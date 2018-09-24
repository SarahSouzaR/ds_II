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
            retornarFuncionario();
        }

        private void LimparCampos()
        {
            //txtCodFunc.Text = "";
            txtCodPessoaF.Text = "";
            txtCargo.Text = "";
            txtSalario.Text = "";
            txtRamal.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //List<Funcionario> lista_Funcionarios = new List<Funcionario>();

        private void CadastrarFuncionario(int cd_Pessoa, string ds_Cargo, string nr_Salario, string nr_Ramal)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=CidadeInteligente;Data Source=LAB-08-01";
            conexao.Open();
            string insertFuncionarios = string.Concat("insert into tb_funcionario (cd_Pessoa, ds_Cargo, nr_Salario, nr_Ramal) values ('", cd_Pessoa, "', '", ds_Cargo, "', '", nr_Salario, "', '", nr_Ramal, "') ");
            SqlCommand comandoSql = new SqlCommand(insertFuncionarios, conexao);
            comandoSql.ExecuteNonQuery();
            conexao.Close();


            /*
            Funcionario funcionario1 = new Funcionario();
            funcionario1.cd_Funcionario = txtCodFunc.Text;
            funcionario1.cd_Pessoa = txtCodPessoaF.Text;
            funcionario1.ds_Cargo = txtCargo.Text;
            funcionario1.nr_Salario = txtSalario.Text;
            funcionario1.nr_Ramal = txtRamal.Text;

            lista_Funcionarios.Add(funcionario1);
            */
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario(Convert.ToInt32(txtCodPessoaF.Text), txtCargo.Text, txtSalario.Text, txtRamal.Text);
            LimparCampos();
            MessageBox.Show("Funcionários cadastrados!", "Cadastro - Funcionários");

            /*
            CadastrarFuncionario();
            CarregarGrid();
            LimparCampos();
            */
        }

        private void retornarFuncionario()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=CidadeInteligente;Data Source=LAB-08-01";
            conexao.Open();

            string comandoSQL = "select * from tb_funcionario";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvFuncionarios.DataSource = dt;

            conexao.Close();
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodPessoaF.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCargo.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSalario.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRamal.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[4].Value.ToString();

            retornarFuncionario();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        /*
        private void CarregarGrid()
        {
            dgvFuncionarios.DataSource = null;
            dgvFuncionarios.DataSource = lista_Funcionarios;
        }
        */

        /*
       private void CadastrarFuncionarios(int cd_Pessoa, string ds_Cargo, string nr_Salario, string nr_Ramal)
       {
           
       }
       */
    }
}
