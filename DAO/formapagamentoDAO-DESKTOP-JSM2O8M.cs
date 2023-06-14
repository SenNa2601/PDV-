using MySql.Data.MySqlClient;
using PDV.project.connect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.DAO
{
    public class formapagamentoDAO
    {
        private readonly MySqlConnection con;

        public formapagamentoDAO()
        {
            this.con = new conexaoSql().GetConnection();
        }


        public DataTable ListarFormaPagamento()
        {
            try
            {

                DataTable dt = new DataTable();
                string sql = "SELECT * FROM formapagamento ORDER BY nome asc";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar: " + ex);
                return null;
            }
        }
    }
}
