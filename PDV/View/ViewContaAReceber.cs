using DGVPrinterHelper;
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
    public partial class ViewContaAReceber : Form
    {
        public ViewContaAReceber()
        {
            InitializeComponent();
        }

        string idSelecionado;
        private void ViewContaAReceber_Load(object sender, EventArgs e)
        {
            contareceberDAO dao = new contareceberDAO();
            GridContaReceber.DataSource = dao.ListarContas();

            tbDataPagamento.Enabled = false;
            tbValor.Enabled = false;
            
        }


        private void btRelatorio_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "RELATÓRIO DE CONTAS A RECEBER";
            printer.SubTitle = string.Format("Contas", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "Lista de Contas";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintPreviewDataGridView(GridContaReceber);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            var res = MessageBox.Show("Você deseja mesmo excluir?", "Cadastro de Contas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                contareceberDAO dao = new contareceberDAO();
                dao.ExcluirConta(idSelecionado);
            }

            contareceberDAO dao1 = new contareceberDAO();
            GridContaReceber.DataSource = dao1.ListarContas();
        }

        private void GridContaReceber_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = GridContaReceber.CurrentRow.Cells[0].Value.ToString();

            tbDataPagamento.Enabled = true;
            tbValor.Enabled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            tbDataPagamento.Enabled = false;
            tbValor.Enabled = false;

            tbDataPagamento.Text = "";
            tbValor.Text = "";
        }

        private void btPagar_Click(object sender, EventArgs e)
        {

            ModelContaReceber obj = new ModelContaReceber()
            {
                pago = "SIM",
                data_pagamento = DateTime.Parse(tbDataPagamento.Text.ToString()),
                valor_pagamento = decimal.Parse(tbValor.Text.ToString()),
            };

            contareceberDAO dao = new contareceberDAO();
            dao.PagarConta(obj, idSelecionado);
            
            GridContaReceber.DataSource = dao.ListarContas();
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            contareceberDAO dao = new contareceberDAO();

            string pago;
            string naoPago;

            if (checkedListBox1.GetItemChecked(2) == true)
            {
                pago = "SIM";
                naoPago = "";
                GridContaReceber.DataSource = dao.FiltrarContas(pago, naoPago);
            }
            if (checkedListBox1.GetItemChecked(1) == true)
            {
                pago = "";
                naoPago = "NÃO";

                GridContaReceber.DataSource = dao.FiltrarContas(pago, naoPago);
            }
            else if (checkedListBox1.GetItemChecked(0) == false && checkedListBox1.GetItemChecked(1) == false && checkedListBox1.GetItemChecked(2) == false)
            {
                GridContaReceber.DataSource = dao.ListarContas();
            }
        }
    }
}
