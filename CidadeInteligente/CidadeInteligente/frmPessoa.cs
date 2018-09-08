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
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
        }

        private void frmPessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Cadastro de Pessoas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            else
            {
                MessageBox.Show("Cancelando");
                e.Cancel = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtEstCivil.Text = "";
            txtDtNasc.Text = "";
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtEstCivil.Text = "";
            txtDtNasc.Text = "";
        }
        
        private void CadastrarPessoa(string nm_Pessoa, string ds_Endereco, string ds_EstCivil, DateTime dt_Nascimento)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CidadeInteligente.accdb; Persist Security Info=False;";
            conexao.Open();
            string insertPessoa = string.Concat("insert into tb_pessoa (nm_Pessoa, ds_Endereco, ds_EstCivil, dt_Nascimento) values ('",nm_Pessoa,"', '",ds_Endereco,"', '",ds_EstCivil,"', '",dt_Nascimento,"') ");
            SqlCommand comandoSql = new SqlCommand(insertPessoa, conexao);
            comandoSql.ExecuteNonQuery();
            conexao.Close();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarPessoa(txtNome.Text, txtEndereco.Text, txtEstCivil.Text, Convert.ToDateTime(txtDtNasc.Text));
            LimparCampos();
            MessageBox.Show("Pessoa cadastrada!", "Cadastro - Pessoas");
        }

        
    }
}
