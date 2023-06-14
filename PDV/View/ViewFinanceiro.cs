﻿using PDV.DAO;
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
    public partial class ViewFinanceiro : Form
    {
        public ViewFinanceiro()
        {
            InitializeComponent();
        }

        private void ViewFinanceiro_Load(object sender, EventArgs e)
        {
            decimal result;

            caixaDAO caixadao = new caixaDAO();
            result = caixadao.RetornarSomaCaixa();

            lbTotalEmCaixa.Text = result.ToString();  
        }
    }
}
