using MySql.Data.MySqlClient;
using PDV.DAO;
using PDV.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class ViewCadastroProduto : Form
    {

        string idSelecionado;
        public ViewCadastroProduto()

        {
            InitializeComponent();
        }

        



        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            ModelProdutos obj = new ModelProdutos()
            {
                nome = tbNomeProd.Text,
                preco = decimal.Parse(tbPrecoProd.Text.ToString()),
                quantidade_estoque = int.Parse(tbQtdEstoque.Text.ToString()),
                unidade = tbUnidadeProd.Text,
                Fornecedor_idFornecedor = int.Parse(cbFornecedor.SelectedValue.ToString()),
            };

            produtoDAO dao = new produtoDAO();
            dao.CadastrarProduto(obj);

            //DEFINE OS BOTÕES COMO HABILITADOS/DESABILITADOS 
            buttonNovo.Enabled = true;
            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;




            //DEFINE OS BOTÕES COMO HABILITADOS/DESABILITADOS 
            buttonNovo.Enabled = true;
            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;


            LimparCampos();          //LIMPA OS CAMPOS TEXTBOX  

            desabilitarCampos();     // DESABILITA OS CAMPOS APÓS A INSERÇÃO NO BANCO PARA QUE O USUARIO
                                     //  TENHA Q CLICAR EM "NOVO" NOVAMENTE


            gridProd.DataSource = dao.ListarProdutos();         // LISTAR OS CLIENTES NA DATAGRID

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }



        private void habilitarCampos()
        {

            //função para habilitar os campos TextBox

            buttonSalvar.Enabled = true;


            tbNomeProd.Enabled = true;
            tbQtdEstoque.Enabled = true;
            tbPrecoProd.Enabled = true;
            tbUnidadeProd.Enabled = true;
            cbFornecedor.Enabled = true;

            buttonNovo.Enabled = false;
        }

        private void desabilitarCampos()
        {
            //função para desabilitar os campos TextBox

            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;
            buttonEditar.Enabled = false;

            tbNomeProd.Enabled = false;
            tbQtdEstoque.Enabled = false;
            tbPrecoProd.Enabled = false;
            tbUnidadeProd.Enabled = false;

            buttonNovo.Enabled = true;
        }
        private void LimparCampos()
        {
            //função para limpar os campos TextBox

            tbNomeProd.Text = "";
            tbQtdEstoque.Text = "";
            tbPrecoProd.Text = "";
            tbUnidadeProd.Text = "";

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;
            buttonSalvar.Enabled = false;
            buttonNovo.Enabled = true;
            desabilitarCampos();
            LimparCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (tbNomeProd.Text.ToString().Trim() == "")
            {
                //TRATAMENTO DOS CAMPOS 
                MessageBox.Show("Preencha o campo nome", "Cadastro Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNomeProd.Text = "";
                tbNomeProd.Focus();
                return;
            }
            if (tbPrecoProd.Text.ToString().Trim() == "")
            {
                //TRATAMENTO DOS CAMPOS 
                MessageBox.Show("Preencha o campo preço", "Cadastro Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPrecoProd.Text = "";
                tbPrecoProd.Focus();
                return;
                //FIM TRATAMENTO DOS CAMPOS
            }

            ModelProdutos obj = new ModelProdutos()
            {
                nome = tbNomeProd.Text,
                preco = decimal.Parse(tbPrecoProd.Text.ToString()),
                quantidade_estoque = int.Parse(tbQtdEstoque.Text.ToString()),
                unidade = tbUnidadeProd.Text,
                Fornecedor_idFornecedor = int.Parse(cbFornecedor.SelectedValue.ToString()),
            };


            produtoDAO dao1 = new produtoDAO();
            dao1.EditarProduto(obj, idSelecionado);

            //DEFINE OS BOTÕES COMO HABILITADOS/DESABILITADOS 
            buttonNovo.Enabled = true;
            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;


            LimparCampos();          //LIMPA OS CAMPOS TEXTBOX  

            desabilitarCampos();     // DESABILITA OS CAMPOS APÓS A INSERÇÃO NO BANCO PARA QUE O USUARIO
                                     //  TENHA Q CLICAR EM "NOVO" NOVAMENTE

            produtoDAO dao = new produtoDAO();
            gridProd.DataSource = dao.ListarProdutos();         // LISTAR OS CLIENTES NA DATAGRID


        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

            var res = MessageBox.Show("Você deseja mesmo excluir?", "Cadastro de Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                produtoDAO dao1 = new produtoDAO();
                dao1.ExcluirProduto(idSelecionado);
            }

                buttonNovo.Enabled = true;
                buttonSalvar.Enabled = false;
                buttonEditar.Enabled = false;
                buttonExcluir.Enabled = false;
                desabilitarCampos();
                LimparCampos();

               produtoDAO dao = new produtoDAO();
               gridProd.DataSource = dao.ListarProdutos();
        }

        private void ComboFornecedores()
        {
            fornecedorDAO dao = new fornecedorDAO();
            cbFornecedor.DataSource = dao.ListarFornecedores();
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "idFornecedor";
        }

        private void ViewCadastroProduto_Load_1(object sender, EventArgs e)
        {
            produtoDAO dao = new produtoDAO();
            gridProd.DataSource = dao.ListarProdutos();
            ComboFornecedores();
            desabilitarCampos();
        }

        private void gridProd_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //função para que quando o usuario clique duas vezes num campo da grid, as informações
            //sejam mostradas nos seus respectivos campos

            if (e.RowIndex > -1) // if para tratar o erro, verificando se há dados na tabela
            {                    // antes de jogar as infos nos respectivos TextBox

                habilitarCampos();

                buttonEditar.Enabled = true;
                buttonExcluir.Enabled = true;


                idSelecionado = gridProd.CurrentRow.Cells[0].Value.ToString();
                tbNomeProd.Text = gridProd.CurrentRow.Cells[1].Value.ToString();
                tbQtdEstoque.Text = gridProd.CurrentRow.Cells[2].Value.ToString();
                tbPrecoProd.Text = gridProd.CurrentRow.Cells[3].Value.ToString();
                tbUnidadeProd.Text = gridProd.CurrentRow.Cells[4].Value.ToString();
                cbFornecedor.Text = gridProd.CurrentRow.Cells[5].Value.ToString();

            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            produtoDAO dao = new produtoDAO();
            gridProd.DataSource = dao.Pesquisar(tbPesquisar.Text);
        }
    }
}
