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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(98, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 48);
            label1.TabIndex = 0;
            label1.Text = "Opciones";
            // 
            // btnDisciplinas
            // 
            btnDisciplinas.Location = new Point(98, 291);
            btnDisciplinas.Margin = new Padding(4, 5, 4, 5);
            btnDisciplinas.Name = "btnDisciplinas";
            btnDisciplinas.Size = new Size(230, 107);
            btnDisciplinas.TabIndex = 2;
            btnDisciplinas.Text = "Disciplinas";
            btnDisciplinas.UseVisualStyleBackColor = true;
            btnDisciplinas.Click += btnListaDisciplinas_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(351, 39);
            btnVolverSistema.Margin = new Padding(4, 5, 4, 5);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(69, 80);
            btnVolverSistema.TabIndex = 3;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // btnListaCategorias
            // 
            btnListaCategorias.Location = new Point(98, 174);
            btnListaCategorias.Margin = new Padding(4, 5, 4, 5);
            btnListaCategorias.Name = "btnListaCategorias";
            btnListaCategorias.Size = new Size(230, 107);
            btnListaCategorias.TabIndex = 4;
            btnListaCategorias.Text = "Categorias";
            btnListaCategorias.UseVisualStyleBackColor = true;
            btnListaCategorias.Click += btnListaCategorias_Click;
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 475);
            ControlBox = false;
            Controls.Add(btnListaCategorias);
            Controls.Add(btnVolverSistema);
            Controls.Add(btnDisciplinas);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(485, 531);
            MinimumSize = new Size(485, 531);
            Name = "Sistema";
            Text = "Sistema";
            Load += Sistema_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDisciplinas;
        private Button btnVolverSistema;
        private Button btnListaCategorias;
    }
}