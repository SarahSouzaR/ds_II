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
    public partial class frmDocumentos : Form
    {
        public frmDocumentos()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtCodPessoaD.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtReservista.Text = "";
            txtCTPS.Text = "";
            txtCNH.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCodPessoaD.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtReservista.Text = "";
            txtCTPS.Text = "";
            txtCNH.Text = "";
        }

        private void CadastrarDocumento(int cd_Pessoa, string nr_RG, string nr_CPF, string nr_Reservista, string nr_CTPS, string nr_CNH) 
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CidadeInteligente.accdb; Persist Security Info=False;";
            conexao.Open();
            string insertDoc = string.Concat("insert into tb_documentos (cd_Pessoa, nr_RG, nr_CPF, nr_Reservista, nr_CTPS, nr_CNH) values ('", cd_Pessoa, "', '", nr_RG, "', '", nr_CPF, "', '", nr_Reservista, "', '",nr_CTPS,"', '",nr_CNH,"') ");
            SqlCommand comandoSql = new SqlCommand(insertDoc, conexao);
            comandoSql.ExecuteNonQuery();
            conexao.Close();
              
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarDocumento(Convert.ToInt32(txtCodPessoaD.Text), txtRG.Text, txtCPF.Text, txtReservista.Text, txtCTPS.Text, txtCNH.Text);
            LimparCampos();
            MessageBox.Show("Documentos cadastrados!", "Cadastro - Documentos");
        }

       
    }
}
