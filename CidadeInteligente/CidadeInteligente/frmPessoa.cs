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
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
        }

        private void frmPessoa_Load(object sender, EventArgs e)
        {
            CadastrarPessoa();
            CarregarGrid();
        }
        
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtEstCivil.Text = "";
            txtDtNasc.Text = "";
            txtCdPessoa.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        List<Pessoa> lista_Pessoas = new List<Pessoa>();

        private void CadastrarPessoa()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nm_Pessoa = txtNome.Text;
            pessoa1.ds_Endereco = txtEndereco.Text;
            pessoa1.ds_EstCivil = txtEstCivil.Text;
            pessoa1.dt_Nascimento = txtDtNasc.Text;
            pessoa1.cd_Pessoa = txtCdPessoa.Text;

            lista_Pessoas.Add(pessoa1);
        }

        private void CarregarGrid()
        {
            dgvPessoas.DataSource = null;
            dgvPessoas.DataSource = lista_Pessoas;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {            
            CadastrarPessoa();
            CarregarGrid();
            LimparCampos();

            /*CadastrarPessoa(txtNome.Text, txtEndereco.Text, txtEstCivil.Text, Convert.ToDateTime(txtDtNasc.Text));
            LimparCampos();
            MessageBox.Show("Pessoa cadastrada!", "Cadastro - Pessoas");
            */
        }

        private void frmPessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Cadastro de Pessoas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            else
            {
                MessageBox.Show("Cancelando");
                e.Cancel = true;
            }
        }

        //PROGRAMA NÃO RECONHECEU O BANCO, deixar comentando em caso de ser a máquina e não o código

        /*
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
        */
    }
}
