namespace PDV.View
{
    partial class ViewFinanceiro
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalEmCaixa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dinheiro em Caixa:";
            // 
            // lbTotalEmCaixa
            // 
            this.lbTotalEmCaixa.AutoSize = true;
            this.lbTotalEmCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalEmCaixa.Location = new System.Drawing.Point(367, 54);
            this.lbTotalEmCaixa.Name = "lbTotalEmCaixa";
            this.lbTotalEmCaixa.Size = new System.Drawing.Size(70, 25);
            this.lbTotalEmCaixa.TabIndex = 1;
            this.lbTotalEmCaixa.Text = "label2";
            // 
            // ViewFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 127);
            this.Controls.Add(this.lbTotalEmCaixa);
            this.Controls.Add(this.label1);
            this.Name = "ViewFinanceiro";
            this.Text = "ViewFinanceiro";
            this.Load += new System.EventHandler(this.ViewFinanceiro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalEmCaixa;
    }
}