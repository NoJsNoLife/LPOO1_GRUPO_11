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
    public partial class AltaParticipantes : Form
    {
        private Form participanteReferencia;
        public AltaParticipantes(Form referenciaSistema)
        {
            InitializeComponent();
            participanteReferencia = referenciaSistema;
            selectSexo.Text = "No declara";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (DatosGlobales.atletas.Exists(
                atleta => atleta.Atl_DNI == txtDni.Text))
            {
                MessageBox.Show("Ya existe un atleta con este DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea agregar el atleta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                Atleta atleta = new Atleta(
                DatosGlobales.atletas.Count + 1, txtDni.Text, txtApellido.Text, txtNombre.Text, txtNacionalidad.Text, txtEntrenador.Text, selectSexo.Text[0], (double)numericAltura.Value, (double)numericPeso.Value, dateTimeNacimiento.Value, txtDireccion.Text, txtEmail.Text);
                DatosGlobales.atletas.Add(atleta);
                MessageBox.Show("Atleta agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            participanteReferencia.Refresh();
            participanteReferencia.Show();
        }
    }
}
