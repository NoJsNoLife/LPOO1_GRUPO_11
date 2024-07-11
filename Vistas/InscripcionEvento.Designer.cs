namespace Vistas
{
    partial class InscripcionEventos
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
            label1 = new Label();
            txtParticipante = new TextBox();
            txtCompetencia = new TextBox();
            label2 = new Label();
            dgwParticipantes = new DataGridView();
            dgwCompetencias = new DataGridView();
            btnAceptar = new Button();
            btnVolverSistema = new Button();
            dtpHoraFin = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwParticipantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwCompetencias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione participante";
            // 
            // txtParticipante
            // 
            txtParticipante.Location = new Point(12, 89);
            txtParticipante.Name = "txtParticipante";
            txtParticipante.PlaceholderText = "Buscar por ID, DNI o Apellido";
            txtParticipante.Size = new Size(349, 23);
            txtParticipante.TabIndex = 1;
            txtParticipante.TextChanged += txtParticipante_TextChanged;
            // 
            // txtCompetencia
            // 
            txtCompetencia.Location = new Point(439, 89);
            txtCompetencia.Name = "txtCompetencia";
            txtCompetencia.PlaceholderText = "Buscar por Nombre o ID";
            txtCompetencia.Size = new Size(349, 23);
            txtCompetencia.TabIndex = 2;
            txtCompetencia.TextChanged += txtCompetencia_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 71);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 3;
            label2.Text = "Seleccione competencia";
            // 
            // dgwParticipantes
            // 
            dgwParticipantes.CausesValidation = false;
            dgwParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwParticipantes.Location = new Point(12, 118);
            dgwParticipantes.Name = "dgwParticipantes";
            dgwParticipantes.Size = new Size(349, 213);
            dgwParticipantes.TabIndex = 4;
            dgwParticipantes.CurrentCellChanged += dgwParticipantes_CurrentCellChanged;
            // 
            // dgwCompetencias
            // 
            dgwCompetencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCompetencias.Location = new Point(439, 118);
            dgwCompetencias.Name = "dgwCompetencias";
            dgwCompetencias.Size = new Size(349, 213);
            dgwCompetencias.TabIndex = 5;
            dgwCompetencias.CurrentCellChanged += dgwCompetencias_CurrentCellChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Green;
            btnAceptar.ForeColor = SystemColors.ControlLightLight;
            btnAceptar.Location = new Point(336, 404);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(126, 34);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(740, 10);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 37;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.CustomFormat = "HH/mm/ss";
            dtpHoraFin.Format = DateTimePickerFormat.Time;
            dtpHoraFin.Location = new Point(439, 363);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.Size = new Size(349, 23);
            dtpHoraFin.TabIndex = 38;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CustomFormat = "HH:mm:ss";
            dtpHoraInicio.Format = DateTimePickerFormat.Time;
            dtpHoraInicio.Location = new Point(12, 363);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.Size = new Size(349, 23);
            dtpHoraInicio.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 345);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 40;
            label3.Text = "Hora Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 345);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 41;
            label4.Text = "Hora Fin";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.Location = new Point(12, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(255, 32);
            lblTitulo.TabIndex = 42;
            lblTitulo.Text = "Registro de inscripción";
            // 
            // InscripcionEventos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblTitulo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpHoraInicio);
            Controls.Add(dtpHoraFin);
            Controls.Add(btnVolverSistema);
            Controls.Add(btnAceptar);
            Controls.Add(dgwCompetencias);
            Controls.Add(dgwParticipantes);
            Controls.Add(label2);
            Controls.Add(txtCompetencia);
            Controls.Add(txtParticipante);
            Controls.Add(label1);
            Name = "InscripcionEventos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripción a evento";
            Load += InscripcionEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dgwParticipantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwCompetencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtParticipante;
        private TextBox txtCompetencia;
        private Label label2;
        private DataGridView dgwParticipantes;
        private DataGridView dgwCompetencias;
        private Button btnAceptar;
        private Button btnVolverSistema;
        private DateTimePicker dtpHoraFin;
        private DateTimePicker dtpHoraInicio;
        private Label label3;
        private Label label4;
        private Label lblTitulo;
    }
}