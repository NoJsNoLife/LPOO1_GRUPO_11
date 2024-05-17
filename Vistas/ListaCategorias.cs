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
    public partial class ListaCategorias : Form
    {
        private Form sistemaReferencia;
        public ListaCategorias(Form sistemaReferencia)
        {
            InitializeComponent();
            this.sistemaReferencia = sistemaReferencia;
            dgwCategorias.Columns.Add("Nombre", "Nombre");
            dgwCategorias.Columns.Add("Descripción", "Descripción");


            DatosGlobales.categorias.ForEach(
                categoria => dgwCategorias.Rows.Add(categoria.Cat_Nombre, categoria.Cat_Descripcion));
            dgwCategorias.Rows.Add();

        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            sistemaReferencia.Show();
        }

        private void btnAltaCategorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form altaCategoria = new AltaCategoria(this);
            altaCategoria.Show();
        }

        private void lblCategorias_Click(object sender, EventArgs e)
        {

        }
    }
}
