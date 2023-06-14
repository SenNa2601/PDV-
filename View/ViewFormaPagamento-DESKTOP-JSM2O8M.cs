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
        DataTable carrinho = new DataTable();

        public ViewFormaPagamento()
        {
            InitializeComponent();
        }

        public ViewFormaPagamento(string total,DataTable carrinho,string caixa)
        {
            InitializeComponent();
            lbTotalPagar.Text = total;
            this.carrinho = carrinho;
            labelCaixa.Text = caixa;
        }

       
        private void ViewFormaPagamento_Load(object sender, EventArgs e)
        {
            ComboClientes();
            ComboFormaPagamento();
            lbdata.Text = DateTime.Now.ToString("dd/MM/yyyy");
            

        }

        private void ComboClientes()
        {
            clienteDAO dao = new clienteDAO();
            cbClienteVenda.DataSource = dao.ListarClientes();
            cbClienteVenda.DisplayMember = "nome";
            cbClienteVenda.ValueMember = "idCliente";
        }
        private void ComboFormaPagamento()
        {
            formapagamentoDAO dao = new formapagamentoDAO();
            cbFormaPagamento.DataSource = dao.ListarFormaPagamento();
            cbFormaPagamento.DisplayMember = "nome";
            cbFormaPagamento.ValueMember = "idFormaPagamento";
        }

        private void VendaParcelada()
        {
                    ModelContaReceber registrarconta = new ModelContaReceber
                    {
                        descricao = "venda",
                        data_lancamento = DateTime.Parse(lbdata.Text),
                        valor = decimal.Parse(lbTotalPagar.Text),
                        pago = "NÃO",
                        data_vencimento = DateTime.Parse(lbdata.Text),
                        Cliente_idCliente = int.Parse(cbClienteVenda.SelectedValue.ToString()),
                    };
                    contareceberDAO dao = new contareceberDAO();
                    dao.CadastrarConta(registrarconta);

        }
        
        private void MostrarParcelas()
        {
            if (cbFormaPagamento.Text == "Parcelado")
            {
                labelParcela.Visible = true;
                cbParcelas.Visible = true;
            }
            else if(cbFormaPagamento.Text == "Cartão")
            {
                labelParcela.Visible = false;
                cbParcelas.Visible = false;
            }
            else if(cbFormaPagamento.Text == "Dinheiro")
            {
                labelParcela.Visible = false;
                cbParcelas.Visible = false;
            }
            
        }

        

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalPago, troco, total;

                int qtd_estoque, qtd_comprada, estoque_atualizado;
                produtoDAO dao_produto = new produtoDAO();

                total = decimal.Parse(lbTotalPagar.Text);

                totalPago = decimal.Parse(textBoxValorRecebido.Text.ToString());

                if(totalPago < total)
                {
                    MessageBox.Show("o total pago é menor que o valor total da venda!");
                }
                else
                {
                    troco = totalPago - total;

                    if (cbFormaPagamento.Text != "Parcelado")
                    {
                        ModelVenda venda = new ModelVenda
                        {
                            data = DateTime.Parse(lbdata.Text),
                            hora = DateTime.Parse(lbhora.Text),
                            total_venda = total,
                            situacao_venda = "fechada",
                            Cliente_idCliente = int.Parse(cbClienteVenda.SelectedValue.ToString()),
                            FormaPagamento_idFormaPagamento = int.Parse(cbFormaPagamento.SelectedValue.ToString()),
                        };

                        tbTroco.Text = troco.ToString();

                        vendaDAO dao = new vendaDAO();
                        dao.RegistrarVenda(venda);
                    }
                    else
                    {
                        VendaParcelada();

                        ModelVenda venda = new ModelVenda
                        {
                            data = DateTime.Parse(lbdata.Text),
                            hora = DateTime.Parse(lbhora.Text),
                            total_venda = total,
                            situacao_venda = "parcelad",
                            Cliente_idCliente = int.Parse(cbClienteVenda.SelectedValue.ToString()),
                            FormaPagamento_idFormaPagamento = int.Parse(cbFormaPagamento.SelectedValue.ToString()),
                        };

                        tbTroco.Text = troco.ToString();

                        vendaDAO dao = new vendaDAO();
                        dao.RegistrarVenda(venda);
                    }



                    vendaDAO daovenda = new vendaDAO();

                    foreach (DataRow linha in carrinho.Rows)
                    {
                        ModelItemVenda item = new ModelItemVenda();
                        item.Venda_idVenda = daovenda.RetornarUltimaVenda();
                        item.Produto_idProduto = int.Parse(linha["Código"].ToString());
                        item.Venda_Cliente_idCliente = int.Parse(cbClienteVenda.SelectedValue.ToString());
                        item.quantidade = int.Parse(linha["Quantidade"].ToString());
                        item.total_item = decimal.Parse(linha["Sub Total"].ToString());
                        item.valor_unitario = decimal.Parse(linha["Preço"].ToString());

                        qtd_estoque = dao_produto.RetornaEstoqueAtual(item.Produto_idProduto);
                        qtd_comprada = item.quantidade;
                        estoque_atualizado = qtd_estoque - qtd_comprada;
                        dao_produto.AtualizaEstoque(item.Produto_idProduto, estoque_atualizado);

                        itemvendaDAO itemDAO = new itemvendaDAO();
                        itemDAO.CadastrarItem(item);
                    }


                    


                    ModelMovimentoCaixa movimento = new ModelMovimentoCaixa()
                    {
                        data_movimento = DateTime.Parse(lbdata.Text),
                        hora_movimento = DateTime.Parse(lbhora.Text),
                        descricao = "",
                        tipo_movimento = "VENDA",
                        valor = total,
                    };

                    movimentocaixaDAO movimentodao = new movimentocaixaDAO();
                    movimentodao.InserirMovimentoCaixa(movimento);


                    ModelCaixa caixa = new ModelCaixa()
                    {

                        nome = labelCaixa.Text,
                        saldo = total,
                        Venda_idVenda = daovenda.RetornarUltimaVenda(),
                        MovimentoCaixa_idMovimentoCaixa = movimentodao.RetornarUltimoMovimento(),
                    };

                    caixaDAO caixadao = new caixaDAO();
                    caixadao.inserirCaixa(caixa);


                    
                    MessageBox.Show("Venda Realizada com sucesso!");
                    this.Dispose();

                    carrinho.Rows.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível realizar a venda" + ex);
            }
 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarParcelas();
        }
    }
}
