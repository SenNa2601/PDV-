using System;

namespace PDV.View
{
    partial class ViewContaAPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewContaAPagar));
            this.buttonNovo = new System.Windows.Forms.Button();
            this.GridConta = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_lancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.tbRelatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLancamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVencimento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDataPag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbValorPag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPago = new System.Windows.Forms.TextBox();
            this.btProcurar = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridConta)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.Gold;
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNovo.Image = ((System.Drawing.Image)(resources.GetObject("buttonNovo.Image")));
            this.buttonNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovo.Location = new System.Drawing.Point(15, 418);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(89, 30);
            this.buttonNovo.TabIndex = 2;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click_1);
            // 
            // GridConta
            // 
            this.GridConta.AllowUserToAddRows = false;
            this.GridConta.AllowUserToDeleteRows = false;
            this.GridConta.AllowUserToOrderColumns = true;
            this.GridConta.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GridConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.data_lancamento,
            this.data_vencimento,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.GridConta.GridColor = System.Drawing.SystemColors.Highlight;
            this.GridConta.Location = new System.Drawing.Point(12, 183);
            this.GridConta.Name = "GridConta";
            this.GridConta.ReadOnly = true;
            this.GridConta.Size = new System.Drawing.Size(781, 212);
            this.GridConta.TabIndex = 3;
            this.GridConta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridConta_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "idConta_Pagar";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // Column1
            // 
            this.Column1.DataPropertyName = "valor";
            this.Column1.HeaderText = "Valor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "pago";
            this.Column2.HeaderText = "Status de Pagamento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "data_pagamento";
            this.Column3.HeaderText = "Data de Pagamento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "valor_pagamento";
            this.Column4.HeaderText = "Valor de Pagamento";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Fornecedor_idFornecedor";
            this.Column5.HeaderText = "id Fornecedor";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "nome";
            this.Column6.HeaderText = "Nome Fornecedor";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditar.Image")));
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(109, 418);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(89, 30);
            this.buttonEditar.TabIndex = 19;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(203, 418);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(89, 30);
            this.buttonCancelar.TabIndex = 20;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.Tomato;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExcluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluir.Image")));
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluir.Location = new System.Drawing.Point(297, 418);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(89, 30);
            this.buttonExcluir.TabIndex = 21;
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
            this.buttonSalvar.Location = new System.Drawing.Point(391, 418);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(89, 30);
            this.buttonSalvar.TabIndex = 23;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click_1);
            // 
            // tbRelatorio
            // 
            this.tbRelatorio.BackColor = System.Drawing.Color.LightPink;
            this.tbRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("tbRelatorio.Image")));
            this.tbRelatorio.Location = new System.Drawing.Point(704, 418);
            this.tbRelatorio.Name = "tbRelatorio";
            this.tbRelatorio.Size = new System.Drawing.Size(89, 30);
            this.tbRelatorio.TabIndex = 25;
            this.tbRelatorio.Text = "Relatório";
            this.tbRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tbRelatorio.UseVisualStyleBackColor = false;
            this.tbRelatorio.Click += new System.EventHandler(this.tbRelatorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor:";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(82, 24);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(116, 21);
            this.cbFornecedor.TabIndex = 4;
            this.cbFornecedor.Text = "Selecione ";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(82, 62);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(116, 20);
            this.tbValor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Emissão:";
            // 
            // tbLancamento
            // 
            this.tbLancamento.Location = new System.Drawing.Point(285, 23);
            this.tbLancamento.Name = "tbLancamento";
            this.tbLancamento.Size = new System.Drawing.Size(90, 20);
            this.tbLancamento.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vencimento:";
            // 
            // tbVencimento
            // 
            this.tbVencimento.Location = new System.Drawing.Point(285, 65);
            this.tbVencimento.Name = "tbVencimento";
            this.tbVencimento.Size = new System.Drawing.Size(90, 20);
            this.tbVencimento.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descrição:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(72, 108);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(303, 20);
            this.tbDescricao.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data Pagamento:";
            // 
            // tbDataPag
            // 
            this.tbDataPag.Location = new System.Drawing.Point(527, 24);
            this.tbDataPag.Name = "tbDataPag";
            this.tbDataPag.Size = new System.Drawing.Size(77, 20);
            this.tbDataPag.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Valor Pagamento:";
            // 
            // tbValorPag
            // 
            this.tbValorPag.Location = new System.Drawing.Point(527, 59);
            this.tbValorPag.Name = "tbValorPag";
            this.tbValorPag.Size = new System.Drawing.Size(77, 20);
            this.tbValorPag.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pago:";
            // 
            // tbPago
            // 
            this.tbPago.Location = new System.Drawing.Point(471, 95);
            this.tbPago.Name = "tbPago";
            this.tbPago.Size = new System.Drawing.Size(33, 20);
            this.tbPago.TabIndex = 18;
            this.tbPago.Text = "NÃO";
            // 
            // btProcurar
            // 
            this.btProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProcurar.FlatAppearance.BorderSize = 0;
            this.btProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btProcurar.Image")));
            this.btProcurar.Location = new System.Drawing.Point(266, 136);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(43, 33);
            this.btProcurar.TabIndex = 29;
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
            this.checkedListBox1.Location = new System.Drawing.Point(12, 138);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox1.Size = new System.Drawing.Size(314, 30);
            this.checkedListBox1.TabIndex = 50;
            // 
            // ViewContaAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 473);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.tbRelatorio);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.tbPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbValorPag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDataPag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbVencimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLancamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.GridConta);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewContaAPagar";
            this.Text = "Conta a Pagar";
            this.Load += new System.EventHandler(this.ViewContaAPagar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GridConta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.DataGridView GridConta;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button tbRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLancamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVencimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDataPag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbValorPag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPago;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_lancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}