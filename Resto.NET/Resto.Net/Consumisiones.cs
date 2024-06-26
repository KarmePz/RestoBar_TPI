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
    public partial class Consumisiones : Form
    {
        public string consumision {  get; set; }
        public decimal precio {  get; set; }
        public Consumisiones()
        {
            InitializeComponent();
        }

        private void agregarConsumisionButton_Click(object sender, EventArgs e)
        {
            consumision = nombreConsumision.Text;    
            precio = decimal.Parse(precioConsumision.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
