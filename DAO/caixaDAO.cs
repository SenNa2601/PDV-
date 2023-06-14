using MySql.Data.MySqlClient;
using PDV.model;
using PDV.project.connect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.DAO
{
    public class caixaDAO
    {
        private readonly MySqlConnection con;

        public caixaDAO()
        {
            this.con = new conexaoSql().GetConnection();
        }

        public void popularCB(ModelCaixa obj)
        {

        }
    }
}

    