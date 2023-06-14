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
    public partial class ViewCaixa : Form
    {
        public ViewCaixa()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ViewPontoDeVendas viewpontodevendas = new ViewPontoDeVendas();
            viewpontodevendas.ShowDialog();
            this.Dispose();
        }

        private void ViewCaixa_Load(object sender, EventArgs e)
        {

        }
    }
}
