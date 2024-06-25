using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Net.Clases
{
    // Clase para serializar los elementos del formulario de diseño
    public class ElementoGuardado
    {
        public string Tipo { get; set; }
        public string Texto { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public int ColorFondo { get; set; }
        public int Id { get; set; } // ID del elemento
        public string TipoMesa { get; set; } // Tipo de mesa (para BotonMesa)
        public int CantidadSillas { get; set; } // Cantidad de sillas (para BotonMesa)
        
    }
    public class LabelInterno
    {
        public string Text { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
    }
}
