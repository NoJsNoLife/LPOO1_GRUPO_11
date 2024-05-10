using ClaseBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtNombre.Text = "Administrador";
            txtContrasena.Text = "admin";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {   String nombre = txtNombre.Text;
            String contrasena = txtContrasena.Text;
            if (DatosGlobales.usuarios.Exists(u => u.Usu_NombreUsuario == nombre && u.Usu_Contraseña == contrasena))
            {
                MessageBox.Show("Bienvenido al sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form principal = new Principal();
                principal.Show();
            }
            else {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
