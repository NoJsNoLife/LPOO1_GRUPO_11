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
            btnEnviarUsuario.Location = new Point(570, 323);
            btnEnviarUsuario.Name = "btnEnviarUsuario";
            btnEnviarUsuario.Size = new Size(120, 54);
            btnEnviarUsuario.TabIndex = 0;
            btnEnviarUsuario.Text = "Modificar";
            btnEnviarUsuario.UseVisualStyleBackColor = true;
            btnEnviarUsuario.Click += btnModificar_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(570, 53);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(110, 15);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(570, 71);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(251, 23);
            txtNombreUsuario.TabIndex = 2;
            // 
            // txtContraseniaUsuario
            // 
            txtContraseniaUsuario.Location = new Point(570, 137);
            txtContraseniaUsuario.Name = "txtContraseniaUsuario";
            txtContraseniaUsuario.Size = new Size(251, 23);
            txtContraseniaUsuario.TabIndex = 3;
            // 
            // txtApellidoNombreUsuario
            // 
            txtApellidoNombreUsuario.Location = new Point(570, 202);
            txtApellidoNombreUsuario.Name = "txtApellidoNombreUsuario";
            txtApellidoNombreUsuario.Size = new Size(251, 23);
            txtApellidoNombreUsuario.TabIndex = 4;
            // 
            // lblContraseniaUsuario
            // 
            lblContraseniaUsuario.AutoSize = true;
            lblContraseniaUsuario.Location = new Point(570, 119);
            lblContraseniaUsuario.Name = "lblContraseniaUsuario";
            lblContraseniaUsuario.Size = new Size(67, 15);
            lblContraseniaUsuario.TabIndex = 6;
            lblContraseniaUsuario.Text = "Contraseña";
            // 
            // lblApellidoNombreUsuario
            // 
            lblApellidoNombreUsuario.AutoSize = true;
            lblApellidoNombreUsuario.Location = new Point(570, 184);
            lblApellidoNombreUsuario.Name = "lblApellidoNombreUsuario";
            lblApellidoNombreUsuario.Size = new Size(107, 15);
            lblApellidoNombreUsuario.TabIndex = 7;
            lblApellidoNombreUsuario.Text = "Apellido y Nombre";
            // 
            // lblCodigoRolUsuario
            // 
            lblCodigoRolUsuario.AutoSize = true;
            lblCodigoRolUsuario.Location = new Point(570, 242);
            lblCodigoRolUsuario.Name = "lblCodigoRolUsuario";
            lblCodigoRolUsuario.Size = new Size(82, 15);
            lblCodigoRolUsuario.TabIndex = 8;
            lblCodigoRolUsuario.Text = "Código de Rol";
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(570, 260);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(251, 23);
            cmbRoles.TabIndex = 9;
            // 
            // dgwUsuarios
            // 
            dgwUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwUsuarios.Location = new Point(32, 88);
            dgwUsuarios.Name = "dgwUsuarios";
            dgwUsuarios.RowHeadersWidth = 62;
            dgwUsuarios.Size = new Size(497, 289);
            dgwUsuarios.TabIndex = 10;
            dgwUsuarios.CurrentCellChanged += dgwUsuarios_CurrentCellChanged;
            // 
            // lblNombreUsuarioBuscar
            // 
            lblNombreUsuarioBuscar.AutoSize = true;
            lblNombreUsuarioBuscar.Location = new Point(32, 53);
            lblNombreUsuarioBuscar.Name = "lblNombreUsuarioBuscar";
            lblNombreUsuarioBuscar.Size = new Size(110, 15);
            lblNombreUsuarioBuscar.TabIndex = 11;
            lblNombreUsuarioBuscar.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuarioBuscar
            // 
            txtNombreUsuarioBuscar.Location = new Point(148, 50);
            txtNombreUsuarioBuscar.Name = "txtNombreUsuarioBuscar";
            txtNombreUsuarioBuscar.Size = new Size(381, 23);
            txtNombreUsuarioBuscar.TabIndex = 12;
            txtNombreUsuarioBuscar.TextChanged += txtNombreUsuarioBuscar_TextChanged;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(700, 323);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(120, 54);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(874, 8);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 37;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(750, 8);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(118, 48);
            btnAgregarUsuario.TabIndex = 38;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // ABMUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 450);
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