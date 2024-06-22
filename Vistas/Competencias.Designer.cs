namespace Vistas
{
    partial class Competencias
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
            btnVolverSistema = new Button();
            dgwCompetencias = new DataGridView();
            label1 = new Label();
            btnAgregar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwCompetencias).BeginInit();
            SuspendLayout();
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(790, 8);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 4;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // dgwCompetencias
            // 
            dgwCompetencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCompetencias.Location = new Point(12, 63);
            dgwCompetencias.Name = "dgwCompetencias";
            dgwCompetencias.Size = new Size(826, 404);
            dgwCompetencias.TabIndex = 5;
            dgwCompetencias.CurrentCellChanged += dgwCompetencias_CurrentCellChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 6;
            label1.Text = "Competencias";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.ForeColor = SystemColors.ButtonFace;
            btnAgregar.Location = new Point(450, 474);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 54);
            btnAgregar.TabIndex = 41;
            btnAgregar.Text = "Agregar Competencia";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Crimson;
            btnBorrar.ForeColor = SystemColors.ButtonFace;
            btnBorrar.Location = new Point(718, 473);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(120, 54);
            btnBorrar.TabIndex = 40;
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DodgerBlue;
            btnModificar.ForeColor = SystemColors.ButtonFace;
            btnModificar.Location = new Point(592, 474);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 54);
            btnModificar.TabIndex = 39;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // Competencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 540);
            ControlBox = false;
            Controls.Add(btnAgregar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(label1);
            Controls.Add(dgwCompetencias);
            Controls.Add(btnVolverSistema);
            MinimumSize = new Size(580, 424);
            Name = "Competencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Competencias";
            Shown += Competencias_VisibleChanged;
            VisibleChanged += Competencias_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dgwCompetencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolverSistema;
        private DataGridView dgwCompetencias;
        private Label label1;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnModificar;
    }
}