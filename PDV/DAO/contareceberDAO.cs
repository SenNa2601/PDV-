using MySql.Data.MySqlClient;
using PDV.model;
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

        public DataTable ListarContas()
        {
            try
            {

                DataTable dt = new DataTable();
                string sql = @"SELECT cr.*, c.nome AS 'Nome cliente' FROM conta_receber AS cr INNER JOIN cliente AS c ON cr.Cliente_idCliente = c.idCliente ORDER BY valor asc";
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

        public void PagarConta(ModelContaReceber obj, string id)
        {
            try
            {
                //INSERINDO OS DADOS CONTIDOS NOS TEXTBOX NO BANCO DE DADOS

                string sql = "UPDATE Conta_receber SET pago = @pago, data_pagamento = @data_pagamento, valor_pagamento = @valor_pagamento WHERE idConta_Receber = @idConta_Receber";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@pago", obj.pago);
                cmd.Parameters.AddWithValue("@data_pagamento", obj.data_pagamento);
                cmd.Parameters.AddWithValue("@valor_pagamento", obj.valor_pagamento);
                cmd.Parameters.AddWithValue("idConta_Receber", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Dispose();
                con.ClearAllPoolsAsync();

                //FIM DA INSERÇÃO

                //MENSAGEM DE SUCESSO NA INSERÇÃO
                MessageBox.Show("Conta Paga com Sucesso!", "Ponto de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar conta: " + ex);

            }

        }

        public void ExcluirConta(string id)
        {
            try
            {
                string sql = "DELETE FROM Conta_receber WHERE idConta_receber = @idConta_receber";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idConta_receber", id);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Conta Excluida com Sucesso!", "Ponto de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o Conta: " + ex);

            }

        }

        public DataTable FiltrarContas(string pago, string naoPago)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT * FROM Conta_receber WHERE pago IN ('" + pago + "','" + naoPago + "') ORDER BY valor asc";
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
