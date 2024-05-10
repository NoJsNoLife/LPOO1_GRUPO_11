namespace Vistas
{
    partial class Login
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
            btnIngresar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtContrasena = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ActiveCaption;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(98, 309);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(294, 52);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(98, 111);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(98, 135);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(294, 29);
            txtNombre.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 12F);
            txtContrasena.Location = new Point(98, 215);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(294, 29);
            txtContrasena.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(98, 191);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(98, 33);
            label3.Name = "label3";
            label3.Size = new Size(73, 32);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(label3);
            Controls.Add(txtContrasena);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            MaximumSize = new Size(501, 489);
            MinimumSize = new Size(501, 489);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIngresar;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtContrasena;
        private Label label2;
        private Label label3;
    }
}