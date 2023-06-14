namespace PDV.View
{
    partial class ViewContaAReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewContaAReceber));
            this.GridContaReceber = new System.Windows.Forms.DataGridView();
            this.idConta_Receber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_lancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btPagar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDataPagamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btProcurar = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridContaReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // GridContaReceber
            // 
            this.GridContaReceber.AllowUserToAddRows = false;
            this.GridContaReceber.AllowUserToDeleteRows = false;
            this.GridContaReceber.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GridContaReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridContaReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConta_Receber,
            this.descricao,
            this.data_lancamento,
            this.data_vencimento,
            this.valor,
            this.pago,
            this.data_pagamento,
            this.valor_pagamento,
            this.Cliente_idCliente});
            this.GridContaReceber.GridColor = System.Drawing.SystemColors.Highlight;
            this.GridContaReceber.Location = new System.Drawing.Point(12, 141);
            this.GridContaReceber.Name = "GridContaReceber";
            this.GridContaReceber.ReadOnly = true;
            this.GridContaReceber.Size = new System.Drawing.Size(806, 285);
            this.GridContaReceber.TabIndex = 0;
            this.GridContaReceber.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridContaReceber_CellContentDoubleClick);
            // 
            // idConta_Receber
            // 
            this.idConta_Receber.DataPropertyName = "idConta_Receber";
            this.idConta_Receber.HeaderText = "id";
            this.idConta_Receber.Name = "idConta_Receber";
            this.idConta_Receber.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // data_lancamento
            // 
            this.data_lancamento.DataPropertyName = "data_lancamento";
            this.data_lancamento.HeaderText = "Data de Lançamento";
            this.data_lancamento.Name = "data_lancamento";
            this.data_lancamento.ReadOnly = true;
            // 
            // data_vencimento
            // 
            this.data_vencimento.DataPropertyName = "data_vencimento";
            this.data_vencimento.HeaderText = "Data de Vencimento";
            this.data_vencimento.Name = "data_vencimento";
            this.data_vencimento.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // pago
            // 
            this.pago.DataPropertyName = "pago";
            this.pago.HeaderText = "Status do Pagamento";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            // 
            // data_pagamento
            // 
            this.data_pagamento.DataPropertyName = "data_pagamento";
            this.data_pagamento.HeaderText = "Data de Pagamento";
            this.data_pagamento.Name = "data_pagamento";
            this.data_pagamento.ReadOnly = true;
            // 
            // valor_pagamento
            // 
            this.valor_pagamento.DataPropertyName = "valor_pagamento";
            this.valor_pagamento.HeaderText = "Valor do Pagamento";
            this.valor_pagamento.Name = "valor_pagamento";
            this.valor_pagamento.ReadOnly = true;
            // 
            // Cliente_idCliente
            // 
            this.Cliente_idCliente.DataPropertyName = "Cliente_idCliente";
            this.Cliente_idCliente.HeaderText = "id do Cliente";
            this.Cliente_idCliente.Name = "Cliente_idCliente";
            this.Cliente_idCliente.ReadOnly = true;
            // 
            // btRelatorio
            // 
            this.btRelatorio.BackColor = System.Drawing.Color.LightPink;
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btRelatorio.Image")));
            this.btRelatorio.Location = new System.Drawing.Point(729, 432);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(89, 30);
            this.btRelatorio.TabIndex = 1;
            this.btRelatorio.Text = "Relátorio";
            this.btRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btRelatorio.UseVisualStyleBackColor = false;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // btPagar
            // 
            this.btPagar.BackColor = System.Drawing.Color.YellowGreen;
            this.btPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPagar.Image = ((System.Drawing.Image)(resources.GetObject("btPagar.Image")));
            this.btPagar.Location = new System.Drawing.Point(12, 432);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(89, 30);
            this.btPagar.TabIndex = 2;
            this.btPagar.Text = "Pagar";
            this.btPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btPagar.UseVisualStyleBackColor = false;
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Tomato;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(226, 432);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(89, 30);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data de Pagamento:";
            // 
            // tbDataPagamento
            // 
            this.tbDataPagamento.Location = new System.Drawing.Point(251, 41);
            this.tbDataPagamento.Name = "tbDataPagamento";
            this.tbDataPagamento.Size = new System.Drawing.Size(139, 20);
            this.tbDataPagamento.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor:";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(553, 41);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(131, 20);
            this.tbValor.TabIndex = 7;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(120, 432);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(89, 30);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btProcurar
            // 
            this.btProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProcurar.FlatAppearance.BorderSize = 0;
            this.btProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btProcurar.Image")));
            this.btProcurar.Location = new System.Drawing.Point(266, 88);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(43, 33);
            this.btProcurar.TabIndex = 51;
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 130;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Contas em Atraso",
            "Contas não Vencidas     ",
            "Contas Pagas"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 90);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox1.Size = new System.Drawing.Size(314, 30);
            this.checkedListBox1.TabIndex = 52;
            // 
            // ViewContaAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 484);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDataPagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btPagar);
            this.Controls.Add(this.btRelatorio);
            this.Controls.Add(this.GridContaReceber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewContaAReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas  a Receber";
            this.Load += new System.EventHandler(this.ViewContaAReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridContaReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridContaReceber;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConta_Receber;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_lancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_idCliente;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDataPagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}