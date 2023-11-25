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
        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Program.connect.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            try
            {
                // Inicio función login
                string User = textBoxUser.Text;
                string Password = textBoxPassword.Text;
                Program.Permitted(textBoxUser.Text);
                Program.Permitted(User);
                Program.connect.Open("loan", User, Password);
                // Llama al formulario MainMenu para usar la aplicación
                MainMenu formMainMenu = new MainMenu();
                formMainMenu.MdiParent = this;
                formMainMenu.Show();
                // Cierra el formulario de Login
                this.Close();
            }
            catch
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos");
                return;
            }

            // Habilita a memoria de consultas
            Program.connect.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
