namespace Resto.Net
{
    partial class Diseño
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
            Salir = new Button();
            PanelDeHerramientas = new Panel();
            Vision = new Label();
            label1 = new Label();
            ElementosControl = new TabControl();
            mesas = new TabPage();
            MCuadrada = new Button();
            MCuadrada3_Button = new Button();
            MCuadrada2_Button = new Button();
            Mcuadrada1_Button = new Button();
            MRedonda1_Button = new Button();
            MRedonda2_Button = new Button();
            MRedonda3_Button = new Button();
            MRedonda4_Button = new Button();
            MRedonda5_Button = new Button();
            MRedonda6_Button = new Button();
            sillas = new TabPage();
            SillaIndividual_Button = new Button();
            estructuras = new TabPage();
            Limite_Button = new Button();
            guardarButton = new Button();
            panelDiseñoLayout = new Panel();
            PanelDeHerramientas.SuspendLayout();
            ElementosControl.SuspendLayout();
            mesas.SuspendLayout();
            sillas.SuspendLayout();
            estructuras.SuspendLayout();
            SuspendLayout();
            // 
            // Salir
            // 
            Salir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Salir.BackColor = Color.FromArgb(37, 43, 52);
            Salir.BackgroundImageLayout = ImageLayout.None;
            Salir.FlatAppearance.BorderColor = Color.FromArgb(37, 43, 52);
            Salir.FlatStyle = FlatStyle.Flat;
            Salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Salir.ForeColor = SystemColors.Control;
            Salir.Location = new Point(0, 490);
            Salir.Margin = new Padding(4, 5, 4, 5);
            Salir.Name = "Salir";
            Salir.Size = new Size(306, 38);
            Salir.TabIndex = 0;
            Salir.Text = "Volver";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // PanelDeHerramientas
            // 
            PanelDeHerramientas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            PanelDeHerramientas.BackColor = Color.FromArgb(54, 61, 74);
            PanelDeHerramientas.Controls.Add(Vision);
            PanelDeHerramientas.Controls.Add(label1);
            PanelDeHerramientas.Controls.Add(ElementosControl);
            PanelDeHerramientas.Controls.Add(guardarButton);
            PanelDeHerramientas.Controls.Add(Salir);
            PanelDeHerramientas.Location = new Point(764, 0);
            PanelDeHerramientas.Margin = new Padding(4);
            PanelDeHerramientas.Name = "PanelDeHerramientas";
            PanelDeHerramientas.Size = new Size(306, 569);
            PanelDeHerramientas.TabIndex = 1;
            // 
            // Vision
            // 
            Vision.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Vision.AutoSize = true;
            Vision.BackColor = Color.Transparent;
            Vision.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            Vision.ForeColor = Color.FromArgb(113, 188, 252);
            Vision.Location = new Point(159, 9);
            Vision.Margin = new Padding(0);
            Vision.Name = "Vision";
            Vision.Size = new Size(105, 36);
            Vision.TabIndex = 5;
            Vision.Text = "Vision";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(54, 61, 74);
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(64, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 36);
            label1.TabIndex = 4;
            label1.Text = "Restó";
            // 
            // ElementosControl
            // 
            ElementosControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ElementosControl.Controls.Add(mesas);
            ElementosControl.Controls.Add(sillas);
            ElementosControl.Controls.Add(estructuras);
            ElementosControl.Cursor = Cursors.Hand;
            ElementosControl.Font = new Font("Lato", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ElementosControl.ItemSize = new Size(85, 35);
            ElementosControl.Location = new Point(4, 82);
            ElementosControl.Margin = new Padding(4);
            ElementosControl.Name = "ElementosControl";
            ElementosControl.SelectedIndex = 0;
            ElementosControl.Size = new Size(298, 230);
            ElementosControl.TabIndex = 1;
            // 
            // mesas
            // 
            mesas.AutoScroll = true;
            mesas.BackColor = Color.FromArgb(54, 61, 74);
            mesas.Controls.Add(MCuadrada);
            mesas.Controls.Add(MCuadrada3_Button);
            mesas.Controls.Add(MCuadrada2_Button);
            mesas.Controls.Add(Mcuadrada1_Button);
            mesas.Controls.Add(MRedonda1_Button);
            mesas.Controls.Add(MRedonda2_Button);
            mesas.Controls.Add(MRedonda3_Button);
            mesas.Controls.Add(MRedonda4_Button);
            mesas.Controls.Add(MRedonda5_Button);
            mesas.Controls.Add(MRedonda6_Button);
            mesas.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            mesas.Location = new Point(4, 39);
            mesas.Margin = new Padding(4);
            mesas.Name = "mesas";
            mesas.Padding = new Padding(4);
            mesas.Size = new Size(290, 187);
            mesas.TabIndex = 0;
            mesas.Text = "Mesas";
            mesas.Click += mesas_Click;
            // 
            // MCuadrada
            // 
            MCuadrada.Dock = DockStyle.Top;
            MCuadrada.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MCuadrada.Location = new Point(4, 508);
            MCuadrada.Margin = new Padding(4);
            MCuadrada.Name = "MCuadrada";
            MCuadrada.Size = new Size(256, 56);
            MCuadrada.TabIndex = 9;
            MCuadrada.Text = "Mesa Cuadrada 4";
            MCuadrada.UseVisualStyleBackColor = true;
            // 
            // MCuadrada3_Button
            // 
            MCuadrada3_Button.Dock = DockStyle.Top;
            MCuadrada3_Button.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MCuadrada3_Button.Location = new Point(4, 452);
            MCuadrada3_Button.Margin = new Padding(4);
            MCuadrada3_Button.Name = "MCuadrada3_Button";
            MCuadrada3_Button.Size = new Size(256, 56);
            MCuadrada3_Button.TabIndex = 8;
            MCuadrada3_Button.Text = "Mesa Cuadrada 3";
            MCuadrada3_Button.UseVisualStyleBackColor = true;
            // 
            // MCuadrada2_Button
            // 
            MCuadrada2_Button.Dock = DockStyle.Top;
            MCuadrada2_Button.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MCuadrada2_Button.Location = new Point(4, 396);
            MCuadrada2_Button.Margin = new Padding(4);
            MCuadrada2_Button.Name = "MCuadrada2_Button";
            MCuadrada2_Button.Size = new Size(256, 56);
            MCuadrada2_Button.TabIndex = 7;
            MCuadrada2_Button.Text = "Mesa Cuadrada 2";
            MCuadrada2_Button.UseVisualStyleBackColor = true;
            // 
            // Mcuadrada1_Button
            // 
            Mcuadrada1_Button.Dock = DockStyle.Top;
            Mcuadrada1_Button.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mcuadrada1_Button.Location = new Point(4, 340);
            Mcuadrada1_Button.Margin = new Padding(4);
            Mcuadrada1_Button.Name = "Mcuadrada1_Button";
            Mcuadrada1_Button.Size = new Size(256, 56);
            Mcuadrada1_Button.TabIndex = 6;
            Mcuadrada1_Button.Text = "Mesa Cuadrada 1";
            Mcuadrada1_Button.UseVisualStyleBackColor = true;
            // 
            // MRedonda1_Button
            // 
            MRedonda1_Button.Dock = DockStyle.Top;
            MRedonda1_Button.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MRedonda1_Button.Location = new Point(4, 284);
            MRedonda1_Button.Margin = new Padding(4);
            MRedonda1_Button.Name = "MRedonda1_Button";
            MRedonda1_Button.Size = new Size(256, 56);
            MRedonda1_Button.TabIndex = 5;
            MRedonda1_Button.Text = "Mesa Redonda 1";
            MRedonda1_Button.UseVisualStyleBackColor = true;
            // 
            // MRedonda2_Button
            // 
            MRedonda2_Button.Dock = DockStyle.Top;
            MRedonda2_Button.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MRedonda2_Button.Location = new Point(4, 228);
            MRedonda2_Button.Margin = new Padding(4);
            MRedonda2_Button.Name = "MRedonda2_Button";
            MRedonda2_Button.Size = new Size(256, 56);
            MRedonda2_Button.TabIndex = 4;
            MRedonda2_Button.Text = "Mesa Redonda 2";
            MRedonda2_Button.UseVisualStyleBackColor = true;
            // 
            // MRedonda3_Button
            // 
            MRedonda3_Button.Dock = DockStyle.Top;
            MRedonda3_Button.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MRedonda3_Button.Location = new Point(4, 172);
            MRedonda3_Button.Margin = new Padding(4);
            MRedonda3_Button.Name = "MRedonda3_Button";
            MRedonda3_Button.Size = new Size(256, 56);
            MRedonda3_Button.TabIndex = 3;
            MRedonda3_Button.Text = "Mesa Redonda 3";
            MRedonda3_Button.UseVisualStyleBackColor = true;
            // 
            // MRedonda4_Button
            // 
            MRedonda4_Button.Dock = DockStyle.Top;
            MRedonda4_Button.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MRedonda4_Button.Location = new Point(4, 116);
            MRedonda4_Button.Margin = new Padding(4);
            MRedonda4_Button.Name = "MRedonda4_Button";
            MRedonda4_Button.Size = new Size(256, 56);
            MRedonda4_Button.TabIndex = 2;
            MRedonda4_Button.Text = "Mesa Redonda 4";
            MRedonda4_Button.UseVisualStyleBackColor = true;
            // 
            // MRedonda5_Button
            // 
            MRedonda5_Button.Dock = DockStyle.Top;
            MRedonda5_Button.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MRedonda5_Button.Location = new Point(4, 60);
            MRedonda5_Button.Margin = new Padding(4);
            MRedonda5_Button.Name = "MRedonda5_Button";
            MRedonda5_Button.Size = new Size(256, 56);
            MRedonda5_Button.TabIndex = 1;
            MRedonda5_Button.Text = "Mesa Redonda 5";
            MRedonda5_Button.UseVisualStyleBackColor = true;
            MRedonda5_Button.Click += mesaMedianaButton_Click;
            // 
            // MRedonda6_Button
            // 
            MRedonda6_Button.AutoSize = true;
            MRedonda6_Button.Dock = DockStyle.Top;
            MRedonda6_Button.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MRedonda6_Button.Location = new Point(4, 4);
            MRedonda6_Button.Margin = new Padding(4);
            MRedonda6_Button.Name = "MRedonda6_Button";
            MRedonda6_Button.Size = new Size(256, 56);
            MRedonda6_Button.TabIndex = 0;
            MRedonda6_Button.Text = "Mesa Redonda 6";
            MRedonda6_Button.UseVisualStyleBackColor = true;
            MRedonda6_Button.Click += mesaChicaButton_Click;
            // 
            // sillas
            // 
            sillas.BackColor = Color.FromArgb(54, 61, 74);
            sillas.Controls.Add(SillaIndividual_Button);
            sillas.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sillas.Location = new Point(4, 39);
            sillas.Margin = new Padding(4);
            sillas.Name = "sillas";
            sillas.Padding = new Padding(4);
            sillas.Size = new Size(290, 187);
            sillas.TabIndex = 1;
            sillas.Text = "Sillas";
            // 
            // SillaIndividual_Button
            // 
            SillaIndividual_Button.Dock = DockStyle.Top;
            SillaIndividual_Button.Font = new Font("Lato", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SillaIndividual_Button.Location = new Point(4, 4);
            SillaIndividual_Button.Margin = new Padding(4);
            SillaIndividual_Button.Name = "SillaIndividual_Button";
            SillaIndividual_Button.Size = new Size(282, 56);
            SillaIndividual_Button.TabIndex = 3;
            SillaIndividual_Button.Text = "Silla individual";
            SillaIndividual_Button.UseVisualStyleBackColor = true;
            // 
            // estructuras
            // 
            estructuras.BackColor = Color.FromArgb(54, 61, 74);
            estructuras.Controls.Add(Limite_Button);
            estructuras.Location = new Point(4, 39);
            estructuras.Margin = new Padding(4);
            estructuras.Name = "estructuras";
            estructuras.Padding = new Padding(4);
            estructuras.Size = new Size(290, 187);
            estructuras.TabIndex = 2;
            estructuras.Text = "Estructuras";
            // 
            // Limite_Button
            // 
            Limite_Button.Dock = DockStyle.Top;
            Limite_Button.Font = new Font("Lato", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Limite_Button.Location = new Point(4, 4);
            Limite_Button.Margin = new Padding(4);
            Limite_Button.Name = "Limite_Button";
            Limite_Button.Size = new Size(282, 56);
            Limite_Button.TabIndex = 4;
            Limite_Button.Text = "Límite";
            Limite_Button.UseVisualStyleBackColor = true;
            Limite_Button.Click += Limite_Button_Click;
            // 
            // guardarButton
            // 
            guardarButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            guardarButton.AutoSize = true;
            guardarButton.BackColor = Color.FromArgb(37, 43, 52);
            guardarButton.BackgroundImageLayout = ImageLayout.None;
            guardarButton.FlatAppearance.BorderColor = Color.FromArgb(37, 43, 52);
            guardarButton.FlatStyle = FlatStyle.Flat;
            guardarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guardarButton.ForeColor = SystemColors.Control;
            guardarButton.Location = new Point(0, 434);
            guardarButton.Margin = new Padding(4, 5, 4, 5);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(306, 46);
            guardarButton.TabIndex = 3;
            guardarButton.Text = "Guardar";
            guardarButton.UseVisualStyleBackColor = false;
            guardarButton.Click += guardarButton_Click;
            // 
            // panelDiseñoLayout
            // 
            panelDiseñoLayout.AllowDrop = true;
            panelDiseñoLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDiseñoLayout.AutoScroll = true;
            panelDiseñoLayout.BackColor = SystemColors.InactiveCaption;
            panelDiseñoLayout.Location = new Point(0, 0);
            panelDiseñoLayout.Margin = new Padding(4);
            panelDiseñoLayout.Name = "panelDiseñoLayout";
            panelDiseñoLayout.Size = new Size(764, 577);
            panelDiseñoLayout.TabIndex = 2;
            // 
            // Diseño
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 578);
            Controls.Add(panelDiseñoLayout);
            Controls.Add(PanelDeHerramientas);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1091, 622);
            Name = "Diseño";
            Text = "Diseño";
            FormClosing += Diseño_FormClosing;
            PanelDeHerramientas.ResumeLayout(false);
            PanelDeHerramientas.PerformLayout();
            ElementosControl.ResumeLayout(false);
            mesas.ResumeLayout(false);
            mesas.PerformLayout();
            sillas.ResumeLayout(false);
            estructuras.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Salir;
        private Panel PanelDeHerramientas;
        private TabControl ElementosControl;
        private TabPage mesas;
        private TabPage sillas;
        private Button MRedonda4_Button;
        private Button MRedonda5_Button;
        private Button MRedonda6_Button;
        private Button button4;
        private Button button5;
        private Button SillaIndividual_Button;
        private Panel panelDiseñoLayout;
        private Button guardarButton;
        private TabPage estructuras;
        private Label Vision;
        private Label label1;
        private Button MCuadrada;
        private Button MCuadrada3_Button;
        private Button MCuadrada2_Button;
        private Button Mcuadrada1_Button;
        private Button MRedonda1_Button;
        private Button MRedonda2_Button;
        private Button MRedonda3_Button;
        private Button Limite_Button;
    }
}