using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgendaMedica
{
    public partial class AgendaConsulta : Form
    {
        public AgendaConsulta()
        {
            InitializeComponent();
        }

        private void cadastrarFuncionario(string nmNome, string dtNascimento, string dsEmail, string nrTelefone, string dsEndereco)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=AgendaMedica;Data Source=LAB-06-03";
            conexao.Open();
            string insertFuncionario = string.Concat("insert into tb_funcionario (nmFuncioario,dsEmail,nrTelefone,dtNascimento,dsEndereco) values ('",nmNome,"','",dsEmail,"','",nrTelefone,"','",dtNascimento,"','",dsEndereco,"')");
            SqlCommand comandoSql = new SqlCommand(insertFuncionario, conexao);
            comandoSql.ExecuteNonQuery();

            conexao.Close();
       }

        private void retornarMedicos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=AgendaMedica;Data Source=LAB-06-03";
            conexao.Open();
            string retornarFuncionario = "select * from tb_funcionario";

            SqlDataAdapter sda = new SqlDataAdapter(retornarFuncionario, conexao);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            cmbNmMedico.DataSource = dt;
            cmbNmMedico.DisplayMember = "nmFuncioario";
            cmbNmMedico.ValueMember = "id_funcionario";
 
            conexao.Close();
        }

        private void cadastrarCliente(string nmCliente, string dtNascimento, string dsEmail, string nrTelefone, string dsEndereco, string nrCPF) 
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=AgendaMedica;Data Source=LAB-06-03";
            conexao.Open();
            string insertCliente = string.Concat("insert into tb_clientes (nmCliente, nrCPF, dsEmail, nrTelefone, dtNascimento, dsEndereco) values ('", nmCliente, "', '", nrCPF, "', '", dsEmail, "', '", nrTelefone, "', '", dtNascimento, "', '", dsEndereco, "')");
            SqlCommand comandoSql = new SqlCommand(insertCliente, conexao);
            comandoSql.ExecuteNonQuery();
            conexao.Close();
        }

        private void retornarPacientes()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=AgendaMedica;Data Source=LAB-06-03";
            conexao.Open();
            string retornarPacientes = "select * from tb_clientes";

            SqlDataAdapter sda2 = new SqlDataAdapter(retornarPacientes, conexao);

            DataTable dt2 = new DataTable();

            sda2.Fill(dt2);
            cmbNmPaciente.DataSource = dt2;
            cmbNmPaciente.DisplayMember = "nmCliente";
            cmbNmPaciente.ValueMember = "id_cliente";

            conexao.Close();
        }

        private void cadastrarConsulta(int id_cliente, string dtConsulta, string hrConsulta, string nmMedico) 
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=AgendaMedica;Data Source=LAB-06-03";
            conexao.Open();
            string inserirConsulta = string.Concat("insert into tb_consulta(dtConsulta, hrConsulta, nmMedico, id_cliente) values ('", id_cliente, "', '", dtConsulta, "', '", hrConsulta, "', '", nmMedico, "')");
            SqlCommand comandoSql = new SqlCommand(inserirConsulta, conexao);
            comandoSql.ExecuteNonQuery();
            conexao.Close();
        }

        private void retornarConsultas() 
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=AgendaMedica;Data Source=LAB-06-03";
            conexao.Open();

            string retornarConsulta = "select * from tb_consulta";

            SqlCommand sqlCommand = new SqlCommand(retornarConsulta, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvConsultas.DataSource = dt;

            conexao.Close(); 
        }

        private void limparCampos() 
        {
            txtNmMedico.Text = "";
            txtDtNascMedico.Text = "";
            txtEmailMedico.Text = "";
            txtTelMedico.Text = "";
            txtEndMedico.Text = "";

            txtNmPaciente.Text = "";
            txtDtNascPaciente.Text = "";
            txtEmailPaciente.Text = "";
            txtTelPaciente.Text = "";
            txtEndPaciente.Text = "";
            txtCPFPaciente.Text = "";
            cmbNmPaciente.Text = "";

            txtDtConsulta.Text = "";
            txtHoraConsulta.Text = "";
            cmbNmMedico.Text = "";
            cmbNmPaciente.Text = "";
        }


        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            cadastrarFuncionario(txtNmMedico.Text, txtDtNascMedico.Text, txtEmailMedico.Text, txtTelMedico.Text,txtEndMedico.Text);
            limparCampos();
            MessageBox.Show("Registro Cadastrado","Funcionario");
        }

        private void btnSalvarCli_Click(object sender, EventArgs e)
        {
            cadastrarCliente(txtNmPaciente.Text, txtDtNascPaciente.Text, txtEmailPaciente.Text, txtTelPaciente.Text, txtEndPaciente.Text, txtCPFPaciente.Text);
            limparCampos();
            MessageBox.Show("Registro Cadastrado", "Cliente");
        }

        private void btnSalvarConsu_Click(object sender, EventArgs e)
        {
            cadastrarConsulta(Convert.ToInt32(cmbNmPaciente.Text), txtDtConsulta.Text, txtHoraConsulta.Text, cmbNmMedico.Text);
            limparCampos();
            MessageBox.Show("Registro Cadastrado", "Consulta");
        }

        private void AgendaConsulta_Load(object sender, EventArgs e)
        {
            retornarMedicos();
            retornarPacientes();
            retornarConsultas();
        }
    }
}
