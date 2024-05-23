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
            btnEnviarUsuario = new Button();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            txtContraseniaUsuario = new TextBox();
            txtApellidoNombreUsuario = new TextBox();
            txtCodigoRolUsuario = new TextBox();
            lblContraseniaUsuario = new Label();
            lblApellidoNombreUsuario = new Label();
            lblCodigoRolUsuario = new Label();
            SuspendLayout();
            // 
            // btnEnviarUsuario
            // 
            btnEnviarUsuario.Location = new Point(189, 343);
            btnEnviarUsuario.Name = "btnEnviarUsuario";
            btnEnviarUsuario.Size = new Size(120, 54);
            btnEnviarUsuario.TabIndex = 0;
            btnEnviarUsuario.Text = "Enviar";
            btnEnviarUsuario.UseVisualStyleBackColor = true;
            btnEnviarUsuario.Click += btnEnviarUsuario_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(128, 73);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(110, 15);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "Nombre de Usuario";
            lblNombreUsuario.Click += label1_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(128, 91);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(251, 23);
            txtNombreUsuario.TabIndex = 2;
            // 
            // txtContraseniaUsuario
            // 
            txtContraseniaUsuario.Location = new Point(128, 157);
            txtContraseniaUsuario.Name = "txtContraseniaUsuario";
            txtContraseniaUsuario.Size = new Size(251, 23);
            txtContraseniaUsuario.TabIndex = 3;
            // 
            // txtApellidoNombreUsuario
            // 
            txtApellidoNombreUsuario.Location = new Point(128, 222);
            txtApellidoNombreUsuario.Name = "txtApellidoNombreUsuario";
            txtApellidoNombreUsuario.Size = new Size(251, 23);
            txtApellidoNombreUsuario.TabIndex = 4;
            // 
            // txtCodigoRolUsuario
            // 
            txtCodigoRolUsuario.Location = new Point(128, 280);
            txtCodigoRolUsuario.Name = "txtCodigoRolUsuario";
            txtCodigoRolUsuario.Size = new Size(251, 23);
            txtCodigoRolUsuario.TabIndex = 5;
            // 
            // lblContraseniaUsuario
            // 
            lblContraseniaUsuario.AutoSize = true;
            lblContraseniaUsuario.Location = new Point(128, 139);
            lblContraseniaUsuario.Name = "lblContraseniaUsuario";
            lblContraseniaUsuario.Size = new Size(70, 15);
            lblContraseniaUsuario.TabIndex = 6;
            lblContraseniaUsuario.Text = "Contrasenia";
            // 
            // lblApellidoNombreUsuario
            // 
            lblApellidoNombreUsuario.AutoSize = true;
            lblApellidoNombreUsuario.Location = new Point(128, 204);
            lblApellidoNombreUsuario.Name = "lblApellidoNombreUsuario";
            lblApellidoNombreUsuario.Size = new Size(107, 15);
            lblApellidoNombreUsuario.TabIndex = 7;
            lblApellidoNombreUsuario.Text = "Apellido y Nombre";
            // 
            // lblCodigoRolUsuario
            // 
            lblCodigoRolUsuario.AutoSize = true;
            lblCodigoRolUsuario.Location = new Point(128, 262);
            lblCodigoRolUsuario.Name = "lblCodigoRolUsuario";
            lblCodigoRolUsuario.Size = new Size(82, 15);
            lblCodigoRolUsuario.TabIndex = 8;
            lblCodigoRolUsuario.Text = "Código de Rol";
            // 
            // AltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(lblCodigoRolUsuario);
            Controls.Add(lblApellidoNombreUsuario);
            Controls.Add(lblContraseniaUsuario);
            Controls.Add(txtCodigoRolUsuario);
            Controls.Add(txtApellidoNombreUsuario);
            Controls.Add(txtContraseniaUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnEnviarUsuario);
            Name = "AltaUsuario";
            Text = "AltaUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviarUsuario;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseniaUsuario;
        private TextBox txtApellidoNombreUsuario;
        private TextBox txtCodigoRolUsuario;
        private Label lblContraseniaUsuario;
        private Label lblApellidoNombreUsuario;
        private Label lblCodigoRolUsuario;
    }
}