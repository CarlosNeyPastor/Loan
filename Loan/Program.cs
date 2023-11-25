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

        public static Login formLogin; /// No se instancia la clase
        public static ADODB.Connection connect = new ADODB.Connection(); /// Conexión a la base de datos

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /// Application.Run(new MainMenu());                                         ####      Original line     ####
            Application.Run(formLogin = new Login()); /// Indica que inicia en Login
        }

        public static void Permitted(string User)
        {
            byte rol = 0;
            string queryLogin;
            ADODB.Recordset recordset;
            Object rowsAffected;
            if (connect.State != 0) // Verifica conexión, si el output es 0 la conexión esta cerrada
            {
                queryLogin = "select rol from usuariorol where usuario =' " + User + "'";
                try
                {
                    recordset = connect.Execute(queryLogin, out rowsAffected);
                }
                catch
                {
                    MessageBox.Show("Error al obtener el Rol del usuario");
                    return;
                }
                if (recordset.RecordCount == 0) 
                {
                    MessageBox.Show("No se encotnro el Rol del usuario");
                    return;
                }
                else
                {
                    rol = Convert.ToByte(recordset.Fields[0].Value);
                    switch (rol)
                    {
                        case 1:
                            // Mantenimiento
                            
                        case 2:
                            // Administrativo

                    }
                }
            }
        }
    }
}
