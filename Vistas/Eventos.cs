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
    }
}
