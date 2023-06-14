using MySql.Data.MySqlClient;
using PDV.project.connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.DAO
{
    public class formapagamentoDAO
    {
        private readonly MySqlConnection con;

        public formapagamentoDAO()
        {
            this.con = new conexaoSql().GetConnection();
        }

    }
}
