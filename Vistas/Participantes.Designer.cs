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
            btnVolverSistema.Location = new Point(1057, 20);
            btnVolverSistema.Margin = new Padding(4, 5, 4, 5);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(69, 80);
            btnVolverSistema.TabIndex = 4;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(17, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 54);
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
            dataGridView1.Location = new Point(17, 128);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1109, 537);
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
            btnAltaParticipantes.Location = new Point(797, 20);
            btnAltaParticipantes.Margin = new Padding(4, 5, 4, 5);
            btnAltaParticipantes.Name = "btnAltaParticipantes";
            btnAltaParticipantes.Size = new Size(251, 80);
            btnAltaParticipantes.TabIndex = 7;
            btnAltaParticipantes.Text = "Alta de Participantes";
            btnAltaParticipantes.UseVisualStyleBackColor = false;
            btnAltaParticipantes.Click += btnAltaParticipantes_Click;
            // 
            // Participantes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 722);
            ControlBox = false;
            Controls.Add(btnAltaParticipantes);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnVolverSistema);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1156, 778);
            MinimumSize = new Size(1156, 778);
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