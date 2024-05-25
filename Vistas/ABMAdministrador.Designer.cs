namespace Vistas
{
    partial class ABMAdministrador
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
            btnRegistrarUsuario = new Button();
            btnVerUsuarios = new Button();
            btnVolverSistema = new Button();
            SuspendLayout();
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Location = new Point(94, 91);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(107, 75);
            btnRegistrarUsuario.TabIndex = 0;
            btnRegistrarUsuario.Text = "Registrar Usuario";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // btnVerUsuarios
            // 
            btnVerUsuarios.Location = new Point(208, 91);
            btnVerUsuarios.Name = "btnVerUsuarios";
            btnVerUsuarios.Size = new Size(107, 75);
            btnVerUsuarios.TabIndex = 2;
            btnVerUsuarios.Text = "Ver Usuarios";
            btnVerUsuarios.UseVisualStyleBackColor = true;
            btnVerUsuarios.Click += btnVerUsuarios_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(358, 8);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 37;
            btnVolverSistema.UseVisualStyleBackColor = true;
            // 
            // ABMAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 277);
            Controls.Add(btnVolverSistema);
            Controls.Add(btnVerUsuarios);
            Controls.Add(btnRegistrarUsuario);
            MaximumSize = new Size(435, 316);
            MinimumSize = new Size(435, 316);
            Name = "ABMAdministrador";
            Text = "ABMAdministrador";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarUsuario;
        private Button btnVerUsuarios;
        private Button btnVolverSistema;
    }
}