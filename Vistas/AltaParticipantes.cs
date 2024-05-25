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
    public partial class AltaParticipantes : Form
    {
        private Form participanteReferencia;
        private Atleta atletaAModificar;
        public AltaParticipantes(Form referenciaSistema, String dni)
        {
            InitializeComponent();
            participanteReferencia = referenciaSistema;
            selectSexo.Text = "No declara";
            selectSexo.DropDownStyle = ComboBoxStyle.DropDownList;

            if (dni != null && dni!="")
            {
                atletaAModificar=TrabajarAtletas.buscar_atleta(dni);
                txtDni.Enabled = false;
                txtDni.Text = atletaAModificar.Atl_DNI;
                txtApellido.Text = atletaAModificar.Atl_Apellido;
                txtNombre.Text = atletaAModificar.Atl_Nombre;
                txtNacionalidad.Text = atletaAModificar.Atl_Nacionalidad;
                txtEntrenador.Text = atletaAModificar.Atl_Entrenador;
                selectSexo.SelectedValue = atletaAModificar.Atl_Genero;
                numericAltura.Value = (decimal)atletaAModificar.Atl_Altura;
                numericPeso.Value = (decimal)atletaAModificar.Atl_Peso;
                dateTimeNacimiento.Value = atletaAModificar.Atl_FechaNac;
                txtDireccion.Text = atletaAModificar.Atl_Dirección;
                txtEmail.Text = atletaAModificar.Atl_email;
                btnModificar.Visible = true;
            }
            else
            {
                btnAgregar.Visible = true;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (TrabajarAtletas.existe_atleta(txtDni.Text))
            {
                MessageBox.Show("Ya existe un atleta con este DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea agregar el atleta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                TrabajarAtletas.alta_atleta(txtDni.Text, txtApellido.Text, txtNombre.Text, txtNacionalidad.Text, txtEntrenador.Text,
                    selectSexo.Text, (double)numericAltura.Value, (double)numericPeso.Value, dateTimeNacimiento.Value, txtDireccion.Text,
                    txtEmail.Text);
                MessageBox.Show("Atleta agregado correctamente", "Atleta Registrado");
            }
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            participanteReferencia.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea modificar el atleta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            TrabajarAtletas.editar_atleta(txtDni.Text, txtApellido.Text, txtNombre.Text, txtNacionalidad.Text, txtEntrenador.Text,
                selectSexo.Text, (double)numericAltura.Value, (double)numericPeso.Value, dateTimeNacimiento.Value, txtDireccion.Text,
                txtEmail.Text);
            MessageBox.Show("Atleta modificado correctamente", "Atleta Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
