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
        private String atletaDni;

        public Atletas(Form referenciaSistema)
        {
            prinicpalReferencia = referenciaSistema;
            InitializeComponent();
            dgwAtletas.MultiSelect = false;
        }

        private void Atletas_VisibleChanged(object sender, EventArgs e)
        {
            // Si el formulario es visible, carga los atletas
            if (this.Visible)
            {
                load_atletas();
            }
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            prinicpalReferencia.Show();
        }

        private void btnAltaParticipantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaParticipantes altaParticipantes = new AltaParticipantes(this, null);
            altaParticipantes.Show();
        }

        private void Atletas_Load(object sender, EventArgs e)
        {
            load_atletas();
        }

        private void load_atletas()
        {
            dgwAtletas.DataSource = null;
            dgwAtletas.DataSource = ClaseBase.TrabajarAtletas.list_atletas();
        }

        private void dgwAtletas_SelectionChanged(object sender, EventArgs e)
        {
            atletaDni = dgwAtletas.CurrentRow.Cells[0].Value.ToString();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el participante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            TrabajarAtletas.baja_atleta(atletaDni);
            load_atletas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaParticipantes altaParticipantes = new AltaParticipantes(this, atletaDni);
            altaParticipantes.Show();
        }

        private void txtDNIAtletaBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtDNIAtletaBuscar.Text != "")
            {
                dgwAtletas.DataSource = TrabajarAtletas.buscar_atletas(txtDNIAtletaBuscar.Text);
            }
            else
            {
                load_atletas();
            }
        }
    }
}
