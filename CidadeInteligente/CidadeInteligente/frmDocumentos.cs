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
    public partial class frmDocumentos : Form
    {
        public frmDocumentos()
        {
            InitializeComponent();
        }

        private void frmDocumentos_Load(object sender, EventArgs e)
        {
            retornarDocumentos();
        }

        private void LimparCampos()
        {
            //txtCodDoc.Text = "";
            txtCodPessoaD.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtReservista.Text = "";
            txtCTPS.Text = "";
            txtCNH.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
       
        //List<Documento> lista_Documento = new List<Documento>();

        private void CadastrarDocumentos(int cd_Pessoa, string nr_RG, string nr_CPF, string nr_Reservista, string nr_CTPS, string nr_CNH)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=CidadeInteligente;Data Source=LAB-06-03";
            conexao.Open();
            string insertDoc = string.Concat("insert into tb_documentos (cd_Pessoa, nr_RG, nr_CPF, nr_Reservista, nr_CTPS, nr_CNH) values ('", cd_Pessoa, "', '", nr_RG, "', '", nr_CPF, "', '", nr_Reservista, "', '", nr_CTPS, "', '", nr_CNH, "') ");
            SqlCommand comandoSql = new SqlCommand(insertDoc, conexao);
            comandoSql.ExecuteNonQuery();
            conexao.Close();
        }
                
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarDocumentos(Convert.ToInt32(txtCodPessoaD.Text), txtRG.Text, txtCPF.Text, txtReservista.Text, txtCTPS.Text, txtCNH.Text);
            LimparCampos();
            MessageBox.Show("Documentos cadastrados!", "Cadastro - Documentos");
        }

        private void retornarDocumentos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=CidadeInteligente;Data Source=LAB-06-03";
            conexao.Open();

            string comandoSQL = "select * from tb_documentos ";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvDocumentos.DataSource = dt;

            conexao.Close();
        }

        private void dgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodPessoaD.Text = dgvDocumentos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRG.Text = dgvDocumentos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCPF.Text = dgvDocumentos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtReservista.Text = dgvDocumentos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCTPS.Text = dgvDocumentos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCNH.Text = dgvDocumentos.Rows[e.RowIndex].Cells[6].Value.ToString();

            retornarDocumentos();
        }

       //PROGRAMA NÃO RECONHECEU O BANCO, deixar comentando em caso de ser a máquina e não o código
        
        /*
        private void CadastrarDocumento(int cd_Pessoa, string nr_RG, string nr_CPF, string nr_Reservista, string nr_CTPS, string nr_CNH) 
        {
            
              
        }
        */

        /*
        private void CarregarGrid()
        {
            dgvDocumentos.DataSource = null;
            dgvDocumentos.DataSource = lista_Documento;
        }
        */
    }

}
