namespace Vistas
{
    partial class AltaCategoria
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
            btnAgregar = new Button();
            label9 = new Label();
            btnVolverSistema = new Button();
            label1 = new Label();
            txtDescripcion = new RichTextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI", 14F);
            btnAgregar.Location = new Point(124, 630);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(353, 78);
            btnAgregar.TabIndex = 51;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(17, 193);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(162, 38);
            label9.TabIndex = 45;
            label9.Text = "Descripcion";
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(519, 18);
            btnVolverSistema.Margin = new Padding(4, 5, 4, 5);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(69, 80);
            btnVolverSistema.TabIndex = 36;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(17, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(363, 48);
            label1.TabIndex = 27;
            label1.Text = "Alta de una Categoria";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 14F);
            txtDescripcion.Location = new Point(17, 240);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(568, 358);
            txtDescripcion.TabIndex = 52;
            txtDescripcion.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(17, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 38);
            label2.TabIndex = 53;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F);
            txtNombre.Location = new Point(17, 135);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(568, 45);
            txtNombre.TabIndex = 54;
            // 
            // AltaCategoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 722);
            ControlBox = false;
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(btnAgregar);
            Controls.Add(label9);
            Controls.Add(btnVolverSistema);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(618, 778);
            MinimumSize = new Size(618, 778);
            Name = "AltaCategoria";
            Text = "AltaCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label label9;
        private Button btnVolverSistema;
        private TextBox txtDni;
        private Label label1;
        private RichTextBox txtDescripcion;
        private RichTextBox richTextBox2;
        private Label label2;
        private TextBox txtNombre;
    }
}