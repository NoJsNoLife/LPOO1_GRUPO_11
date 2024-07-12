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
    public partial class Cronometraje : Form
    {
        private Form principalReferencia;
        private int competenciaId = 0;
        private int atletaId = 0;

        public Cronometraje(Form referencia)
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


        public void cargarAtletas()
        {
            competenciaId = Convert.ToInt32(cmbCompetencias.SelectedValue);
            // Suponiendo que dgwAtletas es tu DataGridView y buscarAtletasPorCompetencia ya ha sido llamado
            DataTable dataTable = TrabajarEvento.buscarAtletasPorCompetencia(competenciaId);
            dgwParticipantes.DataSource = dataTable;

            // Personalizar los encabezados de las columnas
            dgwParticipantes.Columns["Atl_ID"].Visible = false;
            if (dgwParticipantes.Columns["Atl_DNI"] != null)
                dgwParticipantes.Columns["Atl_DNI"].HeaderText = "DNI";
            if (dgwParticipantes.Columns["Atl_Apellido"] != null)
                dgwParticipantes.Columns["Atl_Apellido"].HeaderText = "Apellido";
            if (dgwParticipantes.Columns["Atl_Nombre"] != null)
                dgwParticipantes.Columns["Atl_Nombre"].HeaderText = "Nombre";
            // Repite para las demás columnas según necesites
            dgwParticipantes.Columns["Atl_Nacionalidad"].Visible = false;
            dgwParticipantes.Columns["Atl_Entrenador"].Visible = false;
            dgwParticipantes.Columns["Atl_Genero"].HeaderText = "Genero";
            dgwParticipantes.Columns["Atl_Altura"].HeaderText = "Altura";
            dgwParticipantes.Columns["Atl_Peso"].HeaderText = "Peso";
            dgwParticipantes.Columns["Atl_FechaNac"].Visible = false;
            dgwParticipantes.Columns["Atl_Direccion"].Visible = false;
            dgwParticipantes.Columns["Atl_email"].Visible = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarAtletas();
            MessageBox.Show("Atletas cargados correctamente");
        }

        private void dgwParticipantes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwParticipantes.CurrentRow != null && !Convert.IsDBNull(dgwParticipantes.CurrentRow.Cells["Atl_ID"].Value))
            {
                atletaId = Convert.ToInt32(dgwParticipantes.CurrentRow.Cells["Atl_ID"].Value);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (atletaId == 0)
            {
                MessageBox.Show("Debe seleccionar un atleta para registrar el tiempo");
                return;
            }

            if (competenciaId == 0)
            {
                MessageBox.Show("Debe seleccionar una competencia para registrar el tiempo");
            }

            DateTime horaInicio = dtpLargada.Value;
            DateTime horaFin = dtpLlegada.Value;
            var respuesta = MessageBox.Show("Esta seguro que desea registrar estos tiempos?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                TrabajarEvento.ActualizarTiemposEvento(atletaId, competenciaId, horaInicio, horaFin);
                MessageBox.Show("Tiempos registrados correctamente");
            }

        }

        private void btnDescalificado_Click(object sender, EventArgs e)
        {
            if (atletaId == 0)
            {
                MessageBox.Show("Debe seleccionar un atleta para descalificar");
                return;
            }
            if (competenciaId == 0)
            {
                MessageBox.Show("Debe seleccionar una competencia para descalificar");
            }
            var respuesta = MessageBox.Show("Esta seguro que desea registrar la descalificacion de este participante?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                TrabajarEvento.actualizarEstadoEvento(atletaId, competenciaId, "Descalificado");
                MessageBox.Show("Estado actualizado correctamente");
            }
        }

        private void btnAbandono_Click(object sender, EventArgs e)
        {
            if (atletaId == 0)
            {
                MessageBox.Show("Debe seleccionar un atleta para actualizar su estado");
                return;
            }
            if (competenciaId == 0)
            {
                MessageBox.Show("Debe seleccionar una competencia para actualizar su estado");
            }
            var respuesta = MessageBox.Show("Esta seguro que desea registrar el abandono de este participante?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                TrabajarEvento.actualizarEstadoEvento(atletaId, competenciaId, "Abandono");
                MessageBox.Show("Estado actualizado correctamente");
            }
        }
    }
}
