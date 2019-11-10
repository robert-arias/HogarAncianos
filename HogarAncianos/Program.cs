using System;
using System.Windows.Forms;
using HogarAncianos.View;

namespace HogarAncianos {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRM_MenuPrincipal());
        }
    }
}
