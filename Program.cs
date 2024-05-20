using Fdsmlfr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fdsmlfr.Controllers;
using Fdsmlfr.Interfaces;

namespace Fdsmlfr
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormComida());
            Application.Run(new FormIndex());

        }
    }
}
