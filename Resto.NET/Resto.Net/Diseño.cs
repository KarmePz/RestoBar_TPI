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
using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
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
                            return Properties.Resources.MesaRedonda2Roja;
                        case 1:
                            return Properties.Resources.MesaRedonda3Roja;
                        case 2:
                            return Properties.Resources.MesaRedonda4Roja;
                        case 3:
                            return Properties.Resources.MesaRedonda5Roja;
                        case 4:
                            return Properties.Resources.MesaRedonda6Roja;
                        default:
                            return Properties.Resources.MesaRedonda8Roja;
                    }

                case TipoDeMesa.Cuadrada:
                    switch (claseMesa.Sillas.Count)
                    {
                        case 0:
                            return Properties.Resources.MesaCuadrada4Roja;
                        default:
                            return Properties.Resources.MesaCuadrada8Roja;
                    }

                case TipoDeMesa.Rectangular:
                    switch (claseMesa.Sillas.Count)
                    {
                        case 0:
                            return Properties.Resources.MesasRectangular2Roja;
                        case 1:
                            return Properties.Resources.MesasRectangular4Roja;
                        case 2:
                            return Properties.Resources.MesasRectangular6Roja;
                        default:
                            return Properties.Resources.MesasRectangular8Roja;
                    }
                case TipoDeMesa.Especiales:
                    switch (claseMesa.Sillas.Count)
                    {
                        case 0:
                            return Properties.Resources.MesaEspecial10RojaCopia;
                        default:
                            return Properties.Resources.MesaEspecial12RojaCopia;
                    }

                default:
                    return Properties.Resources.MesasRectangular4Roja;
            }
        }
        // Generamos un BotonMesa de mesa Redonda
        private void mesaRedondaButton_Click(object sender, EventArgs e)
        {
            SeleccionarCantSillas formCantSill = new(TipoDeMesa.Redonda);
            formCantSill.ShowDialog();
            int cantidadSillas = formCantSill.TipoInt;



            BotonMesa mesaRedondaBoton = new BotonMesa(new Mesa(BotonMesa.StaticID++, TipoDeMesa.Redonda, cantidadSillas));
            mesaRedondaBoton.Location = new Point(100, 150);

            mesaRedondaBoton.BackgroundImage = DeterminarImagen(ref mesaRedondaBoton, cantidadSillas);
            mesaRedondaBoton.Size = mesaRedondaBoton.BackgroundImage.Size;
            mesaRedondaBoton.BackgroundImageLayout = ImageLayout.Zoom;

            mesaRedondaBoton.FlatStyle = FlatStyle.Flat;
            mesaRedondaBoton.FlatAppearance.BorderSize = 0;
            //mesaRedondaBoton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            mesaRedondaBoton.BackColor = Color.Transparent;
            //mesaRedondaBoton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            //mesaRedondaBoton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            mesaRedondaBoton.Tag = mesaRedondaBoton.ClaseMesa.Id;
            mesaRedondaBoton.Text = "#" + mesaRedondaBoton.Tag.ToString();



            mesaRedondaBoton.MouseDown += Elemento_MouseDown;
            mesaRedondaBoton.MouseMove += Elemento_MouseMove;
            mesaRedondaBoton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(mesaRedondaBoton);

        }

        //Generamos un BotonMesa de Mesa mediana
        private void mesaCuadradaButton_Click(object sender, EventArgs e)
        {
            SeleccionarCantSillas formCantSill = new(TipoDeMesa.Cuadrada);
            formCantSill.ShowDialog();
            int cantidadSillas = formCantSill.TipoInt;

            BotonMesa mesaCuadradaBoton = new BotonMesa(new Mesa(BotonMesa.StaticID++, TipoDeMesa.Cuadrada, cantidadSillas));
            mesaCuadradaBoton.Location = new Point(100, 100);

            mesaCuadradaBoton.BackgroundImage = DeterminarImagen(ref mesaCuadradaBoton, cantidadSillas);
            mesaCuadradaBoton.Size = mesaCuadradaBoton.BackgroundImage.Size;

            mesaCuadradaBoton.FlatStyle = FlatStyle.Flat;
            mesaCuadradaBoton.FlatAppearance.BorderSize = 0;
            //mesaCuadradaBoton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            mesaCuadradaBoton.BackColor = Color.Transparent;
            //mesaCuadradaBoton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            //mesaCuadradaBoton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            mesaCuadradaBoton.Tag = mesaCuadradaBoton.ClaseMesa.Id;
            mesaCuadradaBoton.Text = "#" + mesaCuadradaBoton.Tag.ToString();

            mesaCuadradaBoton.MouseDown += Elemento_MouseDown;
            mesaCuadradaBoton.MouseMove += Elemento_MouseMove;
            mesaCuadradaBoton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(mesaCuadradaBoton);
        }

        private void mesaRectangularButton_Click(object sender, EventArgs e)
        {
            SeleccionarCantSillas formCantSill = new(TipoDeMesa.Rectangular);
            formCantSill.ShowDialog();
            int cantidadSillas = formCantSill.TipoInt;

            BotonMesa mesaRectangularBoton = new BotonMesa(new Mesa(BotonMesa.StaticID++, TipoDeMesa.Rectangular, cantidadSillas));
            mesaRectangularBoton.Location = new Point(100, 100);

            mesaRectangularBoton.BackgroundImage = DeterminarImagen(ref mesaRectangularBoton, cantidadSillas);
            mesaRectangularBoton.Size = mesaRectangularBoton.BackgroundImage.Size;

            mesaRectangularBoton.FlatStyle = FlatStyle.Flat;
            mesaRectangularBoton.FlatAppearance.BorderSize = 0;
            //mesaRectangularBoton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            mesaRectangularBoton.BackColor = Color.Transparent;
            //mesaRectangularBoton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            //mesaRectangularBoton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            mesaRectangularBoton.Tag = mesaRectangularBoton.ClaseMesa.Id;
            mesaRectangularBoton.Text = "#" + mesaRectangularBoton.Tag.ToString();

            mesaRectangularBoton.MouseDown += Elemento_MouseDown;
            mesaRectangularBoton.MouseMove += Elemento_MouseMove;
            mesaRectangularBoton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(mesaRectangularBoton);
        }

        private void mesasEspecialesBoton_Click(object sender, EventArgs e)
        {
            SeleccionarCantSillas formCantSill = new(TipoDeMesa.Especiales);
            formCantSill.ShowDialog();
            int cantidadSillas = formCantSill.TipoInt;

            BotonMesa mesaEspecialesBoton = new BotonMesa(new Mesa(BotonMesa.StaticID++, TipoDeMesa.Especiales, cantidadSillas));
            mesaEspecialesBoton.Location = new Point(100, 100);

            mesaEspecialesBoton.BackgroundImage = DeterminarImagen(ref mesaEspecialesBoton, cantidadSillas);
            mesaEspecialesBoton.Size = new Size(200, 200);
            mesaEspecialesBoton.BackgroundImageLayout = ImageLayout.Zoom;

            mesaEspecialesBoton.FlatStyle = FlatStyle.Flat;
            mesaEspecialesBoton.FlatAppearance.BorderSize = 0;
            //mesaEspecialesBoton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            mesaEspecialesBoton.BackColor = Color.Transparent;
            //mesaEspecialesBoton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            //mesaEspecialesBoton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            mesaEspecialesBoton.Tag = mesaEspecialesBoton.ClaseMesa.Id;
            mesaEspecialesBoton.Text = "#" + mesaEspecialesBoton.Tag.ToString();

            mesaEspecialesBoton.MouseDown += Elemento_MouseDown;
            mesaEspecialesBoton.MouseMove += Elemento_MouseMove;
            mesaEspecialesBoton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(mesaEspecialesBoton);

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
                        elemento.Id = botonMesa.ClaseMesa.Id;
                        elemento.TipoMesa = botonMesa.ClaseMesa.Tipo.ToString();
                        elemento.CantidadSillas = botonMesa.ClaseMesa.Sillas.Count;
                        
                       //añadido recientemente
               
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
                BotonMesa.StaticID = 1;
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
                        botonMesa.FlatStyle = FlatStyle.Flat;
                        botonMesa.FlatAppearance.BorderSize = 0;
                        botonMesa.BackColor = Color.Transparent;
                        botonMesa.BackgroundImageLayout = ImageLayout.Zoom;


                        BotonMesa.StaticID = elemento.Id > BotonMesa.StaticID ? elemento.Id : BotonMesa.StaticID;
                        control = botonMesa;

                        control.MouseDown += Elemento_MouseDown;
                        control.MouseMove += Elemento_MouseMove;
                        control.MouseUp += Elemento_MouseUp;
                        
                    }
                    else if (elemento.Tipo == nameof(Panel))
                    {
                        control = new Panel
                        {
                            Size = new Size(elemento.Ancho, elemento.Alto),
                            BackColor = Color.FromArgb(elemento.ColorFondo),
                            Location = new Point(elemento.X, elemento.Y),
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        control.DoubleClick += Panel_DoubleClick;
                        control.MouseDown += new MouseEventHandler(Panel_MouseDown);
                        control.MouseMove += new MouseEventHandler(Panel_MouseMove);
                        control.MouseUp += new MouseEventHandler(Panel_MouseUp);
                    }
                    else
                    {
                        continue; // Si no es un tipo soportado, saltar
                    }

                    control.Text = elemento.Texto;
                    control.Location = new Point(elemento.X, elemento.Y);
                    control.Size = new Size(elemento.Ancho, elemento.Alto);
                    //control.BackColor = Color.FromArgb(elemento.ColorFondo);



                    panelDiseñoLayout.Controls.Add(control);
                }

                if (BotonMesa.StaticID > 1) BotonMesa.StaticID++;
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
        // AGREGAR ESTRUCTURA

        private bool resizing;
        private bool moving;
        private Panel currentPanel;
        private Point previousMousePosition;
        private const int GripSize = 10;
        private bool resizingWidth;
        private bool resizingHeight;

        //boton agregar estructura
        private void button1_Click(object sender, EventArgs e)
        {
            Panel newPanel = new Panel
            {
                Size = new Size(100, 100),
                BackColor = Color.Gray,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point((this.ClientSize.Width - 100) / 2, (this.ClientSize.Height - 100) / 2) // Centrar el panel
            };

            // Eventos para que el panel sea redimensionable y coloreable
            newPanel.DoubleClick += Panel_DoubleClick;
            newPanel.MouseDown += new MouseEventHandler(Panel_MouseDown);
            newPanel.MouseMove += new MouseEventHandler(Panel_MouseMove);
            newPanel.MouseUp += new MouseEventHandler(Panel_MouseUp);

            panelDiseñoLayout.Controls.Add(newPanel);
            newPanel.BringToFront(); // Traer el nuevo panel al frente
        }
        // no tocar (por las dudas xd)

        private void Panel_DoubleClick(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    panel.BackColor = colorDialog.Color;
                }
            }
        }
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentPanel = sender as Panel;
                previousMousePosition = e.Location;

                resizingWidth = e.X >= currentPanel.Width - GripSize;
                resizingHeight = e.Y >= currentPanel.Height - GripSize;

                if (resizingWidth || resizingHeight)
                {
                    resizing = true;
                    currentPanel.Cursor = Cursors.SizeNWSE;
                }
                else
                {
                    moving = true;
                    currentPanel.Cursor = Cursors.SizeAll;
                }
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;

            if (resizing)
            {
                if (resizingWidth && resizingHeight)
                {
                    panel.Width += e.X - previousMousePosition.X;
                    panel.Height += e.Y - previousMousePosition.Y;
                }
                else if (resizingWidth)
                {
                    panel.Width += e.X - previousMousePosition.X;
                }
                else if (resizingHeight)
                {
                    panel.Height += e.Y - previousMousePosition.Y;
                }
                previousMousePosition = e.Location;
            }
            else if (moving)
            {
                panel.Left += e.X - previousMousePosition.X;
                panel.Top += e.Y - previousMousePosition.Y;


                if (panel.Left < 0) panel.Left = 0;
                if (panel.Top < 0) panel.Top = 0;
                if (panel.Right > panel.Parent.ClientSize.Width) panel.Left = panel.Parent.ClientSize.Width - panel.Width;
                if (panel.Bottom > panel.Parent.ClientSize.Height) panel.Top = panel.Parent.ClientSize.Height - panel.Height;
            }
            else
            {
                // Cambiar el cursor cuando el mouse está sobre el borde para redimensionar
                if (e.X >= panel.Width - GripSize && e.Y >= panel.Height - GripSize)
                {
                    panel.Cursor = Cursors.SizeNWSE;
                }
                else if (e.X >= panel.Width - GripSize)
                {
                    panel.Cursor = Cursors.SizeWE;
                }
                else if (e.Y >= panel.Height - GripSize)
                {
                    panel.Cursor = Cursors.SizeNS;
                }
                else
                {
                    panel.Cursor = Cursors.Default;
                }
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                resizing = false;
                moving = false;
                resizingWidth = false;
                resizingHeight = false;
                currentPanel.Cursor = Cursors.Default;
            }
        }


        //Codigos de sillas
        //Modelo silla 1
        private void Silla1_Click(object sender, EventArgs e)
        {
            BotonSilla silla1Boton = new BotonSilla(new Silla(false));
            silla1Boton.Location = new Point(100, 100);

            silla1Boton.BackgroundImage = Properties.Resources.Silla1;
            silla1Boton.Size = silla1Boton.BackgroundImage.Size;

            silla1Boton.FlatStyle = FlatStyle.Flat;
            silla1Boton.FlatAppearance.BorderSize = 0;
            silla1Boton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            silla1Boton.BackColor = Color.Transparent;
            silla1Boton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            silla1Boton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //silla1Boton.Tag = silla1Boton.ClaseSilla.Id;
            //silla1Boton.Text = "#" + silla1Boton.Tag.ToString();

            silla1Boton.MouseDown += Elemento_MouseDown;
            silla1Boton.MouseMove += Elemento_MouseMove;
            silla1Boton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(silla1Boton);
        }

        private void Silla2_Click(object sender, EventArgs e)
        {
            BotonSilla silla2Boton = new BotonSilla(new Silla(false));
            silla2Boton.Location = new Point(100, 100);

            silla2Boton.BackgroundImage = Properties.Resources.Silla2;
            silla2Boton.Size = silla2Boton.BackgroundImage.Size;

            silla2Boton.FlatStyle = FlatStyle.Flat;
            silla2Boton.FlatAppearance.BorderSize = 0;
            silla2Boton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            silla2Boton.BackColor = Color.Transparent;
            silla2Boton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            silla2Boton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //silla1Boton.Tag = silla1Boton.ClaseSilla.Id;
            //silla1Boton.Text = "#" + silla1Boton.Tag.ToString();

            silla2Boton.MouseDown += Elemento_MouseDown;
            silla2Boton.MouseMove += Elemento_MouseMove;
            silla2Boton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(silla2Boton);
        }

        private void Silla3_Click(object sender, EventArgs e)
        {
            BotonSilla silla3Boton = new BotonSilla(new Silla(false));
            silla3Boton.Location = new Point(100, 100);

            silla3Boton.BackgroundImage = Properties.Resources.Silla3;
            silla3Boton.Size = silla3Boton.BackgroundImage.Size;

            silla3Boton.FlatStyle = FlatStyle.Flat;
            silla3Boton.FlatAppearance.BorderSize = 0;
            silla3Boton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            silla3Boton.BackColor = Color.Transparent;
            silla3Boton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            silla3Boton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            silla3Boton.MouseDown += Elemento_MouseDown;
            silla3Boton.MouseMove += Elemento_MouseMove;
            silla3Boton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(silla3Boton);
        }

        private void Silla4_Click(object sender, EventArgs e)
        {
            BotonSilla silla4Boton = new BotonSilla(new Silla(false));
            silla4Boton.Location = new Point(100, 100);

            silla4Boton.BackgroundImage = Properties.Resources.Silla4;
            silla4Boton.Size = silla4Boton.BackgroundImage.Size;

            silla4Boton.FlatStyle = FlatStyle.Flat;
            silla4Boton.FlatAppearance.BorderSize = 0;
            silla4Boton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            silla4Boton.BackColor = Color.Transparent;
            silla4Boton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            silla4Boton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            silla4Boton.MouseDown += Elemento_MouseDown;
            silla4Boton.MouseMove += Elemento_MouseMove;
            silla4Boton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(silla4Boton);
        }

        private void silla5_Click(object sender, EventArgs e)
        {
            BotonSilla silla5Boton = new BotonSilla(new Silla(false));
            silla5Boton.Location = new Point(100, 100);

            silla5Boton.BackgroundImage = Properties.Resources.Silla5;
            silla5Boton.Size = silla5Boton.BackgroundImage.Size;

            silla5Boton.FlatStyle = FlatStyle.Flat;
            silla5Boton.FlatAppearance.BorderSize = 0;
            silla5Boton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            silla5Boton.BackColor = Color.Transparent;
            silla5Boton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            silla5Boton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            silla5Boton.MouseDown += Elemento_MouseDown;
            silla5Boton.MouseMove += Elemento_MouseMove;
            silla5Boton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(silla5Boton);
        }

        private void silla6_Click(object sender, EventArgs e)
        {
            BotonSilla silla6Boton = new BotonSilla(new Silla(false));
            silla6Boton.Location = new Point(100, 100);

            silla6Boton.BackgroundImage = Properties.Resources.Silla6;
            silla6Boton.Size = silla6Boton.BackgroundImage.Size;

            silla6Boton.FlatStyle = FlatStyle.Flat;
            silla6Boton.FlatAppearance.BorderSize = 0;
            silla6Boton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            silla6Boton.BackColor = Color.Transparent;
            silla6Boton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            silla6Boton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            silla6Boton.MouseDown += Elemento_MouseDown;
            silla6Boton.MouseMove += Elemento_MouseMove;
            silla6Boton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(silla6Boton);
        }

        private void silla7_Click(object sender, EventArgs e)
        {
            BotonSilla silla7Boton = new BotonSilla(new Silla(false));
            silla7Boton.Location = new Point(100, 100);

            silla7Boton.BackgroundImage = Properties.Resources.Silla7;
            silla7Boton.Size = silla7Boton.BackgroundImage.Size;

            silla7Boton.FlatStyle = FlatStyle.Flat;
            silla7Boton.FlatAppearance.BorderSize = 0;
            silla7Boton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            silla7Boton.BackColor = Color.Transparent;
            silla7Boton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            silla7Boton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            silla7Boton.MouseDown += Elemento_MouseDown;
            silla7Boton.MouseMove += Elemento_MouseMove;
            silla7Boton.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(silla7Boton);
        }
    }
}

