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
            button3 = new Button();
            mesaMedianaButton = new Button();
            mesaChicaButton = new Button();
            sillas = new TabPage();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            estructuras = new TabPage();
            guardarButton = new Button();
            panelDiseñoLayout = new Panel();
            PanelDeHerramientas.SuspendLayout();
            ElementosControl.SuspendLayout();
            mesas.SuspendLayout();
            sillas.SuspendLayout();
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
            Salir.Location = new Point(0, 392);
            Salir.Margin = new Padding(3, 4, 3, 4);
            Salir.Name = "Salir";
            Salir.Size = new Size(245, 30);
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
            PanelDeHerramientas.Location = new Point(611, 0);
            PanelDeHerramientas.Name = "PanelDeHerramientas";
            PanelDeHerramientas.Size = new Size(245, 455);
            PanelDeHerramientas.TabIndex = 1;
            // 
            // Vision
            // 
            Vision.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Vision.AutoSize = true;
            Vision.BackColor = Color.Transparent;
            Vision.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            Vision.ForeColor = Color.FromArgb(113, 188, 252);
            Vision.Location = new Point(127, 7);
            Vision.Margin = new Padding(0);
            Vision.Name = "Vision";
            Vision.Size = new Size(89, 29);
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
            label1.Location = new Point(51, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 29);
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
            ElementosControl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ElementosControl.ItemSize = new Size(85, 35);
            ElementosControl.Location = new Point(3, 66);
            ElementosControl.Name = "ElementosControl";
            ElementosControl.SelectedIndex = 0;
            ElementosControl.Size = new Size(238, 184);
            ElementosControl.TabIndex = 1;
            // 
            // mesas
            // 
            mesas.BackColor = Color.FromArgb(54, 61, 74);
            mesas.Controls.Add(button3);
            mesas.Controls.Add(mesaMedianaButton);
            mesas.Controls.Add(mesaChicaButton);
            mesas.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            mesas.Location = new Point(4, 39);
            mesas.Name = "mesas";
            mesas.Padding = new Padding(3);
            mesas.Size = new Size(230, 141);
            mesas.TabIndex = 0;
            mesas.Text = "Mesas";
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(3, 93);
            button3.Name = "button3";
            button3.Size = new Size(224, 45);
            button3.TabIndex = 2;
            button3.Text = "Mesa Grande";
            button3.UseVisualStyleBackColor = true;
            // 
            // mesaMedianaButton
            // 
            mesaMedianaButton.Dock = DockStyle.Top;
            mesaMedianaButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mesaMedianaButton.Location = new Point(3, 48);
            mesaMedianaButton.Name = "mesaMedianaButton";
            mesaMedianaButton.Size = new Size(224, 45);
            mesaMedianaButton.TabIndex = 1;
            mesaMedianaButton.Text = "Mesa Mediana";
            mesaMedianaButton.UseVisualStyleBackColor = true;
            mesaMedianaButton.Click += mesaMedianaButton_Click;
            // 
            // mesaChicaButton
            // 
            mesaChicaButton.AutoSize = true;
            mesaChicaButton.Dock = DockStyle.Top;
            mesaChicaButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mesaChicaButton.Location = new Point(3, 3);
            mesaChicaButton.Name = "mesaChicaButton";
            mesaChicaButton.Size = new Size(224, 45);
            mesaChicaButton.TabIndex = 0;
            mesaChicaButton.Text = "Mesa Chica";
            mesaChicaButton.UseVisualStyleBackColor = true;
            mesaChicaButton.Click += mesaChicaButton_Click;
            // 
            // sillas
            // 
            sillas.BackColor = Color.RosyBrown;
            sillas.Controls.Add(button4);
            sillas.Controls.Add(button5);
            sillas.Controls.Add(button6);
            sillas.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sillas.Location = new Point(4, 39);
            sillas.Name = "sillas";
            sillas.Padding = new Padding(3);
            sillas.Size = new Size(230, 141);
            sillas.TabIndex = 1;
            sillas.Text = "Sillas";
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(3, 93);
            button4.Name = "button4";
            button4.Size = new Size(224, 45);
            button4.TabIndex = 5;
            button4.Text = "silla 3";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(3, 48);
            button5.Name = "button5";
            button5.Size = new Size(224, 45);
            button5.TabIndex = 4;
            button5.Text = "silla 2";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(224, 45);
            button6.TabIndex = 3;
            button6.Text = "silla 1";
            button6.UseVisualStyleBackColor = true;
            // 
            // estructuras
            // 
            estructuras.BackColor = Color.FromArgb(54, 61, 74);
            estructuras.Location = new Point(4, 39);
            estructuras.Name = "estructuras";
            estructuras.Padding = new Padding(3);
            estructuras.Size = new Size(230, 141);
            estructuras.TabIndex = 2;
            estructuras.Text = "Estructuras";
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
            guardarButton.Location = new Point(0, 352);
            guardarButton.Margin = new Padding(3, 4, 3, 4);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(245, 32);
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
            panelDiseñoLayout.Name = "panelDiseñoLayout";
            panelDiseñoLayout.Size = new Size(611, 455);
            panelDiseñoLayout.TabIndex = 2;
            // 
            // Diseño
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 462);
            Controls.Add(panelDiseñoLayout);
            Controls.Add(PanelDeHerramientas);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(877, 509);
            Name = "Diseño";
            Text = "Diseño";
            FormClosing += Diseño_FormClosing;
            PanelDeHerramientas.ResumeLayout(false);
            PanelDeHerramientas.PerformLayout();
            ElementosControl.ResumeLayout(false);
            mesas.ResumeLayout(false);
            mesas.PerformLayout();
            sillas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Salir;
        private Panel PanelDeHerramientas;
        private TabControl ElementosControl;
        private TabPage mesas;
        private TabPage sillas;
        private Button button3;
        private Button mesaMedianaButton;
        private Button mesaChicaButton;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panelDiseñoLayout;
        private Button guardarButton;
        private TabPage estructuras;
        private Label Vision;
        private Label label1;
    }
}