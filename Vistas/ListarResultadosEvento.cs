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
    public partial class ListarResultadosEvento : Form
    {

        private Form referencia;
        private int competenciaId = 0;

        public ListarResultadosEvento(Form referencia)
        {
            InitializeComponent();
            this.referencia = referencia;
        }

        private void Resultados_load(object sender, EventArgs e)
        {
            load_competencias();
        }

        private void load_competencias()
        {
            dgwCompetencias.DataSource = ClaseBase.TrabajarCompetencia.listarCompetenciasConEventos();
            dgwCompetencias.RowHeadersVisible = false;
        }

        private void dgwCompetencias_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwCompetencias.CurrentRow != null && !Convert.IsDBNull(dgwCompetencias.CurrentRow.Cells["ID"].Value))
            {
                competenciaId = Convert.ToInt32(dgwCompetencias.CurrentRow.Cells["ID"].Value);
                dgw_Participantes.DataSource = ClaseBase.TrabajarEvento.listarAtletasPorCompetencia(competenciaId);
                dgw_Participantes.RowHeadersVisible = false;
                lblParticiparon.Text = TrabajarEvento.contarTotal(competenciaId).ToString();
                lblAbandonos.Text = TrabajarEvento.contarAbandonos(competenciaId).ToString();
                lblDescalificados.Text = TrabajarEvento.contarDescalificados(competenciaId).ToString();
            }
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            this.referencia.Show();
        }
    }

}
