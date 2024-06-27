namespace Resto.Net
{
    partial class DetallesForm
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
            EstadoLabel = new Label();
            PermanenciaLabel = new Label();
            MozoLabel = new Label();
            MesapictureBox = new PictureBox();
            ID_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)MesapictureBox).BeginInit();
            SuspendLayout();
            // 
            // EstadoLabel
            // 
            EstadoLabel.AutoSize = true;
            EstadoLabel.BackColor = Color.FromArgb(54, 61, 74);
            EstadoLabel.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EstadoLabel.ForeColor = SystemColors.ButtonHighlight;
            EstadoLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            EstadoLabel.Location = new Point(12, 270);
            EstadoLabel.Name = "EstadoLabel";
            EstadoLabel.Size = new Size(113, 34);
            EstadoLabel.TabIndex = 0;
            EstadoLabel.Text = "Estado: ";
            EstadoLabel.Click += EstadoLabel_Click;
            // 
            // PermanenciaLabel
            // 
            PermanenciaLabel.AutoSize = true;
            PermanenciaLabel.BackColor = Color.FromArgb(54, 61, 74);
            PermanenciaLabel.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PermanenciaLabel.ForeColor = SystemColors.ButtonHighlight;
            PermanenciaLabel.Location = new Point(12, 323);
            PermanenciaLabel.Name = "PermanenciaLabel";
            PermanenciaLabel.Size = new Size(193, 34);
            PermanenciaLabel.TabIndex = 1;
            PermanenciaLabel.Text = "Permanencia: ";
            // 
            // MozoLabel
            // 
            MozoLabel.AutoSize = true;
            MozoLabel.BackColor = Color.FromArgb(54, 61, 74);
            MozoLabel.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MozoLabel.ForeColor = SystemColors.ButtonHighlight;
            MozoLabel.Location = new Point(13, 389);
            MozoLabel.Name = "MozoLabel";
            MozoLabel.Size = new Size(192, 34);
            MozoLabel.TabIndex = 2;
            MozoLabel.Text = "Mozo a cargo: ";
            MozoLabel.Click += label1_Click;
            // 
            // MesapictureBox
            // 
            MesapictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            MesapictureBox.Location = new Point(416, 25);
            MesapictureBox.Name = "MesapictureBox";
            MesapictureBox.Size = new Size(305, 174);
            MesapictureBox.TabIndex = 3;
            MesapictureBox.TabStop = false;
            // 
            // ID_Label
            // 
            ID_Label.AutoSize = true;
            ID_Label.BackColor = Color.FromArgb(54, 61, 74);
            ID_Label.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID_Label.ForeColor = SystemColors.ButtonHighlight;
            ID_Label.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            ID_Label.Location = new Point(12, 211);
            ID_Label.Name = "ID_Label";
            ID_Label.Size = new Size(239, 34);
            ID_Label.TabIndex = 4;
            ID_Label.Text = "Numero de Mesa: ";
            // 
            // DetallesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 61, 74);
            ClientSize = new Size(758, 537);
            Controls.Add(ID_Label);
            Controls.Add(MesapictureBox);
            Controls.Add(MozoLabel);
            Controls.Add(PermanenciaLabel);
            Controls.Add(EstadoLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DetallesForm";
            Text = "Resto Vision Detalles";
            ((System.ComponentModel.ISupportInitialize)MesapictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal Label EstadoLabel;
        internal Label PermanenciaLabel;
        internal Label MozoLabel;
        internal PictureBox MesapictureBox;
        internal Label ID_Label;
    }
}