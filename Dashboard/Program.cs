using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Dashboard
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Generic generic = new Generic();
            if (generic.InitialConfig() == true)
            {
                MessageBox.Show("Banco de dados criado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro, o Banco de dados já existe !");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }
    }
}
