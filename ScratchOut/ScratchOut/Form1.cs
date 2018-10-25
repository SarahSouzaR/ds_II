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

namespace ScratchOut
{
    public partial class frmTarefas : Form
    {
        public frmTarefas()
        {
            InitializeComponent();
        }

        public void cadastrarTarefa(int idTarefa, string nmTarefa, string descricao, string prazo, string dtInicio, string dtTermino)
        {
            SqlConnection conn = new SqlConnection();

        }


    }
}
