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
    public partial class Participantes : Form
    {
        private Form prinicpalReferencia;
        public Participantes(Form referenciaSistema)
        {
            prinicpalReferencia = referenciaSistema;
            InitializeComponent();
            dataGridView1.Columns.Add("DNI", "DNI");
            dataGridView1.Columns.Add("Apellido", "Apellido");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Nacionalidad", "Nacionalidad");
            dataGridView1.Columns.Add("Genero", "Genero");


            DatosGlobales.atletas.ForEach(
                atleta => dataGridView1.Rows.Add(atleta.Atl_DNI, atleta.Atl_Apellido, atleta.Atl_Nombre, atleta.Atl_Nacionalidad, atleta.Atl_Genero)
                );
            dataGridView1.Rows.Add();
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            prinicpalReferencia.Show();

        }

        private void btnAltaParticipantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form altaParticipantes = new AltaParticipantes(this);
            altaParticipantes.Show();
        }

       
    }
}
