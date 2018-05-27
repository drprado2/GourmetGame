using JogoGourmet.Core;
using JogoGourmet.UI.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet.UI
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var gameManager = new GameManager();
            
            Application.Run(new StartForm(gameManager));
        }
    }
}
