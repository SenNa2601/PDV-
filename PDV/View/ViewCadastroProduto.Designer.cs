namespace PDV
{
    partial class ViewCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCadastroProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomeProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrecoProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUnidadeProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQtdEstoque = new System.Windows.Forms.TextBox();
            this.gridProd = new System.Windows.Forms.DataGridView();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tbNomeProd
            // 
            this.tbNomeProd.Location = new System.Drawing.Point(70, 18);
            this.tbNomeProd.Name = "tbNomeProd";
            this.tbNomeProd.Size = new System.Drawing.Size(175, 20);
            this.tbNomeProd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço:";
            // 
            // tbPrecoProd
            // 
            this.tbPrecoProd.Location = new System.Drawing.Point(70, 61);
            this.tbPrecoProd.Name = "tbPrecoProd";
            this.tbPrecoProd.Size = new System.Drawing.Size(175, 20);
            this.tbPrecoProd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unidade:";
            // 
            // tbUnidadeProd
            // 
            this.tbUnidadeProd.Location = new System.Drawing.Point(414, 18);
            this.tbUnidadeProd.Name = "tbUnidadeProd";
            this.tbUnidadeProd.Size = new System.Drawing.Size(160, 20);
            this.tbUnidadeProd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade Estoque:";
            // 
            // tbQtdEstoque
            // 
            this.tbQtdEstoque.Location = new System.Drawing.Point(471, 61);
            this.tbQtdEstoque.Name = "tbQtdEstoque";
            this.tbQtdEstoque.Size = new System.Drawing.Size(103, 20);
            this.tbQtdEstoque.TabIndex = 7;
            // 
            // gridProd
            // 
            this.gridProd.AllowUserToAddRows = false;
            this.gridProd.AllowUserToDeleteRows = false;
            this.gridProd.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNome,
            this.ColUnidade});
            this.gridProd.Location = new System.Drawing.Point(28, 194);
            this.gridProd.Name = "gridProd";
            this.gridProd.ReadOnly = true;
            this.gridProd.Size = new System.Drawing.Size(623, 267);
            this.gridProd.TabIndex = 8;
            this.gridProd.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProd_CellContentDoubleClick_1);
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.Gold;
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNovo.Image = ((System.Drawing.Image)(resources.GetObject("buttonNovo.Image")));
            this.buttonNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovo.Location = new System.Drawing.Point(39, 482);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(89, 30);
            this.buttonNovo.TabIndex = 9;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditar.Image")));
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(158, 482);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(89, 30);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(277, 482);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(89, 30);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.Tomato;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExcluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluir.Image")));
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluir.Location = new System.Drawing.Point(396, 482);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(89, 30);
            this.buttonExcluir.TabIndex = 12;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(515, 482);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(89, 30);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fornecedor:";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DisplayMember = "nome";
            this.cbFornecedor.Enabled = false;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(95, 104);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(150, 21);
            this.cbFornecedor.TabIndex = 15;
            this.cbFornecedor.Text = "Selecione o Fornecedor";
            this.cbFornecedor.ValueMember = "idFornecedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pesquisar:";
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Location = new System.Drawing.Point(95, 152);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(370, 20);
            this.tbPesquisar.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(471, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 37);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColNome
            // 
            this.ColNome.DataPropertyName = "nome";
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            // 
            // ColUnidade
            // 
            this.ColUnidade.DataPropertyName = "unidade";
            this.ColUnidade.HeaderText = "Unidade";
            this.ColUnidade.Name = "ColUnidade";
            this.ColUnidade.ReadOnly = true;
            // 
            // ViewCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPesquisar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.gridProd);
            this.Controls.Add(this.tbQtdEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUnidadeProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrecoProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomeProd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewCadastroProduto";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.ViewCadastroProduto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomeProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrecoProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUnidadeProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQtdEstoque;
        private System.Windows.Forms.DataGridView gridProd;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnidade;
    }
}