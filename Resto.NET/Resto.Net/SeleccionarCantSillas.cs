using RestoBarClases;

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
                    2, 3, 4, 5, 6, 8
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
                    2, 4, 6, 8
                });
            }
            else if (TipoInt == 3)
            {
                comboBoxSelecCant.Items.AddRange(new object[]//Especiales
                {
                    10, 12
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

        private void SelecSillas_formClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void comboBoxSelecCant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
