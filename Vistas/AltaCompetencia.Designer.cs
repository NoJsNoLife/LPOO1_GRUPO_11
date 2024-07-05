namespace Vistas
{
    partial class AltaCompetencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            dtpInicio = new DateTimePicker();
            lblInicio = new Label();
            lblFin = new Label();
            dtpFin = new DateTimePicker();
            btnVolverSistema = new Button();
            txtOrganizador = new TextBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            lblOrganizador = new Label();
            lblUbicacion = new Label();
            txtUbicacion = new TextBox();
            lblSponsor = new Label();
            txtSponsor = new TextBox();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            cmbDisciplina = new ComboBox();
            label1 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(265, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Crear una Competencia";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(210, 51);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(210, 69);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(283, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // dtpInicio
            // 
            dtpInicio.CustomFormat = "dd/MM/yyyy";
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(499, 69);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(86, 23);
            dtpInicio.TabIndex = 5;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(499, 51);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(86, 15);
            lblInicio.TabIndex = 6;
            lblInicio.Text = "Fecha de Inicio";
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Location = new Point(591, 51);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(73, 15);
            lblFin.TabIndex = 8;
            lblFin.Text = "Fecha de Fin";
            // 
            // dtpFin
            // 
            dtpFin.CustomFormat = "dd/MM/yyyy";
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(591, 69);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(86, 23);
            dtpFin.TabIndex = 7;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(681, 6);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 38;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // txtOrganizador
            // 
            txtOrganizador.Location = new Point(139, 127);
            txtOrganizador.Name = "txtOrganizador";
            txtOrganizador.Size = new Size(188, 23);
            txtOrganizador.TabIndex = 40;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(12, 109);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 39;
            lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Programado", "Postergado", "Reprogramado", "Cancelado" });
            cmbEstado.Location = new Point(12, 127);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 41;
            // 
            // lblOrganizador
            // 
            lblOrganizador.AutoSize = true;
            lblOrganizador.Location = new Point(139, 109);
            lblOrganizador.Name = "lblOrganizador";
            lblOrganizador.Size = new Size(72, 15);
            lblOrganizador.TabIndex = 42;
            lblOrganizador.Text = "Organizador";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(333, 109);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(60, 15);
            lblUbicacion.TabIndex = 44;
            lblUbicacion.Text = "Ubicacion";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(333, 127);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(188, 23);
            txtUbicacion.TabIndex = 43;
            // 
            // lblSponsor
            // 
            lblSponsor.AutoSize = true;
            lblSponsor.Location = new Point(12, 174);
            lblSponsor.Name = "lblSponsor";
            lblSponsor.Size = new Size(50, 15);
            lblSponsor.TabIndex = 46;
            lblSponsor.Text = "Sponsor";
            // 
            // txtSponsor
            // 
            txtSponsor.Location = new Point(12, 192);
            txtSponsor.Name = "txtSponsor";
            txtSponsor.Size = new Size(188, 23);
            txtSponsor.TabIndex = 45;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Programado", "Postergado", "Reprogramado", "Cancelado" });
            cmbCategoria.Location = new Point(210, 192);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 48;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(210, 174);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 47;
            lblCategoria.Text = "Categoria";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Items.AddRange(new object[] { "Programado", "Postergado", "Reprogramado", "Cancelado" });
            cmbDisciplina.Location = new Point(337, 192);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(121, 23);
            cmbDisciplina.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 174);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 49;
            label1.Text = "Disciplina";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.Font = new Font("Segoe UI", 18F);
            btnAgregar.ForeColor = SystemColors.ButtonFace;
            btnAgregar.Location = new Point(296, 252);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 51);
            btnAgregar.TabIndex = 51;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DodgerBlue;
            btnModificar.Font = new Font("Segoe UI", 18F);
            btnModificar.ForeColor = SystemColors.ButtonFace;
            btnModificar.Location = new Point(296, 252);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(137, 51);
            btnModificar.TabIndex = 52;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Visible = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // AltaCompetencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 315);
            ControlBox = false;
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(cmbDisciplina);
            Controls.Add(label1);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(lblSponsor);
            Controls.Add(txtSponsor);
            Controls.Add(lblUbicacion);
            Controls.Add(txtUbicacion);
            Controls.Add(lblOrganizador);
            Controls.Add(cmbEstado);
            Controls.Add(txtOrganizador);
            Controls.Add(lblEstado);
            Controls.Add(btnVolverSistema);
            Controls.Add(lblFin);
            Controls.Add(dtpFin);
            Controls.Add(lblInicio);
            Controls.Add(dtpInicio);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            MaximumSize = new Size(753, 354);
            MinimumSize = new Size(753, 354);
            Name = "AltaCompetencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaCompetencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private DateTimePicker dtpInicio;
        private Label lblInicio;
        private Label lblFin;
        private DateTimePicker dtpFin;
        private Button btnVolverSistema;
        private TextBox txtOrganizador;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Label lblOrganizador;
        private Label lblUbicacion;
        private TextBox txtUbicacion;
        private Label lblSponsor;
        private TextBox txtSponsor;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private ComboBox cmbDisciplina;
        private Label label1;
        private Button btnAgregar;
        private Button btnModificar;
    }
}