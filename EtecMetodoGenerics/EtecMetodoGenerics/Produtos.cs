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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        List<Classes.Produtos> listaProdutos = new List<Classes.Produtos>();

        private void Produtos_Load(object sender, EventArgs e)
        {
            inserirProduto();
            CarregarGrid();
        }

        private void inserirProduto()
        {
            Classes.Produtos produto1 = new Classes.Produtos();
            produto1.idProduto = Convert.ToInt32(txbId.Text);
            produto1.produto = txbProduto.Text;
            produto1.fabricante = txbFabric.Text;
            produto1.precoUnit = txbPrecoUnit.Text;
            produto1.quantidade = Convert.ToInt32(txbQuantidade.Text);
            produto1.validade = Convert.ToDateTime(txbValidade.Text);
            produto1.telefone = txbTelFabric.Text;

            listaProdutos.Add(produto1);

        }

        private void CarregarGrid() {
        
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = listaProdutos;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<Classes.Produtos> listaPesquisa = new List<Classes.Produtos>();
            listaPesquisa = listaProdutos;

            listaPesquisa = listaPesquisa.Where(i => i.produto.Contains(txbProduto.Text) && i.telefone.Contains(txbTelFabric.Text)).ToList();
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = listaPesquisa;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbId.Text = "";
            txbProduto.Text = "";
            txbPrecoUnit.Text = "";
            txbQuantidade = "";

        }

        
      
    

       
    }
}
