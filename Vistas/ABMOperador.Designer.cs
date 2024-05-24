namespace Vistas
{
    partial class ABMOperador
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
            label1.Location = new Point(143, 107);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 48);
            label1.TabIndex = 0;
            label1.Text = "Opciones";
            // 
            // btnDisciplinas
            // 
            btnDisciplinas.Location = new Point(21, 294);
            btnDisciplinas.Margin = new Padding(4, 5, 4, 5);
            btnDisciplinas.Name = "btnDisciplinas";
            btnDisciplinas.Size = new Size(202, 107);
            btnDisciplinas.TabIndex = 2;
            btnDisciplinas.Text = "Disciplinas";
            btnDisciplinas.UseVisualStyleBackColor = true;
            btnDisciplinas.Click += btnListaDisciplinas_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(378, 14);
            btnVolverSistema.Margin = new Padding(4, 5, 4, 5);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(69, 80);
            btnVolverSistema.TabIndex = 3;
            btnVolverSistema.UseVisualStyleBackColor = true;
            // 
            // btnListaCategorias
            // 
            btnListaCategorias.Location = new Point(21, 175);
            btnListaCategorias.Margin = new Padding(4, 5, 4, 5);
            btnListaCategorias.Name = "btnListaCategorias";
            btnListaCategorias.Size = new Size(202, 107);
            btnListaCategorias.TabIndex = 4;
            btnListaCategorias.Text = "Categorias";
            btnListaCategorias.UseVisualStyleBackColor = true;
            btnListaCategorias.Click += btnListaCategorias_Click;
            // 
            // btnAtletas
            // 
            btnAtletas.Location = new Point(231, 175);
            btnAtletas.Margin = new Padding(4, 5, 4, 5);
            btnAtletas.Name = "btnAtletas";
            btnAtletas.Size = new Size(202, 107);
            btnAtletas.TabIndex = 6;
            btnAtletas.Text = "Atletas";
            btnAtletas.UseVisualStyleBackColor = true;
            btnAtletas.Click += btnAtletas_Click;
            // 
            // btnCompetencias
            // 
            btnCompetencias.Location = new Point(231, 294);
            btnCompetencias.Margin = new Padding(4, 5, 4, 5);
            btnCompetencias.Name = "btnCompetencias";
            btnCompetencias.Size = new Size(202, 107);
            btnCompetencias.TabIndex = 5;
            btnCompetencias.Text = "Competencias";
            btnCompetencias.UseVisualStyleBackColor = true;
            btnCompetencias.Click += btnCompetencias_Click;
            // 
            // ABMOperador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 463);
            ControlBox = false;
            Controls.Add(btnAtletas);
            Controls.Add(btnCompetencias);
            Controls.Add(btnListaCategorias);
            Controls.Add(btnVolverSistema);
            Controls.Add(btnDisciplinas);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(482, 519);
            MinimumSize = new Size(482, 519);
            Name = "ABMOperador";
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