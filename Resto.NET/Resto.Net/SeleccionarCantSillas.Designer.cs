namespace Resto.Net
{
    partial class SeleccionarCantSillas
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
            comboBoxSelecCant = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxSelecCant
            // 
            comboBoxSelecCant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSelecCant.BackColor = SystemColors.MenuBar;
            comboBoxSelecCant.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelecCant.FormattingEnabled = true;
            comboBoxSelecCant.Location = new Point(81, 253);
            comboBoxSelecCant.Margin = new Padding(4, 5, 4, 5);
            comboBoxSelecCant.Name = "comboBoxSelecCant";
            comboBoxSelecCant.Size = new Size(171, 33);
            comboBoxSelecCant.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(113, 302);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 1;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SeleccionarCantSillas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 573);
            Controls.Add(button1);
            Controls.Add(comboBoxSelecCant);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SeleccionarCantSillas";
            Text = "SeleccionarCantSillas";
            FormClosing += SelecSillas_formClosing;
            Load += SeleccionarCantSillas_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxSelecCant;
        private Button button1;
    }
}