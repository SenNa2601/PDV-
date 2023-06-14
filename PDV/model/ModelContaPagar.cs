using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.model
{
    public class ModelContaPagar
    {

        public int id_ContaPagar{ get; set; }
        public string descricao { get; set; }
        public float valor { get; set; }
        public string pago { get; set; }
        public DateTime data_lancamento { get; set; }
        public DateTime data_vencimento { get; set; }
        public DateTime data_pagamento { get; set; }
        public float valor_pagamento{ get; set; }

        public int Fornecedor_idFornecedor { get; set; }
    }
}
