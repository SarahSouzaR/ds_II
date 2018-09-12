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
            retornarClientes();
        }

        private void LimparCampos()
        {
            //txtCdCliente.Text = "";
            txtCodPessoaC.Text = "";
            txtDtInclusao.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //List<Cliente> lista_Cliente = new List<Cliente>();

        private void CadastrarCliente(int cd_Pessoa, DateTime dt_Inclusao)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=CidadeInteligente;Data Source=LAB-06-03";
            conexao.Open();
            string insertClientes = string.Concat("insert into tb_cliente (cd_Pessoa, dt_Inclusao) values ('", cd_Pessoa, "', '", dt_Inclusao, "') ");
            SqlCommand comandoSql = new SqlCommand(insertClientes, conexao);
            comandoSql.ExecuteNonQuery();
            conexao.Close();


            /*
            Cliente cliente1 = new Cliente();
            cliente1.cd_Cliente = txtCdCliente.Text;
            cliente1.cd_Pessoa = txtCodPessoaC.Text;
            cliente1.dt_Inclusao = txtDtInclusao.Text;

            lista_Cliente.Add(cliente1); 
            */ 
        }

        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarCliente(Convert.ToInt32(txtCodPessoaC.Text), Convert.ToDateTime(txtDtInclusao.Text));
            LimparCampos();
            MessageBox.Show("Clientes cadastrados!", " Cadastro - Clientes");

            /*
             CadastrarCliente();
            CarregarGrid();
            LimparCampos();
            */
        }

        private void retornarClientes()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=CidadeInteligente;Data Source=LAB-06-03";
            conexao.Open();

            string comandoSQL = "select * from tb_cliente";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvCliente.DataSource = dt;

            conexao.Close();
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodPessoaC.Text = dgvCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDtInclusao.Text = dgvCliente.Rows[e.RowIndex].Cells[2].Value.ToString();

            retornarClientes();
        }

        
        /*
        private void CadastrarClientes(int cd_Pessoa, DateTime dt_Inclusao) 
        {
           
        }
        */


        /*
        private void CarregarGrid()
        {
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = lista_Cliente;
        }
        */
    }
}
