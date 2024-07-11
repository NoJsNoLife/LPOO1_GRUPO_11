namespace Vistas
{
    partial class Eventos
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
            btnVolverSistema = new Button();
            btnInscripcion = new Button();
            btnAnularInscripcion = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dgwEventos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwEventos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(9, 13);
            label1.Name = "label1";
            label1.Size = new Size(109, 37);
            label1.TabIndex = 7;
            label1.Text = "Eventos";
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(799, 14);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 6;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // btnInscripcion
            // 
            btnInscripcion.BackColor = Color.DodgerBlue;
            btnInscripcion.ForeColor = SystemColors.ButtonFace;
            btnInscripcion.Location = new Point(134, 14);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(127, 48);
            btnInscripcion.TabIndex = 8;
            btnInscripcion.Text = "Realizar inscripción";
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // btnAnularInscripcion
            // 
            btnAnularInscripcion.BackColor = Color.Crimson;
            btnAnularInscripcion.ForeColor = SystemColors.ButtonFace;
            btnAnularInscripcion.Location = new Point(267, 14);
            btnAnularInscripcion.Name = "btnAnularInscripcion";
            btnAnularInscripcion.Size = new Size(127, 48);
            btnAnularInscripcion.TabIndex = 9;
            btnAnularInscripcion.Text = "Anular inscripción";
            btnAnularInscripcion.UseVisualStyleBackColor = false;
            btnAnularInscripcion.Click += btnAnularInscripcion_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(400, 14);
            button1.Name = "button1";
            button1.Size = new Size(127, 48);
            button1.TabIndex = 10;
            button1.Text = "Acreditar inscripción";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(533, 14);
            button2.Name = "button2";
            button2.Size = new Size(127, 48);
            button2.TabIndex = 11;
            button2.Text = "Cronometrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(666, 14);
            button3.Name = "button3";
            button3.Size = new Size(127, 48);
            button3.TabIndex = 12;
            button3.Text = "Resultados";
            button3.UseVisualStyleBackColor = false;
            // 
            // dgwEventos
            // 
            dgwEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEventos.Location = new Point(24, 80);
            dgwEventos.Name = "dgwEventos";
            dgwEventos.ReadOnly = true;
            dgwEventos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgwEventos.Size = new Size(766, 293);
            dgwEventos.TabIndex = 13;
            // 
            // Eventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 409);
            ControlBox = false;
            Controls.Add(dgwEventos);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAnularInscripcion);
            Controls.Add(btnInscripcion);
            Controls.Add(label1);
            Controls.Add(btnVolverSistema);
            Margin = new Padding(2);
            MinimumSize = new Size(580, 424);
            Name = "Eventos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eventos";
            VisibleChanged += Eventos_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dgwEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVolverSistema;
        private Button btnInscripcion;
        private Button btnAnularInscripcion;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dgwEventos;
    }
}