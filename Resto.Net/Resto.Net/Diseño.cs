using RestoBarClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
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
            SeleccionarCantSillas formCantSill = new(TipoDeMesa.Redonda);
            formCantSill.ShowDialog();
            int cantidadSillas = formCantSill.TipoInt;

            BotonMesa mesaChicaBoton = new BotonMesa(new Mesa(BotonMesa.StaticID++, TipoDeMesa.Redonda, cantidadSillas));
            mesaChicaBoton.Location = new Point(100, 150);
            mesaChicaBoton.BackgroundImage = DeterminarImagen(ref mesaChicaBoton, cantidadSillas);
            mesaChicaBoton.Size = mesaChicaBoton.BackgroundImage.Size;
            mesaChicaBoton.Tag = mesaChicaBoton.ClaseMesa.Id;
            mesaChicaBoton.Text = "#" + mesaChicaBoton.Tag.ToString();

            mesaChicaBoton.MouseDown += Elemento_MouseDown;
            mesaChicaBoton.MouseMove += Elemento_MouseMove;
            mesaChicaBoton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(mesaChicaBoton);

        }

        private Image DeterminarImagen(ref BotonMesa botonMesa, int cantSillas)
        {
            Mesa claseMesa = botonMesa.ClaseMesa;
            switch (claseMesa.Tipo)
            {
                case TipoDeMesa.Redonda:
                    switch (claseMesa.Sillas.Count)
                    {
                        case 0:
                            return Properties.Resources.Redondo_1;
                        case 1:
                            return Properties.Resources.mesa1;
                        case 2:
                            return Properties.Resources.mesa1;
                        case 3:
                            return Properties.Resources.mesa1;
                        case 4:
                            return Properties.Resources.mesa1;
                        default:
                            return Properties.Resources.mesa2;
                    }
                case TipoDeMesa.Cuadrada:
                    switch (claseMesa.Sillas.Count)
                    {
                        case 0:
                            return Properties.Resources.Cuadrado_1;
                        case 1:
                            return Properties.Resources.mesa2;
                        default:
                            return Properties.Resources.mesa2;
                    }
                case TipoDeMesa.Rectangular:
                    switch (claseMesa.Sillas.Count)
                    {
                        case 0:
                            return Properties.Resources.mesa2;
                        case 1:
                            return Properties.Resources.mesa2;
                        case 2:
                            return Properties.Resources.mesa2;
                        case 3:
                            return Properties.Resources.mesa2;
                        case 4:
                            return Properties.Resources.mesa2;
                        case 5:
                            return Properties.Resources.mesa2;
                        default:
                            return Properties.Resources.mesa2;
                    }
                default:
                    return Properties.Resources.mesa2;
            }
        }
        //Generamos un Button de Mesa mediana

        private void mesaMedianaButton_Click(object sender, EventArgs e)
        {
            SeleccionarCantSillas formCantSill = new(TipoDeMesa.Cuadrada);
            formCantSill.ShowDialog();
            int cantidadSillas = formCantSill.TipoInt;

            BotonMesa mesaMedianaBoton = new BotonMesa(new Mesa(BotonMesa.StaticID++, TipoDeMesa.Cuadrada, cantidadSillas));
            mesaMedianaBoton.Location = new Point(100, 100);
            mesaMedianaBoton.BackgroundImage = DeterminarImagen(ref mesaMedianaBoton, cantidadSillas);
            mesaMedianaBoton.Size = mesaMedianaBoton.BackgroundImage.Size;
            mesaMedianaBoton.Tag = mesaMedianaBoton.ClaseMesa.Id;
            mesaMedianaBoton.Text = "#" + mesaMedianaBoton.Tag.ToString();

            mesaMedianaBoton.MouseDown += Elemento_MouseDown;
            mesaMedianaBoton.MouseMove += Elemento_MouseMove;
            mesaMedianaBoton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(mesaMedianaBoton);
        }

        // se controla el movimiento de los distintos objetos en el layout 

        private void Elemento_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control? control = sender as Control;
                if (control != null)
                {
                    arrastrando = true;
                    offset = e.Location;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                Control? control = sender as Control;
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
                Control? control = sender as Control;
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
                Control? control = sender as Control;
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

        private void buttonSillaIndCuad_Click(object sender, EventArgs e)
        {

        }
    }
}

