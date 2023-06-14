using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.model
{
    public class ModelFornecedor
    {
        public int idFornecedor { get; set; }
        public string nome { get; set; }
        public string cpf_cnpj { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }


    }

}
