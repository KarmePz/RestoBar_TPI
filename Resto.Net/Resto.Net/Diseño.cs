﻿using RestoBarClases;
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

            //Permite que en el panel se puedan mover objetos 
            panelDiseñoLayout.DragDrop += panelDiseñoLayout_DragDrop;
            panelDiseñoLayout.DragEnter += panelDiseñoLayout_DragEnter;
            CargarEtiquetas();


            //ASIGNACION DE EVENTOS PARA CADA MESA Y SILLA
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

            Panel mesaChicaPanel = new Panel();
            PictureBox pictureBox = new PictureBox();

            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = Image.FromFile(@"Resources\Redondo_6.png");
            pictureBox.Enabled = false;


            mesaChicaPanel.Size = new Size(150, 150);
            mesaChicaPanel.Visible = true;
            mesaChicaPanel.Location = new Point(100, 150);
            mesaChicaPanel.BackColor = Color.Magenta;

            mesaChicaPanel.MouseDown += Elemento_MouseDown;
            mesaChicaPanel.MouseMove += Elemento_MouseMove;
            mesaChicaPanel.MouseUp += Elemento_MouseUp;
            mesaChicaPanel.Controls.Add(pictureBox);

            panelDiseñoLayout.Controls.Add(mesaChicaPanel);



        }

        //Generamos un Button de Mesa mediana

        private void mesaMedianaButton_Click(object sender, EventArgs e)
        {
            Button mesaMediana = new Button();
            mesaMediana.Text = "Mesa Mediana";
            mesaMediana.Visible = true;
            mesaMediana.Location = new Point(100, 100);
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
                Control control = sender as Control;
                if (control != null)
                {
                    arrastrando = true;
                    offset = e.Location;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                Control control = sender as Control;
                if (control != null)
                {
                    panelDiseñoLayout.Controls.Remove(control);
                    control.Dispose(); // Liberar recursos del control eliminado
                }
            }
            //if (e.Button == MouseButtons.Left)
            //{
            //    Control control = sender as Control;
            //    if (control != null)
            //    {
            //        // Código para arrastrar el control si es necesario
            //        arrastrando = true;
            //        offset = e.Location;
            //    }



            //}
            //else if (e.Button == MouseButtons.Right)
            //{

            //    //se utiliza para localizar el control seleccionado
            //    Control control = panelDiseñoLayout.GetChildAtPoint(e.Location);
            //    if (control != null)
            //    {
            //        panelDiseñoLayout.Controls.Remove(control);
            //        control.Dispose();//liberar recursos

            //        //MessageBox.Show("Clic derecho detectado!");
            //        //TODO
            //    }

            //}
        }


        private void Elemento_MouseMove(object? sender, MouseEventArgs e)
        {
            // Arrastrar el control
            if (arrastrando)
            {
                Control control = sender as Control;
                if (control != null)
                {
                    Point newLocation = panelDiseñoLayout.PointToClient(Control.MousePosition);
                    control.Location = new Point(newLocation.X - offset.X, newLocation.Y - offset.Y);


                }
            }
            //if (arrastrando)
            //{
            //    Control control = sender as Control;
            //    if (control != null)
            //    {
            //        Point newLocation = new Point(control.Location.X + e.X - offset.X, control.Location.Y + e.Y - offset.Y);
            //        control.Location = newLocation;
            //    }
            //}

        }
        private void Elemento_MouseUp(object sender, MouseEventArgs e)
        {
            // Liberar el control al soltar el botón izquierdo del ratón
            if (e.Button == MouseButtons.Left)
            {
                Control control = sender as Control;
                if (control != null)
                {
                    arrastrando = false;


                }
            }


            //if (e.Button == MouseButtons.Left)
            //{
            //    arrastrando = false;
            //}
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
                        if (tipo == "Panel")
                        {
                            control = new Panel();
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
        private void GuardarControles(Control.ControlCollection controls, StreamWriter writer)
        {
            foreach (Control control in controls)
            {
                writer.WriteLine($"{control.GetType().Name},{control.Text},{control.Location.X},{control.Location.Y},{control.Width},{control.Height},{control.BackColor.ToArgb()}");

                // Si el control tiene controles anidados, guardar también esos controles
                if (control.Controls.Count > 0)
                {
                    GuardarControles(control.Controls, writer);
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

        private void mesas_Click(object sender, EventArgs e)
        {

        }

        private void Limite_Button_Click(object sender, EventArgs e)
        {
            Panel LimitePanel = new Panel();
            PictureBox pictureBox = new PictureBox();

            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = Image.FromFile(@"Resources\Redondo_6.png");
            pictureBox.Enabled = false;


            LimitePanel.Size = new Size(150, 150);
            LimitePanel.Visible = true;
            LimitePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LimitePanel.Location = new Point(100, 150);
            LimitePanel.BackColor = Color.Magenta;


            LimitePanel.MouseDown += panelSizeable_MouseDown;
            LimitePanel.MouseMove += panelSizeable_MouseMove;

            LimitePanel.MouseUp += panelSizeable_MouseUp;
            LimitePanel.Controls.Add(pictureBox);

            panelDiseñoLayout.Controls.Add(LimitePanel);

        }
    


        /// <summary>
        /// Control de cambio de tamaño del apartado limite, Todavia no se implemento el movimiento
        /// se tiene que trabajar en ese movimiento particularmente, se agrega el nuevo proyecto de 
        /// igual manera. Otro problema que surge del codigo siguiente es al momento de guardarlo. Aqui pierde 
        /// sus propiedades de cambio de tamaño y solo se puede mover
        /// </summary>
        private bool resizing = false;
        private Point lastMousePos;

        private void panelSizeable_MouseDown(object sender, MouseEventArgs e)
        {
            Control panelsizeable = sender as Control;
            
                resizing = true;
                lastMousePos = e.Location;
            
        }

        private void panelSizeable_MouseMove(object sender, MouseEventArgs e)
        {
            Control panelSizeable = sender as Control;
            if (resizing)
            {
                int deltaX = e.X - lastMousePos.X;
                int deltaY = e.Y - lastMousePos.Y;

                panelSizeable.Width += deltaX;
                panelSizeable.Height += deltaY;

                lastMousePos = e.Location;
            }
        }

        private void panelSizeable_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = false;
        }
        private bool EsquinaResizing(Point mouseLocation,Control panelResizable)
        {
          
            // Definir un área de la esquina inferior derecha donde se permite el redimensionamiento
            Rectangle resizeArea = new Rectangle(
                panelResizable.Width - 10,
                panelResizable.Height - 10,
                10,
                10);

            return resizeArea.Contains(mouseLocation);
        }
    }
}

