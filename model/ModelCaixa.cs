using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.model
{
    public class ModelCaixa
    {
        public int idCaixa { get; set; }
        public string nome { get; set;}
        public float saldo { get; set;}
        public int Venda_idVenda { get; set; }
        public int MovimentoCaixa_idMovimentoCaixa { get; set; }
    }
}
