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
        public Principal()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form sistema = new Sistema(this);
            sistema.Show();
        }

        private void btnCompetencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form competencias = new Competencias(this);
            competencias.Show();
        }

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form participantes = new Participantes(this);
            participantes.Show();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form eventos = new Eventos(this);
            eventos.Show();
        }
    }
}
