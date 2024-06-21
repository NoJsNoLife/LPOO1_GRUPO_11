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
            txtNombre = new TextBox();
            label2 = new Label();
            txtDescripcion = new RichTextBox();
            btnAgregar = new Button();
            label9 = new Label();
            btModificar = new Button();
            btnEliminar = new Button();
            nuevoBtn = new Button();
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
            dgwCategorias.CurrentCellChanged += dgwCategorias_CurrentCellChanged;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(776, 12);
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
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F);
            txtNombre.Location = new Point(523, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(308, 32);
            txtNombre.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(523, 76);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 58;
            label2.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 14F);
            txtDescripcion.Location = new Point(523, 167);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(308, 135);
            txtDescripcion.TabIndex = 57;
            txtDescripcion.Text = "";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.BackColor = Color.Green;
            btnAgregar.Font = new Font("Segoe UI", 14F);
            btnAgregar.ForeColor = SystemColors.ButtonFace;
            btnAgregar.Location = new Point(523, 308);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 47);
            btnAgregar.TabIndex = 56;
            btnAgregar.Text = "Alta";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(523, 139);
            label9.Name = "label9";
            label9.Size = new Size(111, 25);
            label9.TabIndex = 55;
            label9.Text = "Descripcion";
            // 
            // btModificar
            // 
            btModificar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btModificar.BackColor = Color.DodgerBlue;
            btModificar.Font = new Font("Segoe UI", 14F);
            btModificar.ForeColor = SystemColors.ButtonFace;
            btModificar.Location = new Point(619, 308);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(103, 47);
            btModificar.TabIndex = 60;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = false;
            btModificar.Click += btModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.Font = new Font("Segoe UI", 14F);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(728, 308);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 47);
            btnEliminar.TabIndex = 61;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // nuevoBtn
            // 
            nuevoBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nuevoBtn.BackColor = Color.Green;
            nuevoBtn.Font = new Font("Segoe UI", 14F);
            nuevoBtn.ForeColor = SystemColors.ButtonFace;
            nuevoBtn.Location = new Point(680, 13);
            nuevoBtn.Name = "nuevoBtn";
            nuevoBtn.Size = new Size(90, 47);
            nuevoBtn.TabIndex = 62;
            nuevoBtn.Text = "Nuevo";
            nuevoBtn.UseVisualStyleBackColor = false;
            nuevoBtn.Click += nuevoBtn_Click;
            // 
            // ListaCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 402);
            ControlBox = false;
            Controls.Add(nuevoBtn);
            Controls.Add(btnEliminar);
            Controls.Add(btModificar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(btnAgregar);
            Controls.Add(label9);
            Controls.Add(lblCategorias);
            Controls.Add(btnVolverSistema);
            Controls.Add(dgwCategorias);
            MaximizeBox = false;
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
        private TextBox txtNombre;
        private Label label2;
        private RichTextBox txtDescripcion;
        private Button btnAgregar;
        private Label label9;
        private Button btModificar;
        private Button btnEliminar;
        private Button nuevoBtn;
    }
}