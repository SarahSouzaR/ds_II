using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace frmAlunos
{
    public partial class frmCadAluno : Form
    {
        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //Declare o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_alunos;
        //Declare o BindingSource -- tabela virtual editável
        BindingSource bs_alunos = new BindingSource();
        // cria a variavel que receberá a query (comando sql)
        String _query;

        private void carregar_grid()
        {
            //Determine a query desejada
            _query = "Select * from alunos";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_alunos = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_alunos.HasRows == true)
            {
                bs_alunos.DataSource = dr_alunos;
                dgvAlunos.DataSource = bs_alunos;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos alunos cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar_text()
        {
            txbRM.DataBindings.Add("Text", bs_alunos, "rm");
            txbRM.DataBindings.Clear();
            txbNome.DataBindings.Add("Text", bs_alunos, "nome");
            txbNome.DataBindings.Clear();
            txbResponsavel.DataBindings.Add("Text", bs_alunos, "responsavel");
            txbResponsavel.DataBindings.Clear();
            txbEndereco.DataBindings.Add("Text", bs_alunos, "endereco");
            txbEndereco.DataBindings.Clear();
            mskTelefone.DataBindings.Add("Text", bs_alunos, "telefone");
            mskTelefone.DataBindings.Clear();
        }


        public frmCadAluno()
        {
            InitializeComponent();
        }

        private void frmCadAluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_alunosDataSet.alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.bD_alunosDataSet.alunos);
            // alimenta o datagridview com dados
            carregar_grid();
        }

        private void dgvAlunos_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        private void dgvAlunos_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            _query = "insert into alunos rm, nome, responsavel, endereco, telefone values ";
            //_query = INSERT INTO `alunos`(`rm`, `nome`, `responsavel`, `endereco`, `telefone`) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5]);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //COLOCAR DELETE DO BD
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //COLOCAR UPDATE DO BD
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //LIMPAR TODOS OS CAMPOS
        }
    }
}
