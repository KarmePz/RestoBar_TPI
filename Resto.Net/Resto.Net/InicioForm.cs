using System.Runtime.CompilerServices;

namespace Resto.Net
{
    public partial class InicioForm : Form
    {

        public InicioForm()
        {
            InitializeComponent();

        }
        //Llamado de referencia a Dise�o Form
        private void Dise�o_Click(object sender, EventArgs e)
        {
            Dise�o dise�oForm = new Dise�o();
            dise�oForm.Show();
            dise�oForm.Location = this.Location;
            dise�oForm.Size = this.Size;
            if (this.WindowState == FormWindowState.Maximized)
            {
                dise�oForm.WindowState = FormWindowState.Maximized;
                dise�oForm.StartPosition = FormStartPosition.CenterScreen;
            }
            
            this.Hide();
        }
        //Llamado de referencia a Preview Form
        private void Preview_Click(object sender, EventArgs e)
        {
            Preview previewForm = new Preview();
            previewForm.Show();
            previewForm.Location = this.Location;
            previewForm.Size = this.Size;
            if (this.WindowState == FormWindowState.Maximized)
            {
                previewForm.WindowState = FormWindowState.Maximized;
                previewForm.StartPosition = FormStartPosition.CenterScreen;
            }
            this.Hide();
        }

        //El formulario cada vez que se cierra se termina el programa
        private void InicioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Control del dise�o de botones
        private void buton_MouseEnter(object sender, EventArgs e)//al entrar el mouse
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 113, 188, 252);
            Cursor = Cursors.Hand;

        }

        private void buton_MouseLeave(object sender, EventArgs e)//al salir el mouse
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 37, 43, 52);
            Cursor = Cursors.Default;
        }

        private void InicioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
