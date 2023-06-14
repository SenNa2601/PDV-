using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.model
{
    public class ModelProdutos
    {

        public int id_produto { get; set; } 
        public string nome   { get; set; }
        public int quantidade_estoque { get; set; }
        public decimal preco { get; set; }
        public string unidade { get; set; }
        public int Fornecedor_idFornecedor { get; set; }
    }
}
