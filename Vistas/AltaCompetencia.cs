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
    public partial class AltaCompetencia : Form
    {
        private Form referencia;
        private int competenciaId = 0;
        public AltaCompetencia(Form referencia, int competenciaId)
        {
            InitializeComponent();
            this.referencia = referencia;
            cmbEstado.SelectedIndex = 0;
            var categorias = TrabajarCategoria.ListarCategorias();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";

            var disciplinas = TrabajarDisciplina.listar_disciplinas();
            cmbDisciplina.DataSource = disciplinas;
            cmbDisciplina.DisplayMember = "Nombre";
            cmbDisciplina.ValueMember = "Id";

            if (competenciaId != 0)
            {
                Competencia competencia = TrabajarCompetencia.buscarCompetenciaPorId(competenciaId);
                this.competenciaId = competencia.Com_ID;
                txtNombre.Text = competencia.Com_Nombre;
                txtDescripcion.Text = competencia.Com_Descripcion;
                txtOrganizador.Text = competencia.Com_Organizador;
                txtUbicacion.Text = competencia.Com_Ubicacion;
                txtSponsor.Text = competencia.Com_Sponsors;
                cmbCategoria.SelectedValue = competencia.Cat_ID;
                cmbDisciplina.SelectedValue = competencia.Dis_ID;
                cmbEstado.Text = competencia.Com_Estado;
                dtpInicio.Value = competencia.Com_FechaInicio;
                dtpFin.Value = competencia.Com_FechaFin;
                lblTitulo.Text = "Modificar Competencia";
                btnAgregar.Visible = false;
                btnModificar.Visible = true;
            }

        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            referencia.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dtpInicio.Value.Date > dtpFin.Value.Date)
            {
                MessageBox.Show("La fecha de inicio debe ser menor a la de fin.");
                return;
            }
            else
            {
                MessageBox.Show("¿Desea agregar esta competencia?", "Agregar Competencia", MessageBoxButtons.YesNo);
                TrabajarCompetencia.InsertarCompetencia(txtNombre.Text, txtDescripcion.Text, dtpInicio.Value, dtpFin.Value, cmbEstado.Text, txtOrganizador.Text, txtUbicacion.Text, txtSponsor.Text, (int)cmbCategoria.SelectedValue, (int)cmbDisciplina.SelectedValue);
                MessageBox.Show("Competencia agregada con éxito.", "Exito", MessageBoxButtons.OK);
                limpiarCampos();
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtOrganizador.Text = "";
            txtUbicacion.Text = "";
            txtSponsor.Text = "";
            cmbCategoria.SelectedIndex = 0;
            cmbDisciplina.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Desea modificar esta competencia?", "Modificar Competencia", MessageBoxButtons.YesNo);
            try
            {   
                
                if (dtpInicio.Value.Date > dtpFin.Value.Date)
                {
                    MessageBox.Show("La fecha de inicio debe ser menor a la de fin.");
                    return;
                }
                else
                {
                    TrabajarCompetencia.ActualizarCompetencia(competenciaId, txtNombre.Text, txtDescripcion.Text, dtpInicio.Value, dtpFin.Value, cmbEstado.Text, txtOrganizador.Text, txtUbicacion.Text, txtSponsor.Text, (int)cmbCategoria.SelectedValue, (int)cmbDisciplina.SelectedValue);
                }
                
            }catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la competencia: " + ex.Message);
            }
            limpiarCampos();
            MessageBox.Show("Competencia modificada con éxito.", "Exito", MessageBoxButtons.OK);
            
        }
    }
}
