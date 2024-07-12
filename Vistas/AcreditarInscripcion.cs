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
    public partial class AcreditarInscripcion : Form
    {
        private Form principalReferencia;

        public AcreditarInscripcion(Form referencia)
        {
            InitializeComponent();
            principalReferencia = referencia;
            listarCompetencias();
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            principalReferencia.Show();
        }

        private void listarCompetencias()
        {
            cmbCompetencias.DataSource = ClaseBase.TrabajarCompetencia.listarCompetencias2();
            cmbCompetencias.DisplayMember = "Com_Nombre";
            cmbCompetencias.ValueMember = "Com_ID";
        }

        private void rBtnId_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnId.Checked && rBtnDni.Checked)
            {
                rBtnDni.Checked = false;
            }
        }

        private void rBtnDni_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnDni.Checked && rBtnDni.Checked)
            {
                rBtnId.Checked = false;
            }
        }

        private void btnAcreditar_Click(object sender, EventArgs e)
        {
            if (rBtnId.Checked)
            {
                AcreditarPorId();
            }
            else if (rBtnDni.Checked)
            {
                AcreditarPorDni();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de búsqueda");
            }
        }

        private void AcreditarPorId()
        {
            if (txtParticipante.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID de Atleta");
                return;
            }

            Evento evento = ClaseBase.TrabajarEvento.buscarEventoByIdAtleta(Convert.ToInt32(txtParticipante.Text), Convert.ToInt32(cmbCompetencias.SelectedValue));
            ProcesarEvento(evento);
        }

        private void AcreditarPorDni()
        {
            if (txtParticipante.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI de Atleta");
                return;
            }

            Evento evento = ClaseBase.TrabajarEvento.buscarEventoPorAtletaDniYCompetencia(txtParticipante.Text, Convert.ToInt32(cmbCompetencias.SelectedValue));
            ProcesarEvento(evento);
        }

        private void ProcesarEvento(Evento evento)
        {
            if (evento == null)
            {
                MessageBox.Show("El atleta no se encuentra inscripto en la competencia seleccionada");
            }
            else if (evento.Eve_Estado == "Anulado")
            {
                MessageBox.Show("El evento se encuentra anulado");
            }
            else if (evento.Eve_Estado == "Acreditado")
            {
                MessageBox.Show("El evento ya se encuentra acreditado");
            }
            else
            {
                var result = MessageBox.Show("¿Está seguro que desea acreditar su inscripción?", "Acreditar.", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    ClaseBase.TrabajarEvento.acreditarInscripcion(evento.Eve_ID);
                    MessageBox.Show("Acreditación realizada correctamente");
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            principalReferencia.Show();
        }
    }
}
