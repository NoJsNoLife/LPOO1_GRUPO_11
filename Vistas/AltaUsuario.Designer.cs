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
            cmbRoles.Location = new Point(85, 268);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(251, 23);
            cmbRoles.TabIndex = 18;
            // 
            // lblCodigoRolUsuario
            // 
            lblCodigoRolUsuario.AutoSize = true;
            lblCodigoRolUsuario.Location = new Point(85, 250);
            lblCodigoRolUsuario.Name = "lblCodigoRolUsuario";
            lblCodigoRolUsuario.Size = new Size(82, 15);
            lblCodigoRolUsuario.TabIndex = 17;
            lblCodigoRolUsuario.Text = "Código de Rol";
            // 
            // lblApellidoNombreUsuario
            // 
            lblApellidoNombreUsuario.AutoSize = true;
            lblApellidoNombreUsuario.Location = new Point(85, 192);
            lblApellidoNombreUsuario.Name = "lblApellidoNombreUsuario";
            lblApellidoNombreUsuario.Size = new Size(107, 15);
            lblApellidoNombreUsuario.TabIndex = 16;
            lblApellidoNombreUsuario.Text = "Apellido y Nombre";
            // 
            // lblContraseniaUsuario
            // 
            lblContraseniaUsuario.AutoSize = true;
            lblContraseniaUsuario.Location = new Point(85, 127);
            lblContraseniaUsuario.Name = "lblContraseniaUsuario";
            lblContraseniaUsuario.Size = new Size(70, 15);
            lblContraseniaUsuario.TabIndex = 15;
            lblContraseniaUsuario.Text = "Contrasenia";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 210);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(251, 23);
            txtNombre.TabIndex = 14;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(85, 145);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(251, 23);
            txtContrasenia.TabIndex = 13;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(85, 79);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(251, 23);
            txtNombreUsuario.TabIndex = 12;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(85, 61);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(110, 15);
            lblNombreUsuario.TabIndex = 11;
            lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(146, 331);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(120, 54);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(358, 8);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 57;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // AltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 436);
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
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(435, 475);
            MinimumSize = new Size(435, 475);
            Name = "AltaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
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