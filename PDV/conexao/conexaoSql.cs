using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PDV.project.connect
{
    public class conexaoSql
    {
        public MySqlConnection GetConnection()
        {
            string con = ConfigurationManager.ConnectionStrings["pdv"].ConnectionString;
            return new MySqlConnection(con);
        }


    }
}
