namespace Vistas
{
    partial class BajaEvento
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
            lblParticipante = new Label();
            lblTitulo = new Label();
            rBtnId = new RadioButton();
            rBtnDni = new RadioButton();
            txtParticipante = new TextBox();
            lblCompetencia = new Label();
            btnVolverSistema = new Button();
            btnDarBaja = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cmbCompetencias
            // 
            cmbCompetencias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCompetencias.FormattingEnabled = true;
            cmbCompetencias.Location = new Point(22, 209);
            cmbCompetencias.Name = "cmbCompetencias";
            cmbCompetencias.Size = new Size(369, 23);
            cmbCompetencias.TabIndex = 7;
            // 
            // lblParticipante
            // 
            lblParticipante.AutoSize = true;
            lblParticipante.Location = new Point(20, 81);
            lblParticipante.Name = "lblParticipante";
            lblParticipante.Size = new Size(331, 15);
            lblParticipante.TabIndex = 0;
            lblParticipante.Text = "Seleccione el atributo por el que quiere buscar el participante.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.Location = new Point(12, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(307, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Dar de baja un Participante.";
            // 
            // rBtnId
            // 
            rBtnId.AutoSize = true;
            rBtnId.Location = new Point(21, 99);
            rBtnId.Name = "rBtnId";
            rBtnId.Size = new Size(57, 19);
            rBtnId.TabIndex = 3;
            rBtnId.TabStop = true;
            rBtnId.Text = "Por ID";
            rBtnId.UseVisualStyleBackColor = true;
            rBtnId.CheckedChanged += rBtnId_CheckedChanged;
            // 
            // rBtnDni
            // 
            rBtnDni.AutoSize = true;
            rBtnDni.Location = new Point(103, 99);
            rBtnDni.Name = "rBtnDni";
            rBtnDni.Size = new Size(66, 19);
            rBtnDni.TabIndex = 4;
            rBtnDni.TabStop = true;
            rBtnDni.Text = "Por DNI";
            rBtnDni.UseVisualStyleBackColor = true;
            rBtnDni.CheckedChanged += rBtnDni_CheckedChanged;
            // 
            // txtParticipante
            // 
            txtParticipante.Location = new Point(21, 135);
            txtParticipante.Name = "txtParticipante";
            txtParticipante.Size = new Size(370, 23);
            txtParticipante.TabIndex = 5;
            // 
            // lblCompetencia
            // 
            lblCompetencia.AutoSize = true;
            lblCompetencia.Location = new Point(22, 176);
            lblCompetencia.Name = "lblCompetencia";
            lblCompetencia.Size = new Size(147, 15);
            lblCompetencia.TabIndex = 6;
            lblCompetencia.Text = "Seleccione la competencia";
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(343, 12);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 8;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // btnDarBaja
            // 
            btnDarBaja.Font = new Font("Segoe UI", 9F);
            btnDarBaja.Location = new Point(203, 246);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(99, 41);
            btnDarBaja.TabIndex = 9;
            btnDarBaja.Text = "Dar de Baja";
            btnDarBaja.UseVisualStyleBackColor = true;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.Location = new Point(88, 246);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 41);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // BajaEvento
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(403, 308);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnDarBaja);
            Controls.Add(btnVolverSistema);
            Controls.Add(cmbCompetencias);
            Controls.Add(lblCompetencia);
            Controls.Add(txtParticipante);
            Controls.Add(rBtnDni);
            Controls.Add(rBtnId);
            Controls.Add(lblTitulo);
            Controls.Add(lblParticipante);
            MinimumSize = new Size(389, 324);
            Name = "BajaEvento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BajaEvento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblParticipante;
        private Label lblTitulo;
        private RadioButton rBtnId;
        private RadioButton rBtnDni;
        private TextBox txtParticipante;
        private Label lblCompetencia;
        private ComboBox cmbCompetencias;
        private Button btnVolverSistema;
        private Button btnDarBaja;
        private Button btnCancelar;
    }
}