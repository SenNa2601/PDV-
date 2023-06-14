namespace PDV.View
{
    partial class ViewCadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCadastroFornecedor));
            this.tbCpfCnpjFor = new System.Windows.Forms.MaskedTextBox();
            this.gridFornecedor = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCpf_Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbEmailFor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTelefoneFor = new System.Windows.Forms.TextBox();
            this.tbCepFor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEstadoFor = new System.Windows.Forms.TextBox();
            this.tbCidadeFor = new System.Windows.Forms.TextBox();
            this.tbBairroFor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbComplementoFor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNumFor = new System.Windows.Forms.TextBox();
            this.tbLogradouroFor = new System.Windows.Forms.TextBox();
            this.tbNomeFor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCpfCnpjFor
            // 
            this.tbCpfCnpjFor.Enabled = false;
            this.tbCpfCnpjFor.Location = new System.Drawing.Point(684, 11);
            this.tbCpfCnpjFor.Mask = "000.000.000-00";
            this.tbCpfCnpjFor.Name = "tbCpfCnpjFor";
            this.tbCpfCnpjFor.Size = new System.Drawing.Size(92, 20);
            this.tbCpfCnpjFor.TabIndex = 28;
            // 
            // gridFornecedor
            // 
            this.gridFornecedor.AllowUserToAddRows = false;
            this.gridFornecedor.AllowUserToDeleteRows = false;
            this.gridFornecedor.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridFornecedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNome,
            this.ColCpf_Cnpj,
            this.ColLogradouro,
            this.ColNumero,
            this.ColComplemento,
            this.ColBairro,
            this.ColCidade,
            this.ColEstado,
            this.colCEP,
            this.ColTelefone,
            this.ColEmail});
            this.gridFornecedor.GridColor = System.Drawing.SystemColors.Highlight;
            this.gridFornecedor.Location = new System.Drawing.Point(25, 190);
            this.gridFornecedor.Name = "gridFornecedor";
            this.gridFornecedor.ReadOnly = true;
            this.gridFornecedor.Size = new System.Drawing.Size(751, 251);
            this.gridFornecedor.TabIndex = 45;
            this.gridFornecedor.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFornecedor_CellContentDoubleClick);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "IdFornecedor";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColNome
            // 
            this.ColNome.DataPropertyName = "nome";
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            // 
            // ColCpf_Cnpj
            // 
            this.ColCpf_Cnpj.DataPropertyName = "cpf_cnpj";
            this.ColCpf_Cnpj.HeaderText = "CPF/CNPJ";
            this.ColCpf_Cnpj.Name = "ColCpf_Cnpj";
            this.ColCpf_Cnpj.ReadOnly = true;
            // 
            // ColLogradouro
            // 
            this.ColLogradouro.DataPropertyName = "logradouro";
            this.ColLogradouro.HeaderText = "Logradouro";
            this.ColLogradouro.Name = "ColLogradouro";
            this.ColLogradouro.ReadOnly = true;
            // 
            // ColNumero
            // 
            this.ColNumero.DataPropertyName = "numero";
            this.ColNumero.HeaderText = "Número";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            // 
            // ColComplemento
            // 
            this.ColComplemento.DataPropertyName = "complemento";
            this.ColComplemento.HeaderText = "Complemento";
            this.ColComplemento.Name = "ColComplemento";
            this.ColComplemento.ReadOnly = true;
            // 
            // ColBairro
            // 
            this.ColBairro.DataPropertyName = "bairro";
            this.ColBairro.HeaderText = "Bairro";
            this.ColBairro.Name = "ColBairro";
            this.ColBairro.ReadOnly = true;
            // 
            // ColCidade
            // 
            this.ColCidade.DataPropertyName = "cidade";
            this.ColCidade.HeaderText = "Cidade";
            this.ColCidade.Name = "ColCidade";
            this.ColCidade.ReadOnly = true;
            // 
            // ColEstado
            // 
            this.ColEstado.DataPropertyName = "estado";
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // colCEP
            // 
            this.colCEP.DataPropertyName = "cep";
            this.colCEP.HeaderText = "CEP";
            this.colCEP.Name = "colCEP";
            this.colCEP.ReadOnly = true;
            // 
            // ColTelefone
            // 
            this.ColTelefone.DataPropertyName = "telefone";
            this.ColTelefone.HeaderText = "Telefone";
            this.ColTelefone.Name = "ColTelefone";
            this.ColTelefone.ReadOnly = true;
            // 
            // ColEmail
            // 
            this.ColEmail.DataPropertyName = "email";
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            // 
            // tbEmailFor
            // 
            this.tbEmailFor.Enabled = false;
            this.tbEmailFor.Location = new System.Drawing.Point(606, 146);
            this.tbEmailFor.Name = "tbEmailFor";
            this.tbEmailFor.Size = new System.Drawing.Size(171, 20);
            this.tbEmailFor.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(561, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Email:";
            // 
            // tbTelefoneFor
            // 
            this.tbTelefoneFor.Enabled = false;
            this.tbTelefoneFor.Location = new System.Drawing.Point(409, 146);
            this.tbTelefoneFor.Name = "tbTelefoneFor";
            this.tbTelefoneFor.Size = new System.Drawing.Size(128, 20);
            this.tbTelefoneFor.TabIndex = 40;
            // 
            // tbCepFor
            // 
            this.tbCepFor.Enabled = false;
            this.tbCepFor.Location = new System.Drawing.Point(93, 146);
            this.tbCepFor.Name = "tbCepFor";
            this.tbCepFor.Size = new System.Drawing.Size(251, 20);
            this.tbCepFor.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "CEP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Telefone:";
            // 
            // tbEstadoFor
            // 
            this.tbEstadoFor.Enabled = false;
            this.tbEstadoFor.Location = new System.Drawing.Point(741, 102);
            this.tbEstadoFor.Name = "tbEstadoFor";
            this.tbEstadoFor.Size = new System.Drawing.Size(36, 20);
            this.tbEstadoFor.TabIndex = 36;
            // 
            // tbCidadeFor
            // 
            this.tbCidadeFor.Enabled = false;
            this.tbCidadeFor.Location = new System.Drawing.Point(486, 102);
            this.tbCidadeFor.Name = "tbCidadeFor";
            this.tbCidadeFor.Size = new System.Drawing.Size(185, 20);
            this.tbCidadeFor.TabIndex = 34;
            // 
            // tbBairroFor
            // 
            this.tbBairroFor.Enabled = false;
            this.tbBairroFor.Location = new System.Drawing.Point(93, 102);
            this.tbBairroFor.Name = "tbBairroFor";
            this.tbBairroFor.Size = new System.Drawing.Size(293, 20);
            this.tbBairroFor.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(688, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Bairro:";
            // 
            // tbComplementoFor
            // 
            this.tbComplementoFor.Enabled = false;
            this.tbComplementoFor.Location = new System.Drawing.Point(486, 58);
            this.tbComplementoFor.Name = "tbComplementoFor";
            this.tbComplementoFor.Size = new System.Drawing.Size(185, 20);
            this.tbComplementoFor.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Complemento:";
            // 
            // tbNumFor
            // 
            this.tbNumFor.Enabled = false;
            this.tbNumFor.Location = new System.Drawing.Point(741, 58);
            this.tbNumFor.Name = "tbNumFor";
            this.tbNumFor.Size = new System.Drawing.Size(36, 20);
            this.tbNumFor.TabIndex = 31;
            // 
            // tbLogradouroFor
            // 
            this.tbLogradouroFor.Enabled = false;
            this.tbLogradouroFor.Location = new System.Drawing.Point(93, 58);
            this.tbLogradouroFor.Name = "tbLogradouroFor";
            this.tbLogradouroFor.Size = new System.Drawing.Size(293, 20);
            this.tbLogradouroFor.TabIndex = 29;
            // 
            // tbNomeFor
            // 
            this.tbNomeFor.Enabled = false;
            this.tbNomeFor.Location = new System.Drawing.Point(93, 11);
            this.tbNomeFor.Name = "tbNomeFor";
            this.tbNomeFor.Size = new System.Drawing.Size(503, 20);
            this.tbNomeFor.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Logradouro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "CPF/CNPJ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Location = new System.Drawing.Point(247, 453);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(89, 30);
            this.buttonCancelar.TabIndex = 50;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(469, 453);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(89, 30);
            this.buttonSalvar.TabIndex = 49;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.Tomato;
            this.buttonExcluir.Enabled = false;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExcluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluir.Image")));
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluir.Location = new System.Drawing.Point(358, 453);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(89, 30);
            this.buttonExcluir.TabIndex = 48;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEditar.Enabled = false;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditar.Image")));
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(136, 453);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(89, 30);
            this.buttonEditar.TabIndex = 47;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.Gold;
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNovo.Image = ((System.Drawing.Image)(resources.GetObject("buttonNovo.Image")));
            this.buttonNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovo.Location = new System.Drawing.Point(25, 453);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(89, 30);
            this.buttonNovo.TabIndex = 46;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // ViewCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 495);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.tbCpfCnpjFor);
            this.Controls.Add(this.gridFornecedor);
            this.Controls.Add(this.tbEmailFor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbTelefoneFor);
            this.Controls.Add(this.tbCepFor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbEstadoFor);
            this.Controls.Add(this.tbCidadeFor);
            this.Controls.Add(this.tbBairroFor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbComplementoFor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNumFor);
            this.Controls.Add(this.tbLogradouroFor);
            this.Controls.Add(this.tbNomeFor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewCadastroFornecedor";
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.ViewCadastroFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbCpfCnpjFor;
        private System.Windows.Forms.DataGridView gridFornecedor;
        private System.Windows.Forms.TextBox tbEmailFor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTelefoneFor;
        private System.Windows.Forms.TextBox tbCepFor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEstadoFor;
        private System.Windows.Forms.TextBox tbCidadeFor;
        private System.Windows.Forms.TextBox tbBairroFor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbComplementoFor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNumFor;
        private System.Windows.Forms.TextBox tbLogradouroFor;
        private System.Windows.Forms.TextBox tbNomeFor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCpf_Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
    }
}