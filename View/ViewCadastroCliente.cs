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
    public partial class ViewCadastroCliente : Form
    {

        string cpfAntigo;
        string idSelecionado;
        public ViewCadastroCliente()
        {
            InitializeComponent();
        }

        private void ViewCadastroCliente_Load(object sender, EventArgs e)
        {
            clienteDAO dao = new clienteDAO();
            gridCliente.DataSource = dao.ListarClientes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModelCliente obj = new ModelCliente()
            {
                nome = tbNomeCli.Text,
                cpf_cnpj = tbCpfCnpjCli.Text,
                lougradouro = tbLogradouroCli.Text,
                numero = int.Parse(tbNumCli.Text),
                bairro = tbBairroCli.Text,
                complemento = tbComplementoCli.Text,
                cidade = tbCidadeCli.Text,
                estado = tbEstadoCli.Text,
                cep = tbCepCli.Text,
                telefone = tbTelefoneCli.Text,
                email = tbEmailCli.Text,

        };

            clienteDAO dao = new clienteDAO();
            dao.CadastrarCliente(obj);


            //DEFINE OS BOTÕES COMO HABILITADOS/DESABILITADOS 
            buttonNovo.Enabled = true;
            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;


            LimparCampos();          //LIMPA OS CAMPOS TEXTBOX  

            desabilitarCampos();     // DESABILITA OS CAMPOS APÓS A INSERÇÃO NO BANCO PARA QUE O USUARIO
                                     //  TENHA Q CLICAR EM "NOVO" NOVAMENTE

            gridCliente.DataSource =  dao.ListarClientes();         // LISTAR OS CLIENTES NA DATAGRID


        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
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


            ModelCliente obj = new ModelCliente()
            {
                nome = tbNomeCli.Text,
                cpf_cnpj = tbCpfCnpjCli.Text,
                lougradouro = tbLogradouroCli.Text,
                numero = int.Parse(tbNumCli.Text),
                bairro = tbBairroCli.Text,
                complemento = tbComplementoCli.Text,
                cidade = tbCidadeCli.Text,
                estado = tbEstadoCli.Text,
                cep = tbCepCli.Text,
                telefone = tbTelefoneCli.Text,
                email = tbEmailCli.Text,

            };


            clienteDAO dao = new clienteDAO();
            dao.EditarCliente(obj, idSelecionado);

            //DEFINE OS BOTÕES COMO HABILITADOS/DESABILITADOS 
            buttonNovo.Enabled = true;
            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;


            LimparCampos();          //LIMPA OS CAMPOS TEXTBOX  

            desabilitarCampos();     // DESABILITA OS CAMPOS APÓS A INSERÇÃO NO BANCO PARA QUE O USUARIO
                                     //  TENHA Q CLICAR EM "NOVO" NOVAMENTE

            gridCliente.DataSource = dao.ListarClientes();         // LISTAR OS CLIENTES NA DATAGRID
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a exclusão?", "Cadastro Cliente", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                clienteDAO dao1 = new clienteDAO();
                dao1.ExcluirCliente(idSelecionado);
                gridCliente.Rows.Remove(gridCliente.CurrentRow);
            }
            //DEFINE OS BOTÕES COMO HABILITADOS/DESABILITADOS 
            buttonNovo.Enabled = true;
            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;


            LimparCampos();          //LIMPA OS CAMPOS TEXTBOX  

            desabilitarCampos();     // DESABILITA OS CAMPOS APÓS A INSERÇÃO NO BANCO PARA QUE O USUARIO
                                     //  TENHA Q CLICAR EM "NOVO" NOVAMENTE
            clienteDAO dao = new clienteDAO();
            gridCliente.DataSource = dao.ListarClientes();
        }

        private void habilitarCampos()
        {

            //função para habilitar os campos TextBox

            buttonSalvar.Enabled = true;


            tbNomeCli.Enabled = true;
            tbCpfCnpjCli.Enabled = true;
            tbLogradouroCli.Enabled = true;
            tbNumCli.Enabled = true;
            tbComplementoCli.Enabled = true;
            tbBairroCli.Enabled = true;
            tbCidadeCli.Enabled = true;
            tbEstadoCli.Enabled = true;
            tbCepCli.Enabled = true;
            tbTelefoneCli.Enabled = true;
            tbEmailCli.Enabled = true;

            buttonNovo.Enabled = false;
        }

        private void desabilitarCampos()
        {
            //função para desabilitar os campos TextBox

            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;
            buttonEditar.Enabled = false;

            tbNomeCli.Enabled = false;
            tbCpfCnpjCli.Enabled = false;
            tbLogradouroCli.Enabled = false;
            tbNumCli.Enabled = false;
            tbComplementoCli.Enabled = false;
            tbBairroCli.Enabled = false;
            tbCidadeCli.Enabled = false;
            tbEstadoCli.Enabled = false;
            tbCepCli.Enabled = false;
            tbTelefoneCli.Enabled = false;
            tbEmailCli.Enabled = false;

            buttonNovo.Enabled = true;
        }

        private void LimparCampos()
        {
            //função para limpar os campos TextBox

            tbNomeCli.Text = "";
            tbCpfCnpjCli.Text = "";
            tbLogradouroCli.Text = "";
            tbNumCli.Text = "";
            tbComplementoCli.Text = "";
            tbBairroCli.Text = "";
            tbCidadeCli.Text = "";
            tbEstadoCli.Text = "";
            tbCepCli.Text = "";
            tbTelefoneCli.Text = "";
            tbEmailCli.Text = "";
        }

        private void gridCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //função para que quando o usuario clique duas vezes num campo da grid, as informações
            //sejam mostradas nos seus respectivos campos

            if (e.RowIndex > -1) // if para tratar o erro, verificando se há dados na tabela
            {                    // antes de jogar as infos nos respectivos TextBox

                habilitarCampos();

                buttonEditar.Enabled = true;
                buttonExcluir.Enabled = true;


                idSelecionado = gridCliente.CurrentRow.Cells[0].Value.ToString();
                cpfAntigo = gridCliente.CurrentRow.Cells[2].Value.ToString();
                tbNomeCli.Text = gridCliente.CurrentRow.Cells[1].Value.ToString();
                tbCpfCnpjCli.Text = gridCliente.CurrentRow.Cells[2].Value.ToString();
                tbLogradouroCli.Text = gridCliente.CurrentRow.Cells[3].Value.ToString();
                tbNumCli.Text = gridCliente.CurrentRow.Cells[4].Value.ToString();
                tbComplementoCli.Text = gridCliente.CurrentRow.Cells[5].Value.ToString();
                tbBairroCli.Text = gridCliente.CurrentRow.Cells[6].Value.ToString();
                tbCidadeCli.Text = gridCliente.CurrentRow.Cells[7].Value.ToString();
                tbEstadoCli.Text = gridCliente.CurrentRow.Cells[8].Value.ToString();
                tbCepCli.Text = gridCliente.CurrentRow.Cells[9].Value.ToString();
                tbTelefoneCli.Text = gridCliente.CurrentRow.Cells[10].Value.ToString();
                tbEmailCli.Text = gridCliente.CurrentRow.Cells[11].Value.ToString();
            }
            else
            {
                return;
            }

        }

       
    }
}
