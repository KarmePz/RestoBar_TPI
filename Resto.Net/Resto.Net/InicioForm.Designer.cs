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
            Previuw = new Button();
            SuspendLayout();
            // 
            // Diseño
            // 
            Diseño.Location = new Point(258, 269);
            Diseño.Margin = new Padding(4, 5, 4, 5);
            Diseño.Name = "Diseño";
            Diseño.Size = new Size(186, 108);
            Diseño.TabIndex = 0;
            Diseño.Text = "Diseño";
            Diseño.UseVisualStyleBackColor = true;
            Diseño.Click += Diseño_Click;
            // 
            // Previuw
            // 
            Previuw.Location = new Point(631, 264);
            Previuw.Margin = new Padding(4, 5, 4, 5);
            Previuw.Name = "Previuw";
            Previuw.Size = new Size(186, 113);
            Previuw.TabIndex = 1;
            Previuw.Text = "Previuw";
            Previuw.UseVisualStyleBackColor = true;
            Previuw.Click += Previuw_Click;
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 627);
            Controls.Add(Previuw);
            Controls.Add(Diseño);
            Margin = new Padding(4, 5, 4, 5);
            Name = "InicioForm";
            Text = "Form1";
            FormClosing += InicioForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button Diseño;
        private Button Previuw;
    }
}
