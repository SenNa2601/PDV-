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
    public class movimentocaixaDAO
    {
        readonly MySqlConnection con;

        public movimentocaixaDAO()
        {
            this.con = new conexaoSql().GetConnection();
        }

        public void InserirMovimentoCaixa(ModelMovimentoCaixa obj)
        {
            try
            {
                string sql = "INSERT INTO movimentocaixa (data_movimento, hora_movimento," +
                    "descricao, tipo_movimento, valor) VALUES (@data_movimento, @hora_movimento," +
                    "@descricao, @tipo_movimento, @valor)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@data_movimento",obj.data_movimento);
                cmd.Parameters.AddWithValue("@hora_movimento",obj.hora_movimento);
                cmd.Parameters.AddWithValue("@descricao",obj.descricao);
                cmd.Parameters.AddWithValue("@tipo_movimento",obj.tipo_movimento);
                cmd.Parameters.AddWithValue("@valor",obj.valor);

                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível inserir o movimento de caixa!" + ex);
            }
        }

        public int RetornarUltimoMovimento()
        {
            try
            {
                int idMovimento = 0;
                string sql = "SELECT MAX(idMovimentoCaixa) idMovimentoCaixa FROM movimentocaixa";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();

                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    idMovimento = read.GetInt32("idMovimentoCaixa");
                }

                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
                return idMovimento;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex);
                return 0;
            }
        }
    }
}
