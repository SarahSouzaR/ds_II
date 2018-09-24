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
            retornarPessoas();
            carregarPessoa();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtEstCivil.Text = "";
            txtDtNasc.Text = "";
            //txtCdPessoa.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //List<Pessoa> lista_Pessoas = new List<Pessoa>();

        private void CadastrarPessoa(string nm_Pessoa, string ds_Endereco, string ds_EstCivil, DateTime dt_Nascimento)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=CidadeInteligente;Data Source=LAB-08-01";
            conexao.Open();
            string insertPessoa = string.Concat("insert into tb_pessoa (nm_Pessoa, ds_Endereco, ds_EstCivil, dt_Nascimento) values ('", nm_Pessoa, "', '", ds_Endereco, "', '", ds_EstCivil, "', '", dt_Nascimento, "') ");
            SqlCommand comandoSql = new SqlCommand(insertPessoa, conexao);
            comandoSql.ExecuteNonQuery();
            conexao.Close();
            
            /*
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nm_Pessoa = txtNome.Text;
            pessoa1.ds_Endereco = txtEndereco.Text;
            pessoa1.ds_EstCivil = txtEstCivil.Text;
            pessoa1.dt_Nascimento = txtDtNasc.Text;
            pessoa1.cd_Pessoa = txtCdPessoa.Text;

            lista_Pessoas.Add(pessoa1);
            */
        }
                
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarPessoa(txtNome.Text, txtEndereco.Text, txtEstCivil.Text, Convert.ToDateTime(txtDtNasc.Text));
            LimparCampos();
            MessageBox.Show("Pessoa cadastrada!", "Cadastro - Pessoas");
        }

        private void ApagarPessoa()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=CidadeInteligente;Data Source=LAB-08-01";
            conexao.Open();
            string deletePessoa = string.Concat("delete from tb_pessoa where id=");
            SqlCommand comandoSql = new SqlCommand(deletePessoa, conexao);
            comandoSql.ExecuteNonQuery();
            conexao.Close();
        }


        private void btnApagar_Click(object sender, EventArgs e)
        {
            ApagarPessoa();
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

        //na ausência de um banco, usar a lista

        /*
        private void CarregarGrid()
        {
            dgvPessoas.DataSource = null;
            dgvPessoas.DataSource = lista_Pessoas;
        }
        */

        private void retornarPessoas()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=Cidade;Data Source=LAB-08-01";
            conexao.Open();

            string comandoSQL = "select * from tb_pessoa";
            //string comandoSQL = "select cd_Pessoa 'Código da Pessoa', nm_Pessoa 'Nome da Pessoa' from tb_pessoa";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvPesquisaPessoa.DataSource = dt;

            conexao.Close();
        }

        private void dgvPesquisaPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgvPesquisaPessoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = dgvPesquisaPessoa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEstCivil.Text = dgvPesquisaPessoa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDtNasc.Text = dgvPesquisaPessoa.Rows[e.RowIndex].Cells[4].Value.ToString();

            //MessageBox.Show(dgvPesquisaPessoa.Rows[e.RowIndex].Cells[0].Value.ToString());
            //MessageBox.Show("Olá mundo!", "Etec ZL");

            retornarPessoas();
        }

        private void carregarPessoa()
        {
            DataSet ds = new DataSet();

            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=CidadeInteligente;Data Source=LAB-06-03");
                conexao.Open();

                SqlCommand cmd = new SqlCommand("ps_Nome", conexao);
                cmd.CommandType = CommandType.StoredProcedure;

                if (txtNome.Text != "")
                {
                    cmd.Parameters.AddWithValue("@nm_Pessoa", txtNome.Text);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);

                dgvPesquisaPessoa.DataSource = ds.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro! Contate o administrador!", "ERROR");
            }

            finally
            {
                conexao.Close();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarPessoa();
        }
    }
}
