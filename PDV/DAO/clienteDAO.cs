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
    public class clienteDAO
    {
        private readonly MySqlConnection con;

        public clienteDAO()
        {
            this.con = new conexaoSql().GetConnection();
        }

        public void CadastrarCliente(ModelCliente obj)
        {
            try
            {
                string sql = "INSERT INTO cliente(nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, emai) " +
                "VALUES (@nome, @cpf_cnpj, @logradouro, @numero, @complemento, @bairro, @cidade,@estado, @cep, @telefone, @email)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@cpf_cnpj", obj.cpf_cnpj);
                cmd.Parameters.AddWithValue("@logradouro", obj.lougradouro);
                cmd.Parameters.AddWithValue("@numero", obj.numero);
                cmd.Parameters.AddWithValue("@complemento", obj.complemento);
                cmd.Parameters.AddWithValue("@bairro", obj.bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.cidade);
                cmd.Parameters.AddWithValue("@estado", obj.estado);
                cmd.Parameters.AddWithValue("@cep", obj.cep);
                cmd.Parameters.AddWithValue("@telefone", obj.telefone);
                cmd.Parameters.AddWithValue("@email", obj.email);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com Sucesso!", "Cadastro Produto",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o cliente: " + ex);
            }
        }

        public void EditarCliente(ModelCliente obj, string id)
        {
            try
            {
                string sql = "UPDATE cliente SET nome = @nome, cpf_cnpj = @cpf_cnpj , logradouro = @logradouro, numero = @numero, complemento = @complemento, " +
               "bairro = @bairro, cidade = @cidade, estado = @estado, cep = @cep, telefone = @telefone, emai = @email WHERE idCliente = @idCliente";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@cpf_cnpj", obj.cpf_cnpj);
                cmd.Parameters.AddWithValue("@logradouro", obj.lougradouro);
                cmd.Parameters.AddWithValue("@numero", obj.numero);
                cmd.Parameters.AddWithValue("@complemento", obj.complemento);
                cmd.Parameters.AddWithValue("@bairro", obj.bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.cidade);
                cmd.Parameters.AddWithValue("@estado", obj.estado);
                cmd.Parameters.AddWithValue("@cep", obj.cep);
                cmd.Parameters.AddWithValue("@telefone", obj.telefone);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@idCliente", id);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente atualizado com Sucesso!", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                con.Close();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o cliente: " + ex);
            }


        }



        public void ExcluirCliente(string id)
        {
            try
            {
                string sql = "DELETE FROM cliente WHERE idCliente=@idCliente";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idCliente", id);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente deleteado com Sucesso!", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o cliente: " + ex);

            }
        }






        public DataTable ListarClientes()
        {
            try
            {
                
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM cliente ORDER BY nome asc";
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

        public DataTable Pesquisar(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM cliente WHERE nome LIKE @nome";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
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
