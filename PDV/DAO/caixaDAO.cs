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

        public void inserirCaixa(ModelCaixa obj)
        {

            try
            {
                string sql = "INSERT INTO caixa (nome,saldo,Venda_idVenda,MovimentoCaixa_idMovimentoCaixa) " +
                "VALUES (@nome,@saldo,@Venda_idVenda,@MovimentoCaixa_idMovimentoCaixa)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@saldo", obj.saldo);
                cmd.Parameters.AddWithValue("@Venda_idVenda", obj.Venda_idVenda);
                cmd.Parameters.AddWithValue("@MovimentoCaixa_idMovimentoCaixa", obj.MovimentoCaixa_idMovimentoCaixa);

                con.Open();
                cmd.ExecuteNonQuery();


                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível inserir a venda no caixa" + ex);
            }
            


        }

        public decimal RetornarSomaCaixa()
        {
            try
            {
                decimal soma = 0;
                string sql = "SELECT SUM(saldo) as saldo FROM caixa";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();
                cmd.ExecuteNonQuery();
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    soma = read.GetDecimal("saldo");
                    con.Close();
                    con.Dispose();
                    con.ClearAllPoolsAsync();
                }
                return soma;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar: " + ex);
                return 0;
            }
        }
    }
}

    