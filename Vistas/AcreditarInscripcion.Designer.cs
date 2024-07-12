namespace Vistas
{
    partial class AcreditarInscripcion
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
            btnCancelar = new Button();
            btnAcreditar = new Button();
            btnVolverSistema = new Button();
            cmbCompetencias = new ComboBox();
            lblCompetencia = new Label();
            txtParticipante = new TextBox();
            rBtnDni = new RadioButton();
            rBtnId = new RadioButton();
            lblTitulo = new Label();
            lblParticipante = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.Location = new Point(149, 255);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 41);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAcreditar
            // 
            btnAcreditar.Font = new Font("Segoe UI", 9F);
            btnAcreditar.Location = new Point(264, 255);
            btnAcreditar.Name = "btnAcreditar";
            btnAcreditar.Size = new Size(99, 41);
            btnAcreditar.TabIndex = 19;
            btnAcreditar.Text = "Acreditar";
            btnAcreditar.UseVisualStyleBackColor = true;
            btnAcreditar.Click += btnAcreditar_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(437, 29);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 18;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // cmbCompetencias
            // 
            cmbCompetencias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCompetencias.FormattingEnabled = true;
            cmbCompetencias.Location = new Point(34, 213);
            cmbCompetencias.Name = "cmbCompetencias";
            cmbCompetencias.Size = new Size(451, 23);
            cmbCompetencias.TabIndex = 17;
            // 
            // lblCompetencia
            // 
            lblCompetencia.AutoSize = true;
            lblCompetencia.Location = new Point(34, 180);
            lblCompetencia.Name = "lblCompetencia";
            lblCompetencia.Size = new Size(147, 15);
            lblCompetencia.TabIndex = 16;
            lblCompetencia.Text = "Seleccione la competencia";
            // 
            // txtParticipante
            // 
            txtParticipante.Location = new Point(33, 139);
            txtParticipante.Name = "txtParticipante";
            txtParticipante.Size = new Size(452, 23);
            txtParticipante.TabIndex = 15;
            // 
            // rBtnDni
            // 
            rBtnDni.AutoSize = true;
            rBtnDni.Location = new Point(115, 103);
            rBtnDni.Name = "rBtnDni";
            rBtnDni.Size = new Size(66, 19);
            rBtnDni.TabIndex = 14;
            rBtnDni.TabStop = true;
            rBtnDni.Text = "Por DNI";
            rBtnDni.UseVisualStyleBackColor = true;
            rBtnDni.CheckedChanged += rBtnDni_CheckedChanged;
            // 
            // rBtnId
            // 
            rBtnId.AutoSize = true;
            rBtnId.Location = new Point(33, 103);
            rBtnId.Name = "rBtnId";
            rBtnId.Size = new Size(57, 19);
            rBtnId.TabIndex = 13;
            rBtnId.TabStop = true;
            rBtnId.Text = "Por ID";
            rBtnId.UseVisualStyleBackColor = true;
            rBtnId.CheckedChanged += rBtnId_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.Location = new Point(24, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(395, 32);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Acreditar inscripcion de Participante";
            // 
            // lblParticipante
            // 
            lblParticipante.AutoSize = true;
            lblParticipante.Location = new Point(32, 85);
            lblParticipante.Name = "lblParticipante";
            lblParticipante.Size = new Size(331, 15);
            lblParticipante.TabIndex = 11;
            lblParticipante.Text = "Seleccione el atributo por el que quiere buscar el participante.";
            // 
            // AcreditarInscripcion
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(521, 308);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnAcreditar);
            Controls.Add(btnVolverSistema);
            Controls.Add(cmbCompetencias);
            Controls.Add(lblCompetencia);
            Controls.Add(txtParticipante);
            Controls.Add(rBtnDni);
            Controls.Add(rBtnId);
            Controls.Add(lblTitulo);
            Controls.Add(lblParticipante);
            MinimumSize = new Size(389, 324);
            Name = "AcreditarInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AcreditarInscripcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAcreditar;
        private Button btnVolverSistema;
        private ComboBox cmbCompetencias;
        private Label lblCompetencia;
        private TextBox txtParticipante;
        private RadioButton rBtnDni;
        private RadioButton rBtnId;
        private Label lblTitulo;
        private Label lblParticipante;
    }
}