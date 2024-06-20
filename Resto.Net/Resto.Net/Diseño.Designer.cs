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
            buttonMesaRectangular = new Button();
            mesaCuadradaButton = new Button();
            mesaRedondaButton = new Button();
            sillas = new TabPage();
            button4 = new Button();
            buttonSillaIndRed = new Button();
            buttonSillaIndCuad = new Button();
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
            Salir.Location = new Point(0, 294);
            Salir.Name = "Salir";
            Salir.Size = new Size(214, 23);
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
            PanelDeHerramientas.Location = new Point(535, 0);
            PanelDeHerramientas.Margin = new Padding(3, 2, 3, 2);
            PanelDeHerramientas.Name = "PanelDeHerramientas";
            PanelDeHerramientas.Size = new Size(214, 341);
            PanelDeHerramientas.TabIndex = 1;
            // 
            // Vision
            // 
            Vision.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Vision.AutoSize = true;
            Vision.BackColor = Color.Transparent;
            Vision.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            Vision.ForeColor = Color.FromArgb(113, 188, 252);
            Vision.Location = new Point(111, 5);
            Vision.Margin = new Padding(0);
            Vision.Name = "Vision";
            Vision.Size = new Size(72, 25);
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
            label1.Location = new Point(45, 5);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
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
            ElementosControl.Location = new Point(3, 49);
            ElementosControl.Margin = new Padding(3, 2, 3, 2);
            ElementosControl.Name = "ElementosControl";
            ElementosControl.SelectedIndex = 0;
            ElementosControl.Size = new Size(209, 138);
            ElementosControl.TabIndex = 1;
            // 
            // mesas
            // 
            mesas.AutoScroll = true;
            mesas.BackColor = Color.FromArgb(54, 61, 74);
            mesas.Controls.Add(buttonMesaRectangular);
            mesas.Controls.Add(mesaCuadradaButton);
            mesas.Controls.Add(mesaRedondaButton);
            mesas.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            mesas.Location = new Point(4, 39);
            mesas.Margin = new Padding(3, 2, 3, 2);
            mesas.Name = "mesas";
            mesas.Padding = new Padding(3, 2, 3, 2);
            mesas.Size = new Size(201, 95);
            mesas.TabIndex = 0;
            mesas.Text = "Mesas";
            mesas.Click += mesas_Click;
            // 
            // buttonMesaRectangular
            // 
            buttonMesaRectangular.Dock = DockStyle.Top;
            buttonMesaRectangular.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMesaRectangular.Location = new Point(3, 70);
            buttonMesaRectangular.Margin = new Padding(3, 2, 3, 2);
            buttonMesaRectangular.Name = "buttonMesaRectangular";
            buttonMesaRectangular.Size = new Size(178, 34);
            buttonMesaRectangular.TabIndex = 2;
            buttonMesaRectangular.Text = "Mesa Rectangular";
            buttonMesaRectangular.UseVisualStyleBackColor = true;
            // 
            // mesaCuadradaButton
            // 
            mesaCuadradaButton.Dock = DockStyle.Top;
            mesaCuadradaButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mesaCuadradaButton.Location = new Point(3, 36);
            mesaCuadradaButton.Margin = new Padding(3, 2, 3, 2);
            mesaCuadradaButton.Name = "mesaCuadradaButton";
            mesaCuadradaButton.Size = new Size(178, 34);
            mesaCuadradaButton.TabIndex = 1;
            mesaCuadradaButton.Text = "Mesa Cuadrada";
            mesaCuadradaButton.UseVisualStyleBackColor = true;
            mesaCuadradaButton.Click += mesaMedianaButton_Click;
            // 
            // mesaRedondaButton
            // 
            mesaRedondaButton.AutoSize = true;
            mesaRedondaButton.Dock = DockStyle.Top;
            mesaRedondaButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mesaRedondaButton.Location = new Point(3, 2);
            mesaRedondaButton.Margin = new Padding(3, 2, 3, 2);
            mesaRedondaButton.Name = "mesaRedondaButton";
            mesaRedondaButton.Size = new Size(178, 34);
            mesaRedondaButton.TabIndex = 0;
            mesaRedondaButton.Text = "Mesa Redonda";
            mesaRedondaButton.UseVisualStyleBackColor = true;
            mesaRedondaButton.Click += mesaChicaButton_Click;
            // 
            // sillas
            // 
            sillas.BackColor = Color.RosyBrown;
            sillas.Controls.Add(button4);
            sillas.Controls.Add(buttonSillaIndRed);
            sillas.Controls.Add(buttonSillaIndCuad);
            sillas.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sillas.Location = new Point(4, 39);
            sillas.Margin = new Padding(3, 2, 3, 2);
            sillas.Name = "sillas";
            sillas.Padding = new Padding(3, 2, 3, 2);
            sillas.Size = new Size(201, 95);
            sillas.TabIndex = 1;
            sillas.Text = "Sillas";
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(3, 70);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(195, 34);
            button4.TabIndex = 5;
            button4.Text = "silla 3";
            button4.UseVisualStyleBackColor = true;
            // 
            // buttonSillaIndRed
            // 
            buttonSillaIndRed.Dock = DockStyle.Top;
            buttonSillaIndRed.Location = new Point(3, 36);
            buttonSillaIndRed.Margin = new Padding(3, 2, 3, 2);
            buttonSillaIndRed.Name = "buttonSillaIndRed";
            buttonSillaIndRed.Size = new Size(195, 34);
            buttonSillaIndRed.TabIndex = 4;
            buttonSillaIndRed.Text = "Silla Ind. Redonda";
            buttonSillaIndRed.UseVisualStyleBackColor = true;
            // 
            // buttonSillaIndCuad
            // 
            buttonSillaIndCuad.Dock = DockStyle.Top;
            buttonSillaIndCuad.Location = new Point(3, 2);
            buttonSillaIndCuad.Margin = new Padding(3, 2, 3, 2);
            buttonSillaIndCuad.Name = "buttonSillaIndCuad";
            buttonSillaIndCuad.Size = new Size(195, 34);
            buttonSillaIndCuad.TabIndex = 3;
            buttonSillaIndCuad.Text = "Silla Ind. Cuadrada";
            buttonSillaIndCuad.UseVisualStyleBackColor = true;
            buttonSillaIndCuad.Click += buttonSillaIndCuad_Click;
            // 
            // estructuras
            // 
            estructuras.BackColor = Color.FromArgb(54, 61, 74);
            estructuras.Location = new Point(4, 39);
            estructuras.Margin = new Padding(3, 2, 3, 2);
            estructuras.Name = "estructuras";
            estructuras.Padding = new Padding(3, 2, 3, 2);
            estructuras.Size = new Size(201, 95);
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
            guardarButton.Location = new Point(0, 260);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(214, 28);
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
            panelDiseñoLayout.Margin = new Padding(3, 2, 3, 2);
            panelDiseñoLayout.Name = "panelDiseñoLayout";
            panelDiseñoLayout.Size = new Size(535, 346);
            panelDiseñoLayout.TabIndex = 2;
            // 
            // Diseño
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 350);
            Controls.Add(panelDiseñoLayout);
            Controls.Add(PanelDeHerramientas);
            MinimumSize = new Size(720, 389);
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
        private Button buttonMesaRectangular;
        private Button mesaCuadradaButton;
        private Button mesaRedondaButton;
        private Button button4;
        private Button buttonSillaIndRed;
        private Button buttonSillaIndCuad;
        private Panel panelDiseñoLayout;
        private Button guardarButton;
        private TabPage estructuras;
        private Label Vision;
        private Label label1;
    }
}