using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.model
{
    public class ModelMovimentoCaixa
    {
        public int idMovimentoCaixa { get; set; }
        public DateTime data_movimento { get; set; }
        public DateTime hora_movimento { get; set; }
        public string descricao { get; set; }
        public string tipo_movimento { get; set; }
        public decimal valor { get; set; }
    }
}
