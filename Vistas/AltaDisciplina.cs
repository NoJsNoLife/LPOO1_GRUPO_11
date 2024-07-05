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
            this.Close();
            sistemaReferencia.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea agregar la Disciplina?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            
            if (TrabajarDisciplina.existeByNombre(txtNombre.Text))
            {
                MessageBox.Show("La disciplina ya existe");
                return;
            }
            else
            {
                TrabajarDisciplina.alta_disciplina(txtNombre.Text, txtDescripcion.Text);
                MessageBox.Show("Disciplina creada con éxito");
                this.Close();
                sistemaReferencia.Show();
            }

        }
    }
}
