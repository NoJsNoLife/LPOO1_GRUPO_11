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
    public partial class ListaDisciplinas : Form
    {
        private Form sistemaReferencia;
        public ListaDisciplinas(Form sistemaReferencia)
        {
            InitializeComponent();
            this.sistemaReferencia = sistemaReferencia;
            dgwDisciplinas.Columns.Add("Nombre", "Nombre");
            dgwDisciplinas.Columns.Add("Descripción", "Descripción");


            DatosGlobales.disciplinas.ForEach(
                disciplina => dgwDisciplinas.Rows.Add(disciplina.Dis_Nombre, disciplina.Dis_Descripcion));
            dgwDisciplinas.Rows.Add();
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            sistemaReferencia.Show();
        }

        private void btnAltaDisciplinas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form altaDisciplina = new AltaDisciplina(this);
            altaDisciplina.Show();
        }
    }
}
