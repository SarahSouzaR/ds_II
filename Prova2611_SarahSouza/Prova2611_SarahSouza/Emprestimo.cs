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
    public partial class Emprestimo : Form
    {
        public Emprestimo()
        {
            InitializeComponent();
        }

        private void Emprestimo_Load(object sender, EventArgs e)
        {
            retornarAluno();
            retornarTurma();
            retornarLivros();
        }

        private void retornarLivros()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.conexao;
            conn.Open();

            string selectLiv = "select idEmprestimo 'Código do Empréstimo', nmLivro 'Nome do Livro', turma 'Turma', nmAluno 'Aluno', dtDevolucao 'Data de Devolução' from tbEmprestimo";
           
            SqlCommand sqlCommand = new SqlCommand(selectLiv, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgvLivro.DataSource = dt;

            conn.Close();
        }
                
        //insert e update
        private void CadastrarEmprestimo(int idEmprestimo, string nmLivro, string dtDevolucao, string nmAluno, string turma)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.conexao;
            conn.Open();

            string query = "";

            if (idEmprestimo == 0)
            {
                query = String.Concat("insert into tbEmprestimo (nmLivro, dtDevolucao, nmAluno, turma) values ('", nmLivro, "', '", dtDevolucao, "', '", cboAluno.Text, "', '", cboTurma.Text, "')");
            }
            else
            {
                query = String.Concat("update tbEmprestimo set nmLivro = '", nmLivro, "', dtDevolucao ='", dtDevolucao, "', nmAluno = '", cboAluno.Text, "', turma = '", cboTurma.Text, "' where idEmprestimo = ", idEmprestimo, ";");
            }

            SqlCommand comando = new SqlCommand(query, conn);
            comando.ExecuteNonQuery();
            conn.Close();            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarEmprestimo(int.Parse(txtId.Text), txtNmLivro.Text, txtDtDevolucao.Text, cboAluno.Text, cboTurma.Text);
            LimparCampos();
            MessageBox.Show("Empréstimo Concluído!", "Feito!");
            retornarLivros();
        }

        //delete
        private void DeletarEmprestimo(int idEmprestimo)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.conexao;
            conn.Open();

            string delete = string.Concat("delete tbEmprestimo where idEmprestimo = '", idEmprestimo, "'");

            SqlCommand comando = new SqlCommand(delete, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DeletarEmprestimo(int.Parse(txtId.Text));
            LimparCampos();
            MessageBox.Show("Cadastro Excluído!", "Excluído com sucesso!");
            retornarLivros();
            LimparCampos();
        }    

        //limpar
        private void LimparCampos()
        {
            txtDtDevolucao.Text = "";
            txtNmLivro.Text = "";
            txtPesquisaLivro.Text = "";
            txtId.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }                    

        private void dgvLivro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvLivro.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNmLivro.Text = dgvLivro.Rows[e.RowIndex].Cells[1].Value.ToString();
            cboTurma.Text = dgvLivro.Rows[e.RowIndex].Cells[2].Value.ToString();
            cboAluno.Text = dgvLivro.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDtDevolucao.Text = dgvLivro.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        //pesquisa
        public void buscarLivro() 
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.conexao;
            conn.Open();

            string selectLivro = String.Concat("select idEmprestimo 'Código do Empréstimo', nmLivro 'Nome do Livro', turma 'Turma', nmAluno 'Aluno', dtDevolucao 'Data de Devolução' from tbEmprestimo where nmLivro like '%", txtPesquisaLivro.Text, "%';");

            SqlCommand comando = new SqlCommand(selectLivro, conn);
            SqlDataAdapter sda = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgvLivro.DataSource = dt;

            conn.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            buscarLivro();
        }

        //combobox Aluno
        private void retornarAluno()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.conexao;
            conn.Open();

            string retornarAluno = string.Concat("select nome from tbAluno where turma = '",cboTurma.Text,"' ");

            SqlCommand comandoAluno = new SqlCommand(retornarAluno, conn);
            SqlDataAdapter sda1 = new SqlDataAdapter(comandoAluno);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            cboAluno.DataSource = dt1;
            cboAluno.DisplayMember = "nome";

            conn.Close(); 
        }

        //combobox Turma
        private void retornarTurma()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.conexao;
            conn.Open();

            string retornarTurma = "select turma from tbAluno group by turma order by count(turma) DESC";

            SqlDataAdapter sda2 = new SqlDataAdapter(retornarTurma, conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            cboTurma.DataSource = dt2;
            cboTurma.DisplayMember = "turma";

            conn.Close();
        }

        private void cboTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            retornarAluno();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Aluno voltar = new Aluno();
            this.Hide();
            voltar.Show();
        }
    }
}