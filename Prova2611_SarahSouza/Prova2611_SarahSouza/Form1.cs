using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prova2611_SarahSouza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            retornarEstudantes();
            Turma();
        }

        private void retornarEstudantes()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.conexao;
            conn.Open();

            string selectEst = "select idAluno 'Código do Estudante', nome 'Nome', dtNasc 'Data de Nascimento', email 'E-mail', endereco 'Endereço', telefone 'Telefone', rg 'RG', cpf 'CPF', rm 'RM', turma 'Turma' from tbAluno";

            SqlCommand sqlCommand = new SqlCommand(selectEst, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgvEstudantes.DataSource = dt;

            conn.Close();
        }
                
        //insert e update
        private void CadastrarEstudante(int idAluno, string nome, string dtNasc, string email, string endereco, string telefone, string rg, string cpf, string rm, string turma)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.conexao;
            conn.Open();

            string query = "";

            if (idAluno == 0)
            {
                query = String.Concat("insert into tbAluno (nome, dtNasc, email, endereco, telefone, rg, cpf, rm, turma) values ('", nome, "', '", dtNasc, "', '", email, "', '", endereco, "', '", telefone, "', '", rg, "', '", cpf, "',  '", rm, "', '", turma, "')");
            }
            else
            {
                query = String.Concat("update tbAluno set nome = '",nome,"', dtNasc ='",dtNasc,"', email = '",email,"', endereco = '",endereco,"', telefone = '",telefone,"', rg = '",rg,"', cpf = '",cpf,"', rm = '",rm,"', turma = '",turma,"' where idAluno = ",idAluno,";");
            }

            SqlCommand comando = new SqlCommand(query, conn);
            comando.ExecuteNonQuery();
            conn.Close();             
        }        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "0";
            }

            CadastrarEstudante(int.Parse(txtId.Text), txtNome.Text, txtDtNasc.Text, txtEmail.Text, txtEndereco.Text, txtTel.Text, txtRg.Text, txtCpf.Text, txtRM.Text, cboTurma.Text);
            LimparCampos();
            MessageBox.Show("Estudante Cadastrado!", "Cadastro Estudante");
            retornarEstudantes();
        }

        //limpar
        private void LimparCampos()
        {
            txtCpf.Text = "";
            txtDtNasc.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtPesquisa.Text = "";
            txtRg.Text = "";
            txtRM.Text = "";
            txtTel.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }         

        //delete
        private void DeletarEstudante(int idAluno) 
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.conexao;
            conn.Open();

            string delete = string.Concat("delete tbAluno where idAluno = '",idAluno,"'");

            SqlCommand comando = new SqlCommand(delete, conn);
            comando.ExecuteNonQuery();
            conn.Close();            

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DeletarEstudante(int.Parse(txtId.Text));
            LimparCampos();
            MessageBox.Show("Cadastro Excluído!", "Excluído com sucesso!");
        }

        private void dgvEstudantes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvEstudantes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvEstudantes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDtNasc.Text = dgvEstudantes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvEstudantes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEndereco.Text = dgvEstudantes.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTel.Text = dgvEstudantes.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtRg.Text = dgvEstudantes.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCpf.Text = dgvEstudantes.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtRM.Text = dgvEstudantes.Rows[e.RowIndex].Cells[8].Value.ToString();
            cboTurma.Text = dgvEstudantes.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        //pesquisa
        public void buscarEstudante()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.conexao;
            conn.Open();

            string selectEst = string.Concat("select idAluno 'Código do Estudante', nome 'Nome', dtNasc 'Data de Nascimento', email 'E-mail', endereco 'Endereço', telefone 'Telefone', rg 'RG', cpf 'CPF', rm 'RM', turma 'Turma' from tbAluno where nome like '%" , txtPesquisa.Text, "%';");

            SqlCommand sqlCommand = new SqlCommand(selectEst, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgvEstudantes.DataSource = dt;

            conn.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            buscarEstudante();
        }

        //combobox Turma
        private void Turma()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.conexao;
            conn.Open();

            string retornarTurma = "select turma from tbAluno group by turma order by count(turma) DESC";

            SqlDataAdapter sda = new SqlDataAdapter(retornarTurma, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cboTurma.DataSource = dt;
            cboTurma.DisplayMember = "turma";

            conn.Close();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            Emprestimo emp = new Emprestimo();
            this.Hide();
            emp.Show();
        }
    }
}
