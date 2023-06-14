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
    public partial class ViewFormaPagamento : Form 
    {
        public ViewFormaPagamento()
        {
            InitializeComponent();
        }
        public ViewFormaPagamento(string Valor)
        {
            InitializeComponent();
            lbTotalPagar.Text = Valor;
        }

       
        private void ViewFormaPagamento_Load(object sender, EventArgs e)
        {
            ComboClientes();
            lbdata.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void ComboClientes()
        {
            clienteDAO dao = new clienteDAO();
            cbClienteVenda.DataSource = dao.ListarClientes();
            cbClienteVenda.DisplayMember = "nome";
            cbClienteVenda.ValueMember = "idCliente";
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            ModelVenda obj = new ModelVenda
            {
                data = DateTime.Parse(lbdata.Text),
                hora = DateTime.Parse(lbhora.Text),
                total_venda = decimal.Parse(lbTotalPagar.Text),
                Cliente_idCliente = int.Parse(cbClienteVenda.SelectedValue.ToString()),
                situacao_venda = "fechada",
            };

            vendaDAO dao = new vendaDAO();
            dao.RegistrarVenda(obj);


            ModelFormaPagamento obj = new ModelFormaPagamento
            {
                //fazer o id da compra pegar a forma de pagamento 
            };
            this.Close();

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
