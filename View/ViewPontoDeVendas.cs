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
    public partial class ViewPontoDeVendas : Form
    {

        int qtd, estoque, codProd;
        decimal precos, subtotal, total;
        DataTable carrinho = new DataTable();


        public ViewPontoDeVendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Nome", typeof(String));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Sub Total", typeof(decimal));


            Grid_Carrinho.DataSource = carrinho;
        }


        private void LimparTextos()
        {
            tbCodigoProduto.Text = tbPrecoUnitario.Text = tbQuantidade.Text = string.Empty;
        }

        public void LimparTextosAposVenda()
        {
            tbEstoque.Text = tbPrecoTotal.Text = "";
        }

        private void ViewPontoDeVendas_Load(object sender, EventArgs e)
        {

            DataFrenteCaixa.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void tbQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ViewCadastroProduto view = new ViewCadastroProduto();
                view.ShowDialog();

            }
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Você deseja fechar o PDV?", "PDV", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }

            }
        }

        private void tbPrecoUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ViewCadastroProduto view = new ViewCadastroProduto();
                view.ShowDialog();
            }
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Você deseja fechar o PDV?", "PDV", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }

            }
        }

        private void Grid_Carrinho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Grid_Carrinho.RowCount != 0)
                {
                    decimal subproduto = decimal.Parse(Grid_Carrinho.CurrentRow.Cells[3].Value.ToString());

                    int indice = Grid_Carrinho.CurrentRow.Index;
                    DataRow linha = carrinho.Rows[indice];

                    carrinho.Rows.Remove(linha);
                    carrinho.AcceptChanges();

                    total -= subproduto;

                    tbPrecoTotal.Text = total.ToString();

                    MessageBox.Show("Item removido com sucesso!", "Produto removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    if (Grid_Carrinho.Rows.Count < 1)
                    {
                        labelCaixaLivre.Text = "Caixa Livre";
                        total = 0;
                    }

                    
                }
                else
                {
                    MessageBox.Show("Selecione um produto!", "Erro ao remover o produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AdicionarProdCarrinho()
        {
                try
                {
                    qtd = int.Parse(tbQuantidade.Text);
                    precos = decimal.Parse(tbPrecoUnitario.Text);

                    subtotal = qtd * precos;

                    total += subtotal;

                    estoque = int.Parse(tbEstoque.Text);

                    codProd = int.Parse(tbCodigoProduto.Text);

                    if (estoque >= qtd)
                    {
                        carrinho.Rows.Add(codProd, tbNomeProduto.Text, qtd, precos, subtotal);

                        tbPrecoTotal.Text = total.ToString();
                        
                        LimparTextos();
                        if (Grid_Carrinho.Rows.Count > 0)
                        {
                            labelCaixaLivre.Text = "Caixa Ocupado";
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Estoque Insuficiente", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("A quantidade vazia ou produto não informado", "Erro ao adicionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        private void tbQuantidade_KeyDown_1(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {
                AdicionarProdCarrinho();
            }

            if (e.KeyCode == Keys.F4)
            {
                ViewFormaPagamento view = new ViewFormaPagamento(tbPrecoTotal.Text); // MOSTRAR O VALOR Q ESTAVA NO TEXTBOX DO FRENTE DE CAIXA NO LABEL DO FORM "FINALIZAR VENDA"
                view.ShowDialog();
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HoraFrenteCaixa.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void tbCodigoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                tabControl1.SelectedTab = tabPage2;
                produtoDAO dao = new produtoDAO();
                Grid.DataSource = dao.ListarProdutos();

            }
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Você deseja fechar o PDV?", "PDV", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }

            }
        }

        private void Grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbCodigoProduto.Text = Grid.CurrentRow.Cells[0].Value.ToString();
            tbNomeProduto.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            tbPrecoUnitario.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            tbEstoque.Text = Grid.CurrentRow.Cells[2].Value.ToString();


            tabControl1.SelectedTab = tabPage1;

        }

    }
}
