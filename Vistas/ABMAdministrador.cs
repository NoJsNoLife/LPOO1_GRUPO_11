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
    public partial class ABMAdministrador : Form
    {
        public ABMAdministrador()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form altaUsuario = new AltaUsuario(this);
            altaUsuario.Show();

        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form modificarUsuarios = new ABMUsuarios(this);
            modificarUsuarios.Show();
        }
    }
}
