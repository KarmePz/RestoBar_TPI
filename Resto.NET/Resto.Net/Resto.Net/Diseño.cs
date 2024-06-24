using RestoBarClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resto.Net.Clases;
namespace Resto.Net
{
    public partial class Diseño : Form
    {
        InicioForm inicio;//formulario previo
        private Point lastLocation;//ultima localizacion del control
        private Point offset;
        private bool arrastrando = false;
        private string archivoDiseñoActual; // determinamos cual es el diseño que se esta usando actuamente
        public Diseño()
        {
            InitializeComponent();
            this.inicio = (InicioForm)InicioForm.ActiveForm;

            panelDiseñoLayout.DragDrop += panelDiseñoLayout_DragDrop;
            panelDiseñoLayout.DragEnter += panelDiseñoLayout_DragEnter;


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

        // Cargamos las mesas con sus respectivas sillas
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
                        case 2:
                        case 3:
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
                        default:
                            return Properties.Resources.mesa2;
                    }
                case TipoDeMesa.Rectangular:
                    return Properties.Resources.mesa2;
                default:
                    return Properties.Resources.mesa2;
            }
        }
        // Generamos un BotonMesa de mesa chica
        private void mesaChicaButton_Click(object sender, EventArgs e)
        {
            CantSillasForm formCantSill = new(TipoDeMesa.Redonda);
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

        //Generamos un BotonMesa de Mesa mediana
        private void mesaMedianaButton_Click(object sender, EventArgs e)
        {
            CantSillasForm formCantSill = new(TipoDeMesa.Cuadrada);
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

        // Cargamos los elementos del Diseño 1
        private void diseño1Button_Click(object sender, EventArgs e)
        {
            panelDiseñoLayout.Controls.Clear();
            archivoDiseñoActual = "diseño_1.json";
            CargarDiseño(archivoDiseñoActual);
        }

        // Cargamos los elementos del Diseño 2
        private void diseño2Button_Click(object sender, EventArgs e)
        {
            panelDiseñoLayout.Controls.Clear();
            archivoDiseñoActual = "diseño_2.json";
            CargarDiseño(archivoDiseñoActual);
        }

        // Cargamos los elementos del Diseño 3
        private void diseño3Button_Click(object sender, EventArgs e)
        {
            panelDiseñoLayout.Controls.Clear();
            archivoDiseñoActual = "diseño_3.json";
            CargarDiseño(archivoDiseñoActual);
        }

        // Guardamos los elementos del panel de diseño
        private void guardarButton_Click(object sender, EventArgs e)
        {
            GuardarEtiquetas();
        }

        private void GuardarEtiquetas()
        {
            if (!string.IsNullOrEmpty(archivoDiseñoActual))
            {
                var elementos = new List<ElementoGuardado>();
                foreach (Control control in panelDiseñoLayout.Controls)
                {
                    // Creamos instancias de ElementoGuardado para poder serializar los elementos del
                    // panel de diseño
                    ElementoGuardado elemento = new ElementoGuardado
                    {
                        Tipo = control.GetType().Name,
                        Texto = control.Text,
                        X = control.Location.X,
                        Y = control.Location.Y,
                        Ancho = control.Width,
                        Alto = control.Height,
                        ColorFondo = control.BackColor.ToArgb()
                    };

                    if (control is BotonMesa botonMesa)
                    {
                        elemento.TipoMesa = botonMesa.ClaseMesa.Tipo.ToString();
                        elemento.CantidadSillas = botonMesa.ClaseMesa.Sillas.Count;
                    }

                    elementos.Add(elemento);
                }

                string json = JsonSerializer.Serialize(elementos);
                File.WriteAllText(archivoDiseñoActual, json);
            }
            else
            {
                MessageBox.Show("Seleccione un diseño primero.");
            }
        }
        
        // Cargamos los elementos en el panel diseño
        private void CargarDiseño(string archivo)
        {
            if (File.Exists(archivo))
            {
                panelDiseñoLayout.Controls.Clear();
                string json = File.ReadAllText(archivo);
                var elementos = JsonSerializer.Deserialize<List<ElementoGuardado>>(json);

                foreach (var elemento in elementos)
                {
                    Control control;
                    if (elemento.Tipo == nameof(BotonMesa))
                    {
                        TipoDeMesa tipoMesa = Enum.Parse<TipoDeMesa>(elemento.TipoMesa);
                        BotonMesa botonMesa = new BotonMesa(new Mesa(elemento.Id, tipoMesa, elemento.CantidadSillas));
                        botonMesa.BackgroundImage = DeterminarImagen(ref botonMesa, elemento.CantidadSillas);
                        control = botonMesa;
                    }
                    else
                    {
                        continue; // Si no es un tipo soportado, saltar
                    }

                    control.Text = elemento.Texto;
                    control.Location = new Point(elemento.X, elemento.Y);
                    control.Size = new Size(elemento.Ancho, elemento.Alto);
                    control.BackColor = Color.FromArgb(elemento.ColorFondo);

                    control.MouseDown += Elemento_MouseDown;
                    control.MouseMove += Elemento_MouseMove;
                    control.MouseUp += Elemento_MouseUp;

                    panelDiseñoLayout.Controls.Add(control);
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

