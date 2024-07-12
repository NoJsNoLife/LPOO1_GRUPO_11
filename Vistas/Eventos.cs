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
    public partial class Eventos : Form
    {
        private Form principalReferencia;
        public Eventos(Form principal)
        {
            InitializeComponent();
            principalReferencia = principal;
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            principalReferencia.Show();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            this.Hide();
            InscripcionEventos inscripcionEventos = new InscripcionEventos(this);
            inscripcionEventos.Show();
        }

        private void btnAnularInscripcion_Click(object sender, EventArgs e)
        {
            this.Hide();
            BajaEvento anularInscripcion = new BajaEvento(this);
            anularInscripcion.Show();
        }

        private void btnAcreditarInscripcion_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcreditarInscripcion acreditarInscripcion = new AcreditarInscripcion(this);
            acreditarInscripcion.Show();
        }

        private void Eventos_VisibleChanged(object sender, EventArgs e)
        {
            CargarEventos();
        }

        private void CargarEventos()
        {
            dgwEventos.DataSource = TrabajarEvento.listarEventos();
            dgwEventos.Columns["Eve_ID"].Visible = false;
        }

    }
}
