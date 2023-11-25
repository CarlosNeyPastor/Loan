using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        public static ADODB.Connection connect = new ADODB.Connection(); /// Conexión a la base de datos

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /// Application.Run(new MainMenu());  # Original
            Application.Run(formMainMenu = new MainMenu());
        }

        public static void Permitted(string User)
        {

            string queryLogin;
            ADODB.Recordset recordset;
            Object rowsAffected;
            if (connect.State != 0) // Verifica conexión, si el output es 0 la conexión esta cerrada
            {

            }
        }
    }
}
