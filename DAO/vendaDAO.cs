using MySql.Data.MySqlClient;
using PDV.model;
using PDV.project.connect;
using PDV.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.DAO
{
    public class vendaDAO
    {
        private readonly MySqlConnection con;

        public vendaDAO()
        {
            this.con = new conexaoSql().GetConnection();
        }

        public void RegistrarVenda(ModelVenda obj)
        {
            try
            {
                string sql = "INSERT INTO venda(data, hora, total_venda, situacao_venda, Cliente_idCliente) " +
                    "VALUES (@data, @hora, @total_venda, @situacao_venda, @Cliente_idCliente)";


                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@data", obj.data);
                cmd.Parameters.AddWithValue("@hora", obj.hora);
                cmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                cmd.Parameters.AddWithValue("@situacao_venda", obj.situacao_venda);
                cmd.Parameters.AddWithValue("@Cliente_idCliente", obj.Cliente_idCliente);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Venda realizada com sucesso!", "Venda",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);


                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a venda!" + ex);
            }
        }

    }
}
