using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Inicio funcion login
            string usuario = textBoxUsuario.Text;
            string contrasena = textBoxContrasena.Text;
            Program.conect.Open("loan", usuario, contrasena);

        }
    }
}
