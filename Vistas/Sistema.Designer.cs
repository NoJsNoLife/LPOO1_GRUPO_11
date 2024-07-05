namespace Vistas
{
    partial class Sistema
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
            btnDisciplinas = new Button();
            btnVolverSistema = new Button();
            btnListaCategorias = new Button();
            btnAtletas = new Button();
            btnCompetencias = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(114, 32);
            label1.TabIndex = 0;
            label1.Text = "Opciones";
            // 
            // btnDisciplinas
            // 
            btnDisciplinas.Location = new Point(15, 157);
            btnDisciplinas.Name = "btnDisciplinas";
            btnDisciplinas.Size = new Size(141, 64);
            btnDisciplinas.TabIndex = 2;
            btnDisciplinas.Text = "Disciplinas";
            btnDisciplinas.UseVisualStyleBackColor = true;
            btnDisciplinas.Click += btnListaDisciplinas_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(255, 12);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 3;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // btnListaCategorias
            // 
            btnListaCategorias.Location = new Point(15, 86);
            btnListaCategorias.Name = "btnListaCategorias";
            btnListaCategorias.Size = new Size(141, 64);
            btnListaCategorias.TabIndex = 4;
            btnListaCategorias.Text = "Categorias";
            btnListaCategorias.UseVisualStyleBackColor = true;
            btnListaCategorias.Click += btnListaCategorias_Click;
            // 
            // btnAtletas
            // 
            btnAtletas.Location = new Point(162, 86);
            btnAtletas.Name = "btnAtletas";
            btnAtletas.Size = new Size(141, 64);
            btnAtletas.TabIndex = 6;
            btnAtletas.Text = "Atletas";
            btnAtletas.UseVisualStyleBackColor = true;
            btnAtletas.Click += btnAtletas_Click;
            // 
            // btnCompetencias
            // 
            btnCompetencias.Location = new Point(162, 157);
            btnCompetencias.Name = "btnCompetencias";
            btnCompetencias.Size = new Size(141, 64);
            btnCompetencias.TabIndex = 5;
            btnCompetencias.Text = "Competencias";
            btnCompetencias.UseVisualStyleBackColor = true;
            btnCompetencias.Click += btnCompetencias_Click;
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 288);
            ControlBox = false;
            Controls.Add(btnAtletas);
            Controls.Add(btnCompetencias);
            Controls.Add(btnListaCategorias);
            Controls.Add(btnVolverSistema);
            Controls.Add(btnDisciplinas);
            Controls.Add(label1);
            MaximumSize = new Size(342, 327);
            MinimumSize = new Size(342, 327);
            Name = "Sistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDisciplinas;
        private Button btnVolverSistema;
        private Button btnListaCategorias;
        private Button btnAtletas;
        private Button btnCompetencias;
    }
}