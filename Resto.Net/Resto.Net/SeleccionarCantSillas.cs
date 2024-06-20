using RestoBarClases;
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
    public partial class SeleccionarCantSillas : Form
    {
        public int TipoInt { get; set; }
        public SeleccionarCantSillas(TipoDeMesa tipoDeMesa)
        {
            InitializeComponent();
            TipoInt = (int)tipoDeMesa;
        }

        private void SeleccionarCantSillas_Load(object sender, EventArgs e)
        {
            if (TipoInt == 0) //Redonda
            {
                comboBoxSelecCant.Items.AddRange(new object[]
                {
                    2, 3, 4, 5, 6
                });
            }
            else if (TipoInt == 1) //Cuadrada
            {
                comboBoxSelecCant.Items.AddRange(new object[]
                {
                    4, 8
                });
            }
            else if (TipoInt == 2) //Rectangular
            {
                comboBoxSelecCant.Items.AddRange(new object[]
                {
                    2, 4, 6, 8, 10, 12
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxSelecCant.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una cantidad.", "Error en la seleccion", MessageBoxButtons.OK);
            }
            else
            {
                TipoInt = comboBoxSelecCant.SelectedIndex;
                Close();
            }
        }
    }
}
