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

namespace PDV.View
{
    public partial class ViewCadastroFornecedor : Form
    {
        string idSelecionado;
        string cpfAntigo;

        public ViewCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void ViewCadastroFornecedor_Load(object sender, EventArgs e)
        {
            fornecedorDAO dao = new fornecedorDAO();
            gridFornecedor.DataSource= dao.ListarFornecedores();
        }

        private void habilitarCampos()
        {

            //função para habilitar os campos TextBox

            buttonSalvar.Enabled = true;


            tbNomeFor.Enabled = true;
            tbCpfCnpjFor.Enabled = true;
            tbLogradouroFor.Enabled = true;
            tbNumFor.Enabled = true;
            tbComplementoFor.Enabled = true;
            tbBairroFor.Enabled = true;
            tbCidadeFor.Enabled = true;
            tbEstadoFor.Enabled = true;
            tbCepFor.Enabled = true;
            tbTelefoneFor.Enabled = true;
            tbEmailFor.Enabled = true;

            buttonNovo.Enabled = false;
        }

        private void desabilitarCampos()
        {
            //função para desabilitar os campos TextBox

            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;
            buttonEditar.Enabled = false;

            tbNomeFor.Enabled = false;
            tbCpfCnpjFor.Enabled = false;
            tbLogradouroFor.Enabled = false;
            tbNumFor.Enabled = false;
            tbComplementoFor.Enabled = false;
            tbBairroFor.Enabled = false;
            tbCidadeFor.Enabled = false;
            tbEstadoFor.Enabled = false;
            tbCepFor.Enabled = false;
            tbTelefoneFor.Enabled = false;
            tbEmailFor.Enabled = false;

            buttonNovo.Enabled = true;
        }

        private void LimparCampos()
        {
            //função para limpar os campos TextBox

            tbNomeFor.Text = "";
            tbCpfCnpjFor.Text = "";
            tbLogradouroFor.Text = "";
            tbNumFor.Text = "";
            tbComplementoFor.Text = "";
            tbBairroFor.Text = "";
            tbCidadeFor.Text = "";
            tbEstadoFor.Text = "";
            tbCepFor.Text = "";
            tbTelefoneFor.Text = "";
            tbEmailFor.Text = "";
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (tbNomeFor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNomeFor.Text = "";
                tbNomeFor.Focus();
                return;
            }

            if (tbCpfCnpjFor.Text == "   ,   ,   -" || tbCpfCnpjFor.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF/CNPJ", "Cadastro Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCpfCnpjFor.Text = "";
                tbCpfCnpjFor.Focus();
                return;
            }


            ModelFornecedor obj = new ModelFornecedor()
            {
                nome = tbNomeFor.Text,
                cpf_cnpj = tbCpfCnpjFor.Text,
                logradouro = tbLogradouroFor.Text,
                numero = int.Parse(tbNumFor.Text),
                bairro = tbBairroFor.Text,
                complemento = tbComplementoFor.Text,
                cidade = tbCidadeFor.Text,
                estado = tbEstadoFor.Text,
                cep = tbCepFor.Text,
                telefone = tbTelefoneFor.Text,
                email = tbEmailFor.Text,
            };

            fornecedorDAO dao = new fornecedorDAO();
            dao.CadastrarFornecedor(obj);

           

            buttonNovo.Enabled = true;
            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;

            LimparCampos();
            desabilitarCampos();

            gridFornecedor.DataSource = dao.ListarFornecedores();
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

        private void gridFornecedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) 
            {                    
                habilitarCampos();

                buttonEditar.Enabled = true;
                buttonExcluir.Enabled = true;


                idSelecionado = gridFornecedor.CurrentRow.Cells[0].Value.ToString();
                cpfAntigo = gridFornecedor.CurrentRow.Cells[2].Value.ToString();
                tbNomeFor.Text = gridFornecedor.CurrentRow.Cells[1].Value.ToString();
                tbCpfCnpjFor.Text = gridFornecedor.CurrentRow.Cells[2].Value.ToString();
                tbLogradouroFor.Text = gridFornecedor.CurrentRow.Cells[3].Value.ToString();
                tbNumFor.Text = gridFornecedor.CurrentRow.Cells[4].Value.ToString();
                tbComplementoFor.Text = gridFornecedor.CurrentRow.Cells[5].Value.ToString();
                tbBairroFor.Text = gridFornecedor.CurrentRow.Cells[6].Value.ToString();
                tbCidadeFor.Text = gridFornecedor.CurrentRow.Cells[7].Value.ToString();
                tbEstadoFor.Text = gridFornecedor.CurrentRow.Cells[8].Value.ToString();
                tbCepFor.Text = gridFornecedor.CurrentRow.Cells[9].Value.ToString();
                tbTelefoneFor.Text = gridFornecedor.CurrentRow.Cells[10].Value.ToString();
                tbEmailFor.Text = gridFornecedor.CurrentRow.Cells[11].Value.ToString();
            }
            else
            {
                return;
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (tbNomeFor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNomeFor.Text = "";
                tbNomeFor.Focus();
                return;
            }

            if (tbCpfCnpjFor.Text == "   ,   ,   -" || tbCpfCnpjFor.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF/CNPJ", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCpfCnpjFor.Text = "";
                tbCpfCnpjFor.Focus();
                return;
            }

            ModelFornecedor obj = new ModelFornecedor()
            {
                nome = tbNomeFor.Text,
                cpf_cnpj = tbCpfCnpjFor.Text,
                logradouro = tbLogradouroFor.Text,
                numero = int.Parse(tbNumFor.Text),
                bairro = tbBairroFor.Text,
                complemento = tbComplementoFor.Text,
                cidade = tbCidadeFor.Text,
                estado = tbEstadoFor.Text,
                cep = tbCepFor.Text,
                telefone = tbTelefoneFor.Text,
                email = tbEmailFor.Text,
            };

                fornecedorDAO dao = new fornecedorDAO();
                dao.EditarFornecedor(obj,idSelecionado);


                buttonNovo.Enabled = true;
                buttonSalvar.Enabled = false;
                buttonEditar.Enabled = false;
                buttonExcluir.Enabled = false;

                LimparCampos();
                desabilitarCampos();
                gridFornecedor.DataSource = dao.ListarFornecedores();

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Você deseja mesmo excluir?", "Cadastro de Fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                fornecedorDAO dao = new fornecedorDAO();
                dao.ExcluirFornecedor(idSelecionado);
                gridFornecedor.Rows.Remove(gridFornecedor.CurrentRow);
            }

                buttonNovo.Enabled = true;
                buttonEditar.Enabled = false;
                buttonExcluir.Enabled = false;
                buttonSalvar.Enabled = false;
                desabilitarCampos();
                LimparCampos();

                fornecedorDAO dAO = new fornecedorDAO();
                gridFornecedor.DataSource = dAO.ListarFornecedores();

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            fornecedorDAO dao = new fornecedorDAO();
            gridFornecedor.DataSource = dao.Pesquisar(tbPesquisar.Text);
        }
    }
}
