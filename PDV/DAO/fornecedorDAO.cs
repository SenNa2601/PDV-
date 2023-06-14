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
    public class fornecedorDAO
    {
        private readonly MySqlConnection con;
        public  fornecedorDAO()
        {
            this.con = new conexaoSql().GetConnection();
        }

        public void CadastrarFornecedor(ModelFornecedor obj)
        {

            try
            {
               string sql = "INSERT INTO fornecedor(nome, cpf_cnpj, logradouro, numero, complemento, bairro, cidade, estado, cep, telefone, email) " +
                            "VALUES (@nome, @cpf_cnpj, @logradouro, @numero, @complemento, @bairro, @cidade,@estado, @cep, @telefone, @email)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@cpf_cnpj", obj.cpf_cnpj);
                cmd.Parameters.AddWithValue("@logradouro", obj.logradouro);
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

                MessageBox.Show("Fornecedor Cadastrado com Sucesso!", "Cadastro Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Fornecedor" + ex);
            }
            
        }

        public void EditarFornecedor(ModelFornecedor obj, string id)
        {
            try
            {
                string sql = "UPDATE fornecedor SET nome = @nome, cpf_cnpj = @cpf_cnpj , logradouro = @logradouro, numero = @numero, complemento = @complemento, " +
                             "bairro = @bairro, cidade = @cidade, estado = @estado, cep = @cep, telefone = @telefone, email = @email WHERE idFornecedor = @idFornecedor";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idFornecedor", id);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@cpf_cnpj", obj.cpf_cnpj);
                cmd.Parameters.AddWithValue("@logradouro", obj.logradouro);
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
                

                MessageBox.Show("Fornecedor Editado com Sucesso!", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar o Fornecedor" + ex);
            }
             
        }

        public void ExcluirFornecedor(string id)
        {
            try
            {
                string sql = "DELETE FROM fornecedor WHERE idFornecedor = @idFornecedor;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idFornecedor", id);
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Excluido com Sucesso!", "Cadastro de fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o Fornecedor" + ex);
            }
        }


        public DataTable ListarFornecedores()
        {

            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM fornecedor ORDER BY nome asc";
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
                string sql = "SELECT * FROM fornecedor WHERE nome LIKE @nome";
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
