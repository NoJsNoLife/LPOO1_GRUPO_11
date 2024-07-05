namespace Vistas
{
    partial class AltaParticipantes
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
            label1 = new Label();
            label2 = new Label();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            selectSexo = new ComboBox();
            label5 = new Label();
            colorDialog1 = new ColorDialog();
            txtNacionalidad = new TextBox();
            label114 = new Label();
            txtEntrenador = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dateTimeNacimiento = new DateTimePicker();
            txtDireccion = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            label10 = new Label();
            numericAltura = new NumericUpDown();
            numericPeso = new NumericUpDown();
            label11 = new Label();
            btnAgregar = new Button();
            btnVolverSistema = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPeso).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 0;
            label1.Text = "Alta de un Participante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 14F);
            txtDni.Location = new Point(12, 79);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(195, 32);
            txtDni.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 14F);
            txtApellido.Location = new Point(13, 146);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(195, 32);
            txtApellido.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(13, 114);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 3;
            label3.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F);
            txtNombre.Location = new Point(214, 146);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 32);
            txtNombre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(214, 118);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 5;
            label4.Text = "Nombre";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectSexo
            // 
            selectSexo.DisplayMember = "Hombre";
            selectSexo.Font = new Font("Segoe UI", 14F);
            selectSexo.FormattingEnabled = true;
            selectSexo.Items.AddRange(new object[] { "Hombre", "Mujer", "No Declara" });
            selectSexo.Location = new Point(415, 146);
            selectSexo.Name = "selectSexo";
            selectSexo.Size = new Size(144, 33);
            selectSexo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(415, 118);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 8;
            label5.Text = "Sexo";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Font = new Font("Segoe UI", 14F);
            txtNacionalidad.Location = new Point(13, 216);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(195, 32);
            txtNacionalidad.TabIndex = 11;
            // 
            // label114
            // 
            label114.AutoSize = true;
            label114.Font = new Font("Segoe UI", 14F);
            label114.Location = new Point(13, 184);
            label114.Name = "label114";
            label114.Size = new Size(124, 25);
            label114.TabIndex = 10;
            label114.Text = "Nacionalidad";
            // 
            // txtEntrenador
            // 
            txtEntrenador.Font = new Font("Segoe UI", 14F);
            txtEntrenador.Location = new Point(214, 294);
            txtEntrenador.Name = "txtEntrenador";
            txtEntrenador.Size = new Size(195, 32);
            txtEntrenador.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(214, 262);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 12;
            label6.Text = "Entrenador";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(415, 262);
            label7.Name = "label7";
            label7.Size = new Size(189, 25);
            label7.TabIndex = 14;
            label7.Text = "Fecha de Nacimiento";
            // 
            // dateTimeNacimiento
            // 
            dateTimeNacimiento.CalendarFont = new Font("Segoe UI", 14F);
            dateTimeNacimiento.CustomFormat = "dd/MM/yyyy";
            dateTimeNacimiento.Font = new Font("Segoe UI", 14F);
            dateTimeNacimiento.Format = DateTimePickerFormat.Custom;
            dateTimeNacimiento.Location = new Point(415, 294);
            dateTimeNacimiento.Name = "dateTimeNacimiento";
            dateTimeNacimiento.Size = new Size(189, 32);
            dateTimeNacimiento.TabIndex = 16;
            dateTimeNacimiento.Value = new DateTime(2024, 5, 9, 0, 0, 0, 0);
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 14F);
            txtDireccion.Location = new Point(13, 294);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(195, 32);
            txtDireccion.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(13, 262);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 17;
            label8.Text = "Dirección";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(214, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 32);
            txtEmail.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(214, 51);
            label9.Name = "label9";
            label9.Size = new Size(58, 25);
            label9.TabIndex = 19;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(214, 184);
            label10.Name = "label10";
            label10.Size = new Size(105, 25);
            label10.TabIndex = 21;
            label10.Text = "Altura (cm)";
            // 
            // numericAltura
            // 
            numericAltura.Font = new Font("Segoe UI", 14F);
            numericAltura.Location = new Point(214, 217);
            numericAltura.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericAltura.Name = "numericAltura";
            numericAltura.Size = new Size(120, 32);
            numericAltura.TabIndex = 23;
            // 
            // numericPeso
            // 
            numericPeso.Font = new Font("Segoe UI", 14F);
            numericPeso.Location = new Point(340, 217);
            numericPeso.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericPeso.Name = "numericPeso";
            numericPeso.Size = new Size(120, 32);
            numericPeso.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(340, 184);
            label11.Name = "label11";
            label11.Size = new Size(88, 25);
            label11.TabIndex = 24;
            label11.Text = "Peso (kg)";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.Font = new Font("Segoe UI", 14F);
            btnAgregar.Location = new Point(275, 391);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(247, 47);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Visible = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(740, 12);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 9;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom;
            btnModificar.Font = new Font("Segoe UI", 14F);
            btnModificar.Location = new Point(275, 391);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(247, 47);
            btnModificar.TabIndex = 27;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Visible = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // AltaParticipantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            ControlBox = false;
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(numericPeso);
            Controls.Add(label11);
            Controls.Add(numericAltura);
            Controls.Add(label10);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            Controls.Add(txtDireccion);
            Controls.Add(label8);
            Controls.Add(dateTimeNacimiento);
            Controls.Add(label7);
            Controls.Add(txtEntrenador);
            Controls.Add(label6);
            Controls.Add(txtNacionalidad);
            Controls.Add(label114);
            Controls.Add(btnVolverSistema);
            Controls.Add(label5);
            Controls.Add(selectSexo);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaParticipantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaParticipantes";
            ((System.ComponentModel.ISupportInitialize)numericAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPeso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDni;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private ComboBox selectSexo;
        private Label label5;
        private ColorDialog colorDialog1;
        private TextBox txtNacionalidad;
        private Label label114;
        private TextBox txtEntrenador;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimeNacimiento;
        private TextBox txtDireccion;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private Label label10;
        private NumericUpDown numericAltura;
        private NumericUpDown numericPeso;
        private Label label11;
        private Button btnAgregar;
        private Button btnVolverSistema;
        private Button btnModificar;
    }
}