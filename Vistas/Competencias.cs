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
    public partial class Competencias : Form
    {
        private int competenciaId = 0;
        private Form principalReferencia;
        public Competencias(Form principal)
        {
            InitializeComponent();
            principalReferencia = principal;
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            principalReferencia.Show();
        }

        private void Competencias_Load(object sender, EventArgs e)
        {
            cargarCompetencias();
        }

        private void cargarCompetencias()
        {
            dgwCompetencias.DataSource = null;
            dgwCompetencias.DataSource = TrabajarCompetencia.listarCompetencias();
            dgwCompetencias.Columns["ID"].Visible = false;
            dgwCompetencias.Columns["Cat_ID"].Visible = false;
            dgwCompetencias.Columns["Dis_ID"].Visible = false;
            dgwCompetencias.Columns["Ubicacion"].Visible = false;
            dgwCompetencias.Columns["Sponsor"].Visible = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaCompetencia altaCompetencia = new AltaCompetencia(this, 0);
            altaCompetencia.Show();
        }

        private void dgwCompetencias_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwCompetencias.CurrentRow != null && !Convert.IsDBNull(dgwCompetencias.CurrentRow.Cells["ID"].Value))
            {
                competenciaId = Convert.ToInt32(dgwCompetencias.CurrentRow.Cells["ID"].Value);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Está seguro que desea borrar la competencia?", "Eliminar Competencia", MessageBoxButtons.YesNoCancel);
            TrabajarCompetencia.EliminarCompetencia(competenciaId);
            cargarCompetencias();
            MessageBox.Show("Competencia eliminada con éxito");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaCompetencia altaCompetencia = new AltaCompetencia(this, competenciaId);
            altaCompetencia.Show();
        }

        

        private void Competencias_VisibleChanged(object sender, EventArgs e)
        {
            cargarCompetencias();
        }
    }
}
