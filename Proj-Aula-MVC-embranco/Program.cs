using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Proj_Aula_BD.Visao;

namespace Proj_Aula_BD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FPrincipal());
        }
    }
}
