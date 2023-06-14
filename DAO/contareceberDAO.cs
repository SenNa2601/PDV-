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
    public class contareceberDAO
    {
        private readonly MySqlConnection con;

        public contareceberDAO()
        {
            this.con = new conexaoSql().GetConnection();
        }

        public void CadastrarConta(ModelContaReceber obj)
        {
            try
            {

                string sql = "INSERT INTO conta_receber(descricao,data_lancamento,data_vencimento,valor,pago,Cliente_idCliente) VALUES (@descricao, @data_lancamento, @data_vencimento, @valor, @pago, @Cliente_idCliente)";

                MySqlCommand cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@descricao", obj.descricao);
                cmd.Parameters.AddWithValue("@data_lancamento", obj.data_lancamento);
                cmd.Parameters.AddWithValue("@data_vencimento", obj.data_vencimento);
                cmd.Parameters.AddWithValue("@valor", obj.valor);
                cmd.Parameters.AddWithValue("@pago", obj.pago);
                cmd.Parameters.AddWithValue("@Cliente_idCliente", obj.Cliente_idCliente);

                con.Open();
                cmd.ExecuteNonQuery();


                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a venda" + ex);
            }
        }
    }

}
