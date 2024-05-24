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
            btnRegistrarUsuario.Location = new Point(135, 152);
            btnRegistrarUsuario.Margin = new Padding(4, 5, 4, 5);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(153, 125);
            btnRegistrarUsuario.TabIndex = 0;
            btnRegistrarUsuario.Text = "Registrar Usuario";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // btnVerUsuarios
            // 
            btnVerUsuarios.Location = new Point(297, 152);
            btnVerUsuarios.Margin = new Padding(4, 5, 4, 5);
            btnVerUsuarios.Name = "btnVerUsuarios";
            btnVerUsuarios.Size = new Size(153, 125);
            btnVerUsuarios.TabIndex = 2;
            btnVerUsuarios.Text = "Ver Usuarios";
            btnVerUsuarios.UseVisualStyleBackColor = true;
            btnVerUsuarios.Click += btnVerUsuarios_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(511, 14);
            btnVolverSistema.Margin = new Padding(4, 5, 4, 5);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(69, 80);
            btnVolverSistema.TabIndex = 37;
            btnVolverSistema.UseVisualStyleBackColor = true;
            // 
            // ABMAdministrador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 444);
            Controls.Add(btnVolverSistema);
            Controls.Add(btnVerUsuarios);
            Controls.Add(btnRegistrarUsuario);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(615, 500);
            MinimumSize = new Size(615, 500);
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