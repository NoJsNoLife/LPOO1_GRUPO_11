namespace Vistas
{
    partial class Atletas
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
            dgwAtletas = new DataGridView();
            atletaBindingSource = new BindingSource(components);
            btnAltaParticipantes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwAtletas).BeginInit();
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
            label1.Size = new Size(145, 54);
            label1.TabIndex = 5;
            label1.Text = "Atletas";
            // 
            // dgwAtletas
            // 
            dgwAtletas.AllowUserToAddRows = false;
            dgwAtletas.AllowUserToResizeColumns = false;
            dgwAtletas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwAtletas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwAtletas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAtletas.Location = new Point(17, 128);
            dgwAtletas.Margin = new Padding(4, 5, 4, 5);
            dgwAtletas.Name = "dgwAtletas";
            dgwAtletas.RowHeadersWidth = 62;
            dgwAtletas.Size = new Size(1109, 537);
            dgwAtletas.TabIndex = 6;
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
            btnAltaParticipantes.Text = "Registrar Atleta";
            btnAltaParticipantes.UseVisualStyleBackColor = false;
            btnAltaParticipantes.Click += btnAltaParticipantes_Click;
            // 
            // Atletas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 710);
            ControlBox = false;
            Controls.Add(btnAltaParticipantes);
            Controls.Add(dgwAtletas);
            Controls.Add(label1);
            Controls.Add(btnVolverSistema);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1153, 766);
            MinimumSize = new Size(1153, 706);
            Name = "Atletas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atletas";
            Load += Atletas_Load;
            ((System.ComponentModel.ISupportInitialize)dgwAtletas).EndInit();
            ((System.ComponentModel.ISupportInitialize)atletaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolverSistema;
        private Label label1;
        private DataGridView dgwAtletas;
        private BindingSource atletaBindingSource;
        private Button btnAltaParticipantes;
    }
}