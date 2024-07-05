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
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void btnEnviarUsuario_Click(object sender, EventArgs e)
        {
            if (TrabajarUsuario.existe_usuario(txtNombreUsuario.Text))
            {
                MessageBox.Show("El usuario ya existe");
                return;
            }
            else
            {
                TrabajarUsuario.alta_usuario(txtNombreUsuario.Text, txtContraseniaUsuario.Text, txtApellidoNombreUsuario.Text, cmbRoles.SelectedIndex + 1);
                load_usuarios();
                MessageBox.Show("Usuario creado con éxito");
            }
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            load_roles();
            load_usuarios();
        }

        private void load_roles()
        {
            cmbRoles.DisplayMember = "Rol_Descripcion";
            cmbRoles.ValueMember = "Rol_Id";
            cmbRoles.DataSource = ClaseBase.TrabajarUsuario.list_roles();
        }

        private void load_usuarios()
        {
            dgwUsuarios.DataSource = ClaseBase.TrabajarUsuario.list_usuarios();
        }

        private void btnNombreUsuarioBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuarioBuscar.Text != "")
            {
                dgwUsuarios.DataSource = TrabajarUsuario.buscar_usuarios(txtNombreUsuarioBuscar.Text);
            }
            else
            {
                load_usuarios();
            }
        }
        private void dgwUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwUsuarios.CurrentRow!=null)
            {
                txtNombreUsuario.Text = dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContraseniaUsuario.Text = dgwUsuarios.CurrentRow.Cells["Contrasena"].Value.ToString();
                txtApellidoNombreUsuario.Text = dgwUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
                cmbRoles.SelectedIndex = Convert.ToInt32(dgwUsuarios.CurrentRow.Cells["Rol_Codigo"].Value) - 1;
            }
        }
    }
}
