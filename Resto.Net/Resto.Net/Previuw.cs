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
    public partial class Previuw : Form
    {
        InicioForm inicio;
        public Previuw()
        {
            InitializeComponent();
            this.inicio = (InicioForm)InicioForm.ActiveForm;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.inicio.Show();
            this.inicio.Location = this.Location;
            this.Close();
        }

        private void Preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.inicio.Show();
            this.inicio.Location = this.Location;
        
        }

      
    }
}
