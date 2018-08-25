using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Produtos
    {
        public int idProduto { get; set; }
        public string produto { get; set; }
        public string fabricante { get; set; }
        public string precoUnit { get; set; }
        public int quantidade { get; set; }
        public DateTime validade { get; set; }
        public string telefone { get; set; }
    }
}
