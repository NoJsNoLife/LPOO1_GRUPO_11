namespace Vistas
{
    partial class Competencias
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
            btnVolverSistema = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(503, 8);
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
            label1.Location = new Point(9, 24);
            label1.Name = "label1";
            label1.Size = new Size(366, 37);
            label1.TabIndex = 5;
            label1.Text = "Competencias (En Desarrollo)";
            // 
            // Competencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 385);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(btnVolverSistema);
            MaximumSize = new Size(580, 424);
            MinimumSize = new Size(580, 424);
            Name = "Competencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Competencias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolverSistema;
        private Label label1;
    }
}