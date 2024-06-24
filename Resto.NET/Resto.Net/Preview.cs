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
    public partial class Preview : Form
    {
        InicioForm inicio;//formulario previo
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
    }
}
