using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CidadeInteligente
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPessoa pessoa = new frmPessoa();
            pessoa.MdiParent = this;
            pessoa.Show();
        }

        private void documentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDocumentos doc = new frmDocumentos();
            doc.MdiParent = this;
            doc.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionarios func = new frmFuncionarios();
            func.MdiParent = this;
            func.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes cliente = new frmClientes();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
             
    }
}
