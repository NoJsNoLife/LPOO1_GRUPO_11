namespace Vistas
{
    partial class ABMUsuarios
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
            btnAgregarUsuario = new Button();
            btnBorrarUsuario = new Button();
            btnModificarUsuario = new Button();
            SuspendLayout();
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(220, 161);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(107, 75);
            btnAgregarUsuario.TabIndex = 0;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += button1_Click;
            // 
            // btnBorrarUsuario
            // 
            btnBorrarUsuario.Location = new Point(446, 161);
            btnBorrarUsuario.Name = "btnBorrarUsuario";
            btnBorrarUsuario.Size = new Size(107, 75);
            btnBorrarUsuario.TabIndex = 1;
            btnBorrarUsuario.Text = "Borrar";
            btnBorrarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(333, 161);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(107, 75);
            btnModificarUsuario.TabIndex = 2;
            btnModificarUsuario.Text = "Modificar";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // ABMUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificarUsuario);
            Controls.Add(btnBorrarUsuario);
            Controls.Add(btnAgregarUsuario);
            Name = "ABMUsuarios";
            Text = "ABMUsuarios";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarUsuario;
        private Button btnBorrarUsuario;
        private Button btnModificarUsuario;
    }
}