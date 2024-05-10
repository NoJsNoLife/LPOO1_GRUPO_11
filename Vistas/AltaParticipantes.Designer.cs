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
            ((System.ComponentModel.ISupportInitialize)numericAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPeso).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(379, 48);
            label1.TabIndex = 0;
            label1.Text = "Alta de un Participante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(17, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 38);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 14F);
            txtDni.Location = new Point(17, 132);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(277, 45);
            txtDni.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 14F);
            txtApellido.Location = new Point(19, 243);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(277, 45);
            txtApellido.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(19, 190);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 38);
            label3.TabIndex = 3;
            label3.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F);
            txtNombre.Location = new Point(306, 243);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(277, 45);
            txtNombre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(306, 197);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 38);
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
            selectSexo.Location = new Point(593, 243);
            selectSexo.Margin = new Padding(4, 5, 4, 5);
            selectSexo.Name = "selectSexo";
            selectSexo.Size = new Size(204, 46);
            selectSexo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(593, 197);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 38);
            label5.TabIndex = 8;
            label5.Text = "Sexo";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Font = new Font("Segoe UI", 14F);
            txtNacionalidad.Location = new Point(19, 360);
            txtNacionalidad.Margin = new Padding(4, 5, 4, 5);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(277, 45);
            txtNacionalidad.TabIndex = 11;
            // 
            // label114
            // 
            label114.AutoSize = true;
            label114.Font = new Font("Segoe UI", 14F);
            label114.Location = new Point(19, 307);
            label114.Margin = new Padding(4, 0, 4, 0);
            label114.Name = "label114";
            label114.Size = new Size(178, 38);
            label114.TabIndex = 10;
            label114.Text = "Nacionalidad";
            // 
            // txtEntrenador
            // 
            txtEntrenador.Font = new Font("Segoe UI", 14F);
            txtEntrenador.Location = new Point(306, 490);
            txtEntrenador.Margin = new Padding(4, 5, 4, 5);
            txtEntrenador.Name = "txtEntrenador";
            txtEntrenador.Size = new Size(277, 45);
            txtEntrenador.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(306, 437);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(153, 38);
            label6.TabIndex = 12;
            label6.Text = "Entrenador";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(593, 437);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(278, 38);
            label7.TabIndex = 14;
            label7.Text = "Fecha de Nacimiento";
            // 
            // dateTimeNacimiento
            // 
            dateTimeNacimiento.CalendarFont = new Font("Segoe UI", 14F);
            dateTimeNacimiento.CustomFormat = "dd/MM/yyyy";
            dateTimeNacimiento.Font = new Font("Segoe UI", 14F);
            dateTimeNacimiento.Format = DateTimePickerFormat.Custom;
            dateTimeNacimiento.Location = new Point(593, 490);
            dateTimeNacimiento.Margin = new Padding(4, 5, 4, 5);
            dateTimeNacimiento.Name = "dateTimeNacimiento";
            dateTimeNacimiento.Size = new Size(268, 45);
            dateTimeNacimiento.TabIndex = 16;
            dateTimeNacimiento.Value = new DateTime(2024, 5, 9, 0, 0, 0, 0);
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 14F);
            txtDireccion.Location = new Point(19, 490);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(277, 45);
            txtDireccion.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(19, 437);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(134, 38);
            label8.TabIndex = 17;
            label8.Text = "Dirección";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(306, 132);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(277, 45);
            txtEmail.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(306, 85);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(83, 38);
            label9.TabIndex = 19;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(306, 307);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(152, 38);
            label10.TabIndex = 21;
            label10.Text = "Altura (cm)";
            // 
            // numericAltura
            // 
            numericAltura.Font = new Font("Segoe UI", 14F);
            numericAltura.Location = new Point(306, 362);
            numericAltura.Margin = new Padding(4, 5, 4, 5);
            numericAltura.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericAltura.Name = "numericAltura";
            numericAltura.Size = new Size(171, 45);
            numericAltura.TabIndex = 23;
            // 
            // numericPeso
            // 
            numericPeso.Font = new Font("Segoe UI", 14F);
            numericPeso.Location = new Point(486, 362);
            numericPeso.Margin = new Padding(4, 5, 4, 5);
            numericPeso.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericPeso.Name = "numericPeso";
            numericPeso.Size = new Size(171, 45);
            numericPeso.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(486, 307);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(129, 38);
            label11.TabIndex = 24;
            label11.Text = "Peso (kg)";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.Font = new Font("Segoe UI", 14F);
            btnAgregar.Location = new Point(393, 652);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(353, 78);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(1057, 20);
            btnVolverSistema.Margin = new Padding(4, 5, 4, 5);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(69, 80);
            btnVolverSistema.TabIndex = 9;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // AltaParticipantes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "AltaParticipantes";
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
    }
}