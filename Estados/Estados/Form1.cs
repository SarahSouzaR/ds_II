using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Estados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void carregarEstado()
        {
            ////Validar se o campo estado está preenchido
            ////diferente de vazio

            //if (txtEstado.Text == "")
            //{
            //    MessageBox.Show("Digitar o nome do Estado!!!");

            //    return;
            //}

            DataSet ds = new DataSet();

            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=Cidade;Data Source=LAB-08-01");
                conexao.Open();

                SqlCommand cmd = new SqlCommand("sp_RetornarEstados", conexao);

                //informo que estou trabalhando com stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                if (txtEstado.Text != "")
                {
                    //colocar cursor no addWithValue e aperta F12: saber um pouco mais da biblioteca
                    cmd.Parameters.AddWithValue("@nm_estado", txtEstado.Text);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);

                //carregar datagrid na tela
                dgvEstados.DataSource = ds.Tables[0];
                //colocar Tables[0] para dizer que quero a primeira tabela
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro!!! Contatar administrador!", "Error :-(");
            }

            finally
            {
                conexao.Close(); 
            }                        
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarEstado();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarEstado();
        }

        //ctrl + shift + b ----- para conferir se está tudo certo, sem erros
    }
}
