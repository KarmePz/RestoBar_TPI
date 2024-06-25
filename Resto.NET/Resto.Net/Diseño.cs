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
        private void CrearBotonMesa(TipoDeMesa tipoDeMesa)
        {
            SeleccionarCantSillas formCantSill = new(tipoDeMesa);
            formCantSill.ShowDialog();
            int cantidadSillas = formCantSill.TipoInt;

            BotonMesa nuevoBotonMesa = new BotonMesa(new Mesa(BotonMesa.StaticID++, tipoDeMesa, cantidadSillas), 0);
            nuevoBotonMesa.Location = new Point(100, 100);

            nuevoBotonMesa.BackgroundImage = DeterminarImagen(ref nuevoBotonMesa, cantidadSillas);
            nuevoBotonMesa.Size = nuevoBotonMesa.BackgroundImage.Size;
            nuevoBotonMesa.BackgroundImageLayout = ImageLayout.Zoom;

            nuevoBotonMesa.FlatStyle = FlatStyle.Flat;
            nuevoBotonMesa.FlatAppearance.BorderSize = 0;
            nuevoBotonMesa.ContextMenuStrip = contextMenuLayoutItem;
            nuevoBotonMesa.BackColor = Color.Transparent;

            nuevoBotonMesa.Tag = nuevoBotonMesa.ClaseMesa.Id;
            nuevoBotonMesa.Text = "#" + nuevoBotonMesa.Tag.ToString();

            nuevoBotonMesa.MouseDown += Elemento_MouseDown;
            nuevoBotonMesa.MouseMove += Elemento_MouseMove;
            nuevoBotonMesa.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(nuevoBotonMesa);
        }
        private void mesaRedondaButton_Click(object sender, EventArgs e)
        {
            CrearBotonMesa(TipoDeMesa.Redonda);
        }

        private void mesaCuadradaButton_Click(object sender, EventArgs e)
        {
            CrearBotonMesa(TipoDeMesa.Cuadrada);
        }

        private void mesaRectangularButton_Click(object sender, EventArgs e)
        {
            CrearBotonMesa(TipoDeMesa.Rectangular);
        }

        private void mesasEspecialesBoton_Click(object sender, EventArgs e)
        {
            CrearBotonMesa(TipoDeMesa.Especiales);

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
                        elemento.GradoRotacion = botonMesa.GradoRotacion;

                        //añadido recientemente

                    }
                    if (control is BotonSilla botonSilla)
                    {
                        elemento.Id = botonSilla.claseSilla.Id;
                        elemento.TipoDeSilla = botonSilla.claseSilla.TipoSilla.ToString();
                        elemento.GradoRotacion = botonSilla.GradoRotacion;
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
                        BotonMesa botonMesa = new BotonMesa(new Mesa(elemento.Id, tipoMesa, elemento.CantidadSillas), 0);
                        botonMesa.BackgroundImage = DeterminarImagen(ref botonMesa, elemento.CantidadSillas);
                        botonMesa.FlatStyle = FlatStyle.Flat;
                        botonMesa.FlatAppearance.BorderSize = 0;
                        botonMesa.BackColor = Color.Transparent;
                        botonMesa.BackgroundImageLayout = ImageLayout.Zoom;
                        botonMesa.ContextMenuStrip = contextMenuLayoutItem;
                        botonMesa.GradoRotacion = elemento.GradoRotacion;
                        for (int i = 0; i < elemento.GradoRotacion; i++)
                        {
                            Bitmap imagenOriginal = new Bitmap(botonMesa.BackgroundImage);
                            Bitmap imagenRotada = RotarImagen(imagenOriginal, 90);
                            botonMesa.BackgroundImage = imagenRotada;
                            botonMesa.BackgroundImageLayout = ImageLayout.Zoom;
                        }

                        BotonMesa.StaticID = elemento.Id > BotonMesa.StaticID ? elemento.Id : BotonMesa.StaticID;
                        control = botonMesa;

                        control.MouseDown += Elemento_MouseDown;
                        control.MouseMove += Elemento_MouseMove;
                        control.MouseUp += Elemento_MouseUp;

                    }
                    else if (elemento.Tipo == nameof(BotonSilla))
                    {
                        TipoDeSilla tipoSilla = Enum.Parse<TipoDeSilla>(elemento.TipoDeSilla);
                        BotonSilla botonSilla = new BotonSilla(new Silla(elemento.Id, tipoSilla, false), 0);
                        botonSilla.BackgroundImage = DeterminarImagenSilla(tipoSilla);
                        botonSilla.FlatStyle = FlatStyle.Flat;
                        botonSilla.FlatAppearance.BorderSize = 0;
                        botonSilla.BackColor = Color.Transparent;
                        botonSilla.BackgroundImageLayout = ImageLayout.Zoom;
                        botonSilla.ContextMenuStrip = contextMenuLayoutItem;
                        botonSilla.GradoRotacion = elemento.GradoRotacion;

                        for (int i = 0; i < elemento.GradoRotacion; i++)
                        {
                            Bitmap imagenOriginal = new Bitmap(botonSilla.BackgroundImage);
                            Bitmap imagenRotada = RotarImagen(imagenOriginal, 90);
                            botonSilla.BackgroundImage = imagenRotada;
                            botonSilla.BackgroundImageLayout = ImageLayout.Zoom;
                        }

                        //BotonSilla.StaticID = elemento.
                        BotonMesa.StaticID = elemento.Id > BotonSilla.StaticID ? elemento.Id : BotonSilla.StaticID;
                        control = botonSilla;

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
                            BorderStyle = BorderStyle.FixedSingle,
                            ContextMenuStrip = contextMenuLayoutItem
                        };



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
            newPanel.ContextMenuStrip = contextMenuLayoutItem;


            // Eventos para que el panel sea redimensionable y coloreable

            newPanel.MouseDown += new MouseEventHandler(Panel_MouseDown);
            newPanel.MouseMove += new MouseEventHandler(Panel_MouseMove);
            newPanel.MouseUp += new MouseEventHandler(Panel_MouseUp);

            panelDiseñoLayout.Controls.Add(newPanel);
            newPanel.BringToFront(); // Traer el nuevo panel al frente
        }
        // no tocar (por las dudas xd)


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
            AgregarBotonSilla(TipoDeSilla.Tipo1);
        }

        private void Silla2_Click(object sender, EventArgs e)
        {
            AgregarBotonSilla(TipoDeSilla.Tipo2);
        }

        private void Silla3_Click(object sender, EventArgs e)
        {
            AgregarBotonSilla(TipoDeSilla.Tipo3);
        }

        private void Silla4_Click(object sender, EventArgs e)
        {
            AgregarBotonSilla(TipoDeSilla.Tipo4);
        }

        private void silla5_Click(object sender, EventArgs e)
        {
            AgregarBotonSilla(TipoDeSilla.Tipo5);
        }

        private void silla6_Click(object sender, EventArgs e)
        {
            AgregarBotonSilla(TipoDeSilla.Tipo6);
        }

        private void silla7_Click(object sender, EventArgs e)
        {
            AgregarBotonSilla(TipoDeSilla.Tipo7);
        }


        private void AgregarBotonSilla(TipoDeSilla tipoDeSilla)
        {
            BotonSilla botonSilla = new BotonSilla(new Silla(BotonSilla.StaticID++, tipoDeSilla, false), 0);
            botonSilla.Location = new Point(100, 100);
            botonSilla.BackgroundImage = DeterminarImagenSilla(tipoDeSilla);
            botonSilla.Size = botonSilla.BackgroundImage.Size;
            botonSilla.FlatStyle = FlatStyle.Flat;
            botonSilla.FlatAppearance.BorderSize = 0;
            botonSilla.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            botonSilla.BackColor = Color.Transparent;
            botonSilla.ContextMenuStrip = contextMenuLayoutItem;
            botonSilla.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botonSilla.FlatAppearance.MouseOverBackColor = Color.Transparent;


            botonSilla.Tag = botonSilla.claseSilla.Id;
            botonSilla.Text = "#" + botonSilla.Tag.ToString();

            botonSilla.MouseDown += Elemento_MouseDown;
            botonSilla.MouseMove += Elemento_MouseMove;
            botonSilla.MouseUp += Elemento_MouseUp;

            panelDiseñoLayout.Controls.Add(botonSilla);
        }
        private Image DeterminarImagenSilla(TipoDeSilla tipoDeSilla)
        {
            switch (tipoDeSilla)
            {
                case TipoDeSilla.Tipo1:
                    return Properties.Resources.Silla1;
                case TipoDeSilla.Tipo2:
                    return Properties.Resources.Silla2;
                case TipoDeSilla.Tipo3:
                    return Properties.Resources.Silla3;
                case TipoDeSilla.Tipo4:
                    return Properties.Resources.Silla4;
                case TipoDeSilla.Tipo5:
                    return Properties.Resources.Silla5;
                case TipoDeSilla.Tipo6:
                    return Properties.Resources.Silla6;
                case TipoDeSilla.Tipo7:
                    return Properties.Resources.Silla7;
                default:
                    return Properties.Resources.Silla1;
            }
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;//obtener el toolstrip del evento

            ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;//obtener el CMenuStrip asociado

            Control control = menu.SourceControl as Control;

            if (control != null)
            {
                panelDiseñoLayout.Controls.Remove(control);
                control.Dispose(); // Liberar recursos del control eliminado
            }

        }

        private void Editar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;//obtener el toolstrip del evento

            ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;//obtener el CMenuStrip asociado

            Control control = menu.SourceControl as Control;

            switch (e.ClickedItem.Text)
            {
                case "Color":
                    // Acción para "color"
                    //Cambia de color el panel
                    using (ColorDialog colorDialog = new ColorDialog())
                    {
                        if (colorDialog.ShowDialog() == DialogResult.OK)
                        {
                            control.BackColor = colorDialog.Color;
                        }
                    }

                    break;
                case "ID":
                    // Acción para "Open"
                    MessageBox.Show("NO IMPLEMENTADO");
                    break;
                case "Nombre":
                    // Acción para "Save"
                    EditarNombre_form editarNombre = new EditarNombre_form();
                    editarNombre.ShowDialog();
                    Label label = new Label();
                    label.Text = editarNombre.Texto;
                    label.AutoSize = true;
                    label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);

                    control.Controls.Add(label);
                    break;
                default:
                    // Acción predeterminada
                    MessageBox.Show("NO IMPLEMENTADO");
                    break;
            }
        }

        private void moverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NO IMPLEMENTADO");
        }

        private void verDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NO IMPLEMENTADO");
        }

        private void rotarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contextMenuLayoutItem.SourceControl is BotonSilla botonSilla)
            {
                Bitmap imagenOriginal = new Bitmap(botonSilla.BackgroundImage);
                Bitmap imagenRotada = RotarImagen(imagenOriginal, 90);
                CambiarDimensionesBoton(botonSilla);
                botonSilla.BackgroundImage = imagenRotada;
                botonSilla.BackgroundImageLayout = ImageLayout.Zoom;
                botonSilla.GradoRotacion = botonSilla.GradoRotacion == 3 ? 0 : botonSilla.GradoRotacion + 1;
            }
            else if (contextMenuLayoutItem.SourceControl is BotonMesa botonMesa)
            {
                Bitmap imagenOriginal = new Bitmap(botonMesa.BackgroundImage);
                Bitmap imagenRotada = RotarImagen(imagenOriginal, 90);
                CambiarDimensionesBoton(botonMesa);
                botonMesa.BackgroundImage = imagenRotada;
                botonMesa.BackgroundImageLayout = ImageLayout.Zoom;
                botonMesa.GradoRotacion = botonMesa.GradoRotacion == 3 ? 0 : botonMesa.GradoRotacion + 1;

            }
        }
        private Bitmap RotarImagen(Bitmap bmp, float angulo)
        {
            // intercambia las dimensiones
            int nuevaAnchura, nuevaAltura;
            nuevaAnchura = bmp.Height;
            nuevaAltura = bmp.Width;
            Bitmap imagenRotada = new Bitmap(nuevaAnchura, nuevaAltura);
            using (Graphics g = Graphics.FromImage(imagenRotada))
            {
                // Ajusta la calidad de dibujo
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Traslada el gráfico para que el centro de la imagen quede en el centro del lienzo
                g.TranslateTransform((float)nuevaAnchura / 2, (float)nuevaAltura / 2);
                g.RotateTransform(angulo);
                g.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

                // Dibuja la imagen rotada
                g.DrawImage(bmp, new Point(0, 0));
            }
            return imagenRotada;
        }
        private void CambiarDimensionesBoton(Control boton)
        {
            int nuevaAnchura = boton.Height;
            int nuevaAltura = boton.Width;
            boton.Size = new Size(nuevaAnchura, nuevaAltura);
        }
    }
}
