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
    public partial class Principal : Form
    {
        private Form referenciaLogin;
        public Principal(int rolCodigo, Form referenciaLogin)
        {
            InitializeComponent();
            this.referenciaLogin = referenciaLogin;

            switch (rolCodigo)
            {
                case 1:
                    pnlAdministrador.Visible = true;
                    pnlAdministrador.BringToFront();
                    break;
                case 2:
                    pnlOperador.Visible = true;
                    pnlOperador.BringToFront();
                    break;
                case 3:
                    pnlAuditor.Visible = true;
                    pnlAuditor.BringToFront();
                    break;
                default:
                    MessageBox.Show("Rol no válido");
                    break;


            }
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form sistema = new Sistema(this);
            sistema.Show();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form eventos = new Eventos(this);
            eventos.Show();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form usuarios = new ABMUsuarios(this);
            usuarios.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            referenciaLogin.Show();
        }
    }
}
