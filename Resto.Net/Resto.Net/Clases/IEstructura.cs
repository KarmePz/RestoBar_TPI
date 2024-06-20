using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoBarClases
{
    public interface IEstructura
    {
        //Probablemente estas dos propiedades no sean necesarias
        //pues ya pueden estar incluidas en la clase de UserControl
        public double Longitud { get; set; }
        public double Ancho { get; set; }
    }
}