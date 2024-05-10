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
    public partial class AltaDisciplina : Form
    {
        private Form sistemaReferencia;
        public AltaDisciplina(Form sistemaReferencia)
        {
            InitializeComponent();
            this.sistemaReferencia = sistemaReferencia;
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            sistemaReferencia.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea agregar la Disciplina?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            Disciplina disciplina = new Disciplina(DatosGlobales.disciplinas.Count(), txtNombre.Text, txtDescripcion.Text);
            DatosGlobales.disciplinas.Add(disciplina);
        }
    }
}
