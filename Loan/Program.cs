using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static MainMenu formMainMenu; /// No se instancia la clase
        public static ADODB.Connection conect = new ADODB.Connection(); /// Conexión a la base de datos

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /// Application.Run(new MainMenu());  # Original
            Application.Run(formMainMenu = new MainMenu());
        }
    }
}
