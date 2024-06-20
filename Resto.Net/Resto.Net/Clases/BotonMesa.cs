using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoBarClases
{
    internal class BotonMesa : Button
    {
        public Mesa ClaseMesa { get; set; }
        public static int StaticID = 1; 

        public BotonMesa(Mesa claseMesa)
        {
            ClaseMesa = claseMesa;
        }
    }
}
