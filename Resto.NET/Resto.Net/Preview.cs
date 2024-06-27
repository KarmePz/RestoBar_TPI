using Resto.Net.Clases;
using RestoBarClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Resto.Net.Preview;
using Timer = System.Windows.Forms.Timer;

namespace Resto.Net
{
    public partial class Preview : Form
    {

        InicioForm inicio;//formulario previo
        private string archivoDiseñoActual;
        List<Mozo> listaDeMozos = new List<Mozo>
            {
                new Mozo(1, "Juan Pérez"),
                new Mozo(2, "María González"),
                new Mozo(3, "Carlos López"),
                new Mozo(4, "Ana Martínez"),
                new Mozo(5, "Pedro Ramírez")
                // Puedes agregar más mozos según sea necesario
            };
        public Preview()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.inicio = (InicioForm)InicioForm.ActiveForm;

        }



        /*Al cerrarse el formulario con las herramientas de ventana de windows o 
         * con el boton salir, se vuelve a mostrar el formulario de inicio
         */
        //boton ventana salir evento
        private void Preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.inicio.Show();
            this.inicio.Location = this.Location;
            this.inicio.Size = this.Size;

        }
        //boton salir evento
        private void Salir_Click(object sender, EventArgs e)
        {
            inicio.Show();
            inicio.Location = this.Location;
            this.inicio.Size = this.Size;
            this.Close();
        }

        // Cargamos las mesas con sus respectivas sillas
        private Image DeterminarImagen(ref BotonMesa botonMesa, int cantSillas, Estado estado)
        {
            Mesa claseMesa = botonMesa.ClaseMesa;

            switch (claseMesa.Tipo)
            {
                case TipoDeMesa.Redonda:
                    switch (claseMesa.Sillas.Count)
                    {
                        case 0:
                            return estado == Estado.Libre ? Properties.Resources.MesaRedonda2Sillas_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesaRedonda2Sillas_reservada :
                                   Properties.Resources.MesaRedonda2Sillas;
                        case 1:
                            return estado == Estado.Libre ? Properties.Resources.MesaRedonda3_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesaRedonda3_reservada :
                                   Properties.Resources.MesaRedonda3Roja;
                        case 2:
                            return estado == Estado.Libre ? Properties.Resources.MesaRedonda4_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesaRedonda4_reservada :
                                   Properties.Resources.MesaRedonda4Roja;
                        case 3:
                            return estado == Estado.Libre ? Properties.Resources.MesaRedonda5_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesaRedonda5_reservada :
                                   Properties.Resources.MesaRedonda5Roja;
                        case 4:
                            return estado == Estado.Libre ? Properties.Resources.MesaRedonda6_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesaRedonda6_reservada :
                                   Properties.Resources.MesaRedonda6Roja;
                        default:
                            return estado == Estado.Libre ? Properties.Resources.MesaRedonda8_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesaRedonda8_reservada :
                                   Properties.Resources.MesaRedonda8Roja;
                    }

                case TipoDeMesa.Cuadrada:
                    switch (claseMesa.Sillas.Count)
                    {
                        case 0:
                            return estado == Estado.Libre ? Properties.Resources.MesaCuadrada4_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesaCuadrada4_reservada :
                                   Properties.Resources.MesaCuadrada4Roja;
                        default:
                            return estado == Estado.Libre ? Properties.Resources.MesaCuadrada8_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesaCuadrada8_reservada :
                                   Properties.Resources.MesaCuadrada8Roja;
                    }


                case TipoDeMesa.Rectangular:
                    switch (claseMesa.Sillas.Count)
                    {
                        case 0:
                            return estado == Estado.Libre ? Properties.Resources.MesasRectangular2_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesasRectangular2_reservada :
                                   Properties.Resources.MesasRectangular2Roja;
                        case 1:
                            return estado == Estado.Libre ? Properties.Resources.MesasRectangular4_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesasRectangular4_reservada :
                                   Properties.Resources.MesasRectangular4Roja;
                        case 2:
                            return estado == Estado.Libre ? Properties.Resources.MesasRectangular6_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesasRectangular6_reservada :
                                   Properties.Resources.MesasRectangular6Roja;
                        default:
                            return estado == Estado.Libre ? Properties.Resources.MesasRectangular8_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesasRectangular8_reservada :
                                   Properties.Resources.MesasRectangular8Roja;
                    }


                case TipoDeMesa.Especiales:

                    switch (claseMesa.Sillas.Count)
                    {
                        case 0:
                            return estado == Estado.Libre ? Properties.Resources.MesaEspecial10_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesaEspecial10_reservada :
                                   Properties.Resources.MesaEspecial10Roja;
                        default:
                            return estado == Estado.Libre ? Properties.Resources.MesaEspecial12_libre :
                                   estado == Estado.Reservada ? Properties.Resources.MesaEspecial12_reservada :
                                   Properties.Resources.MesaEspecial12Roja;
                    }
                default:
                    return Properties.Resources.MesasRectangular4Roja;
            }
        }

        // Evento para cargar el diseño 1
        private void diseño1Button_Click(object sender, EventArgs e)
        {
            panelDiseñoLayout.Controls.Clear();
            archivoDiseñoActual = "diseño_1.json";
            CargarDiseño(archivoDiseñoActual);
        }

        // Evento para cargar el diseño 2
        private void diseño2Button_Click(object sender, EventArgs e)
        {
            panelDiseñoLayout.Controls.Clear();
            archivoDiseñoActual = "diseño_2.json";
            CargarDiseño(archivoDiseñoActual);
        }

        // Evento para cargar el diseño 3
        private void diseño3Button_Click(object sender, EventArgs e)
        {
            panelDiseñoLayout.Controls.Clear();
            archivoDiseñoActual = "diseño_3.json";
            CargarDiseño(archivoDiseñoActual);
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
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.SmoothingMode = SmoothingMode.AntiAlias;

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
        private Image DeterminarImagenSilla(TipoDeSilla tipoDeSilla, Estado estado)
        {

            //Cambiar IMAGENES
            switch (tipoDeSilla)
            {
                case TipoDeSilla.Tipo1:
                    return estado == Estado.Libre ? Properties.Resources.Silla1_libre : Properties.Resources.Silla1;
                case TipoDeSilla.Tipo2:
                    return estado == Estado.Libre ? Properties.Resources.Silla2_libre : Properties.Resources.Silla2;
                case TipoDeSilla.Tipo3:
                    return estado == Estado.Libre ? Properties.Resources.Silla3_libre : Properties.Resources.Silla3;
                case TipoDeSilla.Tipo4:
                    return estado == Estado.Libre ? Properties.Resources.Silla4_libre : Properties.Resources.Silla4;
                case TipoDeSilla.Tipo5:
                    return estado == Estado.Libre ? Properties.Resources.Silla5_libre : Properties.Resources.Silla5;
                case TipoDeSilla.Tipo6:
                    return estado == Estado.Libre ? Properties.Resources.Silla6_libre : Properties.Resources.Silla6;
                case TipoDeSilla.Tipo7:
                    return estado == Estado.Libre ? Properties.Resources.Silla7_libre : Properties.Resources.Silla7;
                default:
                    return estado == Estado.Libre ? Properties.Resources.Silla1_libre : Properties.Resources.Silla1;
            }
        }





        // Método para cargar los elementos en el panel de diseño
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
                        botonMesa.BackgroundImage = DeterminarImagen(ref botonMesa, elemento.CantidadSillas, Estado.Libre);
                        botonMesa.FlatStyle = FlatStyle.Flat;
                        botonMesa.FlatAppearance.BorderSize = 0;
                        botonMesa.BackColor = Color.Transparent;
                        botonMesa.BackgroundImageLayout = ImageLayout.Zoom;
                        botonMesa.GradoRotacion = elemento.GradoRotacion;

                        //Se rota la imagen dependiendo el grado de rotacion
                        for (int i = 0; i < elemento.GradoRotacion; i++)
                        {
                            Bitmap imagenOriginal = new Bitmap(botonMesa.BackgroundImage);
                            Bitmap imagenRotada = RotarImagen(imagenOriginal, 90);
                            botonMesa.BackgroundImage = imagenRotada;
                            botonMesa.BackgroundImageLayout = ImageLayout.Zoom;
                        }


                        ContextMenuStrip menu = new ContextMenuStrip();
                        ToolStripMenuItem libreItem = new ToolStripMenuItem("Libre");
                        ToolStripMenuItem reservadaItem = new ToolStripMenuItem("Reservada");
                        ToolStripMenuItem ocupadaItem = new ToolStripMenuItem("Ocupada");
                        ToolStripMenuItem consumisiones = new ToolStripMenuItem("Agregar Consumo (Mesa)");
                        ToolStripMenuItem detallesDeConsumision = new ToolStripMenuItem("Ver Consumo(Mesa)");

                        libreItem.Click += (s, args) => EstablecerEstadoMesa(botonMesa, Estado.Libre);
                        reservadaItem.Click += (s, args) => EstablecerEstadoMesa(botonMesa, Estado.Reservada);
                        ocupadaItem.Click += (s, args) => EstablecerEstadoMesa(botonMesa, Estado.Ocupada);
                        consumisiones.Click += (s, args) => AgregarConsumision(botonMesa);
                        detallesDeConsumision.Click += (s, args) => VerConsumisiones(botonMesa);

                        // Submenú para asignar mozo
                        ToolStripMenuItem asignarMozoItem = new ToolStripMenuItem("Asignar Mozo");
                        foreach (var mozo in listaDeMozos)
                        {
                            ToolStripMenuItem mozoItem = new ToolStripMenuItem(mozo.Nombre);
                            mozoItem.Click += (s, args) => AsignarMozoAMesa(botonMesa, mozo);
                            asignarMozoItem.DropDownItems.Add(mozoItem);
                        }

                        // Agregar opción para ver detalles de la mesa
                        ToolStripMenuItem detallesItem = new ToolStripMenuItem("Detalles de la Mesa");
                        detallesItem.Click += (s, args) => VerDetallesMesa(botonMesa);

                        menu.Items.Add(libreItem);
                        menu.Items.Add(reservadaItem);
                        menu.Items.Add(ocupadaItem);
                        menu.Items.Add(new ToolStripSeparator());
                        menu.Items.Add(asignarMozoItem);
                        menu.Items.Add(consumisiones);
                        menu.Items.Add(detallesDeConsumision);
                        menu.Items.Add(detallesItem);
                        botonMesa.ContextMenuStrip = menu;




                        BotonMesa.StaticID = elemento.Id > BotonMesa.StaticID ? elemento.Id : BotonMesa.StaticID;
                        control = botonMesa;



                    }
                    else if (elemento.Tipo == nameof(BotonSilla))
                    {

                        TipoDeSilla tipoSilla = Enum.Parse<TipoDeSilla>(elemento.TipoDeSilla);
                        BotonSilla botonSilla = new BotonSilla(new Silla(elemento.Id, tipoSilla, true), 0);
                        botonSilla.BackgroundImage = DeterminarImagenSilla(tipoSilla, botonSilla.claseSilla.Estado);
                        botonSilla.FlatStyle = FlatStyle.Flat;
                        botonSilla.FlatAppearance.BorderSize = 0;
                        botonSilla.BackColor = Color.Transparent;
                        botonSilla.BackgroundImageLayout = ImageLayout.Zoom;
                        botonSilla.GradoRotacion = elemento.GradoRotacion;

                        //Se rota la imagen dependiendo el grado de rotacion
                        for (int i = 0; i < elemento.GradoRotacion; i++)
                        {
                            Bitmap imagenOriginal = new Bitmap(botonSilla.BackgroundImage);
                            Bitmap imagenRotada = RotarImagen(imagenOriginal, 90);
                            botonSilla.BackgroundImage = imagenRotada;
                            botonSilla.BackgroundImageLayout = ImageLayout.Zoom;
                        }


                        ContextMenuStrip menu = new ContextMenuStrip();
                        ToolStripMenuItem libreItem = new ToolStripMenuItem("Libre");
                        ToolStripMenuItem reservadaItem = new ToolStripMenuItem("Reservada");
                        ToolStripMenuItem ocupadaItem = new ToolStripMenuItem("Ocupada");
                        ToolStripMenuItem consumisiones = new ToolStripMenuItem("Agregar Consumo(Mesa)");
                        ToolStripMenuItem detallesDeConsumision = new ToolStripMenuItem("Ver Consumo (Silla)");

                        libreItem.Click += (s, args) => EstablecerEstadoSilla(botonSilla, Estado.Libre);
                        reservadaItem.Enabled = false;
                        ocupadaItem.Click += (s, args) => EstablecerEstadoSilla(botonSilla, Estado.Ocupada);
                        consumisiones.Click += (s, args) => AgregarConsumision(botonSilla);
                        detallesDeConsumision.Click += (s, args) => VerConsumisiones(botonSilla);

                        // Submenú para asignar mozo
                        ToolStripMenuItem asignarMozoItem = new ToolStripMenuItem("Asignar Mozo");
                        foreach (var mozo in listaDeMozos)
                        {
                            ToolStripMenuItem mozoItem = new ToolStripMenuItem(mozo.Nombre);
                            mozoItem.Click += (s, args) => AsignarMozoASilla(botonSilla, mozo);
                            asignarMozoItem.DropDownItems.Add(mozoItem);
                        }

                        // Agregar opción para ver detalles de la mesa
                        ToolStripMenuItem detallesItem = new ToolStripMenuItem("Detalles de la Silla");
                        detallesItem.Click += (s, args) => VerDetallesSilla(botonSilla);

                        menu.Items.Add(libreItem);
                        menu.Items.Add(reservadaItem);
                        menu.Items.Add(ocupadaItem);
                        menu.Items.Add(new ToolStripSeparator());
                        menu.Items.Add(asignarMozoItem);
                        menu.Items.Add(consumisiones);
                        menu.Items.Add(detallesDeConsumision);
                        menu.Items.Add(detallesItem);
                        botonSilla.ContextMenuStrip = menu;




                        BotonMesa.StaticID = elemento.Id > BotonMesa.StaticID ? elemento.Id : BotonMesa.StaticID;
                        control = botonSilla;



                    }
                    else if (elemento.Tipo == nameof(Panel))
                    {
                        control = new Panel
                        {
                            Size = new Size(elemento.Ancho, elemento.Alto),
                            BackColor = Color.FromArgb(elemento.ColorFondo),
                            Location = new Point(elemento.X, elemento.Y),
                            BorderStyle = BorderStyle.FixedSingle,

                        };

                    }
                    else
                    {
                        continue; // Si no es un tipo soportado, saltar
                    }

                    control.Text = elemento.Texto;
                    control.Location = new Point(elemento.X, elemento.Y);
                    control.Size = new Size(elemento.Ancho, elemento.Alto);




                    panelDiseñoLayout.Controls.Add(control);
                }

                if (BotonMesa.StaticID > 1) BotonMesa.StaticID++;
            }

        }

        // Método para agregar consumición a la mesa
        private void AgregarConsumision(BotonMesa botonMesa)
        {
            Consumisiones consumisiones = new Consumisiones();
            if (consumisiones.ShowDialog() == DialogResult.OK)
            {
                // Verificar si la consumición ya existe para actualizarla o agregarla nueva
                if (botonMesa.ClaseMesa.Consumo.ContainsKey(consumisiones.consumision))
                {
                    botonMesa.ClaseMesa.Consumo[consumisiones.consumision] += consumisiones.precio;
                }
                else
                {
                    botonMesa.ClaseMesa.Consumo.Add(consumisiones.consumision, consumisiones.precio);
                }
            }
        }
        private void AgregarConsumision(BotonSilla botonMesa)
        {
            Consumisiones consumisiones = new Consumisiones();
            if (consumisiones.ShowDialog() == DialogResult.OK)
            {
                // Verificar si la consumición ya existe para actualizarla o agregarla nueva
                if (botonMesa.claseSilla.Consumo.ContainsKey(consumisiones.consumision))
                {
                    botonMesa.claseSilla.Consumo[consumisiones.consumision] += consumisiones.precio;
                }
                else
                {
                    botonMesa.claseSilla.Consumo.Add(consumisiones.consumision, consumisiones.precio);
                }
            }
        }

        // Método para mostrar las consumiciones registradas en la mesa
        private void VerConsumisiones(BotonMesa botonMesa)
        {
            decimal total = 0;
            if (botonMesa.ClaseMesa.Consumo.Count > 0)
            {
                string consumisionesStr = "Consumiciones:\n";
                foreach (var consumision in botonMesa.ClaseMesa.Consumo)
                {
                    consumisionesStr += $"{consumision.Key}: ${consumision.Value}\n";
                    total += consumision.Value;
                }
                consumisionesStr += "\nTotal: $" + total;
                MessageBox.Show(consumisionesStr, "Consumiciones de la Mesa");
            }
            else
            {
                MessageBox.Show("No hay consumiciones registradas para esta mesa.", "Consumiciones de la Mesa");
            }
        }
        private void VerConsumisiones(BotonSilla botonSilla)
        {
            decimal total = 0;
            if (botonSilla.claseSilla.Consumo.Count > 0)
            {
                string consumisionesStr = "Consumiciones:\n";
                foreach (var consumision in botonSilla.claseSilla.Consumo)
                {
                    consumisionesStr += $"{consumision.Key}: ${consumision.Value}\n";
                    total += consumision.Value;
                }
                consumisionesStr += "\nTotal: $" + total;
                MessageBox.Show(consumisionesStr, "Consumiciones de la Silla individual");
            }
            else
            {
                MessageBox.Show("No hay consumiciones registradas para esta silla.", "Consumiciones de la Silla individual");
            }
        }


        // Método para establecer el estado de la mesa
        private void EstablecerEstadoMesa(BotonMesa botonMesa, Estado estado)
        {
            botonMesa.ClaseMesa.Estado = estado;
            botonMesa.BackgroundImage = DeterminarImagen(ref botonMesa, botonMesa.ClaseMesa.Sillas.Count, estado);

            for (int i = 0; i < botonMesa.GradoRotacion; i++)
            {
                Bitmap imagenOriginal = new Bitmap(botonMesa.BackgroundImage);
                Bitmap imagenRotada = RotarImagen(imagenOriginal, 90);
                botonMesa.BackgroundImage = imagenRotada;
                botonMesa.BackgroundImageLayout = ImageLayout.Zoom;
            }



            // Verifica si ya hay una etiqueta de tiempo presente y detiene el temporizador si existe
            Label existeEtiqueta = null;
            foreach (Control control in botonMesa.Controls)
            {
                if (control is Label label && label.Name == "timerLabel")
                {
                    existeEtiqueta = label;
                    break;
                }
            }
            if (existeEtiqueta != null)
            {
                existeEtiqueta.Dispose();
                if (botonMesa.Tag is Timer timer)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            }

            // Agregar etiqueta con contador si el estado es Ocupada
            if (estado == Estado.Ocupada)
            {
                // Crear la etiqueta
                Label timerLabel = new Label();
                timerLabel.Name = "timerLabel";
                timerLabel.AutoSize = true;
                timerLabel.BackColor = Color.Transparent;
                timerLabel.ForeColor = Color.White;
                timerLabel.Font = new Font("Arial", 6, FontStyle.Bold);
                timerLabel.Text = "Tiempo: 0s";
                timerLabel.Tag = 0; // Tag para almacenar el tiempo transcurrido

                // Añadir etiqueta al BotonMesa
                //botonMesa.Controls.Add(timerLabel);

                timerLabel.Location = new Point(45, 50);

                int tiempoTranscurrido = 0;
                // Evento Tick del Timer para actualizar el contador
                botonMesa.permanenciaTimer.Tick += (s, e) =>
                {
                    tiempoTranscurrido++;
                    botonMesa.Tag = tiempoTranscurrido;
                    botonMesa.TiempoTranscurrido = tiempoTranscurrido; // Almacena el tiempo transcurrido en la propiedad

                    int horas = tiempoTranscurrido / 3600;
                    int minutos = (tiempoTranscurrido % 3600) / 60;
                    int segundos = tiempoTranscurrido % 60;
                };

                // Iniciar el temporizador
                botonMesa.permanenciaTimer.Start();

                // Colocamos el temporizador en el BotonMesa
                botonMesa.Tag = botonMesa.permanenciaTimer;
            }
        }
        private void EstablecerEstadoSilla(BotonSilla botonSilla, Estado estado)
        {
            botonSilla.claseSilla.Estado = estado;
            botonSilla.BackgroundImage = DeterminarImagenSilla(botonSilla.claseSilla.TipoSilla, estado);

            for (int i = 0; i < botonSilla.GradoRotacion; i++)
            {
                Bitmap imagenOriginal = new Bitmap(botonSilla.BackgroundImage);
                Bitmap imagenRotada = RotarImagen(imagenOriginal, 90);
                botonSilla.BackgroundImage = imagenRotada;
                botonSilla.BackgroundImageLayout = ImageLayout.Zoom;
            }


            // Verifica si ya hay una etiqueta de tiempo presente y detiene el temporizador si existe
            Label existeEtiqueta = null;
            foreach (Control control in botonSilla.Controls)
            {
                if (control is Label label && label.Name == "timerLabel")
                {
                    existeEtiqueta = label;
                    break;
                }
            }
            if (existeEtiqueta != null)
            {
                existeEtiqueta.Dispose();
                if (botonSilla.Tag is Timer timer)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            }

            // Agregar etiqueta con contador si el estado es Ocupada
            if (estado == Estado.Ocupada)
            {
                // Crear la etiqueta
                Label timerLabel = new Label();
                timerLabel.Name = "timerLabel";
                timerLabel.AutoSize = true;
                timerLabel.BackColor = Color.Transparent;
                timerLabel.ForeColor = Color.White;
                timerLabel.Font = new Font("Arial", 6, FontStyle.Bold);
                timerLabel.Text = "Tiempo: 0s";

                timerLabel.Tag = 0; // Tag para almacenar el tiempo transcurrido

                // Añadir etiqueta al BotonMesa
                botonSilla.Controls.Add(timerLabel);
                timerLabel.Location = new Point(45, 50);


                // Evento Tick del Timer para actualizar el contador
                int tiempoTranscurrido = 0;
                botonSilla.permanenciaTimer.Tick += (s, e) =>
                {
                    tiempoTranscurrido++;
                    botonSilla.Tag = tiempoTranscurrido;
                    botonSilla.TiempoTranscurrido = tiempoTranscurrido; // Almacena el tiempo transcurrido en la propiedad

                    int horas = tiempoTranscurrido / 3600;
                    int minutos = (tiempoTranscurrido % 3600) / 60;
                    int segundos = tiempoTranscurrido % 60;

                };

                // Iniciar el temporizador
                botonSilla.permanenciaTimer.Start();
                // Colocamos el temporizador en el BotonMesa
                botonSilla.Tag = botonSilla.permanenciaTimer;
            }
        }
        // Método para asignar un mozo a una mesa
        private void AsignarMozoAMesa(BotonMesa botonMesa, Mozo mozo)
        {
            botonMesa.ClaseMesa.MozoAsignado = mozo;
            MessageBox.Show("Mozo Asignado: " + mozo.Nombre, "Aviso");
        }
        private void AsignarMozoASilla(BotonSilla botonSilla, Mozo mozo)
        {
            botonSilla.claseSilla.MozoAsignado = mozo;
            MessageBox.Show("Mozo Asignado: " + mozo.Nombre, "Aviso");
        }

        // Método para ver detalles de la mesa
        private void VerDetallesMesa(BotonMesa botonMesa)
        {
            string estadoMesa;
            string mozoAsignado;

            // Obtener estado de la mesa
            switch (botonMesa.ClaseMesa.Estado)
            {
                case Estado.Libre: // Color verde
                    estadoMesa = "Libre";
                    break;
                case Estado.Reservada: // Color amarillo
                    estadoMesa = "Reservada";
                    break;
                case Estado.Ocupada: // Color rojo
                    estadoMesa = "Ocupada";
                    break;
                default:
                    estadoMesa = "Desconocido";
                    break;
            }


            // Obtener mozo asignado a la mesa
            if (botonMesa.ClaseMesa.MozoAsignado != null)
            {
                mozoAsignado = botonMesa.ClaseMesa.MozoAsignado.Nombre;
            }
            else
            {
                mozoAsignado = "Sin asignar";
            }

            DetallesForm detallesForm = new DetallesForm();
            detallesForm.EstadoLabel.Text += estadoMesa;

            //tiempo de permanencia
            if (estadoMesa is "Ocupada")
            {
                botonMesa.permanenciaTimer.Tick += (s, e) =>
                {

                    int tiempoTranscurrido = botonMesa.TiempoTranscurrido;
                    int horas = tiempoTranscurrido / 3600;
                    int minutos = (tiempoTranscurrido % 3600) / 60;
                    int segundos = tiempoTranscurrido % 60;

                    string tiempoTranscurridoTexto;
                    if (horas > 0)
                    {
                        tiempoTranscurridoTexto = $"{horas}h: {minutos}min: {segundos}s";
                    }
                    else if (minutos > 0)
                    {
                        tiempoTranscurridoTexto = $"{minutos}min: {segundos}s";
                    }
                    else
                    {
                        tiempoTranscurridoTexto = $"{segundos}s";
                    }
                    detallesForm.PermanenciaLabel.Text = "Permanencia: " + tiempoTranscurridoTexto;
                };

            }
            else if (estadoMesa is "Reservada")
            {

                detallesForm.PermanenciaLabel.Text = "Permanencia: Mesa reservada";
            }
            else detallesForm.PermanenciaLabel.Text = "Permanencia: Mesa libre";


            detallesForm.MozoLabel.Text += mozoAsignado;
            detallesForm.ID_Label.Text += botonMesa.Text;

            detallesForm.MesapictureBox.BackgroundImage = botonMesa.BackgroundImage;

            detallesForm.Show();

        }
        private void VerDetallesSilla(BotonSilla botonSilla)
        {
            string estadoSilla;
            string mozoAsignado;

            // Obtener estado de la mesa
            switch (botonSilla.claseSilla.Estado)
            {
                case Estado.Libre: // Color verde
                    estadoSilla = "Libre";
                    break;
                case Estado.Ocupada: // Color rojo
                    estadoSilla = "Ocupada";
                    break;
                default:
                    estadoSilla = "Desconocido";
                    break;
            }
            //tiempo de permanencia



            // Obtener mozo asignado a la mesa
            if (botonSilla.claseSilla.MozoAsignado != null)
            {
                mozoAsignado = botonSilla.claseSilla.MozoAsignado.Nombre;
            }
            else
            {
                mozoAsignado = "Sin asignar";
            }

            DetallesForm detallesForm = new DetallesForm();
            detallesForm.EstadoLabel.Text += estadoSilla;

            if (estadoSilla is "Ocupada")
            {
                botonSilla.permanenciaTimer.Tick += (s, e) =>
                {

                    int tiempoTranscurrido = botonSilla.TiempoTranscurrido;
                    int horas = tiempoTranscurrido / 3600;
                    int minutos = (tiempoTranscurrido % 3600) / 60;
                    int segundos = tiempoTranscurrido % 60;

                    string tiempoTranscurridoTexto;
                    if (horas > 0)
                    {
                        tiempoTranscurridoTexto = $"{horas}h: {minutos}min: {segundos}s";
                    }
                    else if (minutos > 0)
                    {
                        tiempoTranscurridoTexto = $"{minutos}min: {segundos}s";
                    }
                    else
                    {
                        tiempoTranscurridoTexto = $"{segundos}s";
                    }
                    detallesForm.PermanenciaLabel.Text = "Permanencia: " + tiempoTranscurridoTexto;
                };

            }
            else detallesForm.PermanenciaLabel.Text = "Permanencia: Silla libre";






            detallesForm.MozoLabel.Text += mozoAsignado;
            detallesForm.ID_Label.Text = "Numero de la silla: " + botonSilla.Text;

            detallesForm.MesapictureBox.BackgroundImage = botonSilla.BackgroundImage;

            detallesForm.Show();


            //todo agregar consumo
        }

       
        
        private void buton_MouseLeave(object sender, EventArgs e)//al salir el mouse
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 37, 43, 52);
            Cursor = Cursors.Default;
        }

        private void buton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 113, 188, 252);
            Cursor = Cursors.Hand;
        }

        // Clase enum para los estados de la mesa
        public enum Estado
        {
            Libre,
            Reservada,
            Ocupada
        }



    }
}

    
