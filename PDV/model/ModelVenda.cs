using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.model
{
    public class ModelVenda
    {
        public int idVenda { get; set; }
        public DateTime data { get; set; }
        public DateTime hora { get; set; }
        public decimal total_venda { get; set; }
        public string situacao_venda { get; set; }
        public int Cliente_idCliente { get; set; }
        public int FormaPagamento_idFormaPagamento { get; set; }
    }
}
