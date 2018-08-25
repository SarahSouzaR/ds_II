using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;

namespace EtecMetodoGenerics
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        List<Cliente> clientes = new List<Cliente>();

        private void Clientes_Load(object sender, EventArgs e)
        {
            inserirCliente();
            CarregarGrid();
        }

        private void inserirCliente()
        {
            Cliente cliente1 = new Cliente();
            cliente1.codigoCliente = Convert.ToInt32(txbID.Text);
            cliente1.nmCliente = txbNome.Text;
            cliente1.dtNascimento = Convert.ToDateTime(txbDtNasc.Text);
            cliente1.nrTelefone = txbTelefone.Text;
            cliente1.endereco = txbEndereco.Text;

            clientes.Add(cliente1);
        }

        private void CarregarGrid()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<Cliente> listaPesquisa = new List<Cliente>();
            listaPesquisa = clientes;

            listaPesquisa = listaPesquisa.Where(i => i.nmCliente.Contains(txbNome.Text) && i.endereco.Contains(txbEndereco.Text)).ToList();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaPesquisa;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbNome.Text = string.Empty; // string.Empty || "";
            txbDtNasc.Text = "";
            txbTelefone.Text = "";
            txbEndereco.Text = "";

            dgvClientes.DataSource = null;
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            inserirCliente();
            CarregarGrid();
        }
      


  

     

   

    
    }
}
