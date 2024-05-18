namespace Vistas
{
    partial class ListaDisciplinas
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
            btnAltaDisciplinas = new Button();
            lblDisciplinas = new Label();
            btnVolverSistema = new Button();
            dgwDisciplinas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwDisciplinas).BeginInit();
            SuspendLayout();
            // 
            // btnAltaDisciplinas
            // 
            btnAltaDisciplinas.Location = new Point(475, 32);
            btnAltaDisciplinas.Margin = new Padding(4, 5, 4, 5);
            btnAltaDisciplinas.Name = "btnAltaDisciplinas";
            btnAltaDisciplinas.Size = new Size(199, 80);
            btnAltaDisciplinas.TabIndex = 11;
            btnAltaDisciplinas.Text = "Alta de Disciplinas";
            btnAltaDisciplinas.UseVisualStyleBackColor = true;
            btnAltaDisciplinas.Click += btnAltaDisciplinas_Click;
            // 
            // lblDisciplinas
            // 
            lblDisciplinas.AutoSize = true;
            lblDisciplinas.Font = new Font("Segoe UI", 20F);
            lblDisciplinas.Location = new Point(50, 58);
            lblDisciplinas.Margin = new Padding(4, 0, 4, 0);
            lblDisciplinas.Name = "lblDisciplinas";
            lblDisciplinas.Size = new Size(143, 37);
            lblDisciplinas.TabIndex = 10;
            lblDisciplinas.Text = "Disciplinas";
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(682, 32);
            btnVolverSistema.Margin = new Padding(4, 5, 4, 5);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(69, 80);
            btnVolverSistema.TabIndex = 9;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // dgwDisciplinas
            // 
            dgwDisciplinas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDisciplinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDisciplinas.Location = new Point(50, 184);
            dgwDisciplinas.Margin = new Padding(4, 5, 4, 5);
            dgwDisciplinas.Name = "dgwDisciplinas";
            dgwDisciplinas.RowHeadersWidth = 62;
            dgwDisciplinas.Size = new Size(701, 409);
            dgwDisciplinas.TabIndex = 8;
            // 
            // ListaDisciplinas
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(806, 641);
            ControlBox = false;
            Controls.Add(btnAltaDisciplinas);
            Controls.Add(lblDisciplinas);
            Controls.Add(btnVolverSistema);
            Controls.Add(dgwDisciplinas);
            MaximumSize = new Size(822, 680);
            MinimumSize = new Size(822, 680);
            Name = "ListaDisciplinas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaDisciplinas";
            Load += ListaDisciplinas_Load;
            ((System.ComponentModel.ISupportInitialize)dgwDisciplinas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAltaDisciplinas;
        private Label lblDisciplinas;
        private Button btnVolverSistema;
        private DataGridView dgwDisciplinas;
    }
}