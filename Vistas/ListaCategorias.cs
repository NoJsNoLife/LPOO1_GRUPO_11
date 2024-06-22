using ClaseBase;
using Microsoft.VisualBasic;
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
    public partial class ListaCategorias : Form
    {
        private Form sistemaReferencia;
        private int categoriaId;
        public ListaCategorias(Form sistemaReferencia)
        {
            InitializeComponent();
            this.sistemaReferencia = sistemaReferencia;
            cargarCategorias();

        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            sistemaReferencia.Show();
        }

        private void btnAltaCategorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form altaCategoria = new AltaCategoria(this);
            altaCategoria.Show();
        }



        private void ListaCategorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void cargarCategorias()
        {
            dgwCategorias.DataSource = null;
            dgwCategorias.DataSource = ClaseBase.TrabajarCategoria.ListarCategorias();
            dgwCategorias.Columns["ID"].Visible = false;

        }

        private void dgwCategorias_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwCategorias.CurrentRow != null && !Convert.IsDBNull(dgwCategorias.CurrentRow.Cells["ID"].Value))
            {
                categoriaId = Convert.ToInt32(dgwCategorias.CurrentRow.Cells["ID"].Value);
                txtNombre.Text = dgwCategorias.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgwCategorias.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (categoriaId == 0)
            {
                MessageBox.Show("Seleccione una categoría para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("¿Desea modificar esta categoría?", "Modificar Categoría", MessageBoxButtons.YesNo);
                TrabajarCategoria.EditarCategoria(categoriaId, txtNombre.Text, txtDescripcion.Text);
                cargarCategorias();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (categoriaId == 0)
            {
                MessageBox.Show("Seleccione una categoría para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("¿Desea eliminar esta categoría?", "Eliminar Categoría", MessageBoxButtons.YesNo);
                TrabajarCategoria.BajaCategoria(categoriaId);
                cargarCategorias();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (categoriaId != 0)
            {

                MessageBox.Show("Esta categoria ya existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("¿Desea agregar esta categoría?", "Agregar Categoría", MessageBoxButtons.YesNo);
                TrabajarCategoria.AltaCategoria(txtNombre.Text, txtDescripcion.Text);
                cargarCategorias();
            }
        }

        private void nuevoBtn_Click(object sender, EventArgs e)
        {
            categoriaId = 0;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }
    }
}
