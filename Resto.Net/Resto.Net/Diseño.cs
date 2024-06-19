using RestoBarClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resto.Net
{
    public partial class Diseño : Form
    {
        InicioForm inicio;//formulario previo
        private Point lastLocation;//ultima localizacion del control
        private Point offset;
        private bool arrastrando = false;
        public Diseño()
        {
            InitializeComponent();
            this.inicio = (InicioForm)InicioForm.ActiveForm;

            panelDiseñoLayout.DragDrop += panelDiseñoLayout_DragDrop;
            panelDiseñoLayout.DragEnter += panelDiseñoLayout_DragEnter;
            CargarEtiquetas();


            foreach (Control control in panelDiseñoLayout.Controls)
            {
                control.MouseDown += Elemento_MouseDown;
                control.MouseMove += Elemento_MouseMove;
                control.MouseUp += Elemento_MouseUp;
            }
        }

        // Redirec al formulario de Inicio
        private void Salir_Click(object sender, EventArgs e)
        {
            inicio.Location = this.Location;
            inicio.Show();
            this.inicio.Size = this.Size;
            this.Close();
        }
        //Generamos un Label de Mesa chica
        private void mesaChicaButton_Click(object sender, EventArgs e)
        {
            Label mesaChica = new Label();
            mesaChica.Text = "Mesa chica";
            mesaChica.Visible = true;
            mesaChica.Location = new Point(10, 15);
            mesaChica.AutoSize = true;
            mesaChica.BackColor = Color.Magenta;

            mesaChica.MouseDown += Elemento_MouseDown;
            mesaChica.MouseMove += Elemento_MouseMove;
            mesaChica.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(mesaChica);

        }
        //Generamos un Button de Mesa mediana

        private void mesaMedianaButton_Click(object sender, EventArgs e)
        {
            Button mesaMediana = new Button();
            mesaMediana.Text = "Mesa Mediana";
            mesaMediana.Visible = true;
            mesaMediana.Location = new Point(10, 15);
            mesaMediana.AutoSize = true;
            mesaMediana.BackColor = Color.Magenta;

            mesaMediana.MouseDown += Elemento_MouseDown;
            mesaMediana.MouseMove += Elemento_MouseMove;
            mesaMediana.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(mesaMediana);
        }

        // se controla el movimiento de los distintos objetos en el layout 

        private void Elemento_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                arrastrando = true;
                offset = e.Location;
            }
        }


        private void Elemento_MouseMove(object? sender, MouseEventArgs e)
        {
            if (arrastrando)
            {
                Control control = sender as Control;
                if (control != null)
                {
                    Point newLocation = new Point(control.Location.X + e.X - offset.X, control.Location.Y + e.Y - offset.Y);
                    control.Location = newLocation;
                }
            }
        }
        private void Elemento_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                arrastrando = false;
            }
        }

        // Guardamos los elementos del panel de diseño
        private void guardarButton_Click(object sender, EventArgs e)
        {
            GuardarEtiquetas();
        }

        private void GuardarEtiquetas()
        {
            using (StreamWriter writer = new StreamWriter("elementosPanel.txt"))
            {
                foreach (Control control in panelDiseñoLayout.Controls)
                {
                    writer.WriteLine($"{control.GetType().Name},{control.Text},{control.Location.X},{control.Location.Y},{control.Width},{control.Height},{control.BackColor.ToArgb()}");
                }
            }
        }

        // Cargamos los elementos en el panel diseño
        private void CargarEtiquetas()
        {
            if (File.Exists("elementosPanel.txt"))
            {
                string[] lines = File.ReadAllLines("elementosPanel.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7)
                    {
                        string tipo = parts[0];
                        string texto = parts[1];
                        int x = int.Parse(parts[2]);
                        int y = int.Parse(parts[3]);
                        int width = int.Parse(parts[4]);
                        int height = int.Parse(parts[5]);
                        Color backColor = Color.FromArgb(int.Parse(parts[6]));

                        Control control;
                        if (tipo == "Label")
                        {
                            control = new Label();
                        }
                        else if (tipo == "Button")
                        {
                            control = new Button();
                        }
                        else
                        {
                            continue; // Si no es un tipo soportado, saltar
                        }

                        control.Text = texto;
                        control.Location = new Point(x, y);
                        control.Size = new Size(width, height);
                        control.BackColor = backColor;

                        control.MouseDown += Elemento_MouseDown;
                        control.MouseMove += Elemento_MouseMove;
                        control.MouseUp += Elemento_MouseUp;

                        panelDiseñoLayout.Controls.Add(control);
                    }
                }
            }
        }
        /*Se añadio la propiedad de auto scroll para que cuando se agrega un control que queda fuera del area visible
        *se pueda ver correctamente
        */
        // Se controla el drag and drop de los distintos elementos que instanciemos
        private void panelDiseñoLayout_DragEnter(object? sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void panelDiseñoLayout_DragDrop(object? sender, DragEventArgs e)
        {

            Point dropPoint = panelDiseñoLayout.PointToClient(new Point(e.X, e.Y));

            panelDiseñoLayout.Location = new Point(dropPoint.X - panelDiseñoLayout.Width / 2, dropPoint.Y - panelDiseñoLayout.Height / 2);
        }

        /*Al cerrarse el formulario con las herramientas de ventana de windows o 
         * con el boton salir, se vuelve a mostrar el formulario de inicio
         */
        //boton ventana salir evento
        private void Diseño_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.inicio.Show();
            this.inicio.Location = this.Location;
            this.inicio.Size = this.Size;
        }

        
    }
}

