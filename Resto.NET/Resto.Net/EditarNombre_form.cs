﻿using System;
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
    public partial class EditarNombre_form : Form
    {
        public String Texto {  get; set; }
        public EditarNombre_form()
        {
            InitializeComponent();
        }

        private void Enviar_button_Click(object sender, EventArgs e)
        {
            Texto = textBox1.Text;
            Close();
        }
    }
}
