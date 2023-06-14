using MySql.Data.MySqlClient;
using PDV.model;
using PDV.project.connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.DAO
{
    public class itemvendaDAO
    {
        private readonly MySqlConnection con;

        public itemvendaDAO()
        {
            this.con = new conexaoSql().GetConnection();
        }

        public void CadastrarItem(ModelItemVenda obj)
        {
            try
            {
                string sql = "INSERT INTO itemvenda(Venda_idVenda, Venda_Cliente_idCliente, Produto_idProduto, quantidade, valor_unitario, total_item)" +
                              "VALUES(@Venda_idVenda, @Venda_Cliente_idCliente, @Produto_idProduto, @quantidade, @valor_unitario, @total_item)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Venda_idVenda", obj.Venda_idVenda);
                cmd.Parameters.AddWithValue("@Venda_Cliente_idCliente", obj.Venda_Cliente_idCliente);
                cmd.Parameters.AddWithValue("@Produto_idProduto", obj.Produto_idProduto);
                cmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                cmd.Parameters.AddWithValue("@valor_unitario", obj.valor_unitario);
                cmd.Parameters.AddWithValue("@total_item", obj.total_item);
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }
    }
}
