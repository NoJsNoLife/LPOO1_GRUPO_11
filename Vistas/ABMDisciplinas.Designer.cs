namespace Vistas
{
    partial class ABMDisciplinas
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
            dgwDisciplinas = new DataGridView();
            label1 = new Label();
            txtNombreDis = new TextBox();
            label2 = new Label();
            txtDescripcionDis = new TextBox();
            btnVolverSistema = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAgregarDisciplina = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwDisciplinas).BeginInit();
            SuspendLayout();
            // 
            // dgwDisciplinas
            // 
            dgwDisciplinas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDisciplinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDisciplinas.Location = new Point(12, 12);
            dgwDisciplinas.Name = "dgwDisciplinas";
            dgwDisciplinas.Size = new Size(490, 237);
            dgwDisciplinas.TabIndex = 0;
            dgwDisciplinas.CurrentCellChanged += dgwDisciplinas_CurrentCellChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(558, 57);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombreDis
            // 
            txtNombreDis.Location = new Point(558, 75);
            txtNombreDis.Name = "txtNombreDis";
            txtNombreDis.Size = new Size(283, 23);
            txtNombreDis.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(558, 124);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripción";
            // 
            // txtDescripcionDis
            // 
            txtDescripcionDis.Location = new Point(558, 142);
            txtDescripcionDis.Name = "txtDescripcionDis";
            txtDescripcionDis.Size = new Size(283, 23);
            txtDescripcionDis.TabIndex = 4;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(847, 12);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 38;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.MenuHighlight;
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(558, 203);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 46);
            btnEditar.TabIndex = 39;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Brown;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(720, 203);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 46);
            btnEliminar.TabIndex = 40;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregarDisciplina
            // 
            btnAgregarDisciplina.BackColor = Color.ForestGreen;
            btnAgregarDisciplina.ForeColor = SystemColors.HighlightText;
            btnAgregarDisciplina.Location = new Point(750, 12);
            btnAgregarDisciplina.Name = "btnAgregarDisciplina";
            btnAgregarDisciplina.Size = new Size(91, 48);
            btnAgregarDisciplina.TabIndex = 41;
            btnAgregarDisciplina.Text = "Agregar";
            btnAgregarDisciplina.UseVisualStyleBackColor = false;
            btnAgregarDisciplina.Click += btnAgregarDisciplina_Click;
            // 
            // ABMDisciplinas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 450);
            Controls.Add(btnAgregarDisciplina);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnVolverSistema);
            Controls.Add(txtDescripcionDis);
            Controls.Add(label2);
            Controls.Add(txtNombreDis);
            Controls.Add(label1);
            Controls.Add(dgwDisciplinas);
            Name = "ABMDisciplinas";
            Text = "ABMDisciplinas";
            Load += ABMDisciplinas_Load;
            ((System.ComponentModel.ISupportInitialize)dgwDisciplinas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgwDisciplinas;
        private Label label1;
        private TextBox txtNombreDis;
        private Label label2;
        private TextBox txtDescripcionDis;
        private Button btnVolverSistema;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnAgregarDisciplina;
    }
}