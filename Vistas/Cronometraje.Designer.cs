namespace Vistas
{
    partial class Cronometraje
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
            cmbCompetencias = new ComboBox();
            label1 = new Label();
            dgwParticipantes = new DataGridView();
            lblParticipantes = new Label();
            btnVolverSistema = new Button();
            btnBuscar = new Button();
            dtpLargada = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpLlegada = new DateTimePicker();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwParticipantes).BeginInit();
            SuspendLayout();
            // 
            // cmbCompetencias
            // 
            cmbCompetencias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCompetencias.FormattingEnabled = true;
            cmbCompetencias.Location = new Point(26, 60);
            cmbCompetencias.Name = "cmbCompetencias";
            cmbCompetencias.Size = new Size(203, 23);
            cmbCompetencias.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione una Competencia.";
            // 
            // dgwParticipantes
            // 
            dgwParticipantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwParticipantes.Location = new Point(26, 113);
            dgwParticipantes.Name = "dgwParticipantes";
            dgwParticipantes.ReadOnly = true;
            dgwParticipantes.Size = new Size(474, 250);
            dgwParticipantes.TabIndex = 2;
            dgwParticipantes.SelectionChanged += dgwParticipantes_SelectionChanged;
            // 
            // lblParticipantes
            // 
            lblParticipantes.AutoSize = true;
            lblParticipantes.Font = new Font("Segoe UI", 11F);
            lblParticipantes.Location = new Point(26, 90);
            lblParticipantes.Name = "lblParticipantes";
            lblParticipantes.Size = new Size(263, 20);
            lblParticipantes.TabIndex = 3;
            lblParticipantes.Text = "Seleccione un Participante Acreditado.";
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(740, 9);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 7;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(235, 59);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dtpLargada
            // 
            dtpLargada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpLargada.Format = DateTimePickerFormat.Custom;
            dtpLargada.Location = new Point(506, 176);
            dtpLargada.Name = "dtpLargada";
            dtpLargada.Size = new Size(238, 23);
            dtpLargada.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(503, 113);
            label2.Name = "label2";
            label2.Size = new Size(203, 25);
            label2.TabIndex = 11;
            label2.Text = "Seleccione los tiempos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(505, 153);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 12;
            label3.Text = "Horario de largada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(506, 219);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 13;
            label4.Text = "Horario de llegada";
            // 
            // dtpLlegada
            // 
            dtpLlegada.CalendarFont = new Font("Segoe UI", 11F);
            dtpLlegada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpLlegada.Format = DateTimePickerFormat.Custom;
            dtpLlegada.Location = new Point(506, 242);
            dtpLlegada.Name = "dtpLlegada";
            dtpLlegada.Size = new Size(238, 23);
            dtpLlegada.TabIndex = 14;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(631, 312);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(113, 51);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(512, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 51);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnVolverSistema_Click;
            // 
            // Cronometraje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 382);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(dtpLlegada);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpLargada);
            Controls.Add(btnBuscar);
            Controls.Add(btnVolverSistema);
            Controls.Add(lblParticipantes);
            Controls.Add(dgwParticipantes);
            Controls.Add(label1);
            Controls.Add(cmbCompetencias);
            Name = "Cronometraje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cronometraje";
            ((System.ComponentModel.ISupportInitialize)dgwParticipantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCompetencias;
        private Label label1;
        private DataGridView dgwParticipantes;
        private Label lblParticipantes;
        private Button btnVolverSistema;
        private Button btnBuscar;
        private DateTimePicker dtpLargada;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpLlegada;
        private Button btnRegistrar;
        private Button btnCancelar;
    }
}