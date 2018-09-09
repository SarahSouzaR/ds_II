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
            CarregarGrid();
            CadastrarDocumentos();
        }

        private void LimparCampos()
        {
            txtCodDoc.Text = "";
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
       
        List<Documento> lista_Documento = new List<Documento>();

        private void CadastrarDocumentos()
        {
            Documento documento1 = new Documento();
            documento1.cd_DocPessoa = txtCodDoc.Text;
            documento1.cd_Pessoa = txtCodPessoaD.Text;
            documento1.nr_RG = txtRG.Text;
            documento1.nr_CPF = txtCPF.Text;
            documento1.nr_Reservista = txtReservista.Text;
            documento1.nr_CTPS = txtCTPS.Text;
            documento1.nr_CNH = txtCNH.Text;

            lista_Documento.Add(documento1); 
        }

        private void CarregarGrid()
        {
            dgvDocumentos.DataSource = null;
            dgvDocumentos.DataSource = lista_Documento;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarDocumentos();
            CarregarGrid();
            LimparCampos();

            /*
            CadastrarDocumento(Convert.ToInt32(txtCodPessoaD.Text), txtRG.Text, txtCPF.Text, txtReservista.Text, txtCTPS.Text, txtCNH.Text);
            LimparCampos();
            MessageBox.Show("Documentos cadastrados!", "Cadastro - Documentos");
            */
        }

        //PROGRAMA NÃO RECONHECEU O BANCO, deixar comentando em caso de ser a máquina e não o código
        
        /*
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
        */     
    }
}
