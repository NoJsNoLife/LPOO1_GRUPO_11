﻿using System;
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
    public partial class Sistema : Form
    {
        private Form prinicpalReferencia;
        public Sistema(Form principal)
        {
            InitializeComponent();
            prinicpalReferencia = principal;
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            prinicpalReferencia.Show();
        }

        private void btnListaCategorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listaCategorias = new ListaCategorias(this);
            listaCategorias.Show();
        }

        private void btnListaDisciplinas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listaDisciplinas = new ListaDisciplinas(this);
            listaDisciplinas.Show();
        }

        private void Sistema_Load(object sender, EventArgs e)
        {

        }
    }
}
