using DGVPrinterHelper;
using Google.Protobuf.WellKnownTypes;
using PDV.DAO;
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
    public partial class ViewVendas : Form
    {
        public ViewVendas()
        {
            InitializeComponent();
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
            printer.PrintPreviewDataGridView(GridVendas);
        }

        private void ViewVendas_Load(object sender, EventArgs e)
        {
            vendaDAO dao = new vendaDAO();
            GridVendas.DataSource = dao.ListarVendas();
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            vendaDAO dao = new vendaDAO();

            string nome;
            string dataDe, dataAte;

            if (checkBoxCliente.Checked == true)
            {

                nome = tbNomeCliente.Text;
                GridVendas.DataSource = dao.FiltrarVendas(nome);
            }
            if (checkBoxData.Checked == true)
            {
                datePicker_ATE.Visible = true;
                datePicker_DE.Visible = true;

                dataAte = datePicker_ATE.Value.ToString("yyyy-MM-dd");
                dataDe = datePicker_DE.Value.ToString("yyyy-MM-dd");

                GridVendas.DataSource = dao.FiltrarVendasPelaData(dataDe,dataAte);
                
            }

            else if (checkBoxData.Checked == false && checkBoxCliente.Checked == false)
            {
                GridVendas.DataSource = dao.ListarVendas();
               
                
                datePicker_DE.Visible = false;
                datePicker_ATE.Visible = false;
                tbNomeCliente.Visible = false;
                btProcurar.Visible = false;
                labelAte.Visible = false;
                labelDe.Visible = false;
            }
        }

        private void checkBoxCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCliente.Checked == true)
            {
                tbNomeCliente.Visible = true;
                btProcurar.Visible = true;
            }
            else
            {
                tbNomeCliente.Visible = false;
                btProcurar.Visible = false;

                vendaDAO dao = new vendaDAO();
                GridVendas.DataSource = dao.ListarVendas();
            }
        }

        private void checkBoxData_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxData.Checked == true)
            {
                datePicker_ATE.Visible = true;
                datePicker_DE.Visible = true;
                labelAte.Visible = true;
                labelDe.Visible = true;
                btProcurar.Visible = true;
            }
            else
            {
                datePicker_ATE.Visible = false;
                datePicker_DE.Visible = false;
                labelAte.Visible = false;
                labelDe.Visible = false;
                btProcurar.Visible = false;

                vendaDAO dao = new vendaDAO();
                GridVendas.DataSource = dao.ListarVendas();
            }
        }
    }
}
