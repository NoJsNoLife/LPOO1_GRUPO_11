namespace Vistas
{
    partial class ListaCategorias
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
            dgwCategorias = new DataGridView();
            btnVolverSistema = new Button();
            lblCategorias = new Label();
            btnAltaCategorias = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwCategorias).BeginInit();
            SuspendLayout();
            // 
            // dgwCategorias
            // 
            dgwCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCategorias.Location = new Point(12, 103);
            dgwCategorias.Name = "dgwCategorias";
            dgwCategorias.RowHeadersWidth = 62;
            dgwCategorias.Size = new Size(491, 245);
            dgwCategorias.TabIndex = 0;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(454, 12);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 4;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Font = new Font("Segoe UI", 20F);
            lblCategorias.Location = new Point(12, 28);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(144, 37);
            lblCategorias.TabIndex = 6;
            lblCategorias.Text = "Categorías";
            // 
            // btnAltaCategorias
            // 
            btnAltaCategorias.Location = new Point(309, 12);
            btnAltaCategorias.Name = "btnAltaCategorias";
            btnAltaCategorias.Size = new Size(139, 48);
            btnAltaCategorias.TabIndex = 7;
            btnAltaCategorias.Text = "Alta de Categorias";
            btnAltaCategorias.UseVisualStyleBackColor = true;
            btnAltaCategorias.Click += btnAltaCategorias_Click;
            // 
            // ListaCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 379);
            ControlBox = false;
            Controls.Add(btnAltaCategorias);
            Controls.Add(lblCategorias);
            Controls.Add(btnVolverSistema);
            Controls.Add(dgwCategorias);
            MaximizeBox = false;
            MaximumSize = new Size(544, 418);
            MinimizeBox = false;
            MinimumSize = new Size(544, 418);
            Name = "ListaCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaCategorias";
            Load += ListaCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwCategorias;
        private Button btnVolverSistema;
        private Label lblCategorias;
        private Button btnAltaCategorias;
    }
}