using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PDV
{
    public class conexaoSql
    {
        public string conec = "SERVER=localhost; DATABASE=mydb; UID=root; PWD=26010326Vinhotinto; PORT=3306";

        public MySqlConnection con = null;
        
        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }catch (Exception ex)
            {
                MessageBox.Show("erro de conexao com o banco de dados" + ex.Message);
            }
        }
        public void FecharConexao()
        {
                con = new MySqlConnection (conec);
                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
        }


    }
}
