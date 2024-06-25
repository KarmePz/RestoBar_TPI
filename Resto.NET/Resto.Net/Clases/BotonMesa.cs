<<<<<<< HEAD:Resto.Net/Resto.Net/Clases/BotonMesa.cs
﻿using RestoBarClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Net.Clases
{
    internal class BotonMesa : Button
    {

        public Mesa ClaseMesa { get; set; }
        public static int StaticID = 1;
        public int GradoRotacion { get; set; }
        public BotonMesa(Mesa claseMesa, int gradoRotacion)
        {
            ClaseMesa = claseMesa;
            this.ContextMenuStrip = new ContextMenuStrip();
            GradoRotacion = gradoRotacion;
=======
﻿namespace RestoBarClases
{
    internal class BotonMesa : Button
    {
        public Mesa ClaseMesa { get; set; }
        public static int StaticID = 1;

        public BotonMesa(Mesa claseMesa)
        {
            ClaseMesa = claseMesa;
            this.ContextMenuStrip = new ContextMenuStrip();
>>>>>>> 1cecd87ccbb839c03e4c27064a164e6844569531:Resto.NET/Resto.Net/Clases/BotonMesa.cs
        }
    }
    internal class BotonSilla : Button
    {
<<<<<<< HEAD:Resto.Net/Resto.Net/Clases/BotonMesa.cs
        public static int StaticID { get; set; } = 1;
        public Silla claseSilla { get; private set; }
        public int GradoRotacion { get; set; }

        public BotonSilla(Silla silla, int gradoRotacion)
        {
            claseSilla = silla;
            GradoRotacion = gradoRotacion;
        }
    }
}





=======
        public static int StaticID { get; set; } = 0;
        public Silla claseSilla { get; private set; }
        public BotonSilla(Silla silla)
        {
            claseSilla = silla;
        }
    }

}
>>>>>>> 1cecd87ccbb839c03e4c27064a164e6844569531:Resto.NET/Resto.Net/Clases/BotonMesa.cs
