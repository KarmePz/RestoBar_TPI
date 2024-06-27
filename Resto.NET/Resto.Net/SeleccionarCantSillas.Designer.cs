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
            SelSillasLabel = new Label();
            SuspendLayout();
            // 
            // comboBoxSelecCant
            // 
            comboBoxSelecCant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSelecCant.BackColor = SystemColors.MenuBar;
            comboBoxSelecCant.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelecCant.FormattingEnabled = true;
            comboBoxSelecCant.Location = new Point(85, 152);
            comboBoxSelecCant.Margin = new Padding(4, 5, 4, 5);
            comboBoxSelecCant.Name = "comboBoxSelecCant";
            comboBoxSelecCant.Size = new Size(297, 33);
            comboBoxSelecCant.TabIndex = 0;
            comboBoxSelecCant.SelectedIndexChanged += comboBoxSelecCant_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 43, 52);
            button1.Font = new Font("Lato", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(231, 208);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(151, 38);
            button1.TabIndex = 1;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SelSillasLabel
            // 
            SelSillasLabel.AutoSize = true;
            SelSillasLabel.Font = new Font("Lato", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelSillasLabel.ForeColor = SystemColors.Control;
            SelSillasLabel.Location = new Point(26, 105);
            SelSillasLabel.Name = "SelSillasLabel";
            SelSillasLabel.Size = new Size(286, 24);
            SelSillasLabel.TabIndex = 2;
            SelSillasLabel.Text = "Selecciona la cantidad de sillas: ";
            // 
            // SeleccionarCantSillas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 61, 74);
            ClientSize = new Size(469, 398);
            Controls.Add(SelSillasLabel);
            Controls.Add(button1);
            Controls.Add(comboBoxSelecCant);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "SeleccionarCantSillas";
            Text = "SeleccionarCantSillas";
            FormClosing += SelecSillas_formClosing;
            Load += SeleccionarCantSillas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSelecCant;
        private Button button1;
        private Label SelSillasLabel;
    }
}