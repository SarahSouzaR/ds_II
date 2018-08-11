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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSenha.Text== "") 
            {
                MessageBox.Show("Campo não pode estar vazio", "Etec da Zona Leste");
            }
        }
    }
}
