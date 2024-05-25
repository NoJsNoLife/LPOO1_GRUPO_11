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
    public partial class ABMUsuarios : Form
    {
        private Form referencia;
        private int usuarioId = 0;
        public ABMUsuarios(Form referencia)
        {
            InitializeComponent();
            this.referencia = referencia;
        }

        private void btnEnviarUsuario_Click(object sender, EventArgs e)
        {

            if (usuarioId != 0)
            {
                string nuevoUsuario = txtNombreUsuario.Text;
                string nuevaContrasenia;
                if (txtContraseniaUsuario.Text.Equals("")) { 
                    nuevaContrasenia = dgwUsuarios.CurrentRow.Cells["Contrasena"].Value.ToString();
                }else{
                    nuevaContrasenia = txtContraseniaUsuario.Text;
                }
                string nuevoNombreYApellido = txtApellidoNombreUsuario.Text;
                int nuevoRol = Convert.ToInt32(cmbRoles.SelectedIndex) + 1;
                if (TrabajarUsuario.ExisteUsuarioConMismoNombre(nuevoUsuario, usuarioId))
                {
                    MessageBox.Show("Ese usuario ya existe");
                    return;
                }
                else
                {
                    TrabajarUsuario.modificar_usuario(usuarioId, nuevoUsuario, nuevaContrasenia, nuevoNombreYApellido, nuevoRol);
                    load_usuarios();
                    MessageBox.Show("Usuario modificado con éxito");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para modificar");
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
            dgwUsuarios.Columns["Rol_Codigo"].Visible = false;
            dgwUsuarios.Columns["Contrasena"].Visible = false;
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
            if (dgwUsuarios.CurrentRow != null && !Convert.IsDBNull(dgwUsuarios.CurrentRow.Cells["Rol_Codigo"].Value))
            {   
                usuarioId = Convert.ToInt32(dgwUsuarios.CurrentRow.Cells["ID"].Value);
                txtNombreUsuario.Text = dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                //txtContraseniaUsuario.Text = dgwUsuarios.CurrentRow.Cells["Contrasena"].Value.ToString();
                txtApellidoNombreUsuario.Text = dgwUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
                cmbRoles.SelectedIndex = Convert.ToInt32(dgwUsuarios.CurrentRow.Cells["Rol_Codigo"].Value) - 1;
            }
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            this.referencia.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(cmbRoles.SelectedIndex+1 == 1){
                    MessageBox.Show("No se puede eliminar un usuario Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TrabajarUsuario.borrar_usuario(txtNombreUsuario.Text);
                load_usuarios();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form altaUsuarios = new AltaUsuario(this);
            altaUsuarios.Show();
        }
    }
}
