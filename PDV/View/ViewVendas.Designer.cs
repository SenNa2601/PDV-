namespace PDV.View
{
    partial class ViewVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVendas));
            this.GridVendas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btProcurar = new System.Windows.Forms.Button();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.labelDe = new System.Windows.Forms.Label();
            this.labelAte = new System.Windows.Forms.Label();
            this.checkBoxCliente = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.datePicker_DE = new System.Windows.Forms.DateTimePicker();
            this.datePicker_ATE = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.GridVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridVendas
            // 
            this.GridVendas.AllowUserToAddRows = false;
            this.GridVendas.AllowUserToDeleteRows = false;
            this.GridVendas.AllowUserToOrderColumns = true;
            this.GridVendas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.GridVendas.GridColor = System.Drawing.SystemColors.Highlight;
            this.GridVendas.Location = new System.Drawing.Point(12, 91);
            this.GridVendas.Name = "GridVendas";
            this.GridVendas.ReadOnly = true;
            this.GridVendas.Size = new System.Drawing.Size(803, 318);
            this.GridVendas.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idVenda";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "data";
            this.Column2.HeaderText = "Data da Venda";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "hora";
            this.Column3.HeaderText = "Hora da Venda";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "total_venda";
            this.Column4.HeaderText = "Total da Venda";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "situacao_venda";
            this.Column5.HeaderText = "Situação da Venda";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Cliente_idCliente";
            this.Column6.HeaderText = "Id do Cliente";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "nome";
            this.Column7.HeaderText = "Cliente";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "FormaPagamento_idFormaPagamento";
            this.Column8.HeaderText = "Id Forma de Pagamento";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "nome1";
            this.Column9.HeaderText = "Forma de Pagamento";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // btRelatorio
            // 
            this.btRelatorio.BackColor = System.Drawing.Color.LightPink;
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btRelatorio.Image")));
            this.btRelatorio.Location = new System.Drawing.Point(726, 429);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(89, 30);
            this.btRelatorio.TabIndex = 2;
            this.btRelatorio.Text = "Relátorio";
            this.btRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btRelatorio.UseVisualStyleBackColor = false;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // btProcurar
            // 
            this.btProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProcurar.FlatAppearance.BorderSize = 0;
            this.btProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btProcurar.Image")));
            this.btProcurar.Location = new System.Drawing.Point(630, 34);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(43, 33);
            this.btProcurar.TabIndex = 52;
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Visible = false;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(194, 41);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(430, 20);
            this.tbNomeCliente.TabIndex = 53;
            this.tbNomeCliente.Visible = false;
            // 
            // labelDe
            // 
            this.labelDe.AutoSize = true;
            this.labelDe.Location = new System.Drawing.Point(225, 44);
            this.labelDe.Name = "labelDe";
            this.labelDe.Size = new System.Drawing.Size(24, 13);
            this.labelDe.TabIndex = 55;
            this.labelDe.Text = "De:";
            this.labelDe.Visible = false;
            // 
            // labelAte
            // 
            this.labelAte.AutoSize = true;
            this.labelAte.Location = new System.Drawing.Point(430, 44);
            this.labelAte.Name = "labelAte";
            this.labelAte.Size = new System.Drawing.Size(26, 13);
            this.labelAte.TabIndex = 57;
            this.labelAte.Text = "Até:";
            this.labelAte.Visible = false;
            // 
            // checkBoxCliente
            // 
            this.checkBoxCliente.AutoSize = true;
            this.checkBoxCliente.Location = new System.Drawing.Point(28, 34);
            this.checkBoxCliente.Name = "checkBoxCliente";
            this.checkBoxCliente.Size = new System.Drawing.Size(58, 17);
            this.checkBoxCliente.TabIndex = 58;
            this.checkBoxCliente.Text = "Cliente";
            this.checkBoxCliente.UseVisualStyleBackColor = true;
            this.checkBoxCliente.CheckedChanged += new System.EventHandler(this.checkBoxCliente_CheckedChanged);
            // 
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Location = new System.Drawing.Point(28, 57);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(49, 17);
            this.checkBoxData.TabIndex = 59;
            this.checkBoxData.Text = "Data";
            this.checkBoxData.UseVisualStyleBackColor = true;
            this.checkBoxData.CheckedChanged += new System.EventHandler(this.checkBoxData_CheckedChanged);
            // 
            // datePicker_DE
            // 
            this.datePicker_DE.CustomFormat = "yyyy-MM-dd";
            this.datePicker_DE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker_DE.Location = new System.Drawing.Point(255, 41);
            this.datePicker_DE.Name = "datePicker_DE";
            this.datePicker_DE.Size = new System.Drawing.Size(95, 20);
            this.datePicker_DE.TabIndex = 60;
            this.datePicker_DE.Value = new System.DateTime(2023, 5, 29, 0, 0, 0, 0);
            this.datePicker_DE.Visible = false;
            // 
            // datePicker_ATE
            // 
            this.datePicker_ATE.CustomFormat = "yyyy-MM-dd";
            this.datePicker_ATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker_ATE.Location = new System.Drawing.Point(462, 41);
            this.datePicker_ATE.Name = "datePicker_ATE";
            this.datePicker_ATE.Size = new System.Drawing.Size(97, 20);
            this.datePicker_ATE.TabIndex = 61;
            this.datePicker_ATE.Value = new System.DateTime(2023, 5, 29, 0, 0, 0, 0);
            this.datePicker_ATE.Visible = false;
            // 
            // ViewVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 476);
            this.Controls.Add(this.datePicker_ATE);
            this.Controls.Add(this.datePicker_DE);
            this.Controls.Add(this.labelAte);
            this.Controls.Add(this.labelDe);
            this.Controls.Add(this.checkBoxData);
            this.Controls.Add(this.checkBoxCliente);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.btRelatorio);
            this.Controls.Add(this.GridVendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Vendas";
            this.Load += new System.EventHandler(this.ViewVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridVendas;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Label labelDe;
        private System.Windows.Forms.Label labelAte;
        private System.Windows.Forms.CheckBox checkBoxCliente;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.DateTimePicker datePicker_DE;
        private System.Windows.Forms.DateTimePicker datePicker_ATE;
    }
}