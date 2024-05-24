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
    public partial class Atletas : Form
    {
        private Form prinicpalReferencia;
        public Atletas(Form referenciaSistema)
        {
            prinicpalReferencia = referenciaSistema;
            InitializeComponent();
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            prinicpalReferencia.Show();

        }

        private void btnAltaParticipantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form altaParticipantes = new AltaParticipantes(this);
            altaParticipantes.Show();
        }

        private void Atletas_Load(object sender, EventArgs e)
        {
            load_atletas();
        }

        private void load_atletas()
        {
            dgwAtletas.DataSource = ClaseBase.TrabajarAtletas.list_atletas();
        }
    }
}
