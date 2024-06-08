using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace RestoBarClases
{
    public class ControlInfo
    {
        public string NombreTipo { get; set; }
        public Point UbicacionXY { get; set; }

        public ControlInfo(string nombreTipo, Point ubicacionXY)
        {
            NombreTipo = nombreTipo;
            UbicacionXY = ubicacionXY;
        }
    }
}