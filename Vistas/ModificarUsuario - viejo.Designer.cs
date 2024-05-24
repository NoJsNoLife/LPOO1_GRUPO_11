namespace Vistas
{
    partial class ModificarUsuario
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
            lblCodigoRolUsuario = new Label();
            lblApellidoNombreUsuario = new Label();
            lblContraseniaUsuario = new Label();
            txtCodigoRolUsuario = new TextBox();
            txtApellidoNombreUsuario = new TextBox();
            txtContraseniaUsuario = new TextBox();
            txtNombreUsuario = new TextBox();
            lblNombreUsuario = new Label();
            btnEnviarUsuario = new Button();
            btnBuscarUsuario = new Button();
            SuspendLayout();
            // 
            // lblCodigoRolUsuario
            // 
            lblCodigoRolUsuario.AutoSize = true;
            lblCodigoRolUsuario.Location = new Point(117, 246);
            lblCodigoRolUsuario.Name = "lblCodigoRolUsuario";
            lblCodigoRolUsuario.Size = new Size(82, 15);
            lblCodigoRolUsuario.TabIndex = 17;
            lblCodigoRolUsuario.Text = "Código de Rol";
            // 
            // lblApellidoNombreUsuario
            // 
            lblApellidoNombreUsuario.AutoSize = true;
            lblApellidoNombreUsuario.Location = new Point(117, 188);
            lblApellidoNombreUsuario.Name = "lblApellidoNombreUsuario";
            lblApellidoNombreUsuario.Size = new Size(107, 15);
            lblApellidoNombreUsuario.TabIndex = 16;
            lblApellidoNombreUsuario.Text = "Apellido y Nombre";
            // 
            // lblContraseniaUsuario
            // 
            lblContraseniaUsuario.AutoSize = true;
            lblContraseniaUsuario.Location = new Point(117, 123);
            lblContraseniaUsuario.Name = "lblContraseniaUsuario";
            lblContraseniaUsuario.Size = new Size(70, 15);
            lblContraseniaUsuario.TabIndex = 15;
            lblContraseniaUsuario.Text = "Contrasenia";
            // 
            // txtCodigoRolUsuario
            // 
            txtCodigoRolUsuario.Location = new Point(117, 264);
            txtCodigoRolUsuario.Name = "txtCodigoRolUsuario";
            txtCodigoRolUsuario.Size = new Size(251, 23);
            txtCodigoRolUsuario.TabIndex = 14;
            // 
            // txtApellidoNombreUsuario
            // 
            txtApellidoNombreUsuario.Location = new Point(117, 206);
            txtApellidoNombreUsuario.Name = "txtApellidoNombreUsuario";
            txtApellidoNombreUsuario.Size = new Size(251, 23);
            txtApellidoNombreUsuario.TabIndex = 13;
            // 
            // txtContraseniaUsuario
            // 
            txtContraseniaUsuario.Location = new Point(117, 141);
            txtContraseniaUsuario.Name = "txtContraseniaUsuario";
            txtContraseniaUsuario.Size = new Size(251, 23);
            txtContraseniaUsuario.TabIndex = 12;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(117, 75);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(251, 23);
            txtNombreUsuario.TabIndex = 11;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(117, 57);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(110, 15);
            lblNombreUsuario.TabIndex = 10;
            lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // btnEnviarUsuario
            // 
            btnEnviarUsuario.Location = new Point(178, 327);
            btnEnviarUsuario.Name = "btnEnviarUsuario";
            btnEnviarUsuario.Size = new Size(120, 54);
            btnEnviarUsuario.TabIndex = 9;
            btnEnviarUsuario.Text = "Enviar";
            btnEnviarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Location = new Point(374, 74);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(75, 23);
            btnBuscarUsuario.TabIndex = 18;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = true;
            btnBuscarUsuario.Click += button1_Click;
            // 
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 450);
            Controls.Add(btnBuscarUsuario);
            Controls.Add(lblCodigoRolUsuario);
            Controls.Add(lblApellidoNombreUsuario);
            Controls.Add(lblContraseniaUsuario);
            Controls.Add(txtCodigoRolUsuario);
            Controls.Add(txtApellidoNombreUsuario);
            Controls.Add(txtContraseniaUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnEnviarUsuario);
            Name = "ModificarUsuario";
            Text = "ModificarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoRolUsuario;
        private Label lblApellidoNombreUsuario;
        private Label lblContraseniaUsuario;
        private TextBox txtCodigoRolUsuario;
        private TextBox txtApellidoNombreUsuario;
        private TextBox txtContraseniaUsuario;
        private TextBox txtNombreUsuario;
        private Label lblNombreUsuario;
        private Button btnEnviarUsuario;
        private Button btnBuscarUsuario;
    }
}