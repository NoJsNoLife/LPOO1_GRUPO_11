namespace Vistas
{
    partial class ListarResultadosEvento
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
            dgwCompetencias = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            lblDescalificados = new Label();
            lblAbandonos = new Label();
            label6 = new Label();
            lblParticiparon = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgw_Participantes = new DataGridView();
            label7 = new Label();
            btnVolverSistema = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwCompetencias).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Participantes).BeginInit();
            SuspendLayout();
            // 
            // dgwCompetencias
            // 
            dgwCompetencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCompetencias.Location = new Point(15, 48);
            dgwCompetencias.Margin = new Padding(3, 4, 3, 4);
            dgwCompetencias.Name = "dgwCompetencias";
            dgwCompetencias.RowHeadersWidth = 62;
            dgwCompetencias.Size = new Size(309, 536);
            dgwCompetencias.TabIndex = 9;
            dgwCompetencias.CurrentCellChanged += dgwCompetencias_CurrentCellChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 5;
            label1.Text = "Seleccionar la Competencia";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDescalificados);
            panel1.Controls.Add(lblAbandonos);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblParticiparon);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(330, 12);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 98);
            panel1.TabIndex = 10;
            // 
            // lblDescalificados
            // 
            lblDescalificados.AutoSize = true;
            lblDescalificados.Location = new Point(144, 62);
            lblDescalificados.Name = "lblDescalificados";
            lblDescalificados.Size = new Size(18, 20);
            lblDescalificados.TabIndex = 17;
            lblDescalificados.Text = "...";
            // 
            // lblAbandonos
            // 
            lblAbandonos.AutoSize = true;
            lblAbandonos.Location = new Point(144, 38);
            lblAbandonos.Name = "lblAbandonos";
            lblAbandonos.Size = new Size(18, 20);
            lblAbandonos.TabIndex = 16;
            lblAbandonos.Text = "...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 10);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 15;
            label6.Text = "Participaron";
            // 
            // lblParticiparon
            // 
            lblParticiparon.AutoSize = true;
            lblParticiparon.Location = new Point(144, 10);
            lblParticiparon.Name = "lblParticiparon";
            lblParticiparon.Size = new Size(18, 20);
            lblParticiparon.TabIndex = 14;
            lblParticiparon.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 62);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 13;
            label4.Text = "Descalificados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 36);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 12;
            label3.Text = "Abandonos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 11;
            label2.Text = "Datos de la competencia";
            // 
            // dgw_Participantes
            // 
            dgw_Participantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Participantes.Location = new Point(330, 140);
            dgw_Participantes.Margin = new Padding(3, 4, 3, 4);
            dgw_Participantes.Name = "dgw_Participantes";
            dgw_Participantes.RowHeadersWidth = 62;
            dgw_Participantes.Size = new Size(597, 446);
            dgw_Participantes.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(846, 116);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 16;
            label7.Text = "Resultados";
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(999, 6);
            btnVolverSistema.Margin = new Padding(3, 4, 3, 4);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(55, 64);
            btnVolverSistema.TabIndex = 17;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // ListarResultadosEvento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 600);
            Controls.Add(btnVolverSistema);
            Controls.Add(label7);
            Controls.Add(dgw_Participantes);
            Controls.Add(panel1);
            Controls.Add(dgwCompetencias);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListarResultadosEvento";
            Text = "ListarResultadosEvento";
            Load += Resultados_load;
            ((System.ComponentModel.ISupportInitialize)dgwCompetencias).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Participantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwCompetencias;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label lblParticiparon;
        private Label label4;
        private DataGridView dgw_Participantes;
        private Label label7;
        private Button btnVolverSistema;
        private Label lblDescalificados;
        private Label lblAbandonos;
    }
}