namespace Resto.Net
{
    partial class Consumisiones
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
            nombreConsumision = new TextBox();
            precioConsumision = new TextBox();
            agregarConsumisionButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(4, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Consumision";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(21, 154);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 1;
            label2.Text = "Precio     $";
            // 
            // nombreConsumision
            // 
            nombreConsumision.BackColor = SystemColors.Menu;
            nombreConsumision.Location = new Point(158, 85);
            nombreConsumision.Margin = new Padding(4, 4, 4, 4);
            nombreConsumision.Name = "nombreConsumision";
            nombreConsumision.Size = new Size(296, 31);
            nombreConsumision.TabIndex = 2;
            // 
            // precioConsumision
            // 
            precioConsumision.BackColor = SystemColors.MenuBar;
            precioConsumision.Location = new Point(158, 150);
            precioConsumision.Margin = new Padding(4, 4, 4, 4);
            precioConsumision.Name = "precioConsumision";
            precioConsumision.Size = new Size(296, 31);
            precioConsumision.TabIndex = 3;
            // 
            // agregarConsumisionButton
            // 
            agregarConsumisionButton.BackColor = Color.FromArgb(37, 43, 52);
            agregarConsumisionButton.FlatStyle = FlatStyle.Flat;
            agregarConsumisionButton.ForeColor = SystemColors.Control;
            agregarConsumisionButton.Location = new Point(338, 241);
            agregarConsumisionButton.Margin = new Padding(4, 4, 4, 4);
            agregarConsumisionButton.Name = "agregarConsumisionButton";
            agregarConsumisionButton.Size = new Size(118, 36);
            agregarConsumisionButton.TabIndex = 4;
            agregarConsumisionButton.Text = "Agregar";
            agregarConsumisionButton.UseVisualStyleBackColor = false;
            agregarConsumisionButton.Click += agregarConsumisionButton_Click;
            // 
            // Consumisiones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 61, 74);
            ClientSize = new Size(485, 332);
            Controls.Add(agregarConsumisionButton);
            Controls.Add(precioConsumision);
            Controls.Add(nombreConsumision);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Consumisiones";
            Text = "Consumisiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nombreConsumision;
        private TextBox precioConsumision;
        private Button agregarConsumisionButton;
    }
}