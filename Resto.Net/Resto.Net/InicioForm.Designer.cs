namespace Resto.Net
{
    partial class InicioForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Diseño = new Button();
            Preview = new Button();
            panel1 = new Panel();
            Vision = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Diseño
            // 
            Diseño.Anchor = AnchorStyles.None;
            Diseño.AutoSize = true;
            Diseño.BackColor = Color.FromArgb(37, 43, 52);
            Diseño.Cursor = Cursors.Hand;
            Diseño.FlatAppearance.BorderColor = Color.FromArgb(37, 43, 52);
            Diseño.FlatAppearance.BorderSize = 2;
            Diseño.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 188, 252);
            Diseño.FlatStyle = FlatStyle.Flat;
            Diseño.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Diseño.ForeColor = SystemColors.Control;
            Diseño.Location = new Point(275, 281);
            Diseño.Margin = new Padding(3, 4, 3, 4);
            Diseño.Name = "Diseño";
            Diseño.Size = new Size(149, 90);
            Diseño.TabIndex = 0;
            Diseño.Text = "Diseño";
            Diseño.UseVisualStyleBackColor = false;
            Diseño.Click += Diseño_Click;
            Diseño.MouseEnter += buton_MouseEnter;
            Diseño.MouseLeave += buton_MouseLeave;
            // 
            // Preview
            // 
            Preview.Anchor = AnchorStyles.None;
            Preview.AutoSize = true;
            Preview.BackColor = Color.FromArgb(37, 43, 52);
            Preview.FlatAppearance.BorderColor = Color.FromArgb(37, 43, 52);
            Preview.FlatAppearance.BorderSize = 2;
            Preview.FlatAppearance.MouseDownBackColor = Color.FromArgb(113, 188, 252);
            Preview.FlatStyle = FlatStyle.Flat;
            Preview.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Preview.ForeColor = SystemColors.Control;
            Preview.Location = new Point(499, 281);
            Preview.Margin = new Padding(3, 4, 3, 4);
            Preview.Name = "Preview";
            Preview.Size = new Size(149, 90);
            Preview.TabIndex = 1;
            Preview.Text = "Preview";
            Preview.UseVisualStyleBackColor = false;
            Preview.Click += Preview_Click;
            Preview.MouseEnter += buton_MouseEnter;
            Preview.MouseLeave += buton_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 61, 74);
            panel1.Controls.Add(Vision);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Diseño);
            panel1.Controls.Add(Preview);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 640);
            panel1.TabIndex = 2;
            // 
            // Vision
            // 
            Vision.Anchor = AnchorStyles.None;
            Vision.AutoSize = true;
            Vision.BackColor = Color.Transparent;
            Vision.Font = new Font("Microsoft Sans Serif", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vision.ForeColor = Color.FromArgb(113, 188, 252);
            Vision.Location = new Point(449, 138);
            Vision.Margin = new Padding(0);
            Vision.Name = "Vision";
            Vision.Size = new Size(391, 135);
            Vision.TabIndex = 3;
            Vision.Text = "Vision";
            Vision.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(54, 61, 74);
            label1.Font = new Font("Microsoft Sans Serif", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(110, 138);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 135);
            label1.TabIndex = 2;
            label1.Text = "Restó";
            label1.Click += label1_Click;
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 640);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(2461, 1392);
            MinimumSize = new Size(644, 649);
            Name = "InicioForm";
            Text = "Form1";
            FormClosing += InicioForm_FormClosing;
            Load += InicioForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Diseño;
        private Button Preview;
        private Panel panel1;
        private Label label1;
        private Label Vision;
    }
}
