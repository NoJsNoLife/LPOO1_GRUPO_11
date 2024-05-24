namespace Vistas
{
    partial class AltaUsuario
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
            cmbRoles = new ComboBox();
            lblCodigoRolUsuario = new Label();
            lblApellidoNombreUsuario = new Label();
            lblContraseniaUsuario = new Label();
            txtNombre = new TextBox();
            txtContrasenia = new TextBox();
            txtNombreUsuario = new TextBox();
            lblNombreUsuario = new Label();
            btnRegistrar = new Button();
            btnVolverSistema = new Button();
            SuspendLayout();
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(122, 446);
            cmbRoles.Margin = new Padding(4, 5, 4, 5);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(357, 33);
            cmbRoles.TabIndex = 18;
            // 
            // lblCodigoRolUsuario
            // 
            lblCodigoRolUsuario.AutoSize = true;
            lblCodigoRolUsuario.Location = new Point(122, 416);
            lblCodigoRolUsuario.Margin = new Padding(4, 0, 4, 0);
            lblCodigoRolUsuario.Name = "lblCodigoRolUsuario";
            lblCodigoRolUsuario.Size = new Size(126, 25);
            lblCodigoRolUsuario.TabIndex = 17;
            lblCodigoRolUsuario.Text = "Código de Rol";
            // 
            // lblApellidoNombreUsuario
            // 
            lblApellidoNombreUsuario.AutoSize = true;
            lblApellidoNombreUsuario.Location = new Point(122, 320);
            lblApellidoNombreUsuario.Margin = new Padding(4, 0, 4, 0);
            lblApellidoNombreUsuario.Name = "lblApellidoNombreUsuario";
            lblApellidoNombreUsuario.Size = new Size(163, 25);
            lblApellidoNombreUsuario.TabIndex = 16;
            lblApellidoNombreUsuario.Text = "Apellido y Nombre";
            // 
            // lblContraseniaUsuario
            // 
            lblContraseniaUsuario.AutoSize = true;
            lblContraseniaUsuario.Location = new Point(122, 211);
            lblContraseniaUsuario.Margin = new Padding(4, 0, 4, 0);
            lblContraseniaUsuario.Name = "lblContraseniaUsuario";
            lblContraseniaUsuario.Size = new Size(105, 25);
            lblContraseniaUsuario.TabIndex = 15;
            lblContraseniaUsuario.Text = "Contrasenia";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 350);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(357, 31);
            txtNombre.TabIndex = 14;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(122, 241);
            txtContrasenia.Margin = new Padding(4, 5, 4, 5);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(357, 31);
            txtContrasenia.TabIndex = 13;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(122, 131);
            txtNombreUsuario.Margin = new Padding(4, 5, 4, 5);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(357, 31);
            txtNombreUsuario.TabIndex = 12;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(122, 101);
            lblNombreUsuario.Margin = new Padding(4, 0, 4, 0);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(168, 25);
            lblNombreUsuario.TabIndex = 11;
            lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(209, 551);
            btnRegistrar.Margin = new Padding(4, 5, 4, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(171, 90);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(511, 14);
            btnVolverSistema.Margin = new Padding(4, 5, 4, 5);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(69, 80);
            btnVolverSistema.TabIndex = 57;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // AltaUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 710);
            ControlBox = false;
            Controls.Add(btnVolverSistema);
            Controls.Add(cmbRoles);
            Controls.Add(lblCodigoRolUsuario);
            Controls.Add(lblApellidoNombreUsuario);
            Controls.Add(lblContraseniaUsuario);
            Controls.Add(txtNombre);
            Controls.Add(txtContrasenia);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnRegistrar);
            MaximumSize = new Size(615, 766);
            MinimumSize = new Size(615, 766);
            Name = "AltaUsuario";
            Text = "AltaUsuario";
            Load += AltaUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRoles;
        private Label lblCodigoRolUsuario;
        private Label lblApellidoNombreUsuario;
        private Label lblContraseniaUsuario;
        private TextBox txtNombre;
        private TextBox txtContrasenia;
        private TextBox txtNombreUsuario;
        private Label lblNombreUsuario;
        private Button btnRegistrar;
        private Button btnVolverSistema;
    }
}