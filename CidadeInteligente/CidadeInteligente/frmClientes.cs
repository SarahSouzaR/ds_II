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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CadastrarCliente();
            CarregarGrid();
        }

        private void LimparCampos()
        {
            txtCdCliente.Text = "";
            txtCodPessoaC.Text = "";
            txtDtInclusao.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        List<Cliente> lista_Cliente = new List<Cliente>();

        private void CadastrarCliente()
        {
            Cliente cliente1 = new Cliente();
            cliente1.cd_Cliente = txtCdCliente.Text;
            cliente1.cd_Pessoa = txtCodPessoaC.Text;
            cliente1.dt_Inclusao = txtDtInclusao.Text;

            lista_Cliente.Add(cliente1); 
        }

        private void CarregarGrid()
        {
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = lista_Cliente;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarCliente();
            CarregarGrid();
            LimparCampos();

            /*
             CadastrarClientes(Convert.ToInt32(txtCodPessoaC.Text), Convert.ToDateTime(txtDtInclusao.Text));
            LimparCampos();
            MessageBox.Show("Clientes cadastrados!", " Cadastro - Clientes");
            */
        }

        //PROGRAMA NÃO RECONHECEU O BANCO, deixar comentando em caso de ser a máquina e não o código

        /*
        private void CadastrarClientes(int cd_Pessoa, DateTime dt_Inclusao) 
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CidadeInteligente.accdb; Persist Security Info=False;";
            conexao.Open();
            string insertClientes = string.Concat("insert into tb_cliente (cd_Pessoa, dt_Inclusao) values ('", cd_Pessoa, "', '", dt_Inclusao, "') ");
            SqlCommand comandoSql = new SqlCommand(insertClientes, conexao);
            comandoSql.ExecuteNonQuery();
            conexao.Close();
        }
        */
    }
}
