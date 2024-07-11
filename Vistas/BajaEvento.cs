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
    public partial class BajaEvento : Form
    {
        private Form principalReferencia;
        public BajaEvento(Form referencia)
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
            cmbCompetencias.DataSource = ClaseBase.TrabajarCompetencia.listarCompetencias();
            cmbCompetencias.DisplayMember = "Nombre";
            cmbCompetencias.ValueMember = "ID";
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
            if (rBtnDni.Checked && rBtnId.Checked)
            {
                rBtnId.Checked = false;
            }
        }


        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (rBtnId.Checked)
            {
                if (txtParticipante.Text == "")
                {
                    MessageBox.Show("Debe ingresar un ID de Atleta");
                    return;
                }

                Evento evento = ClaseBase.TrabajarEvento.buscarEventoByIdAtleta(Convert.ToInt32(txtParticipante.Text), Convert.ToInt32(cmbCompetencias.SelectedValue));
                if (evento == null)
                {
                    MessageBox.Show("El atleta no se encuentra inscripto en la competencia seleccionada");
                }
                else if (evento.Eve_Estado == "Anulado")
                {
                    MessageBox.Show("El evento ya se encuentra anulado");
                }
                else
                {
                    var result = MessageBox.Show("¿Está seguro que desea dar de baja la inscripcion?", "Dar de Baja.", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        ClaseBase.TrabajarEvento.baja_evento(evento.Eve_ID);
                        MessageBox.Show("Evento dado de baja correctamente");
                    }
                }
            }
            else if (rBtnDni.Checked)
            {
                if (txtParticipante.Text == "")
                {
                    MessageBox.Show("Debe ingresar un DNI de Atleta");
                    return;
                }
                Evento evento = ClaseBase.TrabajarEvento.buscarEventoPorAtletaDniYCompetencia(txtParticipante.Text, Convert.ToInt32(cmbCompetencias.SelectedValue));
                if (evento == null)
                {
                    MessageBox.Show("El atleta no se encuentra inscripto en la competencia seleccionada");
                }
                else if (evento.Eve_Estado == "Anulado")
                {
                    MessageBox.Show("El evento ya se encuentra anulado");
                }
                else
                {
                    var result = MessageBox.Show("¿Está seguro que desea dar de baja la inscripcion?", "Dar de Baja.", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        ClaseBase.TrabajarEvento.baja_evento(evento.Eve_ID);
                        MessageBox.Show("Evento dado de baja correctamente");
                    }
                }
                    
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de búsqueda");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            principalReferencia.Show();
        }
    }
}
