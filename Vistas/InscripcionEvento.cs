using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClaseBase;
using Microsoft.VisualBasic;

namespace Vistas
{
    public partial class InscripcionEventos : Form
    {
        private Form referencia;
        private Competencia competencia;
        private Atleta atleta;
        public InscripcionEventos(Form referencia)
        {
            InitializeComponent();
            this.referencia = referencia;
        }

        private void load_participantes()
        {
            dgwParticipantes.DataSource = TrabajarAtletas.listar_atletas();
            dgwParticipantes.Columns["ID"].Visible = false;
        }

        private void load_competencias()
        {
            dgwCompetencias.DataSource = TrabajarCompetencia.listarCompetencias();
            dgwCompetencias.Columns["ID"].Visible = false;
            dgwCompetencias.Columns["Descripcion"].Visible = false;
            dgwCompetencias.Columns["Organizador"].Visible = false;
            dgwCompetencias.Columns["Ubicacion"].Visible = false;
            dgwCompetencias.Columns["Sponsor"].Visible = false;
            dgwCompetencias.Columns["Cat_ID"].Visible = false;
            dgwCompetencias.Columns["Categoria"].Visible = false;
            dgwCompetencias.Columns["Dis_ID"].Visible = false;
            dgwCompetencias.Columns["Disciplina"].Visible = false;
        }

        private void txtParticipante_TextChanged(object sender, EventArgs e)
        {
            if (txtParticipante.Text != "")
            {

                dgwParticipantes.DataSource = TrabajarAtletas.buscar_atletas(txtParticipante.Text);
            }
            else
            {
                load_participantes();
            }
        }

        private void txtCompetencia_TextChanged(object sender, EventArgs e)
        {
            if (txtCompetencia.Text != "")
            {
                dgwCompetencias.DataSource = TrabajarCompetencia.buscar_competencias(txtCompetencia.Text);
            }
            else
            {
                load_competencias();
            }
        }

        private void dgwParticipantes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwParticipantes.CurrentRow != null && !Convert.IsDBNull(dgwParticipantes.CurrentRow.Cells["ID"].Value))
            {
                this.atleta = TrabajarAtletas.buscar_atleta(Convert.ToString(dgwParticipantes.CurrentRow.Cells["DNI"].Value));
            }
        }

        private void dgwCompetencias_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwCompetencias.CurrentRow != null && !Convert.IsDBNull(dgwCompetencias.CurrentRow.Cells["ID"].Value))
            {
                this.competencia = TrabajarCompetencia.buscarCompetenciaPorId(Convert.ToInt32(dgwCompetencias.CurrentRow.Cells["ID"].Value));
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.atleta == null || this.competencia == null)
            {
                MessageBox.Show("Debe seleccionar un atleta y una competencia");
                return;
            }

            if (TrabajarEvento.existe_duplicado(this.atleta.Atl_ID, this.competencia.Com_ID))
            {
                MessageBox.Show("El atleta ya se encuentra inscripto en la competencia");
                return;
            }

            if (this.competencia.Com_Estado == "Cancelado")
            {
                MessageBox.Show("La competencia no se encuentra disponible");
                return;
            }

            if (DateTime.Now > this.competencia.Com_FechaInicio)
            {
                MessageBox.Show("La competencia ya ha comenzado y no acepta mas inscripciones");
                return;
            }

            DialogResult result = MessageBox.Show("¿Desea inscribir al atleta en la competencia?", "Confirmar inscripcion", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            TrabajarEvento.insertar(this.atleta.Atl_ID, this.competencia.Com_ID, "Inscripto", this.dtpHoraInicio.Value.ToString(), this.dtpHoraFin.Value.ToString());
            MessageBox.Show("Inscripcion realizada con exito");
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            this.referencia.Show();
        }

        private void InscripcionEventos_Load(object sender, EventArgs e)
        {
            load_competencias();
            load_participantes();
        }
    }
}
