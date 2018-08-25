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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        List<ClientePedido> lista_pedido = new List<ClientePedido>();

        private void Pedidos_Load(object sender, EventArgs e)
        {
            inserirPedido();
            CarregarGrid();

        }

        private void inserirPedido()
        {
            ClientePedido pedido1 = new ClientePedido();
            pedido1.idPedido = Convert.ToInt32(txbID.Text);
            pedido1.nmProduto = txbProduto.Text;
            pedido1.marca = txbMarca.Text;
            pedido1.dtPedido = Convert.ToDateTime(txbData.Text);
            pedido1.preco = txbPreco.Text;

            lista_pedido.Add(pedido1);

            //ClientePedido pedido2 = new ClientePedido();
            //pedido2.idPedido = 2;
            //pedido2.nmProduto = "borracha";
            //pedido2.marca = "faber castell";
            //pedido2.dtPedido = Convert.ToDateTime("2018-08-11");
            //pedido2.preco = "1.50";

            //lista_pedido.Add(pedido2);

            //ClientePedido pedido3 = new ClientePedido();
            //pedido3.idPedido = 3;
            //pedido3.nmProduto = "caneta";
            //pedido3.marca = "bic";
            //pedido3.dtPedido = Convert.ToDateTime("2018-08-11");
            //pedido3.preco = "1.20";

            //lista_pedido.Add(pedido3);

            //ClientePedido pedido4 = new ClientePedido();
            //pedido4.idPedido = 4;
            //pedido4.nmProduto = "apontador";
            //pedido4.marca = "faber castell";
            //pedido4.dtPedido = Convert.ToDateTime("2018-08-10");
            //pedido4.preco = "2.00";

            //lista_pedido.Add(pedido4);

            //ClientePedido pedido5 = new ClientePedido();
            //pedido5.idPedido = 5;
            //pedido5.nmProduto = "pasta";
            //pedido5.marca = "dac";
            //pedido5.dtPedido = Convert.ToDateTime("2018-08-11");
            //pedido5.preco = "2.50";

            //lista_pedido.Add(pedido5);

            
        }


        private void CarregarGrid() {

            gdvPedidos.DataSource = null;
            gdvPedidos.DataSource = lista_pedido;
        
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(lista_pedido.Count().ToString());
            //CONSULTA USANDO GENERICS

            List<ClientePedido> listaPesquisa = new List<ClientePedido>();
            listaPesquisa = lista_pedido;

            listaPesquisa = listaPesquisa.Where(i => i.nmProduto.Contains(txbProduto.Text) && i.marca.Contains (txbMarca.Text)).ToList();
            gdvPedidos.DataSource = null;
            gdvPedidos.DataSource = listaPesquisa;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbProduto.Text = string.Empty; // string.Empty || "";
            txbMarca.Text = "";
            txbID.Text = "";
            txbData.Text = "";
            txbPreco.Text = "";

            gdvPedidos.DataSource = null;
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //inserirPedido.Update(DataSet);
            //gdvPedidos.DataSource = lista_pedido;
            inserirPedido();
            CarregarGrid();
        }

      


     
    }
}
