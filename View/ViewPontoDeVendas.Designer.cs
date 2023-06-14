namespace PDV.View
{
    partial class ViewPontoDeVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPontoDeVendas));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Grid_Carrinho = new System.Windows.Forms.DataGridView();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrecoTotal = new System.Windows.Forms.TextBox();
            this.tbPrecoUnitario = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCodigoProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelCaixaLivre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HoraFrenteCaixa = new System.Windows.Forms.Label();
            this.DataFrenteCaixa = new System.Windows.Forms.Label();
            this.labelCaixa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Carrinho)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 749);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.Grid_Carrinho);
            this.tabPage1.Controls.Add(this.tbNomeProduto);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tbEstoque);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbPrecoTotal);
            this.tabPage1.Controls.Add(this.tbPrecoUnitario);
            this.tabPage1.Controls.Add(this.tbQuantidade);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.tbCodigoProduto);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 723);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PDV";
            // 
            // Grid_Carrinho
            // 
            this.Grid_Carrinho.AllowUserToAddRows = false;
            this.Grid_Carrinho.AllowUserToDeleteRows = false;
            this.Grid_Carrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Carrinho.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Grid_Carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Carrinho.Location = new System.Drawing.Point(566, 139);
            this.Grid_Carrinho.Name = "Grid_Carrinho";
            this.Grid_Carrinho.ReadOnly = true;
            this.Grid_Carrinho.Size = new System.Drawing.Size(404, 361);
            this.Grid_Carrinho.TabIndex = 39;
            this.Grid_Carrinho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Grid_Carrinho_KeyDown);
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Enabled = false;
            this.tbNomeProduto.Location = new System.Drawing.Point(945, 599);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(25, 20);
            this.tbNomeProduto.TabIndex = 37;
            this.tbNomeProduto.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(276, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "Estoque";
            // 
            // tbEstoque
            // 
            this.tbEstoque.BackColor = System.Drawing.Color.Gainsboro;
            this.tbEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstoque.Location = new System.Drawing.Point(281, 465);
            this.tbEstoque.Multiline = true;
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(218, 35);
            this.tbEstoque.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 516);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "F3 - Remover Produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "F1 - Adicionar Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "ESC - Sair do PDV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "F4 - Finalizar Venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Comandos:";
            // 
            // tbPrecoTotal
            // 
            this.tbPrecoTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPrecoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecoTotal.Location = new System.Drawing.Point(281, 393);
            this.tbPrecoTotal.Multiline = true;
            this.tbPrecoTotal.Name = "tbPrecoTotal";
            this.tbPrecoTotal.Size = new System.Drawing.Size(218, 35);
            this.tbPrecoTotal.TabIndex = 28;
            // 
            // tbPrecoUnitario
            // 
            this.tbPrecoUnitario.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPrecoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrecoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecoUnitario.Location = new System.Drawing.Point(281, 319);
            this.tbPrecoUnitario.Multiline = true;
            this.tbPrecoUnitario.Name = "tbPrecoUnitario";
            this.tbPrecoUnitario.Size = new System.Drawing.Size(218, 35);
            this.tbPrecoUnitario.TabIndex = 27;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.BackColor = System.Drawing.Color.Gainsboro;
            this.tbQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantidade.Location = new System.Drawing.Point(281, 245);
            this.tbQuantidade.Multiline = true;
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(218, 35);
            this.tbQuantidade.TabIndex = 26;
            this.tbQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQuantidade_KeyDown_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Preço Total";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Preço Unitário";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Quantidade";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Location = new System.Drawing.Point(522, 625);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 80);
            this.panel4.TabIndex = 21;
            // 
            // tbCodigoProduto
            // 
            this.tbCodigoProduto.BackColor = System.Drawing.Color.Gainsboro;
            this.tbCodigoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoProduto.Location = new System.Drawing.Point(281, 171);
            this.tbCodigoProduto.Multiline = true;
            this.tbCodigoProduto.Name = "tbCodigoProduto";
            this.tbCodigoProduto.Size = new System.Drawing.Size(218, 35);
            this.tbCodigoProduto.TabIndex = 22;
            this.tbCodigoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodigoProduto_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código do Produto";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.labelCaixaLivre);
            this.panel3.Location = new System.Drawing.Point(27, 625);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 80);
            this.panel3.TabIndex = 19;
            // 
            // labelCaixaLivre
            // 
            this.labelCaixaLivre.AutoSize = true;
            this.labelCaixaLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaixaLivre.Location = new System.Drawing.Point(22, 23);
            this.labelCaixaLivre.Name = "labelCaixaLivre";
            this.labelCaixaLivre.Size = new System.Drawing.Size(175, 37);
            this.labelCaixaLivre.TabIndex = 12;
            this.labelCaixaLivre.Text = "Caixa Livre";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.HoraFrenteCaixa);
            this.panel2.Controls.Add(this.DataFrenteCaixa);
            this.panel2.Controls.Add(this.labelCaixa);
            this.panel2.Location = new System.Drawing.Point(27, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 80);
            this.panel2.TabIndex = 18;
            // 
            // HoraFrenteCaixa
            // 
            this.HoraFrenteCaixa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.HoraFrenteCaixa.AutoSize = true;
            this.HoraFrenteCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraFrenteCaixa.Location = new System.Drawing.Point(795, 20);
            this.HoraFrenteCaixa.Name = "HoraFrenteCaixa";
            this.HoraFrenteCaixa.Size = new System.Drawing.Size(73, 31);
            this.HoraFrenteCaixa.TabIndex = 2;
            this.HoraFrenteCaixa.Text = "Hora";
            // 
            // DataFrenteCaixa
            // 
            this.DataFrenteCaixa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataFrenteCaixa.AutoSize = true;
            this.DataFrenteCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFrenteCaixa.Location = new System.Drawing.Point(638, 20);
            this.DataFrenteCaixa.Name = "DataFrenteCaixa";
            this.DataFrenteCaixa.Size = new System.Drawing.Size(72, 31);
            this.DataFrenteCaixa.TabIndex = 1;
            this.DataFrenteCaixa.Text = "Data";
            // 
            // labelCaixa
            // 
            this.labelCaixa.AutoSize = true;
            this.labelCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaixa.Location = new System.Drawing.Point(22, 20);
            this.labelCaixa.Name = "labelCaixa";
            this.labelCaixa.Size = new System.Drawing.Size(102, 37);
            this.labelCaixa.TabIndex = 0;
            this.labelCaixa.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(27, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 289);
            this.panel1.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Grid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 723);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produtos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(25, 124);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(942, 576);
            this.Grid.TabIndex = 0;
            this.Grid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_CellMouseDoubleClick);
            // 
            // ViewPontoDeVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(995, 757);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewPontoDeVendas";
            this.Text = "Frente de Caixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewPontoDeVendas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Carrinho)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrecoTotal;
        private System.Windows.Forms.TextBox tbPrecoUnitario;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbCodigoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelCaixaLivre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HoraFrenteCaixa;
        private System.Windows.Forms.Label DataFrenteCaixa;
        private System.Windows.Forms.Label labelCaixa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEstoque;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.DataGridView Grid_Carrinho;
    }
}