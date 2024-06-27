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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            Diseño = new Button();
            Preview = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Vision = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            Diseño.Location = new Point(341, 554);
            Diseño.Margin = new Padding(4, 5, 4, 5);
            Diseño.Name = "Diseño";
            Diseño.Size = new Size(186, 112);
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
            Preview.Location = new Point(603, 554);
            Preview.Margin = new Padding(4, 5, 4, 5);
            Preview.Name = "Preview";
            Preview.Size = new Size(208, 112);
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
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Vision);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Diseño);
            panel1.Controls.Add(Preview);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.MinimumSize = new Size(980, 760);
            panel1.Name = "panel1";
            panel1.Size = new Size(1132, 800);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.Resto_Icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(395, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Vision
            // 
            Vision.Anchor = AnchorStyles.None;
            Vision.AutoSize = true;
            Vision.BackColor = Color.Transparent;
            Vision.Font = new Font("Microsoft Sans Serif", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vision.ForeColor = Color.FromArgb(113, 188, 252);
            Vision.Location = new Point(559, 369);
            Vision.Margin = new Padding(0);
            Vision.Name = "Vision";
            Vision.Size = new Size(469, 163);
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
            label1.Location = new Point(150, 369);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(450, 163);
            label1.TabIndex = 2;
            label1.Text = "Restó";
            label1.Click += label1_Click;
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 800);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(3071, 1726);
            MinimumSize = new Size(980, 797);
            Name = "InicioForm";
            Text = "Resto Vision";
            FormClosing += InicioForm_FormClosing;
            Load += InicioForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Diseño;
        private Button Preview;
        private Panel panel1;
        private Label label1;
        private Label Vision;
        private PictureBox pictureBox1;
    }
}
