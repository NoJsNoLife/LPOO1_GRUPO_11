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
            btnEnviarUsuario = new Button();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            txtContraseniaUsuario = new TextBox();
            txtApellidoNombreUsuario = new TextBox();
            lblContraseniaUsuario = new Label();
            lblApellidoNombreUsuario = new Label();
            lblCodigoRolUsuario = new Label();
            cmbRoles = new ComboBox();
            dgwUsuarios = new DataGridView();
            lblNombreUsuarioBuscar = new Label();
            txtNombreUsuarioBuscar = new TextBox();
            btnBorrar = new Button();
            btnVolverSistema = new Button();
            btnAgregarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnEnviarUsuario
            // 
            btnEnviarUsuario.BackColor = Color.DodgerBlue;
            btnEnviarUsuario.ForeColor = SystemColors.ButtonFace;
            btnEnviarUsuario.Location = new Point(814, 538);
            btnEnviarUsuario.Margin = new Padding(4, 5, 4, 5);
            btnEnviarUsuario.Name = "btnEnviarUsuario";
            btnEnviarUsuario.Size = new Size(171, 90);
            btnEnviarUsuario.TabIndex = 0;
            btnEnviarUsuario.Text = "Modificar";
            btnEnviarUsuario.UseVisualStyleBackColor = false;
            btnEnviarUsuario.Click += btnModificar_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(814, 88);
            lblNombreUsuario.Margin = new Padding(4, 0, 4, 0);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(168, 25);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(814, 118);
            txtNombreUsuario.Margin = new Padding(4, 5, 4, 5);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(357, 31);
            txtNombreUsuario.TabIndex = 2;
            // 
            // txtContraseniaUsuario
            // 
            txtContraseniaUsuario.Location = new Point(814, 228);
            txtContraseniaUsuario.Margin = new Padding(4, 5, 4, 5);
            txtContraseniaUsuario.Name = "txtContraseniaUsuario";
            txtContraseniaUsuario.Size = new Size(357, 31);
            txtContraseniaUsuario.TabIndex = 3;
            // 
            // txtApellidoNombreUsuario
            // 
            txtApellidoNombreUsuario.Location = new Point(814, 337);
            txtApellidoNombreUsuario.Margin = new Padding(4, 5, 4, 5);
            txtApellidoNombreUsuario.Name = "txtApellidoNombreUsuario";
            txtApellidoNombreUsuario.Size = new Size(357, 31);
            txtApellidoNombreUsuario.TabIndex = 4;
            // 
            // lblContraseniaUsuario
            // 
            lblContraseniaUsuario.AutoSize = true;
            lblContraseniaUsuario.Location = new Point(814, 198);
            lblContraseniaUsuario.Margin = new Padding(4, 0, 4, 0);
            lblContraseniaUsuario.Name = "lblContraseniaUsuario";
            lblContraseniaUsuario.Size = new Size(101, 25);
            lblContraseniaUsuario.TabIndex = 6;
            lblContraseniaUsuario.Text = "Contraseña";
            // 
            // lblApellidoNombreUsuario
            // 
            lblApellidoNombreUsuario.AutoSize = true;
            lblApellidoNombreUsuario.Location = new Point(814, 307);
            lblApellidoNombreUsuario.Margin = new Padding(4, 0, 4, 0);
            lblApellidoNombreUsuario.Name = "lblApellidoNombreUsuario";
            lblApellidoNombreUsuario.Size = new Size(163, 25);
            lblApellidoNombreUsuario.TabIndex = 7;
            lblApellidoNombreUsuario.Text = "Apellido y Nombre";
            // 
            // lblCodigoRolUsuario
            // 
            lblCodigoRolUsuario.AutoSize = true;
            lblCodigoRolUsuario.Location = new Point(814, 403);
            lblCodigoRolUsuario.Margin = new Padding(4, 0, 4, 0);
            lblCodigoRolUsuario.Name = "lblCodigoRolUsuario";
            lblCodigoRolUsuario.Size = new Size(37, 25);
            lblCodigoRolUsuario.TabIndex = 8;
            lblCodigoRolUsuario.Text = "Rol";
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(814, 433);
            cmbRoles.Margin = new Padding(4, 5, 4, 5);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(357, 33);
            cmbRoles.TabIndex = 9;
            // 
            // dgwUsuarios
            // 
            dgwUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwUsuarios.Location = new Point(46, 147);
            dgwUsuarios.Margin = new Padding(4, 5, 4, 5);
            dgwUsuarios.Name = "dgwUsuarios";
            dgwUsuarios.RowHeadersWidth = 62;
            dgwUsuarios.Size = new Size(710, 482);
            dgwUsuarios.TabIndex = 10;
            dgwUsuarios.CurrentCellChanged += dgwUsuarios_CurrentCellChanged;
            // 
            // lblNombreUsuarioBuscar
            // 
            lblNombreUsuarioBuscar.AutoSize = true;
            lblNombreUsuarioBuscar.Location = new Point(46, 88);
            lblNombreUsuarioBuscar.Margin = new Padding(4, 0, 4, 0);
            lblNombreUsuarioBuscar.Name = "lblNombreUsuarioBuscar";
            lblNombreUsuarioBuscar.Size = new Size(168, 25);
            lblNombreUsuarioBuscar.TabIndex = 11;
            lblNombreUsuarioBuscar.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuarioBuscar
            // 
            txtNombreUsuarioBuscar.Location = new Point(211, 83);
            txtNombreUsuarioBuscar.Margin = new Padding(4, 5, 4, 5);
            txtNombreUsuarioBuscar.Name = "txtNombreUsuarioBuscar";
            txtNombreUsuarioBuscar.Size = new Size(543, 31);
            txtNombreUsuarioBuscar.TabIndex = 12;
            txtNombreUsuarioBuscar.TextChanged += txtNombreUsuarioBuscar_TextChanged;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Crimson;
            btnBorrar.ForeColor = SystemColors.ButtonFace;
            btnBorrar.Location = new Point(1000, 538);
            btnBorrar.Margin = new Padding(4, 5, 4, 5);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(171, 90);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(1249, 13);
            btnVolverSistema.Margin = new Padding(4, 5, 4, 5);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(69, 80);
            btnVolverSistema.TabIndex = 37;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.Green;
            btnAgregarUsuario.ForeColor = SystemColors.ButtonFace;
            btnAgregarUsuario.Location = new Point(1071, 13);
            btnAgregarUsuario.Margin = new Padding(4, 5, 4, 5);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(169, 80);
            btnAgregarUsuario.TabIndex = 38;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // ABMUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 750);
            ControlBox = false;
            Controls.Add(btnAgregarUsuario);
            Controls.Add(btnVolverSistema);
            Controls.Add(btnBorrar);
            Controls.Add(txtNombreUsuarioBuscar);
            Controls.Add(lblNombreUsuarioBuscar);
            Controls.Add(dgwUsuarios);
            Controls.Add(cmbRoles);
            Controls.Add(lblCodigoRolUsuario);
            Controls.Add(lblApellidoNombreUsuario);
            Controls.Add(lblContraseniaUsuario);
            Controls.Add(txtApellidoNombreUsuario);
            Controls.Add(txtContraseniaUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnEnviarUsuario);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ABMUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaUsuario";
            Load += AltaUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgwUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviarUsuario;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseniaUsuario;
        private TextBox txtApellidoNombreUsuario;
        private Label lblContraseniaUsuario;
        private Label lblApellidoNombreUsuario;
        private Label lblCodigoRolUsuario;
        private ComboBox cmbRoles;
        private DataGridView dgwUsuarios;
        private Label lblNombreUsuarioBuscar;
        private TextBox txtNombreUsuarioBuscar;
        private Button btnBorrar;
        private Button btnVolverSistema;
        private Button btnAgregarUsuario;
    }
}