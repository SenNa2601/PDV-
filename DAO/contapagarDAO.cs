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
    public class contapagarDAO
    {
        private readonly MySqlConnection con;

        public contapagarDAO()
        {
            this.con = new conexaoSql().GetConnection();
        }

        public void CadastrarConta(ModelContaPagar obj)
        {
            try
            {
                string sql = "INSERT INTO Conta_Pagar(descricao, data_lancamento, data_vencimento, valor , pago, Fornecedor_idFornecedor)"+
                             "VALUES (@descricao, @data_lancamento, @data_vencimento, @valor, @pago, @Fornecedor_idFornecedor)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@descricao", obj.descricao);

                DateTime data_lancamento = (obj.data_lancamento);
                cmd.Parameters.AddWithValue("@data_lancamento", data_lancamento);

                DateTime data_vencimento = (obj.data_vencimento);
                cmd.Parameters.AddWithValue("@data_vencimento", data_vencimento);

                cmd.Parameters.AddWithValue("@valor", obj.valor);
                cmd.Parameters.AddWithValue("@pago", obj.pago);

                cmd.Parameters.AddWithValue("@Fornecedor_idFornecedor", obj.Fornecedor_idFornecedor);
                con.Open();
                cmd.ExecuteNonQuery();



                MessageBox.Show("Conta Cadastrada com Sucesso!", "Cadastro Conta",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a Conta: " + ex);

            }
        }

        public void EditarConta(ModelContaPagar obj, string id)
        {
            try
            {
                //INSERINDO OS DADOS CONTIDOS NOS TEXTBOX NO BANCO DE DADOS

                string sql = "UPDATE Conta_Pagar SET descricao = @descricao, data_lancamento = @data_lancamento , data_vencimento = @data_vencimento, valor = @valor, pago = @pago, data_pagamento = @data_pagamento, valor_pagamento = @valor_pagamento, Fornecedor_idFornecedor = @Fornecedor_idFornecedor WHERE idConta_Pagar = @idConta_Pagar";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@descricao", obj.descricao);
                cmd.Parameters.AddWithValue("@data_lancamento", obj.data_lancamento);
                cmd.Parameters.AddWithValue("@data_vencimento", obj.data_vencimento);
                cmd.Parameters.AddWithValue("@valor", obj.valor);
                cmd.Parameters.AddWithValue("@pago", obj.pago);
                cmd.Parameters.AddWithValue("@data_pagamento", obj.data_pagamento);
                cmd.Parameters.AddWithValue("@valor_pagamento", obj.valor_pagamento);
                cmd.Parameters.AddWithValue("@Fornecedor_idFornecedor", obj.Fornecedor_idFornecedor);
                cmd.Parameters.AddWithValue("idConta_Pagar", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Dispose();
                con.ClearAllPoolsAsync();

                //FIM DA INSERÇÃO

                //MENSAGEM DE SUCESSO NA INSERÇÃO
                MessageBox.Show("Conta editada com Sucesso!", "Cadastro  Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string sql = "DELETE FROM Conta_Pagar WHERE idConta_Pagar = @idConta_Pagar";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idConta_Pagar", id);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Conta Excluida com Sucesso!", "Cadastro Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o Conta: " + ex);

            }

        }

        public DataTable ListarConta()
        {
            try
            {

                DataTable dt = new DataTable();
                string sql = @"SELECT * FROM Conta_Pagar ORDER BY valor asc";
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
