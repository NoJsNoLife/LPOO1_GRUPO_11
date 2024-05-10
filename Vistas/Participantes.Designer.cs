namespace Vistas
{
    partial class Participantes
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
            components = new System.ComponentModel.Container();
            btnVolverSistema = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            atletaBindingSource = new BindingSource(components);
            btnAltaParticipantes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atletaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(740, 12);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 4;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 5;
            label1.Text = "Participantes";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 322);
            dataGridView1.TabIndex = 6;
            // 
            // atletaBindingSource
            // 
            atletaBindingSource.DataSource = typeof(ClaseBase.Atleta);
            // 
            // btnAltaParticipantes
            // 
            btnAltaParticipantes.BackColor = SystemColors.ActiveCaption;
            btnAltaParticipantes.Font = new Font("Segoe UI", 12F);
            btnAltaParticipantes.Location = new Point(558, 12);
            btnAltaParticipantes.Name = "btnAltaParticipantes";
            btnAltaParticipantes.Size = new Size(176, 48);
            btnAltaParticipantes.TabIndex = 7;
            btnAltaParticipantes.Text = "Alta de Participantes";
            btnAltaParticipantes.UseVisualStyleBackColor = false;
            btnAltaParticipantes.Click += btnAltaParticipantes_Click;
            // 
            // Participantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAltaParticipantes);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnVolverSistema);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Participantes";
            Text = "Participantes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)atletaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolverSistema;
        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource atletaBindingSource;
        private Button btnAltaParticipantes;
    }
}