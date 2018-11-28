using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Prova2611_SarahSouza
{
    static class Program
    {
        public static string conexao = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=SistemaBiblioteca;Data Source=LAB-01-03";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Aluno());
        }
    }
}
