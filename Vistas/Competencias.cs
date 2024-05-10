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
    public partial class Competencias : Form
    {
        private Form principalReferencia;
        public Competencias(Form principal)
        {
            InitializeComponent();
            principalReferencia = principal;
        }

        private void btnVolverSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            principalReferencia.Show();
        }
    }
}
