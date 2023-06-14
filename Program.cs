using PDV.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ViewCaixa logar = new ViewCaixa();
            if (logar.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new ViewTelaPrincipal());
            }
            
        }
    }
}
