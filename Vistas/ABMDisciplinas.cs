using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseBase;
using Microsoft.VisualBasic;

namespace Vistas
{
    public partial class ABMDisciplinas : Form
    {
        private Form referencia;
        private int disciplinaId = 0;
        public ABMDisciplinas(Form referencia)
        {
            InitializeComponent();
            this.referencia = referencia;
        }

        private void AltaDisciplina_Load(object sender, EventArgs e)
        {
            load_disciplinas();
        }

        private void load_disciplinas()
        {
            dgwDisciplinas.DataSource = TrabajarDisciplina.listar_disciplinas();
            dgwDisciplinas.Columns["ID"].Visible = false;
        }

        private void btnAgregarDisciplina_Click(object sender, EventArgs e)
        {
            if (disciplinaId == 0)
            {
                string nombre = txtNombreDis.Text;
                string descripcion = txtDescripcionDis.Text;
                if (TrabajarDisciplina.existeNombreDuplicado(nombre, 0))
                {
                    MessageBox.Show("Esa disciplina ya existe");
                    return;
                }
                else
                {   
                    MessageBox.Show("Desa agregar la disciplina: " + nombre + " con la descripción: " + descripcion + "?", "Agregar disciplina", MessageBoxButtons.OKCancel);
                    TrabajarDisciplina.alta_disciplina(nombre, descripcion);
                    load_disciplinas();
                    MessageBox.Show("Disciplina agregada con éxito");
                }
            }
            else
            {
                MessageBox.Show("No se puede agregar una disciplina existente");
            }
        }

        private void ABMDisciplinas_Load(object sender, EventArgs e)
        {
            load_disciplinas();
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            this.referencia.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (disciplinaId != 0)
            {
                string nuevoNombre = txtNombreDis.Text;
                string nuevaDescripcion = txtDescripcionDis.Text;
                if (TrabajarDisciplina.existeNombreDuplicado(nuevoNombre, disciplinaId))
                {
                    MessageBox.Show("Esa disciplina ya existe");
                    return;
                }
                else
                {
                    TrabajarDisciplina.modificar_disciplina(disciplinaId, nuevoNombre, nuevaDescripcion);
                    load_disciplinas();
                    MessageBox.Show("Disciplina modificada con éxito");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una disciplina para modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (disciplinaId != 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar la disciplina?", "Eliminar disciplina", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TrabajarDisciplina.baja_disciplina(disciplinaId);
                    load_disciplinas();
                    MessageBox.Show("Disciplina eliminada con éxito");
                    limpiarVariables();
                }
            }
        }

        private void limpiarVariables()
        {
            txtDescripcionDis.Text = "";
            txtNombreDis.Text = "";
            disciplinaId = 0;
        }

        private void dgwDisciplinas_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwDisciplinas.CurrentRow != null && !Convert.IsDBNull(dgwDisciplinas.CurrentRow.Cells["ID"].Value))
            {
                disciplinaId = Convert.ToInt32(dgwDisciplinas.CurrentRow.Cells["ID"].Value);
                txtNombreDis.Text = dgwDisciplinas.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcionDis.Text = dgwDisciplinas.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
        }

        private void nuevoBtn_Click(object sender, EventArgs e)
        {
            limpiarVariables();
        }
    }
}
