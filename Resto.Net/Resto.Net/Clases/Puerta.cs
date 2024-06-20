using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoBarClases
{
    public class Puerta : IEstructura
    {
        public double Longitud { get; set; }
        public double Ancho { get; set; }

        public Puerta(double longitud, double ancho)
        {
            Longitud = longitud;
            Ancho = ancho;
        }
    }
}