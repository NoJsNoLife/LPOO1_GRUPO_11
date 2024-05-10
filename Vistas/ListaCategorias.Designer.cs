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
            dgwCategorias.Location = new Point(17, 172);
            dgwCategorias.Margin = new Padding(4, 5, 4, 5);
            dgwCategorias.Name = "dgwCategorias";
            dgwCategorias.RowHeadersWidth = 62;
            dgwCategorias.Size = new Size(701, 409);
            dgwCategorias.TabIndex = 0;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(649, 20);
            btnVolverSistema.Margin = new Padding(4, 5, 4, 5);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(69, 80);
            btnVolverSistema.TabIndex = 4;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Font = new Font("Segoe UI", 20F);
            lblCategorias.Location = new Point(17, 46);
            lblCategorias.Margin = new Padding(4, 0, 4, 0);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(211, 54);
            lblCategorias.TabIndex = 6;
            lblCategorias.Text = "Categorías";
            // 
            // btnAltaCategorias
            // 
            btnAltaCategorias.Location = new Point(442, 20);
            btnAltaCategorias.Margin = new Padding(4, 5, 4, 5);
            btnAltaCategorias.Name = "btnAltaCategorias";
            btnAltaCategorias.Size = new Size(199, 80);
            btnAltaCategorias.TabIndex = 7;
            btnAltaCategorias.Text = "Alta de Categorias";
            btnAltaCategorias.UseVisualStyleBackColor = true;
            btnAltaCategorias.Click += btnAltaCategorias_Click;
            // 
            // ListaCategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 615);
            Controls.Add(btnAltaCategorias);
            Controls.Add(lblCategorias);
            Controls.Add(btnVolverSistema);
            Controls.Add(dgwCategorias);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(770, 671);
            MinimumSize = new Size(770, 671);
            Name = "ListaCategorias";
            Text = "ListaCategorias";
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