using Resto.Net.Clases;
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

namespace Resto.Net
{
    public partial class Preview : Form
    {
        InicioForm inicio;//formulario previo
        private string archivoDiseñoActual;
        public Preview()
        {
            InitializeComponent();
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

        // Método para cargar los elementos en el panel de diseño
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
                        BotonMesa botonMesa = new BotonMesa(new Mesa(elemento.Id, tipoMesa, elemento.CantidadSillas),0);
                        botonMesa.BackgroundImage = DeterminarImagen(ref botonMesa, elemento.CantidadSillas);
                        botonMesa.FlatStyle = FlatStyle.Flat;
                        botonMesa.FlatAppearance.BorderSize = 0;
                        botonMesa.BackColor = Color.Transparent;
                        botonMesa.BackgroundImageLayout = ImageLayout.Zoom;

                        // Agregamos un context menu para establecer estado de la mesa
                        ContextMenuStrip menu = new ContextMenuStrip();
                        ToolStripMenuItem libreItem = new ToolStripMenuItem("Libre");
                        ToolStripMenuItem reservadaItem = new ToolStripMenuItem("Reservada");
                        ToolStripMenuItem ocupadaItem = new ToolStripMenuItem("Ocupada");

                        libreItem.Click += (s, args) => EstablecerEstadoMesa(botonMesa, EstadoMesa.Libre);
                        reservadaItem.Click += (s, args) => EstablecerEstadoMesa(botonMesa, EstadoMesa.Reservada);
                        ocupadaItem.Click += (s, args) => EstablecerEstadoMesa(botonMesa, EstadoMesa.Ocupada);

                        menu.Items.Add(libreItem);
                        menu.Items.Add(reservadaItem);
                        menu.Items.Add(ocupadaItem);

                        botonMesa.ContextMenuStrip = menu;

                        control = botonMesa;
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
            }
        }

        // Método para establecer el estado de la mesa
        private void EstablecerEstadoMesa(BotonMesa botonMesa, EstadoMesa estado)
        {
   
            int mesaId = botonMesa.ClaseMesa.Id;

            switch (estado)
            {
                case EstadoMesa.Libre:
                    botonMesa.BackColor = Color.Green; // Cambia el color o imagen del botón
                    break;
                case EstadoMesa.Reservada:
                    botonMesa.BackColor = Color.Yellow;
                    break;
                case EstadoMesa.Ocupada:
                    botonMesa.BackColor = Color.Red;
                    break;
                default:
                    break;
            }


        }

        // Clase enum para los estados de la mesa
        public enum EstadoMesa
        {
            Libre,
            Reservada,
            Ocupada
        }


    }
}

    
