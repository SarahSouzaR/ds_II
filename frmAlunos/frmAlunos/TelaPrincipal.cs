using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmAlunos
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void candidatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadAluno cadastrar = new frmCadAluno();
            cadastrar.MdiParent = this;
            cadastrar.Show();
        }

        private void eleitorarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadEleitor eleitor = new frmCadEleitor();
            eleitor.MdiParent = this;
            eleitor.Show();
        }

        private void candidatarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadCandidato candidato = new frmCadCandidato();
            candidato.MdiParent = this;
            candidato.Show();
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.MdiParent = this;
            login.Show();
        }

        private void votarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVotacao votar = new frmVotacao();
            votar.MdiParent = this;
            votar.Show();
        }
    }
}
