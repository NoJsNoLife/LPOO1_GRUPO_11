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
    public partial class AltaUsuario : Form
    {
        private Form referencia;
        public AltaUsuario(Form referencia)
        {
            this.referencia = referencia;
            InitializeComponent();
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            this.referencia.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (TrabajarUsuario.existe_usuario(txtNombreUsuario.Text))
            {
                MessageBox.Show("El usuario ya existe");
                return;
            }
            else
            {
                TrabajarUsuario.alta_usuario(txtNombreUsuario.Text, txtContrasenia.Text, txtNombre.Text, cmbRoles.SelectedIndex + 1);
                MessageBox.Show("Usuario creado con éxito");
                this.Close();
                referencia.Show();
            }
        }
        private void load_roles()
        {
            cmbRoles.DisplayMember = "Rol_Descripcion";
            cmbRoles.ValueMember = "Rol_Id";
            cmbRoles.DataSource = TrabajarUsuario.list_roles();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            load_roles();
        }
    }
}
