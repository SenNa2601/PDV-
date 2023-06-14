using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.model
{
    public class ModelContaReceber
    {
        public int idConta_Receber { get; set; }
        public string descricao { get; set; }
        public DateTime data_lancamento { get; set; }
        public DateTime data_vencimento { get; set; }
        public decimal valor { get; set; }
        public string pago { get; set; }
        public DateTime data_pagamento { get; set; }
        public decimal valor_pagamento { get; set; }
        public int Cliente_idCliente { get; set; }
    }
}
