namespace PDV
{
    partial class ViewCadastroCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCadastroCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomeCli = new System.Windows.Forms.TextBox();
            this.tbLogradouroCli = new System.Windows.Forms.TextBox();
            this.tbNumCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComplementoCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBairroCli = new System.Windows.Forms.TextBox();
            this.tbCidadeCli = new System.Windows.Forms.TextBox();
            this.tbEstadoCli = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCepCli = new System.Windows.Forms.TextBox();
            this.tbTelefoneCli = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEmailCli = new System.Windows.Forms.TextBox();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCpf_Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.tbCpfCnpjCli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF/CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Logradouro:";
            // 
            // tbNomeCli
            // 
            this.tbNomeCli.Enabled = false;
            this.tbNomeCli.Location = new System.Drawing.Point(94, 36);
            this.tbNomeCli.Name = "tbNomeCli";
            this.tbNomeCli.Size = new System.Drawing.Size(503, 20);
            this.tbNomeCli.TabIndex = 4;
            // 
            // tbLogradouroCli
            // 
            this.tbLogradouroCli.Enabled = false;
            this.tbLogradouroCli.Location = new System.Drawing.Point(94, 86);
            this.tbLogradouroCli.Name = "tbLogradouroCli";
            this.tbLogradouroCli.Size = new System.Drawing.Size(293, 20);
            this.tbLogradouroCli.TabIndex = 6;
            // 
            // tbNumCli
            // 
            this.tbNumCli.Enabled = false;
            this.tbNumCli.Location = new System.Drawing.Point(742, 86);
            this.tbNumCli.Name = "tbNumCli";
            this.tbNumCli.Size = new System.Drawing.Size(36, 20);
            this.tbNumCli.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Complemento:";
            // 
            // tbComplementoCli
            // 
            this.tbComplementoCli.Enabled = false;
            this.tbComplementoCli.Location = new System.Drawing.Point(487, 86);
            this.tbComplementoCli.Name = "tbComplementoCli";
            this.tbComplementoCli.Size = new System.Drawing.Size(185, 20);
            this.tbComplementoCli.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bairro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(689, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estado:";
            // 
            // tbBairroCli
            // 
            this.tbBairroCli.Enabled = false;
            this.tbBairroCli.Location = new System.Drawing.Point(94, 130);
            this.tbBairroCli.Name = "tbBairroCli";
            this.tbBairroCli.Size = new System.Drawing.Size(293, 20);
            this.tbBairroCli.TabIndex = 9;
            // 
            // tbCidadeCli
            // 
            this.tbCidadeCli.Enabled = false;
            this.tbCidadeCli.Location = new System.Drawing.Point(487, 130);
            this.tbCidadeCli.Name = "tbCidadeCli";
            this.tbCidadeCli.Size = new System.Drawing.Size(185, 20);
            this.tbCidadeCli.TabIndex = 10;
            // 
            // tbEstadoCli
            // 
            this.tbEstadoCli.Enabled = false;
            this.tbEstadoCli.Location = new System.Drawing.Point(742, 130);
            this.tbEstadoCli.Name = "tbEstadoCli";
            this.tbEstadoCli.Size = new System.Drawing.Size(36, 20);
            this.tbEstadoCli.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "CEP:";
            // 
            // tbCepCli
            // 
            this.tbCepCli.Enabled = false;
            this.tbCepCli.Location = new System.Drawing.Point(94, 174);
            this.tbCepCli.Name = "tbCepCli";
            this.tbCepCli.Size = new System.Drawing.Size(251, 20);
            this.tbCepCli.TabIndex = 12;
            // 
            // tbTelefoneCli
            // 
            this.tbTelefoneCli.Enabled = false;
            this.tbTelefoneCli.Location = new System.Drawing.Point(410, 174);
            this.tbTelefoneCli.Name = "tbTelefoneCli";
            this.tbTelefoneCli.Size = new System.Drawing.Size(128, 20);
            this.tbTelefoneCli.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(562, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email:";
            // 
            // tbEmailCli
            // 
            this.tbEmailCli.Enabled = false;
            this.tbEmailCli.Location = new System.Drawing.Point(607, 174);
            this.tbEmailCli.Name = "tbEmailCli";
            this.tbEmailCli.Size = new System.Drawing.Size(171, 20);
            this.tbEmailCli.TabIndex = 14;
            // 
            // gridCliente
            // 
            this.gridCliente.AllowUserToAddRows = false;
            this.gridCliente.AllowUserToDeleteRows = false;
            this.gridCliente.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNome,
            this.ColCpf_Cnpj,
            this.ColLogradouro,
            this.ColNum,
            this.ColComplemento,
            this.ColBairro,
            this.ColCidade,
            this.ColEstado,
            this.ColCep,
            this.ColTelefone,
            this.ColEmail});
            this.gridCliente.GridColor = System.Drawing.SystemColors.Highlight;
            this.gridCliente.Location = new System.Drawing.Point(26, 236);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.ReadOnly = true;
            this.gridCliente.Size = new System.Drawing.Size(751, 251);
            this.gridCliente.TabIndex = 22;
            this.gridCliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCliente_CellContentDoubleClick);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "idCliente";
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
            // ColNum
            // 
            this.ColNum.DataPropertyName = "numero";
            this.ColNum.HeaderText = "Número";
            this.ColNum.Name = "ColNum";
            this.ColNum.ReadOnly = true;
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
            // ColCep
            // 
            this.ColCep.DataPropertyName = "cep";
            this.ColCep.HeaderText = "CEP";
            this.ColCep.Name = "ColCep";
            this.ColCep.ReadOnly = true;
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
            this.ColEmail.DataPropertyName = "emai";
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.Gold;
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNovo.Image = ((System.Drawing.Image)(resources.GetObject("buttonNovo.Image")));
            this.buttonNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovo.Location = new System.Drawing.Point(26, 505);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(89, 30);
            this.buttonNovo.TabIndex = 23;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEditar.Enabled = false;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditar.Image")));
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(137, 505);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(89, 30);
            this.buttonEditar.TabIndex = 24;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.Tomato;
            this.buttonExcluir.Enabled = false;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExcluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluir.Image")));
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluir.Location = new System.Drawing.Point(359, 505);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(89, 30);
            this.buttonExcluir.TabIndex = 25;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(470, 505);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(89, 30);
            this.buttonSalvar.TabIndex = 26;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Location = new System.Drawing.Point(248, 505);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(89, 30);
            this.buttonCancelar.TabIndex = 28;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // tbCpfCnpjCli
            // 
            this.tbCpfCnpjCli.Enabled = false;
            this.tbCpfCnpjCli.Location = new System.Drawing.Point(685, 36);
            this.tbCpfCnpjCli.Name = "tbCpfCnpjCli";
            this.tbCpfCnpjCli.Size = new System.Drawing.Size(93, 20);
            this.tbCpfCnpjCli.TabIndex = 29;
            // 
            // ViewCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.tbCpfCnpjCli);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.gridCliente);
            this.Controls.Add(this.tbEmailCli);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbTelefoneCli);
            this.Controls.Add(this.tbCepCli);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbEstadoCli);
            this.Controls.Add(this.tbCidadeCli);
            this.Controls.Add(this.tbBairroCli);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbComplementoCli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNumCli);
            this.Controls.Add(this.tbLogradouroCli);
            this.Controls.Add(this.tbNomeCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewCadastroCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.ViewCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNomeCli;
        private System.Windows.Forms.TextBox tbLogradouroCli;
        private System.Windows.Forms.TextBox tbNumCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbComplementoCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBairroCli;
        private System.Windows.Forms.TextBox tbCidadeCli;
        private System.Windows.Forms.TextBox tbEstadoCli;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCepCli;
        private System.Windows.Forms.TextBox tbTelefoneCli;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbEmailCli;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox tbCpfCnpjCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCpf_Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
    }
}

