namespace Resto.Net
{
    partial class EditarNombre_form
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
            Enviar_button = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Enviar_button
            // 
            Enviar_button.Location = new Point(265, 131);
            Enviar_button.Name = "Enviar_button";
            Enviar_button.Size = new Size(112, 34);
            Enviar_button.TabIndex = 0;
            Enviar_button.Text = "Enviar";
            Enviar_button.UseVisualStyleBackColor = true;
            Enviar_button.Click += Enviar_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el nombre: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 31);
            textBox1.TabIndex = 2;
            // 
            // EditarNombre_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 207);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Enviar_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EditarNombre_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Enviar_button;
        private Label label1;
        private TextBox textBox1;
    }
}