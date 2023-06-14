using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.model
{
    public class ModelItemVenda
    {
        public int Venda_idVenda { get; set; }
        public int Venda_Cliente_idCliente { get; set; }
        public int Produto_idProduto { get; set; }
        public int quantidade { get; set; }
        public decimal valor_unitario { get; set; }
        public decimal total_item { get; set; }


    }
}
