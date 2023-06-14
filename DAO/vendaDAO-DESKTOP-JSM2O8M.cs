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
                string sql = "INSERT INTO venda(data, hora, total_venda, situacao_venda, Cliente_idCliente, FormaPagamento_idFormaPagamento) " +
                    "VALUES (@data, @hora, @total_venda, @situacao_venda, @Cliente_idCliente, @FormaPagamento_idFormaPagamento)";


                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@data", obj.data);
                cmd.Parameters.AddWithValue("@hora", obj.hora);
                cmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                cmd.Parameters.AddWithValue("@situacao_venda", obj.situacao_venda);
                cmd.Parameters.AddWithValue("@Cliente_idCliente", obj.Cliente_idCliente);
                cmd.Parameters.AddWithValue("@FormaPagamento_idFormaPagamento", obj.FormaPagamento_idFormaPagamento);

                con.Open();
                cmd.ExecuteNonQuery();


                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a venda!" + ex);
            }
        }

        public int RetornarUltimaVenda()
        {
            try
            {
                int idVenda = 0;
                string sql = "SELECT MAX(idVenda) idVenda FROM venda";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();

                MySqlDataReader read = cmd.ExecuteReader();
                if(read.Read())
                {
                    idVenda = read.GetInt32("idVenda");
                }

                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
                return idVenda;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex);
                return 0;
            }
        }

        public int RetornarCliente()
        {
            try
            {
                int idCliente = 0;
                string sql = @"SELECT MAX(Cliente_idCliente) Cliente_idCliente FROM venda";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();

                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    idCliente = read.GetInt32("Cliente_idCliente");
                }

                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
                return idCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex);
                return 0;
            }
        }

    }
}
