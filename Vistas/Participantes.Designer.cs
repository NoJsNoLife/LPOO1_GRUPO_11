﻿namespace Vistas
{
    partial class Atletas
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
            components = new System.ComponentModel.Container();
            btnVolverSistema = new Button();
            label1 = new Label();
            dgwAtletas = new DataGridView();
            atletaBindingSource = new BindingSource(components);
            btnAltaParticipantes = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtDNIAtletaBuscar = new TextBox();
            lblDNIAtletaBuscar = new Label();
            rdbDNI = new RadioButton();
            rdbApellido = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgwAtletas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atletaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(740, 12);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 4;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(98, 37);
            label1.TabIndex = 5;
            label1.Text = "Atletas";
            // 
            // dgwAtletas
            // 
            dgwAtletas.AllowUserToAddRows = false;
            dgwAtletas.AllowUserToResizeColumns = false;
            dgwAtletas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwAtletas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwAtletas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAtletas.Location = new Point(12, 125);
            dgwAtletas.Name = "dgwAtletas";
            dgwAtletas.RowHeadersWidth = 62;
            dgwAtletas.Size = new Size(776, 299);
            dgwAtletas.TabIndex = 6;
            dgwAtletas.SelectionChanged += dgwAtletas_SelectionChanged;
            // 
            // atletaBindingSource
            // 
            atletaBindingSource.DataSource = typeof(ClaseBase.Atleta);
            // 
            // btnAltaParticipantes
            // 
            btnAltaParticipantes.BackColor = Color.Green;
            btnAltaParticipantes.Font = new Font("Segoe UI", 12F);
            btnAltaParticipantes.ForeColor = SystemColors.ButtonFace;
            btnAltaParticipantes.Location = new Point(194, 12);
            btnAltaParticipantes.Name = "btnAltaParticipantes";
            btnAltaParticipantes.Size = new Size(176, 48);
            btnAltaParticipantes.TabIndex = 7;
            btnAltaParticipantes.Text = "Registrar Atleta";
            btnAltaParticipantes.UseVisualStyleBackColor = false;
            btnAltaParticipantes.Click += btnAltaParticipantes_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DodgerBlue;
            btnModificar.Enabled = false;
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.ForeColor = SystemColors.ButtonFace;
            btnModificar.Location = new Point(376, 12);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(176, 48);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar Atleta";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(558, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(176, 48);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar Atleta";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtDNIAtletaBuscar
            // 
            txtDNIAtletaBuscar.Location = new Point(60, 71);
            txtDNIAtletaBuscar.Name = "txtDNIAtletaBuscar";
            txtDNIAtletaBuscar.Size = new Size(728, 23);
            txtDNIAtletaBuscar.TabIndex = 14;
            txtDNIAtletaBuscar.TextChanged += txtDNIAtletaBuscar_TextChanged;
            // 
            // lblDNIAtletaBuscar
            // 
            lblDNIAtletaBuscar.AutoSize = true;
            lblDNIAtletaBuscar.Location = new Point(12, 74);
            lblDNIAtletaBuscar.Name = "lblDNIAtletaBuscar";
            lblDNIAtletaBuscar.Size = new Size(42, 15);
            lblDNIAtletaBuscar.TabIndex = 13;
            lblDNIAtletaBuscar.Text = "Buscar";
            // 
            // rdbDNI
            // 
            rdbDNI.AutoSize = true;
            rdbDNI.Location = new Point(16, 100);
            rdbDNI.Name = "rdbDNI";
            rdbDNI.Size = new Size(112, 19);
            rdbDNI.TabIndex = 15;
            rdbDNI.TabStop = true;
            rdbDNI.Text = "Ordenar por DNI";
            rdbDNI.UseVisualStyleBackColor = true;
            rdbDNI.CheckedChanged += rdbDNI_CheckedChanged;
            // 
            // rdbApellido
            // 
            rdbApellido.AutoSize = true;
            rdbApellido.Location = new Point(134, 100);
            rdbApellido.Name = "rdbApellido";
            rdbApellido.Size = new Size(136, 19);
            rdbApellido.TabIndex = 16;
            rdbApellido.TabStop = true;
            rdbApellido.Text = "Ordenar por Apellido";
            rdbApellido.UseVisualStyleBackColor = true;
            rdbApellido.CheckedChanged += rdbApellido_CheckedChanged;
            // 
            // Atletas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 436);
            ControlBox = false;
            Controls.Add(rdbApellido);
            Controls.Add(rdbDNI);
            Controls.Add(txtDNIAtletaBuscar);
            Controls.Add(lblDNIAtletaBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAltaParticipantes);
            Controls.Add(dgwAtletas);
            Controls.Add(label1);
            Controls.Add(btnVolverSistema);
            MaximumSize = new Size(812, 475);
            MinimumSize = new Size(812, 439);
            Name = "Atletas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atletas";
            Load += Atletas_Load;
            VisibleChanged += Atletas_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dgwAtletas).EndInit();
            ((System.ComponentModel.ISupportInitialize)atletaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolverSistema;
        private Label label1;
        private DataGridView dgwAtletas;
        private BindingSource atletaBindingSource;
        private Button btnAltaParticipantes;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtDNIAtletaBuscar;
        private Label lblDNIAtletaBuscar;
        private RadioButton rdbDNI;
        private RadioButton rdbApellido;
    }
}