using MySql.Data.MySqlClient;
using PDV.model;
using PDV.project.connect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.DAO
{
    public class produtoDAO
    {
        private readonly MySqlConnection con;

        public produtoDAO()
        {
            this.con = new conexaoSql().GetConnection();
        }

        public void CadastrarProduto(ModelProdutos obj)
        {
            try
            {
                string sql = "INSERT INTO produto(nome, quantidade_estoque, preco, unidade,Fornecedor_idFornecedor) " +
                             "VALUES (@nome, @quantidade_estoque, @preco, @unidade,@Fornecedor_idFornecedor)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@quantidade_estoque", obj.quantidade_estoque);
                cmd.Parameters.AddWithValue("@preco", obj.preco);
                cmd.Parameters.AddWithValue("@unidade", obj.unidade);
                cmd.Parameters.AddWithValue("@Fornecedor_idFornecedor", obj.Fornecedor_idFornecedor);
                con.Open();
                cmd.ExecuteNonQuery();



                MessageBox.Show("Produto Cadastrado com Sucesso!", "Cadastro Produto",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o produto: " + ex);

            }
        }

        public void EditarProduto(ModelProdutos obj, string id)
        {
            try
            {
                //INSERINDO OS DADOS CONTIDOS NOS TEXTBOX NO BANCO DE DADOS

                string sql = "UPDATE produto SET nome = @nome, quantidade_estoque = @quantidade_estoque , preco = @preco, unidade = @unidade, Fornecedor_idFornecedor = @Fornecedor_idFornecedor WHERE idProduto = @idProduto";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@quantidade_estoque", obj.quantidade_estoque);
                cmd.Parameters.AddWithValue("@preco", obj.preco);
                cmd.Parameters.AddWithValue("@unidade", obj.unidade);
                cmd.Parameters.AddWithValue("@Fornecedor_idFornecedor", obj.Fornecedor_idFornecedor);
                cmd.Parameters.AddWithValue("idProduto", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Dispose();
                con.ClearAllPoolsAsync();

                //FIM DA INSERÇÃO

                //MENSAGEM DE SUCESSO NA INSERÇÃO
                MessageBox.Show("Produto Editado com Sucesso!", "Cadastro  Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editarr o produto: " + ex);

            }

        }
        public void ExcluirProduto(string id)
        {
            try
            {
                string sql = "DELETE FROM produto WHERE idProduto = @idProduto";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idProduto", id);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Excluido com Sucesso!", "Cadastro Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o Produto: " + ex);

            }

        }

        public DataTable ListarProdutos()
        {
            try
            {

                DataTable dt = new DataTable();
                string sql = @"SELECT p.idProduto AS 'Código do produto', p.nome AS 'Nome', p.quantidade_estoque AS 'Quantidade em estoque', p.preco AS 'Preço', p.unidade AS 'Unidade', p.Fornecedor_idFornecedor AS 'Código do fornecedor', f.nome AS 'Nome Fornecedor'  FROM produto as p INNER JOIN fornecedor as f on f.idFornecedor = p.Fornecedor_idFornecedor ORDER BY p.nome asc";
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

        public int RetornaEstoqueAtual(int idProduto)
        {
            try
            {
                int qtd_estoque = 0;
                string sql = "SELECT quantidade_estoque FROM produto WHERE idProduto =@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idProduto);
                con.Open();
                cmd.ExecuteNonQuery();
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    qtd_estoque = read.GetInt32("quantidade_estoque");
                    con.Close();
                    con.Dispose();
                    con.ClearAllPoolsAsync();
                }
                return qtd_estoque;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
                return 0;
            }
        }

        public void AtualizaEstoque(int idProduto, int qtdEstoque)
        {
            try
            {
                string sql = "UPDATE produto SET quantidade_estoque= @qtd WHERE idProduto=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@qtd", qtdEstoque);
                cmd.Parameters.AddWithValue("@id", idProduto);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o erro: " + ex);
            }
        }

        public DataTable Pesquisar(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM produto WHERE nome LIKE @nome";
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
