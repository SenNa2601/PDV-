using PDV.View;
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
    public partial class ViewTelaPrincipal : Form
    {
        public ViewTelaPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCadastroCliente viewcadastrocliente = new ViewCadastroCliente();
            viewcadastrocliente.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCadastroProduto viewcadastroproduto = new ViewCadastroProduto();
            viewcadastroproduto.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCadastroFornecedor viewcadastrofornecedor = new ViewCadastroFornecedor();
            viewcadastrofornecedor.ShowDialog();
        }

        private void pontoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPontoDeVendas view = new ViewPontoDeVendas();
            view.ShowDialog();
        }

        private void ViewTelaPrincipal_Load(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void labelHora_Click(object sender, EventArgs e)
        {

        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewContaAPagar view = new ViewContaAPagar();
            view.ShowDialog();
        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewContaAReceber view = new ViewContaAReceber();
            view.ShowDialog();
        }

        private void financeiroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewFinanceiro view = new ViewFinanceiro();
            view.ShowDialog();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewVendas view = new ViewVendas();
            view.ShowDialog();
        }
    }
}
