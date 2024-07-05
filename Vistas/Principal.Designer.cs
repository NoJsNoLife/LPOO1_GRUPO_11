namespace Vistas
{
    partial class Principal
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
            pnlAdministrador = new Panel();
            btnUsuariosAdmin = new Button();
            label2 = new Label();
            pnlOperador = new Panel();
            btnParticipantesOp = new Button();
            btnCompetenciasOp = new Button();
            label3 = new Label();
            pnlAuditor = new Panel();
            btnUsuariosAud = new Button();
            btnSistemaAud = new Button();
            btnEventosAud = new Button();
            label4 = new Label();
            btnCerrarSesion = new Button();
            pnlAdministrador.SuspendLayout();
            pnlOperador.SuspendLayout();
            pnlAuditor.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(796, 37);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al Sistema de control de Eventos!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlAdministrador
            // 
            pnlAdministrador.BackColor = Color.Transparent;
            pnlAdministrador.Controls.Add(btnUsuariosAdmin);
            pnlAdministrador.Controls.Add(label2);
            pnlAdministrador.Location = new Point(50, 82);
            pnlAdministrador.Name = "pnlAdministrador";
            pnlAdministrador.Size = new Size(673, 314);
            pnlAdministrador.TabIndex = 1;
            pnlAdministrador.Visible = false;
            // 
            // btnUsuariosAdmin
            // 
            btnUsuariosAdmin.AutoSize = true;
            btnUsuariosAdmin.Font = new Font("Segoe UI", 18F);
            btnUsuariosAdmin.Location = new Point(16, 76);
            btnUsuariosAdmin.Name = "btnUsuariosAdmin";
            btnUsuariosAdmin.Size = new Size(181, 58);
            btnUsuariosAdmin.TabIndex = 8;
            btnUsuariosAdmin.Text = "Usuarios";
            btnUsuariosAdmin.UseVisualStyleBackColor = true;
            btnUsuariosAdmin.Click += btn_Usuarios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 13);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 0;
            label2.Text = "Panel de Administrador";
            // 
            // pnlOperador
            // 
            pnlOperador.BackColor = Color.Transparent;
            pnlOperador.Controls.Add(btnParticipantesOp);
            pnlOperador.Controls.Add(btnCompetenciasOp);
            pnlOperador.Controls.Add(label3);
            pnlOperador.Location = new Point(50, 83);
            pnlOperador.Name = "pnlOperador";
            pnlOperador.Size = new Size(673, 314);
            pnlOperador.TabIndex = 7;
            pnlOperador.Visible = false;
            // 
            // btnParticipantesOp
            // 
            btnParticipantesOp.AutoSize = true;
            btnParticipantesOp.Font = new Font("Segoe UI", 18F);
            btnParticipantesOp.Location = new Point(31, 162);
            btnParticipantesOp.Name = "btnParticipantesOp";
            btnParticipantesOp.Size = new Size(232, 58);
            btnParticipantesOp.TabIndex = 5;
            btnParticipantesOp.Text = "Participantes";
            btnParticipantesOp.UseVisualStyleBackColor = true;
            btnParticipantesOp.Click += btnParticipantesOp_Click;
            // 
            // btnCompetenciasOp
            // 
            btnCompetenciasOp.AutoSize = true;
            btnCompetenciasOp.Font = new Font("Segoe UI", 18F);
            btnCompetenciasOp.Location = new Point(31, 98);
            btnCompetenciasOp.Name = "btnCompetenciasOp";
            btnCompetenciasOp.Size = new Size(232, 58);
            btnCompetenciasOp.TabIndex = 4;
            btnCompetenciasOp.Text = "Competencias";
            btnCompetenciasOp.UseVisualStyleBackColor = true;
            btnCompetenciasOp.Click += btnCompetenciasOp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 13);
            label3.Name = "label3";
            label3.Size = new Size(213, 32);
            label3.TabIndex = 0;
            label3.Text = "Panel de Operador";
            // 
            // pnlAuditor
            // 
            pnlAuditor.BackColor = Color.Transparent;
            pnlAuditor.Controls.Add(btnUsuariosAud);
            pnlAuditor.Controls.Add(btnSistemaAud);
            pnlAuditor.Controls.Add(btnEventosAud);
            pnlAuditor.Controls.Add(label4);
            pnlAuditor.Location = new Point(50, 82);
            pnlAuditor.Name = "pnlAuditor";
            pnlAuditor.Size = new Size(673, 314);
            pnlAuditor.TabIndex = 8;
            pnlAuditor.Visible = false;
            // 
            // btnUsuariosAud
            // 
            btnUsuariosAud.AutoSize = true;
            btnUsuariosAud.Font = new Font("Segoe UI", 18F);
            btnUsuariosAud.Location = new Point(489, 256);
            btnUsuariosAud.Name = "btnUsuariosAud";
            btnUsuariosAud.Size = new Size(181, 58);
            btnUsuariosAud.TabIndex = 10;
            btnUsuariosAud.Text = "Usuarios";
            btnUsuariosAud.UseVisualStyleBackColor = true;
            btnUsuariosAud.Click += btn_Usuarios_Click;
            // 
            // btnSistemaAud
            // 
            btnSistemaAud.AutoSize = true;
            btnSistemaAud.Font = new Font("Segoe UI", 18F);
            btnSistemaAud.Location = new Point(489, 128);
            btnSistemaAud.Name = "btnSistemaAud";
            btnSistemaAud.Size = new Size(181, 58);
            btnSistemaAud.TabIndex = 6;
            btnSistemaAud.Text = "Sistema";
            btnSistemaAud.UseVisualStyleBackColor = true;
            btnSistemaAud.Click += btnSistema_Click;
            // 
            // btnEventosAud
            // 
            btnEventosAud.AutoSize = true;
            btnEventosAud.Font = new Font("Segoe UI", 18F);
            btnEventosAud.Location = new Point(489, 192);
            btnEventosAud.Name = "btnEventosAud";
            btnEventosAud.Size = new Size(181, 58);
            btnEventosAud.TabIndex = 9;
            btnEventosAud.Text = "Eventos";
            btnEventosAud.UseVisualStyleBackColor = true;
            btnEventosAud.Click += btnEventos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DimGray;
            label4.Font = new Font("Segoe UI", 18F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 13);
            label4.Name = "label4";
            label4.Size = new Size(191, 32);
            label4.TabIndex = 0;
            label4.Text = "Panel de Auditor";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.DeepSkyBlue;
            btnCerrarSesion.Location = new Point(683, 0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(115, 37);
            btnCerrarSesion.TabIndex = 9;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(796, 414);
            ControlBox = false;
            Controls.Add(btnCerrarSesion);
            Controls.Add(label1);
            Controls.Add(pnlOperador);
            Controls.Add(pnlAdministrador);
            Controls.Add(pnlAuditor);
            MaximumSize = new Size(812, 475);
            MinimumSize = new Size(812, 439);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            pnlAdministrador.ResumeLayout(false);
            pnlAdministrador.PerformLayout();
            pnlOperador.ResumeLayout(false);
            pnlOperador.PerformLayout();
            pnlAuditor.ResumeLayout(false);
            pnlAuditor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnSistema;
        private Button btnCompetencias;
        private Button btnParticipantes;
        private Button btnEventos;
        private Button btnUsuarios;
        private Panel pnlAdministrador;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Panel pnlAuditor;
        private Panel pnlOperador;
        private Button button1;
        private Button button2;
        private Label label4;
        private Button btnParticipantesOp;
        private Button btnCompetenciasOp;
        private Button btnUsuariosAud;
        private Button btnSistemaAud;
        private Button btnEventosAud;
        private Button btnParticipantesAud;
        private Button btnCompetenciasAud;
        private Button btnUsuariosAdmin;
        private Button btnCerrarSesion;
    }
}