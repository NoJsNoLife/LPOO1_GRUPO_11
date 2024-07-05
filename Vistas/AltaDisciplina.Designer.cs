namespace Vistas
{
    partial class AltaDisciplina
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
            txtNombre = new TextBox();
            label2 = new Label();
            txtDescripcion = new RichTextBox();
            btnAgregar = new Button();
            label9 = new Label();
            btnVolverSistema = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F);
            txtNombre.Location = new Point(9, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(399, 32);
            txtNombre.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(9, 51);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 60;
            label2.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 14F);
            txtDescripcion.Location = new Point(9, 143);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(399, 216);
            txtDescripcion.TabIndex = 59;
            txtDescripcion.Text = "";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI", 14F);
            btnAgregar.Location = new Point(84, 377);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(247, 47);
            btnAgregar.TabIndex = 58;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(9, 115);
            label9.Name = "label9";
            label9.Size = new Size(111, 25);
            label9.TabIndex = 57;
            label9.Text = "Descripcion";
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(360, 10);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 56;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(9, 10);
            label1.Name = "label1";
            label1.Size = new Size(245, 32);
            label1.TabIndex = 55;
            label1.Text = "Alta de una Disciplina";
            // 
            // AltaDisciplina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 433);
            ControlBox = false;
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(btnAgregar);
            Controls.Add(label9);
            Controls.Add(btnVolverSistema);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(437, 482);
            MinimumSize = new Size(437, 446);
            Name = "AltaDisciplina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaDisciplina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label2;
        private RichTextBox txtDescripcion;
        private Button btnAgregar;
        private Label label9;
        private Button btnVolverSistema;
        private Label label1;
    }
}