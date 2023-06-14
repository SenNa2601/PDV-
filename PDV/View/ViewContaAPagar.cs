using MySql.Data.MySqlClient;
using PDV.DAO;
using PDV.model;
using PDV.project.connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PDV.View
{
    public partial class ViewContaAPagar : Form
    {
        string idSelecionado;
        public ViewContaAPagar()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            ModelContaPagar obj = new ModelContaPagar()
            {
                descricao = (tbDescricao.Text.ToString()),
                data_lancamento = DateTime.Parse(tbLancamento.Text.ToString()),
                data_vencimento = DateTime.Parse(tbVencimento.Text.ToString()),
                valor = float.Parse(tbValor.Text.ToString()),
                pago = (tbPago.Text.ToString()),
                Fornecedor_idFornecedor = int.Parse(cbFornecedor.SelectedValue.ToString()),
            };

            contapagarDAO dao = new contapagarDAO();
            dao.CadastrarConta(obj);

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


            GridConta.DataSource = dao.ListarConta();         // LISTAR OS CLIENTES NA DATAGRID

        }

        private void buttonNovo_Click_1(object sender, EventArgs e)
        {
            habilitarCampos();
            tbDataPag.Enabled = false;
            tbValorPag.Enabled = false;
            tbPago.Enabled = false;

        }



        private void habilitarCampos()
        {

            //função para habilitar os campos TextBox

            buttonSalvar.Enabled = true;


            tbDescricao.Enabled = true;
            tbLancamento.Enabled = true;
            tbVencimento.Enabled = true;
            tbValor.Enabled = true;
            tbPago.Enabled = true;
            tbDataPag.Enabled = true;
            tbValorPag.Enabled = true;

            buttonNovo.Enabled = false;
        }

        private void desabilitarCampos()
        {
            //função para desabilitar os campos TextBox

            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;
            buttonEditar.Enabled = false;


            tbDescricao.Enabled = false;
            tbLancamento.Enabled = false;
            tbVencimento.Enabled = false;
            tbValor.Enabled = false;
            tbPago.Enabled = false;
            tbDataPag.Enabled = false;
            tbValorPag.Enabled = false;

            buttonNovo.Enabled = true;
        }


        private void LimparCampos()
        {
            //função para limpar os campos TextBox

            tbDescricao.Text = "";
            tbLancamento.Text = "";
            tbVencimento.Text = "";
            tbValor.Text = "";
            tbPago.Text = "NAO";
            tbDataPag.Text = "";
            tbValorPag.Text = "";
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
            if (tbValor.Text.ToString().Trim() == "")
            {
                //TRATAMENTO DOS CAMPOS 
                MessageBox.Show("Preencha o campo Valor", "Cadastro Conta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbValor.Text = "";
                tbValor.Focus();
                return;
            }

            //FIM TRATAMENTO DOS CAMPOS


            ModelContaPagar obj = new ModelContaPagar()
            {

                descricao = (tbDescricao.Text.ToString()),
                data_lancamento = DateTime.Parse(tbLancamento.Text.ToString()),
                data_vencimento = DateTime.Parse(tbVencimento.Text.ToString()),
                valor = float.Parse(tbValor.Text.ToString()),
                pago = (tbPago.Text.ToString()),
                data_pagamento = DateTime.Parse(tbDataPag.Text.ToString()),
                valor_pagamento = float.Parse(tbValorPag.Text.ToString()),
                Fornecedor_idFornecedor = int.Parse(cbFornecedor.SelectedValue.ToString()),
            };


            contapagarDAO dao1 = new contapagarDAO();
            dao1.EditarConta(obj, idSelecionado);

            //DEFINE OS BOTÕES COMO HABILITADOS/DESABILITADOS 
            buttonNovo.Enabled = true;
            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;



            LimparCampos();          //LIMPA OS CAMPOS TEXTBOX  

            desabilitarCampos();     // DESABILITA OS CAMPOS APÓS A INSERÇÃO NO BANCO PARA QUE O USUARIO
                                     //  TENHA Q CLICAR EM "NOVO" NOVAMENTE

            contapagarDAO dao = new contapagarDAO();
            GridConta.DataSource = dao.ListarConta();    // LISTAR OS CLIENTES NA DATAGRID

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

            var res = MessageBox.Show("Você deseja mesmo excluir?", "Cadastro de Contas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                contapagarDAO dao1 = new contapagarDAO();
                dao1.ExcluirConta(idSelecionado);
            }

            buttonNovo.Enabled = true;
            buttonSalvar.Enabled = false;
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;
            desabilitarCampos();
            LimparCampos();

            contapagarDAO dao = new contapagarDAO();
            GridConta.DataSource = dao.ListarConta();
        }

        private void ComboFornecedores()
        {
            fornecedorDAO dao = new fornecedorDAO();
            cbFornecedor.DataSource = dao.ListarFornecedores();
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "idFornecedor";
        }
        private void ViewContaAPagar_Load_1(object sender, EventArgs e)
        {
            contapagarDAO dao = new contapagarDAO();
            GridConta.DataSource = dao.ListarConta();
            ComboFornecedores();
            desabilitarCampos();
        }

        private void GridConta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //função para que quando o usuario clique duas vezes num campo da grid, as informações
            //sejam mostradas nos seus respectivos campos

            if (e.RowIndex > -1) // if para tratar o erro, verificando se há dados na tabela
            {                    // antes de jogar as infos nos respectivos TextBox

                habilitarCampos();

                buttonEditar.Enabled = true;
                buttonExcluir.Enabled = true;



                idSelecionado = GridConta.CurrentRow.Cells[0].Value.ToString();
                tbDescricao.Text = GridConta.CurrentRow.Cells[1].Value.ToString();
                tbLancamento.Text = GridConta.CurrentRow.Cells[2].Value.ToString();
                tbVencimento.Text = GridConta.CurrentRow.Cells[3].Value.ToString();
                tbValor.Text = GridConta.CurrentRow.Cells[4].Value.ToString();
                tbPago.Text = GridConta.CurrentRow.Cells[5].Value.ToString();
                tbDataPag.Text = GridConta.CurrentRow.Cells[6].Value.ToString();
                tbValorPag.Text = GridConta.CurrentRow.Cells[7].Value.ToString();
                cbFornecedor.Text = GridConta.CurrentRow.Cells[8].Value.ToString();
            }

            else
            {
                return;
            }
        }



        private void tbRelatorio_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "RELATÓRIO DE CONTAS A PAGAR";
            printer.SubTitle = string.Format("Contas", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "Lista de Contas";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintPreviewDataGridView(GridConta);

        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            contapagarDAO dao = new contapagarDAO();

            string pago;
            string naoPago;
            string dataAtual;


            if(checkedListBox1.GetItemChecked(0) == true)
            {
                dataAtual = DateTime.Now.ToString("yyyy-MM-dd");
                
                GridConta.DataSource = dao.FiltrarContasAtrasadas(dataAtual);
            }
            if (checkedListBox1.GetItemChecked(2) == true)
            {
                pago = "SIM";
                naoPago = "";
                GridConta.DataSource = dao.FiltrarContas(pago, naoPago);
            }
            if (checkedListBox1.GetItemChecked(1) == true)
            {
                pago = "";
                naoPago = "NÃO";

                GridConta.DataSource = dao.FiltrarContas(pago, naoPago);
            }
            else if (checkedListBox1.GetItemChecked(0) == false && checkedListBox1.GetItemChecked(1) == false && checkedListBox1.GetItemChecked(2) == false)
            {
                GridConta.DataSource = dao.ListarConta();
            }


        }
    }
}







        

        
 


 

