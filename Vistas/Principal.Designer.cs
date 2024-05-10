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
            btnSistema = new Button();
            btnCompetencias = new Button();
            btnParticipantes = new Button();
            btnEventos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(211, 112);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(816, 54);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al Sistema de control de Eventos!";
            // 
            // btnSistema
            // 
            btnSistema.AutoSize = true;
            btnSistema.Font = new Font("Segoe UI", 18F);
            btnSistema.Location = new Point(773, 212);
            btnSistema.Margin = new Padding(4, 5, 4, 5);
            btnSistema.Name = "btnSistema";
            btnSistema.Size = new Size(259, 97);
            btnSistema.TabIndex = 1;
            btnSistema.Text = "Sistema";
            btnSistema.UseVisualStyleBackColor = true;
            btnSistema.Click += btnSistema_Click;
            // 
            // btnCompetencias
            // 
            btnCompetencias.AutoSize = true;
            btnCompetencias.Font = new Font("Segoe UI", 18F);
            btnCompetencias.Location = new Point(773, 318);
            btnCompetencias.Margin = new Padding(4, 5, 4, 5);
            btnCompetencias.Name = "btnCompetencias";
            btnCompetencias.Size = new Size(259, 97);
            btnCompetencias.TabIndex = 2;
            btnCompetencias.Text = "Competencias";
            btnCompetencias.UseVisualStyleBackColor = true;
            btnCompetencias.Click += btnCompetencias_Click;
            // 
            // btnParticipantes
            // 
            btnParticipantes.AutoSize = true;
            btnParticipantes.Font = new Font("Segoe UI", 18F);
            btnParticipantes.Location = new Point(773, 425);
            btnParticipantes.Margin = new Padding(4, 5, 4, 5);
            btnParticipantes.Name = "btnParticipantes";
            btnParticipantes.Size = new Size(259, 97);
            btnParticipantes.TabIndex = 3;
            btnParticipantes.Text = "Participantes";
            btnParticipantes.UseVisualStyleBackColor = true;
            btnParticipantes.Click += btnParticipantes_Click;
            // 
            // btnEventos
            // 
            btnEventos.AutoSize = true;
            btnEventos.Font = new Font("Segoe UI", 18F);
            btnEventos.Location = new Point(773, 532);
            btnEventos.Margin = new Padding(4, 5, 4, 5);
            btnEventos.Name = "btnEventos";
            btnEventos.Size = new Size(259, 97);
            btnEventos.TabIndex = 4;
            btnEventos.Text = "Eventos";
            btnEventos.UseVisualStyleBackColor = true;
            btnEventos.Click += btnEventos_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1134, 722);
            Controls.Add(btnEventos);
            Controls.Add(btnParticipantes);
            Controls.Add(btnCompetencias);
            Controls.Add(btnSistema);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1156, 778);
            MinimumSize = new Size(1156, 778);
            Name = "Principal";
            Text = "Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSistema;
        private Button btnCompetencias;
        private Button btnParticipantes;
        private Button btnEventos;
    }
}